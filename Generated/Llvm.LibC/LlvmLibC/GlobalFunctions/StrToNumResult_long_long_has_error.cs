using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class StrToNumResult_long_long_has_error
{
	[MangledName("_ZN19__llvm_libc_20_1_2_14StrToNumResultIxE9has_errorEv")]
	[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<long long>::has_error()")]
	public unsafe static bool Invoke([MangledName("this")] void* This)
	{
		return unchecked((Llvm_libc_20_1_2_StrToNumResult_gbeb3a*)This)->Error != 0;
	}
}
