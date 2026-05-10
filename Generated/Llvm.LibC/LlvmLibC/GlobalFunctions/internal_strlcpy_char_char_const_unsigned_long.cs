using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal7strlcpyEPcPKcm")]
[DemangledName("__llvm_libc_20_1_2_::internal::strlcpy(char*, char const*, unsigned long)")]
internal static partial class internal_strlcpy_char_char_const_unsigned_long
{
	public unsafe static long Invoke(void* dst, void* src, long size)
	{
		long num = 0L;
		long num2 = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = unsigned_long_internal_string_length_char_char_const.Invoke(src);
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
				inline_memcpy_void_void_const_unsigned_long.Invoke(dst, src, num2);
				((sbyte*)dst)[num2] = 0;
				result = num;
				llvm_lifetime_end_p0.Invoke(8L, &num2);
			}
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
