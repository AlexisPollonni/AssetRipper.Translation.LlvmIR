using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_14StrToNumResultIeEcveEv")]
[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<long double>::operator long double()")]
internal static partial class StrToNumResult_long_double_operator_long_double
{
	public unsafe static double Invoke(void* @this)
	{
		return unchecked((StrToNumResult_6sg7zz*)@this)->value;
	}
}
