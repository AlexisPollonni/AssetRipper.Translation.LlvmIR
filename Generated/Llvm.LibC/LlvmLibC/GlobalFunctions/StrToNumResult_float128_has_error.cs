using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class StrToNumResult_float128_has_error
{
	[MangledName("_ZN19__llvm_libc_20_1_2_14StrToNumResultIgE9has_errorEv")]
	[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<__float128>::has_error()")]
	public unsafe static bool Invoke(StrToNumResult_c5b6ms* @this)
	{
		return @this->error != 0;
	}
}
