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
		StrToNumResult_uytq62 strToNumResult_uytq = default(StrToNumResult_uytq62);
		Llvm_lifetime_start_p0.Invoke(32L, &strToNumResult_uytq);
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
			Internal_strtonan_long_double.Invoke(&strToNumResult_uytq, Arg);
			if (StrToNumResult_long_double_has_error.Invoke(&strToNumResult_uytq))
			{
				Errno_Assignment.Invoke(A: strToNumResult_uytq.Error, This: Libc_errno.Pointer);
			}
			double value = strToNumResult_uytq.Value;
			Llvm_lifetime_end_p0.Invoke(32L, &strToNumResult_uytq);
			return value;
		}
	}
}
