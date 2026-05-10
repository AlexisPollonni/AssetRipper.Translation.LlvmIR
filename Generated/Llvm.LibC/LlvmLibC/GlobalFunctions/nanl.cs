using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class nanl
{
	public unsafe static double Invoke(void* arg)
	{
		StrToNumResult_6sg7zz strToNumResult_6sg7zz = default(StrToNumResult_6sg7zz);
		llvm_lifetime_start_p0.Invoke(32L, &strToNumResult_6sg7zz);
		unchecked
		{
			*(double*)(&strToNumResult_6sg7zz) = double.NaN;
			((int*)(&strToNumResult_6sg7zz))[4] = -1431655766;
			sbyte* ptr = (sbyte*)(&strToNumResult_6sg7zz) + 20;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			ptr[3] = -86;
			((long*)(&strToNumResult_6sg7zz))[3] = -6148914691236517206L;
			StrToNumResult_long_double_internal_strtonan_long_double_char_const.Invoke(&strToNumResult_6sg7zz, arg);
			if (StrToNumResult_long_double_has_error.Invoke(&strToNumResult_6sg7zz))
			{
				Errno_operator_int_dntwiy.Invoke(a: strToNumResult_6sg7zz.error, @this: libc_errno.Pointer);
			}
			double value = strToNumResult_6sg7zz.value;
			llvm_lifetime_end_p0.Invoke(32L, &strToNumResult_6sg7zz);
			return value;
		}
	}
}
