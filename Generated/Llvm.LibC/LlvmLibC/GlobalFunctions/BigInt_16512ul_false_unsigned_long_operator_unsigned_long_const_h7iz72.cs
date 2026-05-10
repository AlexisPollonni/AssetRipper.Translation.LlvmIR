using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm16512ELb0EmEixEm")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<16512ul, false, unsigned long>::operator[](unsigned long) const")]
[CleanName("BigInt_16512ul_false_unsigned_long_operator_unsigned_long_const")]
internal static partial class BigInt_16512ul_false_unsigned_long_operator_unsigned_long_const_h7iz72
{
	public unsafe static void* Invoke(void* @this, long i)
	{
		return cpp_array_unsigned_long_258ul_operator_unsigned_long_const.Invoke(&unchecked((BigInt_k36xhe*)@this)->val, i);
	}
}
