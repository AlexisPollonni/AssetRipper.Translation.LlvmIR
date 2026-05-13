using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11fixed_point7bit_notIDAiEENS_3cpp9enable_ifIXsr3cppE16is_fixed_point_vIT_EES4_E4typeES4_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_fixed_point_v<_Accum>, _Accum>::type __llvm_libc_20_1_2_::fixed_point::bit_not<_Accum>(_Accum)")]
internal static partial class cpp_enable_if_cpp_is_fixed_point_v_Accum_Accum_type_fixed_point_bit_not_Accum_Accum
{
	public unsafe static int Invoke(int x)
	{
		int num = 0;
		int num2 = 0;
		int num3 = x;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = cpp_enable_if_sizeof_unsigned_int_sizeof_Accum_cpp_is_trivially_constructible_unsigned_int_value_cpp_is_trivially_copyable_unsigned_int_value_cpp_is_trivially_copyable_Accum_value_unsigned_int_type_cpp_bit_cast_unsigned_int_Accum_Accum_const.Invoke(&num3);
		llvm_lifetime_start_p0.Invoke(4L, &num2);
		num2 = num ^ -1;
		int result = cpp_enable_if_sizeof_Accum_sizeof_unsigned_int_cpp_is_trivially_constructible_Accum_value_cpp_is_trivially_copyable_Accum_value_cpp_is_trivially_copyable_unsigned_int_value_Accum_type_cpp_bit_cast_Accum_unsigned_int_unsigned_int_const.Invoke(&num2);
		llvm_lifetime_end_p0.Invoke(4L, &num2);
		llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
