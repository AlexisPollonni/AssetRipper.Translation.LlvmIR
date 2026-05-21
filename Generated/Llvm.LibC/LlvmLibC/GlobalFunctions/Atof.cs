using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Atof
{
	[MangledName("atof")]
	[DemangledName("atof")]
	public unsafe static double Invoke([MangledName("str")] void* Str)
	{
		Llvm_libc_20_1_2_StrToNumResult_k826n6 llvm_libc_20_1_2_StrToNumResult_k826n = default(Llvm_libc_20_1_2_StrToNumResult_k826n6);
		Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_StrToNumResult_k826n);
		unchecked
		{
			*(double*)(&llvm_libc_20_1_2_StrToNumResult_k826n) = double.NaN;
			((int*)(&llvm_libc_20_1_2_StrToNumResult_k826n))[2] = -1431655766;
			sbyte* ptr = (sbyte*)(&llvm_libc_20_1_2_StrToNumResult_k826n) + 12;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			ptr[3] = -86;
			((long*)(&llvm_libc_20_1_2_StrToNumResult_k826n))[2] = -6148914691236517206L;
			Internal_strtofloatingpoint_double.Invoke(&llvm_libc_20_1_2_StrToNumResult_k826n, Str);
			if (StrToNumResult_double_has_error.Invoke(&llvm_libc_20_1_2_StrToNumResult_k826n))
			{
				Errno_Assignment.Invoke(A: llvm_libc_20_1_2_StrToNumResult_k826n.Error, This: Llvm_libc_20_1_2_libc_errno.Pointer);
			}
			double value = llvm_libc_20_1_2_StrToNumResult_k826n.Value;
			Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_StrToNumResult_k826n);
			return value;
		}
	}
}
