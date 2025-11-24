#:package LLVMSharp@*

#:property AllowUnsafeBlocks=true

using LLVMSharp.Interop;
using System.Runtime.InteropServices;

var path = args[0];
switch (Path.GetExtension(path))
{
    case ".ll":
        {
            var outputPath = Path.ChangeExtension(path, ".bc");
            var name = Path.GetFileNameWithoutExtension(path);
            var content = File.ReadAllBytes(path);
            ConvertTextToBinary(name, content, outputPath);
            break;
        }
    case ".bc":
        {
            var outputPath = Path.ChangeExtension(path, ".ll");
            var name = Path.GetFileNameWithoutExtension(path);
            var content = File.ReadAllBytes(path);
            var textContent = ConvertBinaryToText(name, content);
            File.WriteAllText(outputPath, textContent);
            break;
        }
    default:
        throw new NotSupportedException($"Unsupported file extension: {Path.GetExtension(path)}");
}




static unsafe void ConvertTextToBinary(string name, ReadOnlySpan<byte> content, string outputPath)
{
    fixed (byte* ptr = content)
    {
        var namePtr = Marshal.StringToHGlobalAnsi(name);
        var outputPathPtr = Marshal.StringToHGlobalAnsi(outputPath);
        LLVMMemoryBufferRef buffer = LLVM.CreateMemoryBufferWithMemoryRange((sbyte*)ptr, (nuint)content.Length, (sbyte*)namePtr, 1);
        try
        {
            var context = LLVMContextRef.Create();
            try
            {
                var module = context.ParseIR(buffer);
                LLVM.WriteBitcodeToFile(module, (sbyte*)outputPathPtr);
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
            Marshal.FreeHGlobal(outputPathPtr);
        }
    }
}

static unsafe string ConvertBinaryToText(string name, ReadOnlySpan<byte> content)
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
                var module = context.ParseBitcode(buffer);
                return module.PrintToString();
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