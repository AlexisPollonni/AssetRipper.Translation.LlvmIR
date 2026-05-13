using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm128ELb0EmE7ful_mulILm128EEEDaRKNS0_IXT_ELb0EmEE")]
[DemangledName("auto __llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>::ful_mul<128ul>(__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long> const&) const")]
internal static partial class auto_BigInt_128ul_false_unsigned_long_ful_mul_128ul_BigInt_128ul_false_unsigned_long_const_const
{
	public unsafe static void Invoke([MangledName("agg.result")] BigInt_x9dsed* agg_result, anon_izyfb7* @this, anon_izyfb7* other)
	{
		BigInt_x9dsed bigInt_x9dsed = default(BigInt_x9dsed);
		llvm_lifetime_start_p0.Invoke(32L, &bigInt_x9dsed);
		unchecked
		{
			sbyte* ptr = (sbyte*)(&bigInt_x9dsed);
			*(long*)ptr = -6148914691236517206L;
			((long*)ptr)[1] = -6148914691236517206L;
			((long*)ptr)[2] = -6148914691236517206L;
			((long*)ptr)[3] = -6148914691236517206L;
			BigInt_256ul_false_unsigned_long_BigInt.Invoke(&bigInt_x9dsed);
			unsigned_long_multiword_multiply_with_carry_unsigned_long_4ul_2ul_2ul_cpp_array_unsigned_long_4ul_cpp_array_unsigned_long_2ul_const_cpp_array_unsigned_long_2ul_const.Invoke(&bigInt_x9dsed.val, &((BigInt_qdkjbh*)@this)->val, &((BigInt_qdkjbh*)other)->val);
			llvm_memcpy_p0_p0_i64.Invoke(agg_result, &bigInt_x9dsed, 32L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(32L, &bigInt_x9dsed);
		}
	}
}
