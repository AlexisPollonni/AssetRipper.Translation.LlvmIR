using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class nanl
{
	public unsafe static double Invoke(void* arg)
	{
		StrToNumResult_uytq62 strToNumResult_uytq = default(StrToNumResult_uytq62);
		llvm_lifetime_start_p0.Invoke(32L, &strToNumResult_uytq);
		unchecked
		{
			*(double*)(&strToNumResult_uytq) = double.NaN;
			((int*)(&strToNumResult_uytq))[4] = -1431655766;
			sbyte* ptr = (sbyte*)(&strToNumResult_uytq) + 20;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			ptr[3] = -86;
			((long*)(&strToNumResult_uytq))[3] = -6148914691236517206L;
			internal_strtonan_long_double.Invoke(&strToNumResult_uytq, arg);
			if (StrToNumResult_long_double_has_error.Invoke(&strToNumResult_uytq))
			{
				Errno_Assignment.Invoke(a: strToNumResult_uytq.error, @this: libc_errno.Pointer);
			}
			double value = strToNumResult_uytq.value;
			llvm_lifetime_end_p0.Invoke(32L, &strToNumResult_uytq);
			return value;
		}
	}
}
