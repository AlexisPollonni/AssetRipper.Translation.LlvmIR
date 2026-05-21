using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_32ul_false_unsigned_int_unsigned_short_unsigned_short
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm32ELb0EjEcvT_ItEEv")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<32ul, false, unsigned int>::operator unsigned short<unsigned short>() const")]
	public unsafe static short Invoke(BigInt_vtm4cw* @this)
	{
		return BigInt_32ul_false_unsigned_int_to_unsigned_short.Invoke(@this);
	}
}
