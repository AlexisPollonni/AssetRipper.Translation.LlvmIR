using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_anERKNS_6BigIntILm64ELb0EmEES3_")]
[DemangledName("__llvm_libc_20_1_2_::operator&(__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long> const&, __llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long> const&)")]
[CleanName("operator_BigInt_64ul_false_unsigned_long_const_BigInt_64ul_false_unsigned_long_const")]
internal static partial class operator_BigInt_64ul_false_unsigned_long_const_BigInt_64ul_false_unsigned_long_const_ufy43f
{
	public unsafe static long Invoke(void* lhs, void* rhs)
	{
		BigInt_nx6qdt bigInt_nx6qdt = default(BigInt_nx6qdt);
		long num = 0L;
		unchecked
		{
			*(long*)(&bigInt_nx6qdt) = -6148914691236517206L;
			BigInt_64ul_false_unsigned_long_BigInt.Invoke(&bigInt_nx6qdt);
			llvm_lifetime_start_p0.Invoke(8L, &num);
			for (num = 0L; (ulong)num < 1uL; num++)
			{
				long num2 = *(long*)BigInt_64ul_false_unsigned_long_operator_unsigned_long_const_64yjsu.Invoke(lhs, num) & *(long*)BigInt_64ul_false_unsigned_long_operator_unsigned_long_const_64yjsu.Invoke(rhs, num);
				*(long*)BigInt_64ul_false_unsigned_long_operator_unsigned_long_kztvyk.Invoke(&bigInt_nx6qdt, num) = num2;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return *(long*)(&bigInt_nx6qdt.val.Data);
		}
	}
}
