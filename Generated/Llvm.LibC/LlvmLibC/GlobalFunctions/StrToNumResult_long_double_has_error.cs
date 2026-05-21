using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class StrToNumResult_long_double_has_error
{
	[MangledName("_ZN19__llvm_libc_20_1_2_14StrToNumResultIeE9has_errorEv")]
	[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<long double>::has_error()")]
	public unsafe static bool Invoke(void* @this)
	{
		return unchecked((StrToNumResult_uytq62*)@this)->error != 0;
	}
}
