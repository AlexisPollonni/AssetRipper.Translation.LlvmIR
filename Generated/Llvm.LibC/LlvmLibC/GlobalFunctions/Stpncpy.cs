using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Stpncpy
{
	[MangledName("stpncpy")]
	[DemangledName("stpncpy")]
	public unsafe static void* Invoke([MangledName("dest")] void* Dest, [MangledName("src")] void* Src, [MangledName("n")] long N)
	{
		long num = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = -6148914691236517206L;
		unchecked
		{
			for (num = 0L; (ulong)num < (ulong)N && ((sbyte*)Src)[num] != 0; num++)
			{
				sbyte b = ((sbyte*)Src)[num];
				((sbyte*)Dest)[num] = b;
			}
			if ((ulong)N > (ulong)num)
			{
				Llvm_libc_20_1_2_inline_bzero_s6t36y.Invoke((byte*)Dest + num, N - num);
			}
			byte* result = (byte*)Dest + num;
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
