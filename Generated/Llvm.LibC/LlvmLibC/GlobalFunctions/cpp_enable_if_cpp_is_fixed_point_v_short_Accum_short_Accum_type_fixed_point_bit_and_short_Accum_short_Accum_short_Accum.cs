using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11fixed_point7bit_andIDAsEENS_3cpp9enable_ifIXsr3cppE16is_fixed_point_vIT_EES4_E4typeES4_S4_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_fixed_point_v<short _Accum>, short _Accum>::type __llvm_libc_20_1_2_::fixed_point::bit_and<short _Accum>(short _Accum, short _Accum)")]
internal static partial class cpp_enable_if_cpp_is_fixed_point_v_short_Accum_short_Accum_type_fixed_point_bit_and_short_Accum_short_Accum_short_Accum
{
	public unsafe static short Invoke(short x, short y)
	{
		short num = 0;
		short num2 = 0;
		short num3 = 0;
		short num4 = x;
		short num5 = y;
		llvm_lifetime_start_p0.Invoke(2L, &num);
		num = cpp_enable_if_sizeof_unsigned_short_sizeof_short_Accum_cpp_is_trivially_constructible_unsigned_short_value_cpp_is_trivially_copyable_unsigned_short_value_cpp_is_trivially_copyable_short_Accum_value_unsigned_short_type_cpp_bit_cast_unsigned_short_short_Accum_short_Accum_const.Invoke(&num4);
		llvm_lifetime_start_p0.Invoke(2L, &num2);
		num2 = cpp_enable_if_sizeof_unsigned_short_sizeof_short_Accum_cpp_is_trivially_constructible_unsigned_short_value_cpp_is_trivially_copyable_unsigned_short_value_cpp_is_trivially_copyable_short_Accum_value_unsigned_short_type_cpp_bit_cast_unsigned_short_short_Accum_short_Accum_const.Invoke(&num5);
		llvm_lifetime_start_p0.Invoke(2L, &num3);
		num3 = unchecked((short)((ushort)num & (ushort)num2));
		short result = cpp_enable_if_sizeof_short_Accum_sizeof_unsigned_short_cpp_is_trivially_constructible_short_Accum_value_cpp_is_trivially_copyable_short_Accum_value_cpp_is_trivially_copyable_unsigned_short_value_short_Accum_type_cpp_bit_cast_short_Accum_unsigned_short_unsigned_short_const.Invoke(&num3);
		llvm_lifetime_end_p0.Invoke(2L, &num3);
		llvm_lifetime_end_p0.Invoke(2L, &num2);
		llvm_lifetime_end_p0.Invoke(2L, &num);
		return result;
	}
}
