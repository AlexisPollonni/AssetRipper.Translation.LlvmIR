using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_14StrToNumResultIdE9has_errorEv")]
[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<double>::has_error()")]
internal static partial class StrToNumResult_double_has_error
{
	public unsafe static bool Invoke(void* @this)
	{
		return unchecked((StrToNumResult_r53a3q*)@this)->error != 0;
	}
}
