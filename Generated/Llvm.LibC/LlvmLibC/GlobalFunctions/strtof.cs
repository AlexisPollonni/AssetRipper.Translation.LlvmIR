using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class strtof
{
	public unsafe static float Invoke(void* str, void* str_end)
	{
		StrToNumResult_jptppf strToNumResult_jptppf = default(StrToNumResult_jptppf);
		llvm_lifetime_start_p0.Invoke(16L, &strToNumResult_jptppf);
		unchecked
		{
			*(float*)(&strToNumResult_jptppf) = float.NaN;
			((int*)(&strToNumResult_jptppf))[1] = -1431655766;
			((long*)(&strToNumResult_jptppf))[1] = -6148914691236517206L;
			Struct_fiz2nb struct_fiz2nb = StrToNumResult_float_internal_strtofloatingpoint_float_char_const.Invoke(str);
			StrToNumResult_jptppf* num = &strToNumResult_jptppf;
			Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
			*(long*)num = struct_fiz2nb2.field_0;
			byte* num2 = (byte*)(&strToNumResult_jptppf) + 8u;
			Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
			*(long*)num2 = struct_fiz2nb3.field_1;
			if (StrToNumResult_float_has_error.Invoke(&strToNumResult_jptppf))
			{
				Errno_operator_int_dntwiy.Invoke(a: strToNumResult_jptppf.error, @this: libc_errno.Pointer);
			}
			if (str_end != null)
			{
				*(byte**)str_end = (byte*)str + strToNumResult_jptppf.parsed_len;
			}
			float value = strToNumResult_jptppf.value;
			llvm_lifetime_end_p0.Invoke(16L, &strToNumResult_jptppf);
			return value;
		}
	}
}
