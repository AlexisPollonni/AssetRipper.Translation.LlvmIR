using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_32ul_false_unsigned_int_unsigned_int_unsigned_int
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm32ELb0EjEcvT_IjEEv")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<32ul, false, unsigned int>::operator unsigned int<unsigned int>() const")]
	public unsafe static int Invoke(BigInt_vtm4cw* @this)
	{
		return BigInt_32ul_false_unsigned_int_to_unsigned_int.Invoke(@this);
	}
}
