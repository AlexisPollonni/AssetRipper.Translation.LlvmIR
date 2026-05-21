using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_256ul_false_unsigned_long_quick_mul_hi
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm256ELb0EmE12quick_mul_hiERKS1_")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long>::quick_mul_hi(__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long> const&) const")]
	public unsafe static void Invoke([MangledName("agg.result")] BigInt_x9dsed* agg_result, BigInt_x9dsed* @this, BigInt_x9dsed* other)
	{
		unchecked
		{
			*(long*)agg_result = -6148914691236517206L;
			((long*)agg_result)[1] = -6148914691236517206L;
			((long*)agg_result)[2] = -6148914691236517206L;
			((long*)agg_result)[3] = -6148914691236517206L;
			BigInt_256ul_false_unsigned_long_Constructor.Invoke(agg_result);
			multiword_quick_mul_hi_unsigned_long_4ul.Invoke(&agg_result->val, &@this->val, &other->val);
		}
	}
}
