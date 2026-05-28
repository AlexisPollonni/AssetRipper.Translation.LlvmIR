using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Nan
{
	[MangledName("nan")]
	[DemangledName("nan")]
	public unsafe static double Invoke([MangledName("arg")] void* Arg)
	{
		StrToNumResult_k826n6 strToNumResult_k826n = default(StrToNumResult_k826n6);
		Llvm_lifetime_start_p0.Invoke(24L, &strToNumResult_k826n);
		unchecked
		{
			*(double*)(&strToNumResult_k826n) = double.NaN;
			((int*)(&strToNumResult_k826n))[2] = -1431655766;
			sbyte* ptr = (sbyte*)(&strToNumResult_k826n) + 12;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			ptr[3] = -86;
			((long*)(&strToNumResult_k826n))[2] = -6148914691236517206L;
			Internal_strtonan_double.Invoke(&strToNumResult_k826n, Arg);
			if (StrToNumResult_double_has_error.Invoke(&strToNumResult_k826n))
			{
				Errno_Assignment.Invoke(A: strToNumResult_k826n.Error, This: Libc_errno.Pointer);
			}
			double value = strToNumResult_k826n.Value;
			Llvm_lifetime_end_p0.Invoke(24L, &strToNumResult_k826n);
			return value;
		}
	}
}
