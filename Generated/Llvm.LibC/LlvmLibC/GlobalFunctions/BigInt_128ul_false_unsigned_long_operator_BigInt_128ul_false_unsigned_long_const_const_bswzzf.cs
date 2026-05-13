using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm128ELb0EmEmiERKS1_")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>::operator-(__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long> const&) const")]
[CleanName("BigInt_128ul_false_unsigned_long_operator_BigInt_128ul_false_unsigned_long_const_const")]
internal static partial class BigInt_128ul_false_unsigned_long_operator_BigInt_128ul_false_unsigned_long_const_const_bswzzf
{
	public unsafe static Struct_fiz2nb Invoke(anon_izyfb7* @this, anon_izyfb7* other)
	{
		BigInt_qdkjbh bigInt_qdkjbh = default(BigInt_qdkjbh);
		unchecked
		{
			sbyte* ptr = (sbyte*)(&bigInt_qdkjbh);
			*(long*)ptr = -6148914691236517206L;
			((long*)ptr)[1] = -6148914691236517206L;
			llvm_memcpy_p0_p0_i64.Invoke(&bigInt_qdkjbh, @this, 16L, isVolatile: false);
			BigInt_128ul_false_unsigned_long_sub_overflow_BigInt_128ul_false_unsigned_long_const.Invoke((anon_izyfb7*)(&bigInt_qdkjbh), other);
			return *(Struct_fiz2nb*)(&bigInt_qdkjbh.val.Data);
		}
	}
}
