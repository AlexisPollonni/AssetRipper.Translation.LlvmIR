using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_256ul_false_unsigned_long_quick_mul_hi
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm256ELb0EmE12quick_mul_hiERKS1_")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long>::quick_mul_hi(__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long> const&) const")]
	public unsafe static void Invoke([MangledName("agg.result")] BigInt_x9dsed* Agg_result, [MangledName("this")] BigInt_x9dsed* This, [MangledName("other")] BigInt_x9dsed* Other)
	{
		unchecked
		{
			*(long*)Agg_result = -6148914691236517206L;
			((long*)Agg_result)[1] = -6148914691236517206L;
			((long*)Agg_result)[2] = -6148914691236517206L;
			((long*)Agg_result)[3] = -6148914691236517206L;
			BigInt_256ul_false_unsigned_long_Constructor.Invoke(Agg_result);
			Multiword_quick_mul_hi_unsigned_long_4ul.Invoke(&Agg_result->Val, &This->Val, &Other->Val);
		}
	}
}
