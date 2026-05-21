using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_128ul_false_unsigned_long_unsigned_long_unsigned_long
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm128ELb0EmEcvT_ImEEv")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>::operator unsigned long<unsigned long>() const")]
	public unsafe static long Invoke(anon_izyfb7* @this)
	{
		return BigInt_128ul_false_unsigned_long_to_unsigned_long.Invoke(@this);
	}
}
