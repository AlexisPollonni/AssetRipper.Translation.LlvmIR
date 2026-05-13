using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_14StrToNumResultIxEcvxEv")]
[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<long long>::operator long long()")]
internal static partial class StrToNumResult_long_long_operator_long_long
{
	public unsafe static long Invoke(void* @this)
	{
		return unchecked((StrToNumResult_aztiru*)@this)->value;
	}
}
