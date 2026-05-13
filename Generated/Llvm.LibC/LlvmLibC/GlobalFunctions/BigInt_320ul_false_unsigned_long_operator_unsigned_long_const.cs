using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm320ELb0EmErsEm")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<320ul, false, unsigned long>::operator>>(unsigned long) const")]
internal static partial class BigInt_320ul_false_unsigned_long_operator_unsigned_long_const
{
	public unsafe static void Invoke([MangledName("agg.result")] BigInt_76gxx6* agg_result, BigInt_76gxx6* @this, long s)
	{
		cpp_array_v97b5b cpp_array_v97b5b2 = default(cpp_array_v97b5b);
		cpp_array_v97b5b cpp_array_v97b5b3 = default(cpp_array_v97b5b);
		llvm_lifetime_start_p0.Invoke(40L, &cpp_array_v97b5b2);
		llvm_memcpy_p0_p0_i64.Invoke(&cpp_array_v97b5b3, &@this->val, 40L, isVolatile: false);
		cpp_array_unsigned_long_5ul_multiword_shift_multiword_Direction_1_false_unsigned_long_5ul_cpp_array_unsigned_long_5ul_unsigned_long.Invoke(&cpp_array_v97b5b2, &cpp_array_v97b5b3, s);
		BigInt_320ul_false_unsigned_long_BigInt_cpp_array_unsigned_long_5ul_const.Invoke(agg_result, &cpp_array_v97b5b2);
		llvm_lifetime_end_p0.Invoke(40L, &cpp_array_v97b5b2);
	}
}
