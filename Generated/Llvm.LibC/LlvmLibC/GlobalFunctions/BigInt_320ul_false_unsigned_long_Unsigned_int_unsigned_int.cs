using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_320ul_false_unsigned_long_Unsigned_int_unsigned_int
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm320ELb0EmEcvT_IjEEv")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<320ul, false, unsigned long>::operator unsigned int<unsigned int>() const")]
	public unsafe static int Invoke([MangledName("this")] BigInt_76gxx6* This)
	{
		return BigInt_320ul_false_unsigned_long_to_unsigned_int.Invoke(This);
	}
}
