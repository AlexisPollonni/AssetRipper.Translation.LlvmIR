using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_14StrToNumResultIfEcvfEv")]
[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<float>::operator float()")]
internal static partial class StrToNumResult_float_operator_float
{
	public unsafe static float Invoke(void* @this)
	{
		return unchecked((StrToNumResult_jptppf*)@this)->value;
	}
}
