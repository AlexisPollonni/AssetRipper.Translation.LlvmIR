using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class StrToNumResult_unsigned_long_long_ToUInt64
{
	[MangledName("_ZN19__llvm_libc_20_1_2_14StrToNumResultIyEcvyEv")]
	[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<unsigned long long>::operator unsigned long long()")]
	public unsafe static long Invoke([MangledName("this")] void* This)
	{
		return unchecked((Llvm_libc_20_1_2_StrToNumResult_gbeb3a*)This)->Value;
	}
}
