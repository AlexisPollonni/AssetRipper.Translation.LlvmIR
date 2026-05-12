using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm320ELb0EmElSEm")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<320ul, false, unsigned long>::operator<<=(unsigned long)")]
[CleanName("BigInt_320ul_false_unsigned_long_operator_unsigned_long")]
internal static partial class BigInt_320ul_false_unsigned_long_operator_unsigned_long_9v34k9
{
	public unsafe static BigInt_76gxx6* Invoke(BigInt_76gxx6* @this, long s)
	{
		cpp_array_v97b5b cpp_array_v97b5b2 = default(cpp_array_v97b5b);
		cpp_array_v97b5b cpp_array_v97b5b3 = default(cpp_array_v97b5b);
		llvm_lifetime_start_p0.Invoke(40L, &cpp_array_v97b5b2);
		llvm_memcpy_p0_p0_i64.Invoke(&cpp_array_v97b5b3, &@this->val, 40L, isVolatile: false);
		cpp_array_unsigned_long_5ul_multiword_shift_multiword_Direction_0_false_unsigned_long_5ul_cpp_array_unsigned_long_5ul_unsigned_long.Invoke(&cpp_array_v97b5b2, &cpp_array_v97b5b3, s);
		llvm_memcpy_p0_p0_i64.Invoke(&@this->val, &cpp_array_v97b5b2, 40L, isVolatile: false);
		llvm_lifetime_end_p0.Invoke(40L, &cpp_array_v97b5b2);
		return @this;
	}
}
