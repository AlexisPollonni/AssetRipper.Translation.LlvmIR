using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Strxfrm
{
	[MangledName("strxfrm")]
	[DemangledName("strxfrm")]
	public unsafe static long Invoke([MangledName("dest")] void* Dest, [MangledName("src")] void* Src, [MangledName("n")] long N)
	{
		long num = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = Internal_string_length_char.Invoke(Src);
		unchecked
		{
			if ((ulong)N > (ulong)num)
			{
				Llvm_libc_20_1_2_inline_memcpy.Invoke(Dest, Src, num + 1L);
			}
			long result = num;
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
