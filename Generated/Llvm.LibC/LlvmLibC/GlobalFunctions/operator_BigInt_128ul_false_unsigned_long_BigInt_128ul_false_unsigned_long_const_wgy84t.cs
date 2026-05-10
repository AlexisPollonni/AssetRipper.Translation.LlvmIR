using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_oRERNS_6BigIntILm128ELb0EmEERKS1_")]
[DemangledName("__llvm_libc_20_1_2_::operator|=(__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>&, __llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long> const&)")]
[CleanName("operator_BigInt_128ul_false_unsigned_long_BigInt_128ul_false_unsigned_long_const")]
internal static partial class operator_BigInt_128ul_false_unsigned_long_BigInt_128ul_false_unsigned_long_const_wgy84t
{
	public unsafe static Struct_fiz2nb Invoke(void* lhs, void* rhs)
	{
		BigInt_qdkjbh bigInt_qdkjbh = default(BigInt_qdkjbh);
		long num = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		unchecked
		{
			for (num = 0L; (ulong)num < 2uL; num++)
			{
				long num2 = *(long*)BigInt_128ul_false_unsigned_long_operator_unsigned_long_const_ua9ih9.Invoke(rhs, num);
				*(long*)BigInt_128ul_false_unsigned_long_operator_unsigned_long_3b99zc.Invoke(lhs, num) |= num2;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num);
			llvm_memcpy_p0_p0_i64.Invoke(&bigInt_qdkjbh, lhs, 16L, isVolatile: false);
			return *(Struct_fiz2nb*)(&bigInt_qdkjbh.val.Data);
		}
	}
}
