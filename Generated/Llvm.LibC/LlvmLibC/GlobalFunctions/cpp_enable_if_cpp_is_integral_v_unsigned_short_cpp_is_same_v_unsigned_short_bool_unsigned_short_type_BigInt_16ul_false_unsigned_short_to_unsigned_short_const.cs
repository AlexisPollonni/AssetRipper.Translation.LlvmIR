using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm16ELb0EtE2toItEENS_3cpp9enable_ifIXaasr3cppE13is_integral_vIT_Entsr3cppE9is_same_vIS5_bEES5_E4typeEv")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_integral_v<unsigned short> && !cpp::is_same_v<unsigned short, bool>, unsigned short>::type __llvm_libc_20_1_2_::BigInt<16ul, false, unsigned short>::to<unsigned short>() const")]
internal static partial class cpp_enable_if_cpp_is_integral_v_unsigned_short_cpp_is_same_v_unsigned_short_bool_unsigned_short_type_BigInt_16ul_false_unsigned_short_to_unsigned_short_const
{
	public unsafe static short Invoke(void* @this)
	{
		long num = 0L;
		short num2 = 0;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = 16L;
		llvm_lifetime_start_p0.Invoke(2L, &num2);
		num2 = *unchecked((short*)cpp_array_unsigned_short_1ul_operator_unsigned_long_const.Invoke(&((BigInt_ys7s55*)@this)->val, 0L));
		short result = num2;
		llvm_lifetime_end_p0.Invoke(2L, &num2);
		llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}
}
