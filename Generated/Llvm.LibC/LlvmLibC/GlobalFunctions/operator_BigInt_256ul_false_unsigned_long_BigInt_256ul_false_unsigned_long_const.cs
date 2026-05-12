using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_oRERNS_6BigIntILm256ELb0EmEERKS1_")]
[DemangledName("__llvm_libc_20_1_2_::operator|=(__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long>&, __llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long> const&)")]
internal static partial class operator_BigInt_256ul_false_unsigned_long_BigInt_256ul_false_unsigned_long_const
{
	public unsafe static void Invoke([MangledName("agg.result")] BigInt_x9dsed* agg_result, BigInt_x9dsed* lhs, BigInt_x9dsed* rhs)
	{
		long num = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		unchecked
		{
			for (num = 0L; (ulong)num < 4uL; num++)
			{
				long num2 = *(long*)BigInt_256ul_false_unsigned_long_operator_unsigned_long_const_g5vf7y.Invoke(rhs, num);
				*(long*)BigInt_256ul_false_unsigned_long_operator_unsigned_long_vfj24x.Invoke(lhs, num) |= num2;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num);
			llvm_memcpy_p0_p0_i64.Invoke(agg_result, lhs, 32L, isVolatile: false);
		}
	}
}
