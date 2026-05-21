using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Nanl
{
	[MangledName("nanl")]
	[DemangledName("nanl")]
	public unsafe static double Invoke([MangledName("arg")] void* Arg)
	{
		Llvm_libc_20_1_2_StrToNumResult_uytq62 llvm_libc_20_1_2_StrToNumResult_uytq = default(Llvm_libc_20_1_2_StrToNumResult_uytq62);
		Llvm_lifetime_start_p0.Invoke(32L, &llvm_libc_20_1_2_StrToNumResult_uytq);
		unchecked
		{
			*(double*)(&llvm_libc_20_1_2_StrToNumResult_uytq) = double.NaN;
			((int*)(&llvm_libc_20_1_2_StrToNumResult_uytq))[4] = -1431655766;
			sbyte* ptr = (sbyte*)(&llvm_libc_20_1_2_StrToNumResult_uytq) + 20;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			ptr[3] = -86;
			((long*)(&llvm_libc_20_1_2_StrToNumResult_uytq))[3] = -6148914691236517206L;
			Internal_strtonan_long_double.Invoke(&llvm_libc_20_1_2_StrToNumResult_uytq, Arg);
			if (StrToNumResult_long_double_has_error.Invoke(&llvm_libc_20_1_2_StrToNumResult_uytq))
			{
				Errno_Assignment.Invoke(A: llvm_libc_20_1_2_StrToNumResult_uytq.Error, This: Llvm_libc_20_1_2_libc_errno.Pointer);
			}
			double value = llvm_libc_20_1_2_StrToNumResult_uytq.Value;
			Llvm_lifetime_end_p0.Invoke(32L, &llvm_libc_20_1_2_StrToNumResult_uytq);
			return value;
		}
	}
}
