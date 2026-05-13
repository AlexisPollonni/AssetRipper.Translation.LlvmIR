using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_14StrToNumResultIoE9has_errorEv")]
[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<unsigned __int128>::has_error()")]
internal static partial class StrToNumResult_unsigned_int128_has_error
{
	public unsafe static bool Invoke(void* @this)
	{
		return unchecked((StrToNumResult_i4jxtt*)@this)->error != 0;
	}
}
