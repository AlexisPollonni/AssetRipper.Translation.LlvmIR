using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class StrToNumResult_unsigned_long_has_error
{
	[MangledName("_ZN19__llvm_libc_20_1_2_14StrToNumResultImE9has_errorEv")]
	[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<unsigned long>::has_error()")]
	public unsafe static bool Invoke([MangledName("this")] void* This)
	{
		return unchecked((StrToNumResult_gbeb3a*)This)->Error != 0;
	}
}
