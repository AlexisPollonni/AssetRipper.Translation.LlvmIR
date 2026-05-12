using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm16512ELb0EmE3mulEm")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<16512ul, false, unsigned long>::mul(unsigned long)")]
internal static partial class BigInt_16512ul_false_unsigned_long_mul_unsigned_long
{
	public unsafe static long Invoke(BigInt_k36xhe* @this, long x)
	{
		return unsigned_long_multiword_scalar_multiply_with_carry_unsigned_long_258ul_cpp_array_unsigned_long_258ul_unsigned_long.Invoke(&@this->val, x);
	}
}
