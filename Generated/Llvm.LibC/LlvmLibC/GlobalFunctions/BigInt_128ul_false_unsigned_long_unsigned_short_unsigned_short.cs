using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_128ul_false_unsigned_long_unsigned_short_unsigned_short
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm128ELb0EmEcvT_ItEEv")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>::operator unsigned short<unsigned short>() const")]
	public unsafe static short Invoke(anon_izyfb7* @this)
	{
		return BigInt_128ul_false_unsigned_long_to_unsigned_short.Invoke(@this);
	}
}
