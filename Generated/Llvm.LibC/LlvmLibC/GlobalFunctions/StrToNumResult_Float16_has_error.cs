using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_14StrToNumResultIDF16_E9has_errorEv")]
[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<_Float16>::has_error()")]
internal static partial class StrToNumResult_Float16_has_error
{
	public unsafe static bool Invoke(StrToNumResult_stcih6* @this)
	{
		return @this->error != 0;
	}
}
