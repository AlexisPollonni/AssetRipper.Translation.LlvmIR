using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class StrToNumResult_unsigned_short_has_error
{
	[MangledName("_ZN19__llvm_libc_20_1_2_14StrToNumResultItE9has_errorEv")]
	[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<unsigned short>::has_error()")]
	public unsafe static bool Invoke([MangledName("this")] void* This)
	{
		return unchecked((StrToNumResult_wwcts2*)This)->Error != 0;
	}
}
