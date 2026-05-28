using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_256ul_false_unsigned_long_Subtract_zudad5
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm256ELb0EmEmiERKS1_")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long>::operator-(__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long> const&) const")]
	[CleanName("BigInt_256ul_false_unsigned_long_Subtract")]
	public unsafe static void Invoke([MangledName("agg.result")] BigInt_x9dsed* Agg_result, [MangledName("this")] BigInt_x9dsed* This, [MangledName("other")] BigInt_x9dsed* Other)
	{
		unchecked
		{
			*(long*)Agg_result = -6148914691236517206L;
			((long*)Agg_result)[1] = -6148914691236517206L;
			((long*)Agg_result)[2] = -6148914691236517206L;
			((long*)Agg_result)[3] = -6148914691236517206L;
			Llvm_memcpy_p0_p0_i64.Invoke(Agg_result, This, 32L, isVolatile: false);
			BigInt_256ul_false_unsigned_long_sub_overflow.Invoke(Agg_result, Other);
		}
	}
}
