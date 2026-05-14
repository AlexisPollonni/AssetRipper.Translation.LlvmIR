using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm16512ELb0EmElSEm")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<16512ul, false, unsigned long>::operator<<=(unsigned long)")]
[CleanName("BigInt_16512ul_false_unsigned_long_operator_unsigned_long")]
internal static partial class BigInt_16512ul_false_unsigned_long_operator_unsigned_long_en4bet
{
	public unsafe static BigInt_q8g275* Invoke(BigInt_q8g275* @this, long s)
	{
		cpp_array_anzbtp cpp_array_anzbtp2 = default(cpp_array_anzbtp);
		cpp_array_anzbtp cpp_array_anzbtp3 = default(cpp_array_anzbtp);
		llvm_lifetime_start_p0.Invoke(2064L, &cpp_array_anzbtp2);
		llvm_memcpy_p0_p0_i64.Invoke(&cpp_array_anzbtp3, &@this->val, 2064L, isVolatile: false);
		cpp_array_unsigned_long_258ul_multiword_shift_multiword_Direction_0_false_unsigned_long_258ul_cpp_array_unsigned_long_258ul_unsigned_long.Invoke(&cpp_array_anzbtp2, &cpp_array_anzbtp3, s);
		llvm_memcpy_p0_p0_i64.Invoke(&@this->val, &cpp_array_anzbtp2, 2064L, isVolatile: false);
		llvm_lifetime_end_p0.Invoke(2064L, &cpp_array_anzbtp2);
		return @this;
	}
}
