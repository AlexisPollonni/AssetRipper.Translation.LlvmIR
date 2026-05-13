using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_14StrToNumResultIyEC2Eyli")]
[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<unsigned long long>::StrToNumResult(unsigned long long, long, int)")]
internal static partial class StrToNumResult_unsigned_long_long_StrToNumResult_unsigned_long_long_long_int
{
	public unsafe static void Invoke(void* @this, long value, long parsed_len, int error)
	{
		unchecked
		{
			((StrToNumResult_aztiru*)@this)->value = value;
			((StrToNumResult_aztiru*)@this)->error = error;
			((StrToNumResult_aztiru*)@this)->parsed_len = parsed_len;
		}
	}
}
