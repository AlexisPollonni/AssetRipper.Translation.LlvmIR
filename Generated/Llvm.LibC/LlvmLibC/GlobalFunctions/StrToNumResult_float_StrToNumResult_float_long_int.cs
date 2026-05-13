using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_14StrToNumResultIfEC2Efli")]
[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<float>::StrToNumResult(float, long, int)")]
internal static partial class StrToNumResult_float_StrToNumResult_float_long_int
{
	public unsafe static void Invoke(void* @this, float value, long parsed_len, int error)
	{
		unchecked
		{
			((StrToNumResult_jptppf*)@this)->value = value;
			((StrToNumResult_jptppf*)@this)->error = error;
			((StrToNumResult_jptppf*)@this)->parsed_len = parsed_len;
		}
	}
}
