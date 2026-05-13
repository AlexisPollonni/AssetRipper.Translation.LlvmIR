using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_14StrToNumResultItE9has_errorEv")]
[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<unsigned short>::has_error()")]
internal static partial class StrToNumResult_unsigned_short_has_error
{
	public unsafe static bool Invoke(void* @this)
	{
		return unchecked((StrToNumResult_wwcts2*)@this)->error != 0;
	}
}
