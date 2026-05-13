using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_15ziv_test_denormEiddd")]
[DemangledName("__llvm_libc_20_1_2_::ziv_test_denorm(int, double, double, double)")]
internal static partial class ziv_test_denorm_int_double_double_double
{
	public unsafe static Struct_8myw6y Invoke(int hi, double mid, double lo, double err)
	{
		cpp_optional_s4iqgj cpp_optional_s4iqgj2 = default(cpp_optional_s4iqgj);
		double x = 0.0;
		double num = 0.0;
		long num2 = 0L;
		double num3 = 0.0;
		long num4 = 0L;
		double num5 = 0.0;
		long num6 = 0L;
		double num7 = 0.0;
		long num8 = 0L;
		double num9 = 0.0;
		long num10 = 0L;
		double num11 = 0.0;
		double num12 = 0.0;
		double num13 = 0.0;
		double num14 = 0.0;
		double num15 = 0.0;
		long num16 = 0L;
		double num17 = mid;
		x = lo;
		num = err;
		llvm_lifetime_start_p0.Invoke(8L, &num2);
		unchecked
		{
			num2 = (long)checked(hi + 1022) << 52;
			llvm_lifetime_start_p0.Invoke(8L, &num3);
			llvm_lifetime_start_p0.Invoke(8L, &num4);
		}
		num4 = num2 + cpp_enable_if_sizeof_long_sizeof_double_cpp_is_trivially_constructible_long_value_cpp_is_trivially_copyable_long_value_cpp_is_trivially_copyable_double_value_long_type_cpp_bit_cast_long_double_double_const.Invoke(&num17);
		double num18 = cpp_enable_if_sizeof_double_sizeof_long_cpp_is_trivially_constructible_double_value_cpp_is_trivially_copyable_double_value_cpp_is_trivially_copyable_long_value_double_type_cpp_bit_cast_double_long_long_const.Invoke(&num4);
		llvm_lifetime_end_p0.Invoke(8L, &num4);
		num3 = num18;
		llvm_lifetime_start_p0.Invoke(8L, &num5);
		bool num19 = NumericHelper.IsUnorderedOrNotEquals(x, 0.0);
		llvm_lifetime_start_p0.Invoke(8L, &num6);
		double num20;
		if (num19)
		{
			num6 = num2 + cpp_enable_if_sizeof_long_sizeof_double_cpp_is_trivially_constructible_long_value_cpp_is_trivially_copyable_long_value_cpp_is_trivially_copyable_double_value_long_type_cpp_bit_cast_long_double_double_const.Invoke(&x);
			num20 = cpp_enable_if_sizeof_double_sizeof_long_cpp_is_trivially_constructible_double_value_cpp_is_trivially_copyable_double_value_cpp_is_trivially_copyable_long_value_double_type_cpp_bit_cast_double_long_long_const.Invoke(&num6);
		}
		else
		{
			num20 = 0.0;
		}
		llvm_lifetime_end_p0.Invoke(8L, &num6);
		num5 = num20;
		llvm_lifetime_start_p0.Invoke(8L, &num7);
		num7 = 0.0;
		llvm_lifetime_start_p0.Invoke(8L, &num8);
		num8 = 4602678819172646912L;
		if (1.0 - num3 > num5)
		{
			num += 2.220446049250313E-16;
			num7 = 1.0;
			num8 = 4607182418800017408L;
		}
		llvm_lifetime_start_p0.Invoke(8L, &num9);
		llvm_lifetime_start_p0.Invoke(8L, &num10);
		num10 = num2 + cpp_enable_if_sizeof_long_sizeof_double_cpp_is_trivially_constructible_long_value_cpp_is_trivially_copyable_long_value_cpp_is_trivially_copyable_double_value_long_type_cpp_bit_cast_long_double_double_const.Invoke(&num);
		double num21 = cpp_enable_if_sizeof_double_sizeof_long_cpp_is_trivially_constructible_double_value_cpp_is_trivially_copyable_double_value_cpp_is_trivially_copyable_long_value_double_type_cpp_bit_cast_double_long_long_const.Invoke(&num10);
		llvm_lifetime_end_p0.Invoke(8L, &num10);
		num9 = num21;
		llvm_lifetime_start_p0.Invoke(8L, &num11);
		num11 = num5 + num9;
		llvm_lifetime_start_p0.Invoke(8L, &num12);
		num12 = num5 - num9;
		llvm_lifetime_start_p0.Invoke(8L, &num13);
		num13 = num7 + (num3 + num11);
		llvm_lifetime_start_p0.Invoke(8L, &num14);
		num14 = num7 + (num3 + num12);
		unchecked
		{
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(num13 == num14, expected: true))
			{
				llvm_lifetime_start_p0.Invoke(8L, &num15);
				llvm_lifetime_start_p0.Invoke(8L, &num16);
				num16 = cpp_enable_if_sizeof_unsigned_long_sizeof_double_cpp_is_trivially_constructible_unsigned_long_value_cpp_is_trivially_copyable_unsigned_long_value_cpp_is_trivially_copyable_double_value_unsigned_long_type_cpp_bit_cast_unsigned_long_double_double_const.Invoke(&num13) - num8;
				num15 = cpp_enable_if_sizeof_double_sizeof_unsigned_long_cpp_is_trivially_constructible_double_value_cpp_is_trivially_copyable_double_value_cpp_is_trivially_copyable_unsigned_long_value_double_type_cpp_bit_cast_double_unsigned_long_unsigned_long_const.Invoke(&num16);
				cpp_optional_double_optional_double.Invoke(&cpp_optional_s4iqgj2, &num15);
				llvm_lifetime_end_p0.Invoke(8L, &num16);
				llvm_lifetime_end_p0.Invoke(8L, &num15);
			}
			else
			{
				cpp_optional_double_optional_cpp_nullopt_t.Invoke(&cpp_optional_s4iqgj2);
			}
			llvm_lifetime_end_p0.Invoke(8L, &num14);
			llvm_lifetime_end_p0.Invoke(8L, &num13);
			llvm_lifetime_end_p0.Invoke(8L, &num12);
			llvm_lifetime_end_p0.Invoke(8L, &num11);
			llvm_lifetime_end_p0.Invoke(8L, &num9);
			llvm_lifetime_end_p0.Invoke(8L, &num8);
			llvm_lifetime_end_p0.Invoke(8L, &num7);
			llvm_lifetime_end_p0.Invoke(8L, &num5);
			llvm_lifetime_end_p0.Invoke(8L, &num3);
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			return *(Struct_8myw6y*)(&cpp_optional_s4iqgj2.storage);
		}
	}
}
