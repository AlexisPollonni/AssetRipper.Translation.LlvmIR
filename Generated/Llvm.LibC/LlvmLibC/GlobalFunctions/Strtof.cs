using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Strtof
{
	[MangledName("strtof")]
	[DemangledName("strtof")]
	public unsafe static float Invoke([MangledName("str")] void* Str, [MangledName("str_end")] void* Str_end)
	{
		StrToNumResult_cqc3yy strToNumResult_cqc3yy = default(StrToNumResult_cqc3yy);
		Llvm_lifetime_start_p0.Invoke(16L, &strToNumResult_cqc3yy);
		unchecked
		{
			*(float*)(&strToNumResult_cqc3yy) = float.NaN;
			((int*)(&strToNumResult_cqc3yy))[1] = -1431655766;
			((long*)(&strToNumResult_cqc3yy))[1] = -6148914691236517206L;
			Struct_fiz2nb struct_fiz2nb = Internal_strtofloatingpoint_float.Invoke(Str);
			StrToNumResult_cqc3yy* num = &strToNumResult_cqc3yy;
			Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
			*(long*)num = struct_fiz2nb2.field_0;
			byte* num2 = (byte*)(&strToNumResult_cqc3yy) + 8u;
			Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
			*(long*)num2 = struct_fiz2nb3.field_1;
			if (StrToNumResult_float_has_error.Invoke(&strToNumResult_cqc3yy))
			{
				Errno_Assignment.Invoke(A: strToNumResult_cqc3yy.Error, This: Libc_errno.Pointer);
			}
			if (Str_end != null)
			{
				*(byte**)Str_end = (byte*)Str + strToNumResult_cqc3yy.Parsed_len;
			}
			float value = strToNumResult_cqc3yy.Value;
			Llvm_lifetime_end_p0.Invoke(16L, &strToNumResult_cqc3yy);
			return value;
		}
	}
}
