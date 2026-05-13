using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_14StrToNumResultIlEC2Elli")]
[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<long>::StrToNumResult(long, long, int)")]
internal static partial class StrToNumResult_long_StrToNumResult_long_long_int
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
