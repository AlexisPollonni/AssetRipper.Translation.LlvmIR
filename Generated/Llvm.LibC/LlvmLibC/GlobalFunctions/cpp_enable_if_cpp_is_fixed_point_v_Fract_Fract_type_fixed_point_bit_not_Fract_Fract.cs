using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11fixed_point7bit_notIDRiEENS_3cpp9enable_ifIXsr3cppE16is_fixed_point_vIT_EES4_E4typeES4_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_fixed_point_v<_Fract>, _Fract>::type __llvm_libc_20_1_2_::fixed_point::bit_not<_Fract>(_Fract)")]
internal static partial class cpp_enable_if_cpp_is_fixed_point_v_Fract_Fract_type_fixed_point_bit_not_Fract_Fract
{
	public unsafe static short Invoke(short x)
	{
		short num = 0;
		short num2 = 0;
		short num3 = x;
		llvm_lifetime_start_p0.Invoke(2L, &num);
		num = cpp_enable_if_sizeof_unsigned_short_sizeof_Fract_cpp_is_trivially_constructible_unsigned_short_value_cpp_is_trivially_copyable_unsigned_short_value_cpp_is_trivially_copyable_Fract_value_unsigned_short_type_cpp_bit_cast_unsigned_short_Fract_Fract_const.Invoke(&num3);
		llvm_lifetime_start_p0.Invoke(2L, &num2);
		num2 = unchecked((short)((ushort)num ^ -1));
		short result = cpp_enable_if_sizeof_Fract_sizeof_unsigned_short_cpp_is_trivially_constructible_Fract_value_cpp_is_trivially_copyable_Fract_value_cpp_is_trivially_copyable_unsigned_short_value_Fract_type_cpp_bit_cast_Fract_unsigned_short_unsigned_short_const.Invoke(&num2);
		llvm_lifetime_end_p0.Invoke(2L, &num2);
		llvm_lifetime_end_p0.Invoke(2L, &num);
		return result;
	}
}
