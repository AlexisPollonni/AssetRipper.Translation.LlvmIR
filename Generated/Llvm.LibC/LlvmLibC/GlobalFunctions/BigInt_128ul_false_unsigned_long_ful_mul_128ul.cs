using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_128ul_false_unsigned_long_ful_mul_128ul
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm128ELb0EmE7ful_mulILm128EEEDaRKNS0_IXT_ELb0EmEE")]
	[DemangledName("auto __llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>::ful_mul<128ul>(__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long> const&) const")]
	[return: NativeType("auto")]
	public unsafe static void Invoke([MangledName("agg.result")] Llvm_libc_20_1_2_BigInt_x9dsed* Agg_result, [MangledName("this")] Anon_izyfb7* This, [MangledName("other")] Anon_izyfb7* Other)
	{
		Llvm_libc_20_1_2_BigInt_x9dsed llvm_libc_20_1_2_BigInt_x9dsed = default(Llvm_libc_20_1_2_BigInt_x9dsed);
		Llvm_lifetime_start_p0.Invoke(32L, &llvm_libc_20_1_2_BigInt_x9dsed);
		unchecked
		{
			sbyte* ptr = (sbyte*)(&llvm_libc_20_1_2_BigInt_x9dsed);
			*(long*)ptr = -6148914691236517206L;
			((long*)ptr)[1] = -6148914691236517206L;
			((long*)ptr)[2] = -6148914691236517206L;
			((long*)ptr)[3] = -6148914691236517206L;
			BigInt_256ul_false_unsigned_long_Constructor.Invoke(&llvm_libc_20_1_2_BigInt_x9dsed);
			Multiword_multiply_with_carry_unsigned_long_4ul_2ul_2ul.Invoke(&llvm_libc_20_1_2_BigInt_x9dsed.Val, &((Llvm_libc_20_1_2_BigInt_qdkjbh*)This)->Val, &((Llvm_libc_20_1_2_BigInt_qdkjbh*)Other)->Val);
			Llvm_memcpy_p0_p0_i64.Invoke(Agg_result, &llvm_libc_20_1_2_BigInt_x9dsed, 32L, isVolatile: false);
			Llvm_lifetime_end_p0.Invoke(32L, &llvm_libc_20_1_2_BigInt_x9dsed);
		}
	}
}
