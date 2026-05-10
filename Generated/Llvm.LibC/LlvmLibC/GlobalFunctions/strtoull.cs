using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class strtoull
{
	public unsafe static long Invoke(void* str, void* str_end, int @base)
	{
		StrToNumResult_aztiru strToNumResult_aztiru = default(StrToNumResult_aztiru);
		llvm_lifetime_start_p0.Invoke(24L, &strToNumResult_aztiru);
		unchecked
		{
			*(long*)(&strToNumResult_aztiru) = -6148914691236517206L;
			((int*)(&strToNumResult_aztiru))[2] = -1431655766;
			sbyte* ptr = (sbyte*)(&strToNumResult_aztiru) + 12;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			ptr[3] = -86;
			((long*)(&strToNumResult_aztiru))[2] = -6148914691236517206L;
			StrToNumResult_unsigned_long_long_internal_strtointeger_unsigned_long_long_char_const_int_unsigned_long.Invoke(&strToNumResult_aztiru, str, @base, cpp_internal_integer_impl_unsigned_long_0ul_18446744073709551615ul_max.Invoke());
			if (StrToNumResult_unsigned_long_long_has_error.Invoke(&strToNumResult_aztiru))
			{
				Errno_operator_int_dntwiy.Invoke(a: strToNumResult_aztiru.error, @this: libc_errno.Pointer);
			}
			if (str_end != null)
			{
				*(byte**)str_end = (byte*)str + strToNumResult_aztiru.parsed_len;
			}
			long result = StrToNumResult_unsigned_long_long_operator_unsigned_long_long.Invoke(&strToNumResult_aztiru);
			llvm_lifetime_end_p0.Invoke(24L, &strToNumResult_aztiru);
			return result;
		}
	}
}
