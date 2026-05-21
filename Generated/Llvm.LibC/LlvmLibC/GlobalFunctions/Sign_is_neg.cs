using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Sign_is_neg
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_4Sign6is_negEv")]
	[DemangledName("__llvm_libc_20_1_2_::Sign::is_neg() const")]
	public unsafe static bool Invoke([MangledName("this")] void* This)
	{
		return (unchecked((Anon_izyfb7*)This)->Val & 1) == 1;
	}
}
