using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class nan
{
	public unsafe static double Invoke(void* arg)
	{
		StrToNumResult_r53a3q strToNumResult_r53a3q = default(StrToNumResult_r53a3q);
		llvm_lifetime_start_p0.Invoke(24L, &strToNumResult_r53a3q);
		unchecked
		{
			*(double*)(&strToNumResult_r53a3q) = double.NaN;
			((int*)(&strToNumResult_r53a3q))[2] = -1431655766;
			sbyte* ptr = (sbyte*)(&strToNumResult_r53a3q) + 12;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			ptr[3] = -86;
			((long*)(&strToNumResult_r53a3q))[2] = -6148914691236517206L;
			StrToNumResult_double_internal_strtonan_double_char_const.Invoke(&strToNumResult_r53a3q, arg);
			if (StrToNumResult_double_has_error.Invoke(&strToNumResult_r53a3q))
			{
				Errno_operator_int_dntwiy.Invoke(a: strToNumResult_r53a3q.error, @this: libc_errno.Pointer);
			}
			double value = strToNumResult_r53a3q.value;
			llvm_lifetime_end_p0.Invoke(24L, &strToNumResult_r53a3q);
			return value;
		}
	}
}
