using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_14StrToNumResultIlE9has_errorEv")]
[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<long>::has_error()")]
internal static partial class StrToNumResult_long_has_error
{
	public unsafe static bool Invoke(void* @this)
	{
		return unchecked((StrToNumResult_aztiru*)@this)->error != 0;
	}
}
