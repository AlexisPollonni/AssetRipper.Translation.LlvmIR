using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_14StrToNumResultIiEC2Eili")]
[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<int>::StrToNumResult(int, long, int)")]
internal static partial class StrToNumResult_int_StrToNumResult_int_long_int
{
	public unsafe static void Invoke(void* @this, int value, long parsed_len, int error)
	{
		unchecked
		{
			((StrToNumResult_yrtfty*)@this)->value = value;
			((StrToNumResult_yrtfty*)@this)->error = error;
			((StrToNumResult_yrtfty*)@this)->parsed_len = parsed_len;
		}
	}
}
