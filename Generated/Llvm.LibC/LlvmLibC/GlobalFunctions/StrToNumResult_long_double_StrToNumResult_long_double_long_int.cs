using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_14StrToNumResultIeEC2Eeli")]
[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<long double>::StrToNumResult(long double, long, int)")]
internal static partial class StrToNumResult_long_double_StrToNumResult_long_double_long_int
{
	public unsafe static void Invoke(void* @this, double value, long parsed_len, int error)
	{
		unchecked
		{
			((StrToNumResult_6sg7zz*)@this)->value = value;
			((StrToNumResult_6sg7zz*)@this)->error = error;
			((StrToNumResult_6sg7zz*)@this)->parsed_len = parsed_len;
		}
	}
}
