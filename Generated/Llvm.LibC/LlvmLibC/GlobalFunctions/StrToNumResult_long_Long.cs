using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class StrToNumResult_long_Long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_14StrToNumResultIlEcvlEv")]
	[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<long>::operator long()")]
	public unsafe static long Invoke([MangledName("this")] void* This)
	{
		return unchecked((StrToNumResult_gbeb3a*)This)->Value;
	}
}
