using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal20first_non_whitespaceEPKcm")]
[DemangledName("__llvm_libc_20_1_2_::internal::first_non_whitespace(char const*, unsigned long)")]
internal static partial class internal_first_non_whitespace_char_const_unsigned_long
{
	public unsafe static void* Invoke(void* src, long src_len)
	{
		long num = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		unchecked
		{
			for (num = 0L; (ulong)num < (ulong)src_len && internal_isspace_int.Invoke(((sbyte*)src)[num]); num++)
			{
			}
			byte* result = (byte*)src + num;
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
