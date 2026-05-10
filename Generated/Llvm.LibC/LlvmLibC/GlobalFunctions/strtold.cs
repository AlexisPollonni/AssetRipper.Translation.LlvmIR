using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class strtold
{
	public unsafe static double Invoke(void* str, void* str_end)
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
			StrToNumResult_long_double_internal_strtofloatingpoint_long_double_char_const.Invoke(&strToNumResult_6sg7zz, str);
			if (StrToNumResult_long_double_has_error.Invoke(&strToNumResult_6sg7zz))
			{
				Errno_operator_int_dntwiy.Invoke(a: strToNumResult_6sg7zz.error, @this: libc_errno.Pointer);
			}
			if (str_end != null)
			{
				*(byte**)str_end = (byte*)str + strToNumResult_6sg7zz.parsed_len;
			}
			double value = strToNumResult_6sg7zz.value;
			llvm_lifetime_end_p0.Invoke(32L, &strToNumResult_6sg7zz);
			return value;
		}
	}
}
