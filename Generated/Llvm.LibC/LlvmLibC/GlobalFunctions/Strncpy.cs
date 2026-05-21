using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Strncpy
{
	public unsafe static readonly void* __pointer = PointerIndices.Register((delegate*<void*, void*, long, void*>)(&Invoke));

	[MangledName("strncpy")]
	[DemangledName("strncpy")]
	public unsafe static void* Invoke([MangledName("dest")] void* Dest, [MangledName("src")] void* Src, [MangledName("n")] long N)
	{
		long num = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		unchecked
		{
			for (num = 0L; (ulong)num < (ulong)N && ((sbyte*)Src)[num] != 0; num++)
			{
				sbyte b = ((sbyte*)Src)[num];
				((sbyte*)Dest)[num] = b;
			}
			for (; (ulong)num < (ulong)N; num++)
			{
				((sbyte*)Dest)[num] = 0;
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			return Dest;
		}
	}
}
