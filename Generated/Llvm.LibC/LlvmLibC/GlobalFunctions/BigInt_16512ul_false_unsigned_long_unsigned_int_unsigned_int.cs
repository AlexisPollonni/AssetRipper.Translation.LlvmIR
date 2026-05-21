using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_16512ul_false_unsigned_long_unsigned_int_unsigned_int
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm16512ELb0EmEcvT_IjEEv")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<16512ul, false, unsigned long>::operator unsigned int<unsigned int>() const")]
	public unsafe static int Invoke(BigInt_q8g275* @this)
	{
		return BigInt_16512ul_false_unsigned_long_to_unsigned_int.Invoke(@this);
	}
}
