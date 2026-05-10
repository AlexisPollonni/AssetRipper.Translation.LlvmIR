using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_anERKNS_6BigIntILm256ELb0EmEES3_")]
[DemangledName("__llvm_libc_20_1_2_::operator&(__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long> const&, __llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long> const&)")]
[CleanName("operator_BigInt_256ul_false_unsigned_long_const_BigInt_256ul_false_unsigned_long_const")]
internal static partial class operator_BigInt_256ul_false_unsigned_long_const_BigInt_256ul_false_unsigned_long_const_abg3um
{
	public unsafe static void Invoke([MangledName("agg.result")] BigInt_x9dsed* agg_result, void* lhs, void* rhs)
	{
		long num = 0L;
		unchecked
		{
			*(long*)agg_result = -6148914691236517206L;
			((long*)agg_result)[1] = -6148914691236517206L;
			((long*)agg_result)[2] = -6148914691236517206L;
			((long*)agg_result)[3] = -6148914691236517206L;
			BigInt_256ul_false_unsigned_long_BigInt.Invoke(agg_result);
			llvm_lifetime_start_p0.Invoke(8L, &num);
			for (num = 0L; (ulong)num < 4uL; num++)
			{
				long num2 = *(long*)BigInt_256ul_false_unsigned_long_operator_unsigned_long_const_g5vf7y.Invoke(lhs, num) & *(long*)BigInt_256ul_false_unsigned_long_operator_unsigned_long_const_g5vf7y.Invoke(rhs, num);
				*(long*)BigInt_256ul_false_unsigned_long_operator_unsigned_long_vfj24x.Invoke(agg_result, num) = num2;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num);
		}
	}
}
