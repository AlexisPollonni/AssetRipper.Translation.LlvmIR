using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_256ul_false_unsigned_long_Subtract_zudad5
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm256ELb0EmEmiERKS1_")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long>::operator-(__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long> const&) const")]
	[CleanName("BigInt_256ul_false_unsigned_long_Subtract")]
	public unsafe static void Invoke([MangledName("agg.result")] BigInt_x9dsed* agg_result, BigInt_x9dsed* @this, BigInt_x9dsed* other)
	{
		unchecked
		{
			*(long*)agg_result = -6148914691236517206L;
			((long*)agg_result)[1] = -6148914691236517206L;
			((long*)agg_result)[2] = -6148914691236517206L;
			((long*)agg_result)[3] = -6148914691236517206L;
			llvm_memcpy_p0_p0_i64.Invoke(agg_result, @this, 32L, isVolatile: false);
			BigInt_256ul_false_unsigned_long_sub_overflow.Invoke(agg_result, other);
		}
	}
}
