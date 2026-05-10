using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class atoi
{
	public unsafe static int Invoke(void* str)
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
			StrToNumResult_long_internal_strtointeger_long_char_const_int_unsigned_long.Invoke(&strToNumResult_aztiru, str, 10, cpp_internal_integer_impl_unsigned_long_0ul_18446744073709551615ul_max.Invoke());
			if (StrToNumResult_long_has_error.Invoke(&strToNumResult_aztiru))
			{
				Errno_operator_int_dntwiy.Invoke(a: strToNumResult_aztiru.error, @this: libc_errno.Pointer);
			}
			int result = (int)StrToNumResult_long_operator_long.Invoke(&strToNumResult_aztiru);
			llvm_lifetime_end_p0.Invoke(24L, &strToNumResult_aztiru);
			return result;
		}
	}
}
