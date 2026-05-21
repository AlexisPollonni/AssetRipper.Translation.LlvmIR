using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_64ul_false_unsigned_long_ful_mul_64ul
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm64ELb0EmE7ful_mulILm64EEEDaRKNS0_IXT_ELb0EmEE")]
	[DemangledName("auto __llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long>::ful_mul<64ul>(__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long> const&) const")]
	[return: NativeType("auto")]
	public unsafe static Struct_fiz2nb Invoke([MangledName("this")] Llvm_libc_20_1_2_BigInt_555ggs* This, [MangledName("other")][NativeType("__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long> const&")] Llvm_libc_20_1_2_BigInt_555ggs* Other)
	{
		Llvm_libc_20_1_2_BigInt_qdkjbh llvm_libc_20_1_2_BigInt_qdkjbh = default(Llvm_libc_20_1_2_BigInt_qdkjbh);
		Llvm_libc_20_1_2_BigInt_qdkjbh llvm_libc_20_1_2_BigInt_qdkjbh2 = default(Llvm_libc_20_1_2_BigInt_qdkjbh);
		Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh2);
		unchecked
		{
			sbyte* ptr = (sbyte*)(&llvm_libc_20_1_2_BigInt_qdkjbh2);
			*(long*)ptr = -6148914691236517206L;
			((long*)ptr)[1] = -6148914691236517206L;
			BigInt_128ul_false_unsigned_long_Constructor.Invoke((Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh2));
			Multiword_multiply_with_carry_unsigned_long_2ul_1ul_1ul.Invoke(&llvm_libc_20_1_2_BigInt_qdkjbh2.Val, &This->Val, &Other->Val);
			Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_BigInt_qdkjbh, &llvm_libc_20_1_2_BigInt_qdkjbh2, 16L, isVolatile: false);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh2);
			return *(Struct_fiz2nb*)(&llvm_libc_20_1_2_BigInt_qdkjbh.Val.Data);
		}
	}
}
