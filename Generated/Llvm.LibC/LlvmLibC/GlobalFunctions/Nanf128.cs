using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Nanf128
{
	[MangledName("nanf128")]
	[DemangledName("nanf128")]
	public unsafe static double Invoke([MangledName("arg")] void* Arg)
	{
		Llvm_libc_20_1_2_StrToNumResult_c5b6ms llvm_libc_20_1_2_StrToNumResult_c5b6ms = default(Llvm_libc_20_1_2_StrToNumResult_c5b6ms);
		Llvm_lifetime_start_p0.Invoke(32L, &llvm_libc_20_1_2_StrToNumResult_c5b6ms);
		unchecked
		{
			*(double*)(&llvm_libc_20_1_2_StrToNumResult_c5b6ms) = double.NaN;
			((int*)(&llvm_libc_20_1_2_StrToNumResult_c5b6ms))[4] = -1431655766;
			sbyte* ptr = (sbyte*)(&llvm_libc_20_1_2_StrToNumResult_c5b6ms) + 20;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			ptr[3] = -86;
			((long*)(&llvm_libc_20_1_2_StrToNumResult_c5b6ms))[3] = -6148914691236517206L;
			Internal_strtonan_float128.Invoke(&llvm_libc_20_1_2_StrToNumResult_c5b6ms, Arg);
			if (StrToNumResult_float128_has_error.Invoke(&llvm_libc_20_1_2_StrToNumResult_c5b6ms))
			{
				Errno_Assignment.Invoke(A: llvm_libc_20_1_2_StrToNumResult_c5b6ms.Error, This: Llvm_libc_20_1_2_libc_errno.Pointer);
			}
			double value = llvm_libc_20_1_2_StrToNumResult_c5b6ms.Value;
			Llvm_lifetime_end_p0.Invoke(32L, &llvm_libc_20_1_2_StrToNumResult_c5b6ms);
			return value;
		}
	}
}
