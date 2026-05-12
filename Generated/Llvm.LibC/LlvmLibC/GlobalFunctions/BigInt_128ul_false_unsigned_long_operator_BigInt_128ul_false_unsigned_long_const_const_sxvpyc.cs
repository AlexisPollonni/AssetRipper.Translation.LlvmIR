using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm128ELb0EmEmlERKS1_")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>::operator*(__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long> const&) const")]
[CleanName("BigInt_128ul_false_unsigned_long_operator_BigInt_128ul_false_unsigned_long_const_const")]
internal static partial class BigInt_128ul_false_unsigned_long_operator_BigInt_128ul_false_unsigned_long_const_const_sxvpyc
{
	public unsafe static Struct_fiz2nb Invoke(anon_izyfb7* @this, anon_izyfb7* other)
	{
		BigInt_qdkjbh bigInt_qdkjbh = default(BigInt_qdkjbh);
		BigInt_x9dsed bigInt_x9dsed = default(BigInt_x9dsed);
		llvm_lifetime_start_p0.Invoke(32L, &bigInt_x9dsed);
		auto_BigInt_128ul_false_unsigned_long_ful_mul_128ul_BigInt_128ul_false_unsigned_long_const_const.Invoke(&bigInt_x9dsed, @this, other);
		unchecked
		{
			BigInt_128ul_false_unsigned_long_BigInt_256ul_false_unsigned_long_BigInt_256ul_false_unsigned_long_const.Invoke((anon_izyfb7*)(&bigInt_qdkjbh), &bigInt_x9dsed);
			llvm_lifetime_end_p0.Invoke(32L, &bigInt_x9dsed);
			return *(Struct_fiz2nb*)(&bigInt_qdkjbh.val.Data);
		}
	}
}
