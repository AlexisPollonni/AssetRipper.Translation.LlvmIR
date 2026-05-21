using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class StrToNumResult_float_has_error
{
	[MangledName("_ZN19__llvm_libc_20_1_2_14StrToNumResultIfE9has_errorEv")]
	[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<float>::has_error()")]
	public unsafe static bool Invoke(void* @this)
	{
		return unchecked((StrToNumResult_cqc3yy*)@this)->error != 0;
	}
}
