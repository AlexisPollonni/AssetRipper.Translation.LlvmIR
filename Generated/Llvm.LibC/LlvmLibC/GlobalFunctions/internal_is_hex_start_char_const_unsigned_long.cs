using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal12is_hex_startEPKcm")]
[DemangledName("__llvm_libc_20_1_2_::internal::is_hex_start(char const*, unsigned long)")]
internal static partial class internal_is_hex_start_char_const_unsigned_long
{
	public unsafe static bool Invoke(void* src, long src_len)
	{
		unchecked
		{
			if ((ulong)src_len < 3uL)
			{
				return false;
			}
			return *(sbyte*)src == 48 && internal_tolower_int.Invoke(((sbyte*)src)[1]) == 120 && internal_isalnum_int.Invoke(((sbyte*)src)[2]) && internal_b36_char_to_int_int.Invoke(((sbyte*)src)[2]) < 16;
		}
	}
}
