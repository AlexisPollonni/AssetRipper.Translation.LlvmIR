using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_320ul_false_unsigned_long_Multiply
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm320ELb0EmEmlERKS1_")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<320ul, false, unsigned long>::operator*(__llvm_libc_20_1_2_::BigInt<320ul, false, unsigned long> const&) const")]
	public unsafe static void Invoke([MangledName("agg.result")] BigInt_76gxx6* agg_result, BigInt_76gxx6* @this, BigInt_76gxx6* other)
	{
		BigInt_m94xi3 bigInt_m94xi = default(BigInt_m94xi3);
		llvm_lifetime_start_p0.Invoke(80L, &bigInt_m94xi);
		BigInt_320ul_false_unsigned_long_ful_mul_320ul.Invoke(&bigInt_m94xi, @this, other);
		BigInt_320ul_false_unsigned_long_BigInt_640ul_false_unsigned_long.Invoke(agg_result, &bigInt_m94xi);
		llvm_lifetime_end_p0.Invoke(80L, &bigInt_m94xi);
	}
}
