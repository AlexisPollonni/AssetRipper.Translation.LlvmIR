using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Atoll
{
	[MangledName("atoll")]
	[DemangledName("atoll")]
	public unsafe static long Invoke([MangledName("str")] void* Str)
	{
		Llvm_libc_20_1_2_StrToNumResult_gbeb3a llvm_libc_20_1_2_StrToNumResult_gbeb3a = default(Llvm_libc_20_1_2_StrToNumResult_gbeb3a);
		Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_StrToNumResult_gbeb3a);
		unchecked
		{
			*(long*)(&llvm_libc_20_1_2_StrToNumResult_gbeb3a) = -6148914691236517206L;
			((int*)(&llvm_libc_20_1_2_StrToNumResult_gbeb3a))[2] = -1431655766;
			sbyte* ptr = (sbyte*)(&llvm_libc_20_1_2_StrToNumResult_gbeb3a) + 12;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			ptr[3] = -86;
			((long*)(&llvm_libc_20_1_2_StrToNumResult_gbeb3a))[2] = -6148914691236517206L;
			Internal_strtointeger_long_long.Invoke(&llvm_libc_20_1_2_StrToNumResult_gbeb3a, Str, 10, Integer_impl_unsigned_long_0ul_18446744073709551615ul_max.Invoke());
			if (StrToNumResult_long_long_has_error.Invoke(&llvm_libc_20_1_2_StrToNumResult_gbeb3a))
			{
				Errno_Assignment.Invoke(A: llvm_libc_20_1_2_StrToNumResult_gbeb3a.Error, This: Llvm_libc_20_1_2_libc_errno.Pointer);
			}
			long result = StrToNumResult_long_long_ToInt64.Invoke(&llvm_libc_20_1_2_StrToNumResult_gbeb3a);
			Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_StrToNumResult_gbeb3a);
			return result;
		}
	}
}
