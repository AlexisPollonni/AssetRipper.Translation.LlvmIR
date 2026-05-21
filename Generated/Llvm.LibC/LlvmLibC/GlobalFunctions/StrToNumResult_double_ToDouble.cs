using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class StrToNumResult_double_ToDouble
{
	[MangledName("_ZN19__llvm_libc_20_1_2_14StrToNumResultIdEcvdEv")]
	[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<double>::operator double()")]
	public unsafe static double Invoke([MangledName("this")] Llvm_libc_20_1_2_StrToNumResult_k826n6* This)
	{
		return This->Value;
	}
}
