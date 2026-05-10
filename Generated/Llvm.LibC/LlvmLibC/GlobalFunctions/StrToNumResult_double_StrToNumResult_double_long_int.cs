using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_14StrToNumResultIdEC2Edli")]
[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<double>::StrToNumResult(double, long, int)")]
internal static partial class StrToNumResult_double_StrToNumResult_double_long_int
{
	public unsafe static void Invoke(void* @this, double value, long parsed_len, int error)
	{
		unchecked
		{
			((StrToNumResult_r53a3q*)@this)->value = value;
			((StrToNumResult_r53a3q*)@this)->error = error;
			((StrToNumResult_r53a3q*)@this)->parsed_len = parsed_len;
		}
	}
}
