using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_14StrToNumResultIdEcvdEv")]
[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<double>::operator double()")]
internal static partial class StrToNumResult_double_operator_double
{
	public unsafe static double Invoke(StrToNumResult_r53a3q* @this)
	{
		return @this->value;
	}
}
