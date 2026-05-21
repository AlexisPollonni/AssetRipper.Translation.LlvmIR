using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class StrToNumResult_unsigned_int_has_error
{
	[MangledName("_ZN19__llvm_libc_20_1_2_14StrToNumResultIjE9has_errorEv")]
	[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<unsigned int>::has_error()")]
	public unsafe static bool Invoke(void* @this)
	{
		return unchecked((StrToNumResult_imtnam*)@this)->error != 0;
	}
}
