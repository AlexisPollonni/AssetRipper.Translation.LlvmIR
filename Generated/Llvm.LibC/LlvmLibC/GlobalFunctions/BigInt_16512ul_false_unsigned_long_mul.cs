using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_16512ul_false_unsigned_long_mul
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm16512ELb0EmE3mulEm")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<16512ul, false, unsigned long>::mul(unsigned long)")]
	public unsafe static long Invoke([MangledName("this")] Llvm_libc_20_1_2_BigInt_q8g275* This, [MangledName("x")][NativeType("unsigned long")] long X)
	{
		return Multiword_scalar_multiply_with_carry_unsigned_long_258ul.Invoke(&This->Val, X);
	}
}
