using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm256ELb0EmE7ful_mulILm256EEEDaRKNS0_IXT_ELb0EmEE")]
[DemangledName("auto __llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long>::ful_mul<256ul>(__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long> const&) const")]
internal static partial class auto_BigInt_256ul_false_unsigned_long_ful_mul_256ul_BigInt_256ul_false_unsigned_long_const_const
{
	public unsafe static void Invoke([MangledName("agg.result")] BigInt_fjg8pd* agg_result, BigInt_x9dsed* @this, BigInt_x9dsed* other)
	{
		BigInt_fjg8pd bigInt_fjg8pd = default(BigInt_fjg8pd);
		llvm_lifetime_start_p0.Invoke(64L, &bigInt_fjg8pd);
		llvm_memset_p0_i64.Invoke(&bigInt_fjg8pd, -86, 64L, isVolatile: false);
		BigInt_512ul_false_unsigned_long_BigInt.Invoke(&bigInt_fjg8pd);
		unsigned_long_multiword_multiply_with_carry_unsigned_long_8ul_4ul_4ul_cpp_array_unsigned_long_8ul_cpp_array_unsigned_long_4ul_const_cpp_array_unsigned_long_4ul_const.Invoke(&bigInt_fjg8pd.val, &@this->val, &other->val);
		llvm_memcpy_p0_p0_i64.Invoke(agg_result, &bigInt_fjg8pd, 64L, isVolatile: false);
		llvm_lifetime_end_p0.Invoke(64L, &bigInt_fjg8pd);
	}
}
