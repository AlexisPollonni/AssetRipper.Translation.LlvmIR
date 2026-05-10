using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm16512ELb0EmElSEm")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<16512ul, false, unsigned long>::operator<<=(unsigned long)")]
[CleanName("BigInt_16512ul_false_unsigned_long_operator_unsigned_long")]
internal static partial class BigInt_16512ul_false_unsigned_long_operator_unsigned_long_en4bet
{
	public unsafe static void* Invoke(void* @this, long s)
	{
		cpp_array_vnnqx8 cpp_array_vnnqx9 = default(cpp_array_vnnqx8);
		cpp_array_vnnqx8 cpp_array_vnnqx10 = default(cpp_array_vnnqx8);
		llvm_lifetime_start_p0.Invoke(2064L, &cpp_array_vnnqx9);
		unchecked
		{
			llvm_memcpy_p0_p0_i64.Invoke(&cpp_array_vnnqx10, &((BigInt_k36xhe*)@this)->val, 2064L, isVolatile: false);
			cpp_array_unsigned_long_258ul_multiword_shift_multiword_Direction_0_false_unsigned_long_258ul_cpp_array_unsigned_long_258ul_unsigned_long.Invoke(&cpp_array_vnnqx9, &cpp_array_vnnqx10, s);
			llvm_memcpy_p0_p0_i64.Invoke(&((BigInt_k36xhe*)@this)->val, &cpp_array_vnnqx9, 2064L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(2064L, &cpp_array_vnnqx9);
			return @this;
		}
	}
}
