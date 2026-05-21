using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_64ul_false_unsigned_long_unsigned_short_unsigned_short
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm64ELb0EmEcvT_ItEEv")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long>::operator unsigned short<unsigned short>() const")]
	public unsafe static short Invoke(BigInt_555ggs* @this)
	{
		return BigInt_64ul_false_unsigned_long_to_unsigned_short.Invoke(@this);
	}
}
