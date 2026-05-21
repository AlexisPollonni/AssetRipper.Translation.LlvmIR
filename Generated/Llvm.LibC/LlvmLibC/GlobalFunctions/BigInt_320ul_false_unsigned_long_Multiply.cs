using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_320ul_false_unsigned_long_Multiply
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm320ELb0EmEmlERKS1_")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<320ul, false, unsigned long>::operator*(__llvm_libc_20_1_2_::BigInt<320ul, false, unsigned long> const&) const")]
	public unsafe static void Invoke([MangledName("agg.result")] Llvm_libc_20_1_2_BigInt_76gxx6* Agg_result, [MangledName("this")] Llvm_libc_20_1_2_BigInt_76gxx6* This, [MangledName("other")] Llvm_libc_20_1_2_BigInt_76gxx6* Other)
	{
		Llvm_libc_20_1_2_BigInt_m94xi3 llvm_libc_20_1_2_BigInt_m94xi = default(Llvm_libc_20_1_2_BigInt_m94xi3);
		Llvm_lifetime_start_p0.Invoke(80L, &llvm_libc_20_1_2_BigInt_m94xi);
		BigInt_320ul_false_unsigned_long_ful_mul_320ul.Invoke(&llvm_libc_20_1_2_BigInt_m94xi, This, Other);
		BigInt_320ul_false_unsigned_long_BigInt_640ul_false_unsigned_long.Invoke(Agg_result, &llvm_libc_20_1_2_BigInt_m94xi);
		Llvm_lifetime_end_p0.Invoke(80L, &llvm_libc_20_1_2_BigInt_m94xi);
	}
}
