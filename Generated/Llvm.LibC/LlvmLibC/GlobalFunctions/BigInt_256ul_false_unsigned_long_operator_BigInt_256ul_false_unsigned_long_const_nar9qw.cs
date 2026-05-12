using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm256ELb0EmEmiEOS1_")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long>::operator-(__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long>&&) const")]
[CleanName("BigInt_256ul_false_unsigned_long_operator_BigInt_256ul_false_unsigned_long_const")]
internal static partial class BigInt_256ul_false_unsigned_long_operator_BigInt_256ul_false_unsigned_long_const_nar9qw
{
	public unsafe static void Invoke([MangledName("agg.result")] BigInt_x9dsed* agg_result, BigInt_x9dsed* @this, BigInt_x9dsed* other)
	{
		unchecked
		{
			*(long*)agg_result = -6148914691236517206L;
			((long*)agg_result)[1] = -6148914691236517206L;
			((long*)agg_result)[2] = -6148914691236517206L;
			((long*)agg_result)[3] = -6148914691236517206L;
			llvm_memcpy_p0_p0_i64.Invoke(agg_result, @this, 32L, isVolatile: false);
			BigInt_256ul_false_unsigned_long_sub_overflow_BigInt_256ul_false_unsigned_long_const.Invoke(agg_result, other);
		}
	}
}
