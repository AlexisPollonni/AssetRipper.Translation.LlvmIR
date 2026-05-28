using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_256ul_false_unsigned_long_Multiply
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm256ELb0EmEmlERKS1_")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long>::operator*(__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long> const&) const")]
	public unsafe static void Invoke([MangledName("agg.result")] BigInt_x9dsed* Agg_result, [MangledName("this")] BigInt_x9dsed* This, [MangledName("other")] BigInt_x9dsed* Other)
	{
		BigInt_fjg8pd bigInt_fjg8pd = default(BigInt_fjg8pd);
		Llvm_lifetime_start_p0.Invoke(64L, &bigInt_fjg8pd);
		BigInt_256ul_false_unsigned_long_ful_mul_256ul.Invoke(&bigInt_fjg8pd, This, Other);
		BigInt_256ul_false_unsigned_long_BigInt_512ul_false_unsigned_long.Invoke(Agg_result, &bigInt_fjg8pd);
		Llvm_lifetime_end_p0.Invoke(64L, &bigInt_fjg8pd);
	}
}
