using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm256ELb0EmE2toImEENS_3cpp9enable_ifIXaasr3cppE13is_integral_vIT_Entsr3cppE9is_same_vIS5_bEES5_E4typeEv")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_integral_v<unsigned long> && !cpp::is_same_v<unsigned long, bool>, unsigned long>::type __llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long>::to<unsigned long>() const")]
internal static partial class cpp_enable_if_cpp_is_integral_v_unsigned_long_cpp_is_same_v_unsigned_long_bool_unsigned_long_type_BigInt_256ul_false_unsigned_long_to_unsigned_long_const
{
	public unsafe static long Invoke(BigInt_x9dsed* @this)
	{
		long num = 0L;
		long num2 = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = 64L;
		llvm_lifetime_start_p0.Invoke(8L, &num2);
		num2 = *unchecked((long*)cpp_array_unsigned_long_4ul_operator_unsigned_long_const.Invoke(&@this->val, 0L));
		long result = num2;
		llvm_lifetime_end_p0.Invoke(8L, &num2);
		llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}
}
