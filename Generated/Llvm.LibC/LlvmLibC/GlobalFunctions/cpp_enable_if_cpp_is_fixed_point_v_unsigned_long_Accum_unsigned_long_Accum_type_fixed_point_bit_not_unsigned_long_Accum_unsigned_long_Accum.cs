using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11fixed_point7bit_notIDAmEENS_3cpp9enable_ifIXsr3cppE16is_fixed_point_vIT_EES4_E4typeES4_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_fixed_point_v<unsigned long _Accum>, unsigned long _Accum>::type __llvm_libc_20_1_2_::fixed_point::bit_not<unsigned long _Accum>(unsigned long _Accum)")]
internal static partial class cpp_enable_if_cpp_is_fixed_point_v_unsigned_long_Accum_unsigned_long_Accum_type_fixed_point_bit_not_unsigned_long_Accum_unsigned_long_Accum
{
	public unsafe static long Invoke(long x)
	{
		long num = 0L;
		long num2 = 0L;
		long num3 = x;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = cpp_enable_if_sizeof_unsigned_long_sizeof_unsigned_long_Accum_cpp_is_trivially_constructible_unsigned_long_value_cpp_is_trivially_copyable_unsigned_long_value_cpp_is_trivially_copyable_unsigned_long_Accum_value_unsigned_long_type_cpp_bit_cast_unsigned_long_unsigned_long_Accum_unsigned_long_Accum_const.Invoke(&num3);
		llvm_lifetime_start_p0.Invoke(8L, &num2);
		num2 = num ^ -1L;
		long result = cpp_enable_if_sizeof_unsigned_long_Accum_sizeof_unsigned_long_cpp_is_trivially_constructible_unsigned_long_Accum_value_cpp_is_trivially_copyable_unsigned_long_Accum_value_cpp_is_trivially_copyable_unsigned_long_value_unsigned_long_Accum_type_cpp_bit_cast_unsigned_long_Accum_unsigned_long_unsigned_long_const.Invoke(&num2);
		llvm_lifetime_end_p0.Invoke(8L, &num2);
		llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}
}
