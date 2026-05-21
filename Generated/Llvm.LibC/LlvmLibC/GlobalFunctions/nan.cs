using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class nan
{
	public unsafe static double Invoke(void* arg)
	{
		StrToNumResult_k826n6 strToNumResult_k826n = default(StrToNumResult_k826n6);
		llvm_lifetime_start_p0.Invoke(24L, &strToNumResult_k826n);
		unchecked
		{
			*(double*)(&strToNumResult_k826n) = double.NaN;
			((int*)(&strToNumResult_k826n))[2] = -1431655766;
			sbyte* ptr = (sbyte*)(&strToNumResult_k826n) + 12;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			ptr[3] = -86;
			((long*)(&strToNumResult_k826n))[2] = -6148914691236517206L;
			internal_strtonan_double.Invoke(&strToNumResult_k826n, arg);
			if (StrToNumResult_double_has_error.Invoke(&strToNumResult_k826n))
			{
				Errno_Assignment.Invoke(a: strToNumResult_k826n.error, @this: libc_errno.Pointer);
			}
			double value = strToNumResult_k826n.value;
			llvm_lifetime_end_p0.Invoke(24L, &strToNumResult_k826n);
			return value;
		}
	}
}
