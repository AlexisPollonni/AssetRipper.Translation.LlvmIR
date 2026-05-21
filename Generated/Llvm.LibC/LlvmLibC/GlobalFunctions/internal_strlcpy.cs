using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class internal_strlcpy
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal7strlcpyEPcPKcm")]
	[DemangledName("__llvm_libc_20_1_2_::internal::strlcpy(char*, char const*, unsigned long)")]
	public unsafe static long Invoke([NativeType("char*")] void* dst, [NativeType("char const*")] void* src, [NativeType("unsigned long")] long size)
	{
		long num = 0L;
		long num2 = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = internal_string_length_char.Invoke(src);
		unchecked
		{
			long result;
			if (size == 0L)
			{
				result = num;
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(8L, &num2);
				num2 = (((ulong)num >= (ulong)(size - 1L)) ? (size - 1L) : num);
				inline_memcpy.Invoke(dst, src, num2);
				((sbyte*)dst)[num2] = 0;
				result = num;
				llvm_lifetime_end_p0.Invoke(8L, &num2);
			}
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
