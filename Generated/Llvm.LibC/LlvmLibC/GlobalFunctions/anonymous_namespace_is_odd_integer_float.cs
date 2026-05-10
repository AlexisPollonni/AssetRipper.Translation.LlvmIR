using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_114is_odd_integerEf")]
[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::is_odd_integer(float)")]
internal static partial class anonymous_namespace_is_odd_integer_float
{
	public unsafe static bool Invoke(float x)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		float num5 = x;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = cpp_enable_if_sizeof_unsigned_int_sizeof_float_cpp_is_trivially_constructible_unsigned_int_value_cpp_is_trivially_copyable_unsigned_int_value_cpp_is_trivially_copyable_float_value_unsigned_int_type_cpp_bit_cast_unsigned_int_float_float_const.Invoke(&num5);
		llvm_lifetime_start_p0.Invoke(4L, &num2);
		num2 = (num & 0x7F800000) >>> 23;
		llvm_lifetime_start_p0.Invoke(4L, &num3);
		num3 = cpp_enable_if_cpp_is_unsigned_v_unsigned_int_int_type_cpp_countr_zero_unsigned_int_unsigned_int.Invoke(num | 0x7F800000);
		llvm_lifetime_start_p0.Invoke(4L, &num4);
		num4 = 150;
		bool result = num2 + num3 == 150;
		llvm_lifetime_end_p0.Invoke(4L, &num4);
		llvm_lifetime_end_p0.Invoke(4L, &num3);
		llvm_lifetime_end_p0.Invoke(4L, &num2);
		llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
