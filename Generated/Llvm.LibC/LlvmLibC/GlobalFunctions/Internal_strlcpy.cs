using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_strlcpy
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal7strlcpyEPcPKcm")]
	[DemangledName("__llvm_libc_20_1_2_::internal::strlcpy(char*, char const*, unsigned long)")]
	public unsafe static long Invoke([MangledName("dst")][NativeType("char*")] void* Dst, [MangledName("src")][NativeType("char const*")] void* Src, [MangledName("size")][NativeType("unsigned long")] long Size)
	{
		long num = 0L;
		long num2 = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = Internal_string_length_char.Invoke(Src);
		unchecked
		{
			long result;
			if (Size == 0L)
			{
				result = num;
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(8L, &num2);
				num2 = (((ulong)num >= (ulong)(Size - 1L)) ? (Size - 1L) : num);
				Llvm_libc_20_1_2_inline_memcpy.Invoke(Dst, Src, num2);
				((sbyte*)Dst)[num2] = 0;
				result = num;
				Llvm_lifetime_end_p0.Invoke(8L, &num2);
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
