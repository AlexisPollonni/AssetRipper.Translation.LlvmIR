using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_120atan2f_double_doubleEdddiddRKNS_10NumberPairIdEE")]
[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::atan2f_double_double(double, double, double, int, double, double, __llvm_libc_20_1_2_::NumberPair<double> const&)")]
internal static partial class anonymous_namespace_atan2f_double_double_double_double_double_int_double_double_NumberPair_double_const
{
	public unsafe static float Invoke(double num_d, double den_d, double q_d, int idx, double k_d, double final_sign, void* const_term)
	{
		NumberPair numberPair = default(NumberPair);
		double num = 0.0;
		double num2 = 0.0;
		NumberPair numberPair2 = default(NumberPair);
		NumberPair numberPair3 = default(NumberPair);
		NumberPair numberPair4 = default(NumberPair);
		NumberPair numberPair5 = default(NumberPair);
		NumberPair numberPair6 = default(NumberPair);
		long num3 = 0L;
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb11 = default(anon_izyfb7);
		double num4 = k_d;
		llvm_lifetime_start_p0.Invoke(16L, &numberPair);
		unchecked
		{
			*(double*)(&numberPair) = double.NaN;
			((double*)(&numberPair))[1] = double.NaN;
			NumberPair_double_NumberPair.Invoke(&numberPair);
			llvm_lifetime_start_p0.Invoke(8L, &num);
			num = double.NaN;
			llvm_lifetime_start_p0.Invoke(8L, &num2);
			num2 = double.NaN;
			if (idx != 0)
			{
				num4 *= 0.0625;
				num = fputil_multiply_add_double_double_double.Invoke(num4, 0.0 - den_d, num_d);
				num2 = fputil_multiply_add_double_double_double.Invoke(num4, num_d, den_d);
				numberPair.hi = num / num2;
			}
			else
			{
				numberPair.hi = q_d;
				num = num_d;
				num2 = den_d;
			}
			numberPair.lo = fputil_multiply_add_double_double_double.Invoke(numberPair.hi, 0.0 - num2, num) / num2;
			llvm_lifetime_start_p0.Invoke(16L, &numberPair2);
			*(double*)(&numberPair2) = double.NaN;
			((double*)(&numberPair2))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja = NumberPair_double_fputil_quick_mult_27ul_NumberPair_double_const_NumberPair_double_const.Invoke(&numberPair, &numberPair);
			NumberPair* num5 = &numberPair2;
			Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
			*(double*)num5 = struct_4ydhja2.field_0;
			byte* num6 = (byte*)(&numberPair2) + 8u;
			Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
			*(double*)num6 = struct_4ydhja3.field_1;
			llvm_lifetime_start_p0.Invoke(16L, &numberPair3);
			*(double*)(&numberPair3) = double.NaN;
			((double*)(&numberPair3))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja4 = cpp_enable_if_sizeof_NumberPair_double_8ul_NumberPair_double_type_fputil_polyeval_NumberPair_double_NumberPair_double_NumberPair_double_NumberPair_double_NumberPair_double_NumberPair_double_NumberPair_double_NumberPair_double_NumberPair_double_NumberPair_double_const_NumberPair_double_const_NumberPair_double_const_NumberPair_double_const_NumberPair_double_const_NumberPair_double_const_NumberPair_double_const_NumberPair_double_const_NumberPair_double_const_NumberPair_double_const.Invoke(&numberPair2, anonymous_namespace_COEFFS_61.Pointer, (byte*)anonymous_namespace_COEFFS_61.Pointer + sizeof(NumberPair), (byte*)anonymous_namespace_COEFFS_61.Pointer + (nint)2 * sizeof(NumberPair), (byte*)anonymous_namespace_COEFFS_61.Pointer + (nint)3 * sizeof(NumberPair), (byte*)anonymous_namespace_COEFFS_61.Pointer + (nint)4 * sizeof(NumberPair), (byte*)anonymous_namespace_COEFFS_61.Pointer + (nint)5 * sizeof(NumberPair), (byte*)anonymous_namespace_COEFFS_61.Pointer + (nint)6 * sizeof(NumberPair), (byte*)anonymous_namespace_COEFFS_61.Pointer + (nint)7 * sizeof(NumberPair), (byte*)anonymous_namespace_COEFFS_61.Pointer + (nint)8 * sizeof(NumberPair));
			NumberPair* num7 = &numberPair3;
			Struct_4ydhja struct_4ydhja5 = struct_4ydhja4;
			*(double*)num7 = struct_4ydhja5.field_0;
			byte* num8 = (byte*)(&numberPair3) + 8u;
			Struct_4ydhja struct_4ydhja6 = struct_4ydhja4;
			*(double*)num8 = struct_4ydhja6.field_1;
			llvm_lifetime_start_p0.Invoke(16L, &numberPair4);
			*(double*)(&numberPair4) = double.NaN;
			((double*)(&numberPair4))[1] = double.NaN;
			llvm_lifetime_start_p0.Invoke(16L, &numberPair5);
			Struct_4ydhja struct_4ydhja7 = cpp_enable_if_sizeof_NumberPair_double_8ul_NumberPair_double_type_fputil_multiply_add_NumberPair_double_NumberPair_double_const_NumberPair_double_const_NumberPair_double_const.Invoke(&numberPair, &numberPair3, (byte*)anonymous_namespace_ATAN_I.Pointer + (nint)idx * (nint)sizeof(NumberPair));
			NumberPair* num9 = &numberPair5;
			Struct_4ydhja struct_4ydhja8 = struct_4ydhja7;
			*(double*)num9 = struct_4ydhja8.field_0;
			byte* num10 = (byte*)(&numberPair5) + 8u;
			Struct_4ydhja struct_4ydhja9 = struct_4ydhja7;
			*(double*)num10 = struct_4ydhja9.field_1;
			Struct_4ydhja struct_4ydhja10 = fputil_add_NumberPair_double_const_NumberPair_double_const.Invoke(const_term, &numberPair5);
			NumberPair* num11 = &numberPair4;
			Struct_4ydhja struct_4ydhja11 = struct_4ydhja10;
			*(double*)num11 = struct_4ydhja11.field_0;
			byte* num12 = (byte*)(&numberPair4) + 8u;
			Struct_4ydhja struct_4ydhja12 = struct_4ydhja10;
			*(double*)num12 = struct_4ydhja12.field_1;
			llvm_lifetime_end_p0.Invoke(16L, &numberPair5);
			numberPair4.hi *= final_sign;
			numberPair4.lo *= final_sign;
			llvm_lifetime_start_p0.Invoke(16L, &numberPair6);
			*(double*)(&numberPair6) = double.NaN;
			((double*)(&numberPair6))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja13 = NumberPair_double_fputil_exact_add_true_double_double.Invoke(numberPair4.hi, numberPair4.lo);
			NumberPair* num13 = &numberPair6;
			Struct_4ydhja struct_4ydhja14 = struct_4ydhja13;
			*(double*)num13 = struct_4ydhja14.field_0;
			byte* num14 = (byte*)(&numberPair6) + 8u;
			Struct_4ydhja struct_4ydhja15 = struct_4ydhja13;
			*(double*)num14 = struct_4ydhja15.field_1;
			llvm_lifetime_start_p0.Invoke(8L, &num3);
			num3 = cpp_enable_if_sizeof_unsigned_long_sizeof_double_cpp_is_trivially_constructible_unsigned_long_value_cpp_is_trivially_copyable_unsigned_long_value_cpp_is_trivially_copyable_double_value_unsigned_long_type_cpp_bit_cast_unsigned_long_double_double_const.Invoke(&numberPair6.hi);
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((num3 & 0xFFFFFFFL) == 0L && NumericHelper.IsUnorderedOrNotEquals(numberPair6.lo, 0.0), expected: false))
			{
				llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb8);
				*(sbyte*)(&anon_izyfb8) = -86;
				llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
				fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm2, numberPair6.hi);
				anon_izyfb8.val = fputil_internal_FPStorage_fputil_FPType_2_sign_const.Invoke(&fputil_FPBits_wjhbrm2);
				llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
				llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb9);
				*(sbyte*)(&anon_izyfb9) = -86;
				llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
				fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm3, numberPair6.lo);
				anon_izyfb9.val = fputil_internal_FPStorage_fputil_FPType_2_sign_const.Invoke(&fputil_FPBits_wjhbrm3);
				llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb10, &anon_izyfb8, 1L, isVolatile: false);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb11, &anon_izyfb9, 1L, isVolatile: false);
				if (operator_Sign_Sign_fy8fvt.Invoke(anon_izyfb10.val, anon_izyfb11.val))
				{
					num3++;
				}
				else if ((ulong)(num3 & 0xFFFFFFFFFFFFFL) > 0uL)
				{
					num3 += -1L;
				}
				llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb9);
				llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb8);
			}
			float result = (float)cpp_enable_if_sizeof_double_sizeof_unsigned_long_cpp_is_trivially_constructible_double_value_cpp_is_trivially_copyable_double_value_cpp_is_trivially_copyable_unsigned_long_value_double_type_cpp_bit_cast_double_unsigned_long_unsigned_long_const.Invoke(&num3);
			llvm_lifetime_end_p0.Invoke(8L, &num3);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair6);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair4);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair3);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair2);
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			llvm_lifetime_end_p0.Invoke(8L, &num);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair);
			return result;
		}
	}
}
