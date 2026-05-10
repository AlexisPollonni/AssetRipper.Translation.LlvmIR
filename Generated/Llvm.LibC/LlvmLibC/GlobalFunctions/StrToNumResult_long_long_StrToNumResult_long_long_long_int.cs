using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_14StrToNumResultIxEC2Exli")]
[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<long long>::StrToNumResult(long long, long, int)")]
internal static partial class StrToNumResult_long_long_StrToNumResult_long_long_long_int
{
	public unsafe static void Invoke(void* @this, long value, long parsed_len, int error)
	{
		unchecked
		{
			((StrToNumResult_aztiru*)@this)->value = value;
			((StrToNumResult_aztiru*)@this)->error = error;
			((StrToNumResult_aztiru*)@this)->parsed_len = parsed_len;
		}
	}
}
