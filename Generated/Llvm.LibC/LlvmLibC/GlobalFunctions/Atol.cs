using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Atol
{
	[MangledName("atol")]
	[DemangledName("atol")]
	public unsafe static long Invoke([MangledName("str")] void* Str)
	{
		StrToNumResult_gbeb3a strToNumResult_gbeb3a = default(StrToNumResult_gbeb3a);
		Llvm_lifetime_start_p0.Invoke(24L, &strToNumResult_gbeb3a);
		unchecked
		{
			*(long*)(&strToNumResult_gbeb3a) = -6148914691236517206L;
			((int*)(&strToNumResult_gbeb3a))[2] = -1431655766;
			sbyte* ptr = (sbyte*)(&strToNumResult_gbeb3a) + 12;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			ptr[3] = -86;
			((long*)(&strToNumResult_gbeb3a))[2] = -6148914691236517206L;
			Internal_strtointeger_long.Invoke(&strToNumResult_gbeb3a, Str, 10, Integer_impl_unsigned_long_0ul_18446744073709551615ul_max.Invoke());
			if (StrToNumResult_long_has_error.Invoke(&strToNumResult_gbeb3a))
			{
				Errno_Assignment.Invoke(A: strToNumResult_gbeb3a.Error, This: Libc_errno.Pointer);
			}
			long result = StrToNumResult_long_Long.Invoke(&strToNumResult_gbeb3a);
			Llvm_lifetime_end_p0.Invoke(24L, &strToNumResult_gbeb3a);
			return result;
		}
	}
}
