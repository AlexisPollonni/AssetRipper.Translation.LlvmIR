using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11fixed_point7bit_andIDRtEENS_3cpp9enable_ifIXsr3cppE16is_fixed_point_vIT_EES4_E4typeES4_S4_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_fixed_point_v<unsigned short _Fract>, unsigned short _Fract>::type __llvm_libc_20_1_2_::fixed_point::bit_and<unsigned short _Fract>(unsigned short _Fract, unsigned short _Fract)")]
internal static partial class cpp_enable_if_cpp_is_fixed_point_v_unsigned_short_Fract_unsigned_short_Fract_type_fixed_point_bit_and_unsigned_short_Fract_unsigned_short_Fract_unsigned_short_Fract
{
	public unsafe static sbyte Invoke(sbyte x, sbyte y)
	{
		sbyte b = 0;
		sbyte b2 = 0;
		sbyte b3 = 0;
		sbyte b4 = x;
		sbyte b5 = y;
		llvm_lifetime_start_p0.Invoke(1L, &b);
		b = cpp_enable_if_sizeof_unsigned_char_sizeof_unsigned_short_Fract_cpp_is_trivially_constructible_unsigned_char_value_cpp_is_trivially_copyable_unsigned_char_value_cpp_is_trivially_copyable_unsigned_short_Fract_value_unsigned_char_type_cpp_bit_cast_unsigned_char_unsigned_short_Fract_unsigned_short_Fract_const.Invoke(&b4);
		llvm_lifetime_start_p0.Invoke(1L, &b2);
		b2 = cpp_enable_if_sizeof_unsigned_char_sizeof_unsigned_short_Fract_cpp_is_trivially_constructible_unsigned_char_value_cpp_is_trivially_copyable_unsigned_char_value_cpp_is_trivially_copyable_unsigned_short_Fract_value_unsigned_char_type_cpp_bit_cast_unsigned_char_unsigned_short_Fract_unsigned_short_Fract_const.Invoke(&b5);
		llvm_lifetime_start_p0.Invoke(1L, &b3);
		b3 = unchecked((sbyte)((byte)b & (byte)b2));
		sbyte result = cpp_enable_if_sizeof_unsigned_short_Fract_sizeof_unsigned_char_cpp_is_trivially_constructible_unsigned_short_Fract_value_cpp_is_trivially_copyable_unsigned_short_Fract_value_cpp_is_trivially_copyable_unsigned_char_value_unsigned_short_Fract_type_cpp_bit_cast_unsigned_short_Fract_unsigned_char_unsigned_char_const.Invoke(&b3);
		llvm_lifetime_end_p0.Invoke(1L, &b3);
		llvm_lifetime_end_p0.Invoke(1L, &b2);
		llvm_lifetime_end_p0.Invoke(1L, &b);
		return result;
	}
}
