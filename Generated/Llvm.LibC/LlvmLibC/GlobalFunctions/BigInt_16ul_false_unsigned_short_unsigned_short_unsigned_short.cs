using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_16ul_false_unsigned_short_unsigned_short_unsigned_short
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm16ELb0EtEcvT_ItEEv")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<16ul, false, unsigned short>::operator unsigned short<unsigned short>() const")]
	public unsafe static short Invoke(BigInt_ys7s55* @this)
	{
		return BigInt_16ul_false_unsigned_short_to_unsigned_short.Invoke(@this);
	}
}
