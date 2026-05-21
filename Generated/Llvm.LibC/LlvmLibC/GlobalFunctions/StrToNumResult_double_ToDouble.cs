using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class StrToNumResult_double_ToDouble
{
	[MangledName("_ZN19__llvm_libc_20_1_2_14StrToNumResultIdEcvdEv")]
	[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<double>::operator double()")]
	public unsafe static double Invoke(StrToNumResult_k826n6* @this)
	{
		return @this->value;
	}
}
