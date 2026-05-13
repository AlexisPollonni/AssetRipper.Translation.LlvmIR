using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_14StrToNumResultIyEcvyEv")]
[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<unsigned long long>::operator unsigned long long()")]
internal static partial class StrToNumResult_unsigned_long_long_operator_unsigned_long_long
{
	public unsafe static long Invoke(void* @this)
	{
		return unchecked((StrToNumResult_aztiru*)@this)->value;
	}
}
