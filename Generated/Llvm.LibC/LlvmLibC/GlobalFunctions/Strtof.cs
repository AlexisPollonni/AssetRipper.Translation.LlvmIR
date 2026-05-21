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
		Llvm_libc_20_1_2_StrToNumResult_cqc3yy llvm_libc_20_1_2_StrToNumResult_cqc3yy = default(Llvm_libc_20_1_2_StrToNumResult_cqc3yy);
		Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_StrToNumResult_cqc3yy);
		unchecked
		{
			*(float*)(&llvm_libc_20_1_2_StrToNumResult_cqc3yy) = float.NaN;
			((int*)(&llvm_libc_20_1_2_StrToNumResult_cqc3yy))[1] = -1431655766;
			((long*)(&llvm_libc_20_1_2_StrToNumResult_cqc3yy))[1] = -6148914691236517206L;
			Struct_fiz2nb struct_fiz2nb = Internal_strtofloatingpoint_float.Invoke(Str);
			Llvm_libc_20_1_2_StrToNumResult_cqc3yy* num = &llvm_libc_20_1_2_StrToNumResult_cqc3yy;
			Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
			*(long*)num = struct_fiz2nb2.field_0;
			byte* num2 = (byte*)(&llvm_libc_20_1_2_StrToNumResult_cqc3yy) + 8u;
			Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
			*(long*)num2 = struct_fiz2nb3.field_1;
			if (StrToNumResult_float_has_error.Invoke(&llvm_libc_20_1_2_StrToNumResult_cqc3yy))
			{
				Errno_Assignment.Invoke(A: llvm_libc_20_1_2_StrToNumResult_cqc3yy.Error, This: Llvm_libc_20_1_2_libc_errno.Pointer);
			}
			if (Str_end != null)
			{
				*(byte**)Str_end = (byte*)Str + llvm_libc_20_1_2_StrToNumResult_cqc3yy.Parsed_len;
			}
			float value = llvm_libc_20_1_2_StrToNumResult_cqc3yy.Value;
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_StrToNumResult_cqc3yy);
			return value;
		}
	}
}
