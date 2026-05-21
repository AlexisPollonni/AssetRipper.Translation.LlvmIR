using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_320ul_false_unsigned_long_ful_mul_320ul
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm320ELb0EmE7ful_mulILm320EEEDaRKNS0_IXT_ELb0EmEE")]
	[DemangledName("auto __llvm_libc_20_1_2_::BigInt<320ul, false, unsigned long>::ful_mul<320ul>(__llvm_libc_20_1_2_::BigInt<320ul, false, unsigned long> const&) const")]
	[return: NativeType("auto")]
	public unsafe static void Invoke([MangledName("agg.result")] Llvm_libc_20_1_2_BigInt_m94xi3* Agg_result, [MangledName("this")] Llvm_libc_20_1_2_BigInt_76gxx6* This, [MangledName("other")] Llvm_libc_20_1_2_BigInt_76gxx6* Other)
	{
		Llvm_libc_20_1_2_BigInt_m94xi3 llvm_libc_20_1_2_BigInt_m94xi = default(Llvm_libc_20_1_2_BigInt_m94xi3);
		Llvm_lifetime_start_p0.Invoke(80L, &llvm_libc_20_1_2_BigInt_m94xi);
		Llvm_memset_p0_i64.Invoke(&llvm_libc_20_1_2_BigInt_m94xi, -86, 80L, isVolatile: false);
		BigInt_640ul_false_unsigned_long_Constructor.Invoke(&llvm_libc_20_1_2_BigInt_m94xi);
		Multiword_multiply_with_carry_unsigned_long_10ul_5ul_5ul.Invoke(&llvm_libc_20_1_2_BigInt_m94xi.Val, &This->Val, &Other->Val);
		Llvm_memcpy_p0_p0_i64.Invoke(Agg_result, &llvm_libc_20_1_2_BigInt_m94xi, 80L, isVolatile: false);
		Llvm_lifetime_end_p0.Invoke(80L, &llvm_libc_20_1_2_BigInt_m94xi);
	}
}
