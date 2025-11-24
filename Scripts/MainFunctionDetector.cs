#:package LLVMSharp@*

#:property AllowUnsafeBlocks=true
#:property InvariantGlobalization=true


using LLVMSharp.Interop;
using System.Runtime.InteropServices;

var path = args[0];
var containsMain = ContainsMainFunction(Path.GetFileName(path), File.ReadAllBytes(path));
Environment.ExitCode = containsMain ? 1 : 0;


unsafe static bool ContainsMainFunction(string name, ReadOnlySpan<byte> content)
{
    fixed (byte* ptr = content)
    {
        var namePtr = Marshal.StringToHGlobalAnsi(name);
        LLVMMemoryBufferRef buffer = LLVM.CreateMemoryBufferWithMemoryRange((sbyte*)ptr, (nuint)content.Length, (sbyte*)namePtr, 1);
        try
        {
            var context = LLVMContextRef.Create();
            try
            {
                var module = context.ParseIR(buffer);
                return module.GetNamedFunction("main") != default;
            }
            finally
            {
                // https://github.com/dotnet/LLVMSharp/issues/234
                //context.Dispose();
            }
        }
        finally
        {
            // This fails randomly with no real explanation.
            // I'm fairly certain that the IR text data is only referenced (not copied),
            // so the memory leak of not disposing the buffer is probably not a big deal.
            // https://github.com/dotnet/LLVMSharp/issues/234
            //LLVM.DisposeMemoryBuffer(buffer);

            Marshal.FreeHGlobal(namePtr);
        }
    }
}