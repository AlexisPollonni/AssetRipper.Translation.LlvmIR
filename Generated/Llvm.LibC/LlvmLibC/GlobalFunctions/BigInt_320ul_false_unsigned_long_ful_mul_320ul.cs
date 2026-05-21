using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_320ul_false_unsigned_long_ful_mul_320ul
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm320ELb0EmE7ful_mulILm320EEEDaRKNS0_IXT_ELb0EmEE")]
	[DemangledName("auto __llvm_libc_20_1_2_::BigInt<320ul, false, unsigned long>::ful_mul<320ul>(__llvm_libc_20_1_2_::BigInt<320ul, false, unsigned long> const&) const")]
	[return: NativeType("auto")]
	public unsafe static void Invoke([MangledName("agg.result")] BigInt_m94xi3* agg_result, BigInt_76gxx6* @this, BigInt_76gxx6* other)
	{
		BigInt_m94xi3 bigInt_m94xi = default(BigInt_m94xi3);
		llvm_lifetime_start_p0.Invoke(80L, &bigInt_m94xi);
		llvm_memset_p0_i64.Invoke(&bigInt_m94xi, -86, 80L, isVolatile: false);
		BigInt_640ul_false_unsigned_long_Constructor.Invoke(&bigInt_m94xi);
		multiword_multiply_with_carry_unsigned_long_10ul_5ul_5ul.Invoke(&bigInt_m94xi.val, &@this->val, &other->val);
		llvm_memcpy_p0_p0_i64.Invoke(agg_result, &bigInt_m94xi, 80L, isVolatile: false);
		llvm_lifetime_end_p0.Invoke(80L, &bigInt_m94xi);
	}
}
