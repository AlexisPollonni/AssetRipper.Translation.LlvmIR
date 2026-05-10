using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_anERKNS_6BigIntILm128ELb0EmEES3_")]
[DemangledName("__llvm_libc_20_1_2_::operator&(__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long> const&, __llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long> const&)")]
[CleanName("operator_BigInt_128ul_false_unsigned_long_const_BigInt_128ul_false_unsigned_long_const")]
internal static partial class operator_BigInt_128ul_false_unsigned_long_const_BigInt_128ul_false_unsigned_long_const_bs7s6m
{
	public unsafe static Struct_fiz2nb Invoke(void* lhs, void* rhs)
	{
		BigInt_qdkjbh bigInt_qdkjbh = default(BigInt_qdkjbh);
		long num = 0L;
		unchecked
		{
			sbyte* ptr = (sbyte*)(&bigInt_qdkjbh);
			*(long*)ptr = -6148914691236517206L;
			((long*)ptr)[1] = -6148914691236517206L;
			BigInt_128ul_false_unsigned_long_BigInt.Invoke(&bigInt_qdkjbh);
			llvm_lifetime_start_p0.Invoke(8L, &num);
			for (num = 0L; (ulong)num < 2uL; num++)
			{
				long num2 = *(long*)BigInt_128ul_false_unsigned_long_operator_unsigned_long_const_ua9ih9.Invoke(lhs, num) & *(long*)BigInt_128ul_false_unsigned_long_operator_unsigned_long_const_ua9ih9.Invoke(rhs, num);
				*(long*)BigInt_128ul_false_unsigned_long_operator_unsigned_long_3b99zc.Invoke(&bigInt_qdkjbh, num) = num2;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return *(Struct_fiz2nb*)(&bigInt_qdkjbh.val.Data);
		}
	}
}
