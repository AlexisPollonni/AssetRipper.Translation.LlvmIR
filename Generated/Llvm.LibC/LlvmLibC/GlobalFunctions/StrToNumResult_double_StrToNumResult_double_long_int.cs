using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_14StrToNumResultIdEC2Edli")]
[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<double>::StrToNumResult(double, long, int)")]
internal static partial class StrToNumResult_double_StrToNumResult_double_long_int
{
	public unsafe static void Invoke(StrToNumResult_k826n6* @this, double value, long parsed_len, int error)
	{
		@this->value = value;
		@this->error = error;
		@this->parsed_len = parsed_len;
	}
}
