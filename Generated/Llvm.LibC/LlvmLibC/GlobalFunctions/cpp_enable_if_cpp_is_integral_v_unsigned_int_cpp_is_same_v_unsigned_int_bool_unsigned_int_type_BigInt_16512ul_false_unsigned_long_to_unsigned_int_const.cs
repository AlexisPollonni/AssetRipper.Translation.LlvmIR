using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm16512ELb0EmE2toIjEENS_3cpp9enable_ifIXaasr3cppE13is_integral_vIT_Entsr3cppE9is_same_vIS5_bEES5_E4typeEv")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_integral_v<unsigned int> && !cpp::is_same_v<unsigned int, bool>, unsigned int>::type __llvm_libc_20_1_2_::BigInt<16512ul, false, unsigned long>::to<unsigned int>() const")]
internal static partial class cpp_enable_if_cpp_is_integral_v_unsigned_int_cpp_is_same_v_unsigned_int_bool_unsigned_int_type_BigInt_16512ul_false_unsigned_long_to_unsigned_int_const
{
	public unsafe static int Invoke(BigInt_q8g275* @this)
	{
		long num = 0L;
		int num2 = 0;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = 32L;
		llvm_lifetime_start_p0.Invoke(4L, &num2);
		num2 = unchecked((int)(*(long*)cpp_array_unsigned_long_258ul_operator_unsigned_long_const.Invoke(&@this->val, 0L)));
		int result = num2;
		llvm_lifetime_end_p0.Invoke(4L, &num2);
		llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}
}
