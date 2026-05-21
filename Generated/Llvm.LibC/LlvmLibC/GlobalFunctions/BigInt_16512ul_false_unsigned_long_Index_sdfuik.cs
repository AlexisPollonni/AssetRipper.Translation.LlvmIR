using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_16512ul_false_unsigned_long_Index_sdfuik
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm16512ELb0EmEixEm")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<16512ul, false, unsigned long>::operator[](unsigned long) const")]
	[CleanName("BigInt_16512ul_false_unsigned_long_Index")]
	public unsafe static void* Invoke([MangledName("this")] Llvm_libc_20_1_2_BigInt_q8g275* This, [MangledName("i")][NativeType("unsigned long")] long I)
	{
		return Array_unsigned_long_258ul_Index_7gdq4k.Invoke(&This->Val, I);
	}
}
