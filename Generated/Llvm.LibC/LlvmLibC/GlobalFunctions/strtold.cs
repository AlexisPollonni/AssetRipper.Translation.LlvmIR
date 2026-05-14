using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class strtold
{
	public unsafe static double Invoke(void* str, void* str_end)
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
			StrToNumResult_long_double_internal_strtofloatingpoint_long_double_char_const.Invoke(&strToNumResult_uytq, str);
			if (StrToNumResult_long_double_has_error.Invoke(&strToNumResult_uytq))
			{
				Errno_operator_int_dntwiy.Invoke(a: strToNumResult_uytq.error, @this: libc_errno.Pointer);
			}
			if (str_end != null)
			{
				*(byte**)str_end = (byte*)str + strToNumResult_uytq.parsed_len;
			}
			double value = strToNumResult_uytq.value;
			llvm_lifetime_end_p0.Invoke(32L, &strToNumResult_uytq);
			return value;
		}
	}
}
