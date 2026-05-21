using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class nanf128
{
	public unsafe static double Invoke(void* arg)
	{
		StrToNumResult_c5b6ms strToNumResult_c5b6ms = default(StrToNumResult_c5b6ms);
		llvm_lifetime_start_p0.Invoke(32L, &strToNumResult_c5b6ms);
		unchecked
		{
			*(double*)(&strToNumResult_c5b6ms) = double.NaN;
			((int*)(&strToNumResult_c5b6ms))[4] = -1431655766;
			sbyte* ptr = (sbyte*)(&strToNumResult_c5b6ms) + 20;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			ptr[3] = -86;
			((long*)(&strToNumResult_c5b6ms))[3] = -6148914691236517206L;
			internal_strtonan_float128.Invoke(&strToNumResult_c5b6ms, arg);
			if (StrToNumResult_float128_has_error.Invoke(&strToNumResult_c5b6ms))
			{
				Errno_Assignment.Invoke(a: strToNumResult_c5b6ms.error, @this: libc_errno.Pointer);
			}
			double value = strToNumResult_c5b6ms.value;
			llvm_lifetime_end_p0.Invoke(32L, &strToNumResult_c5b6ms);
			return value;
		}
	}
}
