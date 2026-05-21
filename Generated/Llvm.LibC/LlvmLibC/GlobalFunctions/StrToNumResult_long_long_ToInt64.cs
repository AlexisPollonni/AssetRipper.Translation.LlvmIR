using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class StrToNumResult_long_long_ToInt64
{
	[MangledName("_ZN19__llvm_libc_20_1_2_14StrToNumResultIxEcvxEv")]
	[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<long long>::operator long long()")]
	public unsafe static long Invoke(void* @this)
	{
		return unchecked((StrToNumResult_gbeb3a*)@this)->value;
	}
}
