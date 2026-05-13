using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm64ELb0EmE7ful_mulILm64EEEDaRKNS0_IXT_ELb0EmEE")]
[DemangledName("auto __llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long>::ful_mul<64ul>(__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long> const&) const")]
internal static partial class auto_BigInt_64ul_false_unsigned_long_ful_mul_64ul_BigInt_64ul_false_unsigned_long_const_const
{
	public unsafe static Struct_fiz2nb Invoke(BigInt_nx6qdt* @this, BigInt_nx6qdt* other)
	{
		BigInt_qdkjbh bigInt_qdkjbh = default(BigInt_qdkjbh);
		BigInt_qdkjbh bigInt_qdkjbh2 = default(BigInt_qdkjbh);
		llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh2);
		unchecked
		{
			sbyte* ptr = (sbyte*)(&bigInt_qdkjbh2);
			*(long*)ptr = -6148914691236517206L;
			((long*)ptr)[1] = -6148914691236517206L;
			BigInt_128ul_false_unsigned_long_BigInt.Invoke((anon_izyfb7*)(&bigInt_qdkjbh2));
			unsigned_long_multiword_multiply_with_carry_unsigned_long_2ul_1ul_1ul_cpp_array_unsigned_long_2ul_cpp_array_unsigned_long_1ul_const_cpp_array_unsigned_long_1ul_const.Invoke(&bigInt_qdkjbh2.val, &@this->val, &other->val);
			llvm_memcpy_p0_p0_i64.Invoke(&bigInt_qdkjbh, &bigInt_qdkjbh2, 16L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh2);
			return *(Struct_fiz2nb*)(&bigInt_qdkjbh.val.Data);
		}
	}
}
