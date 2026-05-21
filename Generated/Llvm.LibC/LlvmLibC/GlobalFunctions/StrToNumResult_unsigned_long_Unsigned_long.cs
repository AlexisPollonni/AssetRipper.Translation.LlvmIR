using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class StrToNumResult_unsigned_long_Unsigned_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_14StrToNumResultImEcvmEv")]
	[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<unsigned long>::operator unsigned long()")]
	public unsafe static long Invoke([MangledName("this")] void* This)
	{
		return unchecked((Llvm_libc_20_1_2_StrToNumResult_gbeb3a*)This)->Value;
	}
}
