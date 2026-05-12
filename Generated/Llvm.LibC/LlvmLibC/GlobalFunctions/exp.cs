using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class exp
{
	public unsafe static double Invoke(double x)
	{
		double result = 0.0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		long num = 0L;
		double num2 = 0.0;
		int num3 = 0;
		double num4 = 0.0;
		int num5 = 0;
		int num6 = 0;
		int num7 = 0;
		sbyte b = 0;
		NumberPair numberPair = default(NumberPair);
		NumberPair numberPair2 = default(NumberPair);
		NumberPair numberPair3 = default(NumberPair);
		double z = 0.0;
		double num8 = 0.0;
		double y = 0.0;
		double x2 = 0.0;
		double num9 = 0.0;
		cpp_optional_s4iqgj cpp_optional_s4iqgj2 = default(cpp_optional_s4iqgj);
		double num10 = 0.0;
		double num11 = 0.0;
		long num12 = 0L;
		double num13 = 0.0;
		long num14 = 0L;
		NumberPair numberPair4 = default(NumberPair);
		cpp_optional_s4iqgj cpp_optional_s4iqgj3 = default(cpp_optional_s4iqgj);
		double num15 = 0.0;
		double num16 = 0.0;
		long num17 = 0L;
		double num18 = 0.0;
		long num19 = 0L;
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd5 = default(fputil_DyadicFloat_kt2kd4);
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		unchecked
		{
			*(long*)(&fputil_FPBits_wjhbrm2) = -6148914691236517206L;
			fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm2, x);
			llvm_lifetime_start_p0.Invoke(8L, &num);
			num = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2));
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(((ulong)num >= 13873137513782915154uL) ? true : (((ulong)num >= 13591863675404156928uL || (ulong)num < 4649454530587146736uL) ? ((ulong)num < 4368491638549381120uL) : true), expected: false))
			{
				result = anonymous_namespace_set_exceptional_double_50.Invoke(x);
				goto IL_0aa7;
			}
			llvm_lifetime_start_p0.Invoke(8L, &num2);
			num2 = fputil_multiply_add_double_double_double.Invoke(x, 1.4426950408889634, 3145728.0001220703);
			llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = (int)(cpp_enable_if_sizeof_unsigned_long_sizeof_double_cpp_is_trivially_constructible_unsigned_long_value_cpp_is_trivially_copyable_unsigned_long_value_cpp_is_trivially_copyable_double_value_unsigned_long_type_cpp_bit_cast_unsigned_long_double_double_const.Invoke(&num2) >>> 19);
			llvm_lifetime_start_p0.Invoke(8L, &num4);
			num4 = num3;
			llvm_lifetime_start_p0.Invoke(4L, &num5);
			num5 = (num3 >> 6) & 0x3F;
			llvm_lifetime_start_p0.Invoke(4L, &num6);
			num6 = num3 & 0x3F;
			llvm_lifetime_start_p0.Invoke(4L, &num7);
			num7 = num3 >> 12;
			llvm_lifetime_start_p0.Invoke(1L, &b);
			b = ((num7 <= -1022) ? ((sbyte)1) : ((sbyte)0));
			llvm_lifetime_start_p0.Invoke(16L, &numberPair);
			*(double*)(&numberPair) = double.NaN;
			((double*)(&numberPair))[1] = double.NaN;
			long num20 = (uint)num5;
			numberPair.lo = ((fputil_TripleDouble*)EXP2_MID1.Pointer)[num20].mid;
			long num21 = (uint)num5;
			numberPair.hi = ((fputil_TripleDouble*)EXP2_MID1.Pointer)[num21].hi;
			llvm_lifetime_start_p0.Invoke(16L, &numberPair2);
			*(double*)(&numberPair2) = double.NaN;
			((double*)(&numberPair2))[1] = double.NaN;
			long num22 = (uint)num6;
			numberPair2.lo = ((fputil_TripleDouble*)EXP2_MID2.Pointer)[num22].mid;
			long num23 = (uint)num6;
			numberPair2.hi = ((fputil_TripleDouble*)EXP2_MID2.Pointer)[num23].hi;
			llvm_lifetime_start_p0.Invoke(16L, &numberPair3);
			*(double*)(&numberPair3) = double.NaN;
			((double*)(&numberPair3))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja = NumberPair_double_fputil_quick_mult_27ul_NumberPair_double_const_NumberPair_double_const.Invoke(&numberPair, &numberPair2);
			NumberPair* num24 = &numberPair3;
			Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
			*(double*)num24 = struct_4ydhja2.field_0;
			byte* num25 = (byte*)(&numberPair3) + 8u;
			Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
			*(double*)num25 = struct_4ydhja3.field_1;
			llvm_lifetime_start_p0.Invoke(8L, &z);
			z = fputil_multiply_add_double_double_double.Invoke(num4, -0.00016922538588914904, x);
			llvm_lifetime_start_p0.Invoke(8L, &num8);
			num8 = fputil_multiply_add_double_double_double.Invoke(num4, 1.0256140314162804E-14, z);
			llvm_lifetime_start_p0.Invoke(8L, &y);
			y = num8 * numberPair3.hi;
			llvm_lifetime_start_p0.Invoke(8L, &x2);
			x2 = anonymous_namespace_poly_approx_d_double_51.Invoke(num8);
			llvm_lifetime_start_p0.Invoke(8L, &num9);
			num9 = fputil_multiply_add_double_double_double.Invoke(x2, y, numberPair3.lo);
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((b & 1) == 1, expected: false))
			{
				llvm_lifetime_start_p0.Invoke(16L, &cpp_optional_s4iqgj2);
				sbyte* ptr = (sbyte*)(&cpp_optional_s4iqgj2);
				*(double*)ptr = double.NaN;
				ptr[8] = -86;
				sbyte* ptr2 = ptr + 9;
				*ptr2 = -86;
				ptr2[1] = -86;
				ptr2[2] = -86;
				ptr2[3] = -86;
				ptr2[4] = -86;
				ptr2[5] = -86;
				ptr2[6] = -86;
				Struct_8myw6y struct_8myw6y = ziv_test_denorm_int_double_double_double.Invoke(num7, numberPair3.hi, num9, 1.6263032587282567E-19);
				cpp_optional_double_OptionalStorage* ptr3 = &cpp_optional_s4iqgj2.storage;
				Struct_8myw6y struct_8myw6y2 = struct_8myw6y;
				((Struct_8myw6y*)ptr3)->field_0 = struct_8myw6y2.field_0;
				Struct_8myw6y struct_8myw6y3 = struct_8myw6y;
				((Struct_8myw6y*)ptr3)->field_1 = struct_8myw6y3.field_1;
				int num26;
				if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(cpp_optional_double_has_value_const.Invoke(&cpp_optional_s4iqgj2), expected: true))
				{
					result = *(double*)cpp_optional_double_value.Invoke(&cpp_optional_s4iqgj2);
					num26 = 1;
				}
				else
				{
					num26 = 0;
				}
				llvm_lifetime_end_p0.Invoke(16L, &cpp_optional_s4iqgj2);
				switch (num26)
				{
				case 0:
					break;
				default:
					goto IL_09b5;
				}
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(8L, &num10);
				num10 = numberPair3.hi + (num9 + 1.6263032587282567E-19);
				llvm_lifetime_start_p0.Invoke(8L, &num11);
				num11 = numberPair3.hi + (num9 - 1.6263032587282567E-19);
				int num26;
				if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(num10 == num11, expected: true))
				{
					llvm_lifetime_start_p0.Invoke(8L, &num12);
					num12 = (long)num7 << 52;
					llvm_lifetime_start_p0.Invoke(8L, &num13);
					llvm_lifetime_start_p0.Invoke(8L, &num14);
					num14 = checked(num12 + cpp_enable_if_sizeof_long_sizeof_double_cpp_is_trivially_constructible_long_value_cpp_is_trivially_copyable_long_value_cpp_is_trivially_copyable_double_value_long_type_cpp_bit_cast_long_double_double_const.Invoke(&num10));
					double num27 = cpp_enable_if_sizeof_double_sizeof_long_cpp_is_trivially_constructible_double_value_cpp_is_trivially_copyable_double_value_cpp_is_trivially_copyable_long_value_double_type_cpp_bit_cast_double_long_long_const.Invoke(&num14);
					llvm_lifetime_end_p0.Invoke(8L, &num14);
					num13 = num27;
					result = num13;
					num26 = 1;
					llvm_lifetime_end_p0.Invoke(8L, &num13);
					llvm_lifetime_end_p0.Invoke(8L, &num12);
				}
				else
				{
					num26 = 0;
				}
				llvm_lifetime_end_p0.Invoke(8L, &num11);
				llvm_lifetime_end_p0.Invoke(8L, &num10);
				switch (num26)
				{
				case 0:
					break;
				default:
					goto IL_09b5;
				}
			}
			llvm_lifetime_start_p0.Invoke(16L, &numberPair4);
			*(double*)(&numberPair4) = double.NaN;
			((double*)(&numberPair4))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja4 = anonymous_namespace_exp_double_double_double_double_NumberPair_double_const.Invoke(x, num4, &numberPair3);
			NumberPair* num28 = &numberPair4;
			Struct_4ydhja struct_4ydhja5 = struct_4ydhja4;
			*(double*)num28 = struct_4ydhja5.field_0;
			byte* num29 = (byte*)(&numberPair4) + 8u;
			Struct_4ydhja struct_4ydhja6 = struct_4ydhja4;
			*(double*)num29 = struct_4ydhja6.field_1;
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((b & 1) == 1, expected: false))
			{
				llvm_lifetime_start_p0.Invoke(16L, &cpp_optional_s4iqgj3);
				sbyte* ptr4 = (sbyte*)(&cpp_optional_s4iqgj3);
				*(double*)ptr4 = double.NaN;
				ptr4[8] = -86;
				sbyte* ptr5 = ptr4 + 9;
				*ptr5 = -86;
				ptr5[1] = -86;
				ptr5[2] = -86;
				ptr5[3] = -86;
				ptr5[4] = -86;
				ptr5[5] = -86;
				ptr5[6] = -86;
				Struct_8myw6y struct_8myw6y4 = ziv_test_denorm_int_double_double_double.Invoke(num7, numberPair4.hi, numberPair4.lo, 1.5777218104420236E-30);
				cpp_optional_double_OptionalStorage* ptr6 = &cpp_optional_s4iqgj3.storage;
				Struct_8myw6y struct_8myw6y5 = struct_8myw6y4;
				((Struct_8myw6y*)ptr6)->field_0 = struct_8myw6y5.field_0;
				Struct_8myw6y struct_8myw6y6 = struct_8myw6y4;
				((Struct_8myw6y*)ptr6)->field_1 = struct_8myw6y6.field_1;
				int num26;
				if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(cpp_optional_double_has_value_const.Invoke(&cpp_optional_s4iqgj3), expected: true))
				{
					result = *(double*)cpp_optional_double_value.Invoke(&cpp_optional_s4iqgj3);
					num26 = 1;
				}
				else
				{
					num26 = 0;
				}
				llvm_lifetime_end_p0.Invoke(16L, &cpp_optional_s4iqgj3);
				switch (num26)
				{
				case 0:
					break;
				default:
					goto IL_09a3;
				}
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(8L, &num15);
				num15 = numberPair4.hi + (numberPair4.lo + 1.5777218104420236E-30);
				llvm_lifetime_start_p0.Invoke(8L, &num16);
				num16 = numberPair4.hi + (numberPair4.lo - 1.5777218104420236E-30);
				int num26;
				if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(num15 == num16, expected: true))
				{
					llvm_lifetime_start_p0.Invoke(8L, &num17);
					num17 = (long)num7 << 52;
					llvm_lifetime_start_p0.Invoke(8L, &num18);
					llvm_lifetime_start_p0.Invoke(8L, &num19);
					num19 = checked(num17 + cpp_enable_if_sizeof_long_sizeof_double_cpp_is_trivially_constructible_long_value_cpp_is_trivially_copyable_long_value_cpp_is_trivially_copyable_double_value_long_type_cpp_bit_cast_long_double_double_const.Invoke(&num15));
					double num30 = cpp_enable_if_sizeof_double_sizeof_long_cpp_is_trivially_constructible_double_value_cpp_is_trivially_copyable_double_value_cpp_is_trivially_copyable_long_value_double_type_cpp_bit_cast_double_long_long_const.Invoke(&num19);
					llvm_lifetime_end_p0.Invoke(8L, &num19);
					num18 = num30;
					result = num18;
					num26 = 1;
					llvm_lifetime_end_p0.Invoke(8L, &num18);
					llvm_lifetime_end_p0.Invoke(8L, &num17);
				}
				else
				{
					num26 = 0;
				}
				llvm_lifetime_end_p0.Invoke(8L, &num16);
				llvm_lifetime_end_p0.Invoke(8L, &num15);
				switch (num26)
				{
				case 0:
					break;
				default:
					goto IL_09a3;
				}
			}
			llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd5);
			*(sbyte*)(&fputil_DyadicFloat_kt2kd5) = -86;
			sbyte* ptr7 = (sbyte*)(&fputil_DyadicFloat_kt2kd5) + 1;
			*ptr7 = -86;
			ptr7[1] = -86;
			ptr7[2] = -86;
			((int*)(&fputil_DyadicFloat_kt2kd5))[1] = -1431655766;
			sbyte* ptr8 = (sbyte*)(&fputil_DyadicFloat_kt2kd5) + 8;
			*(long*)ptr8 = -6148914691236517206L;
			((long*)ptr8)[1] = -6148914691236517206L;
			anonymous_namespace_exp_f128_double_double_int_int.Invoke(&fputil_DyadicFloat_kt2kd5, x, num4, num5, num6);
			result = fputil_DyadicFloat_128ul_operator_double_double_void_const.Invoke(&fputil_DyadicFloat_kt2kd5);
			llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd5);
			goto IL_09a3;
		}
		IL_0aa7:
		llvm_lifetime_end_p0.Invoke(8L, &num);
		llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		return result;
		IL_09b5:
		llvm_lifetime_end_p0.Invoke(8L, &num9);
		llvm_lifetime_end_p0.Invoke(8L, &x2);
		llvm_lifetime_end_p0.Invoke(8L, &y);
		llvm_lifetime_end_p0.Invoke(8L, &num8);
		llvm_lifetime_end_p0.Invoke(8L, &z);
		llvm_lifetime_end_p0.Invoke(16L, &numberPair3);
		llvm_lifetime_end_p0.Invoke(16L, &numberPair2);
		llvm_lifetime_end_p0.Invoke(16L, &numberPair);
		llvm_lifetime_end_p0.Invoke(1L, &b);
		llvm_lifetime_end_p0.Invoke(4L, &num7);
		llvm_lifetime_end_p0.Invoke(4L, &num6);
		llvm_lifetime_end_p0.Invoke(4L, &num5);
		llvm_lifetime_end_p0.Invoke(8L, &num4);
		llvm_lifetime_end_p0.Invoke(4L, &num3);
		llvm_lifetime_end_p0.Invoke(8L, &num2);
		goto IL_0aa7;
		IL_09a3:
		llvm_lifetime_end_p0.Invoke(16L, &numberPair4);
		goto IL_09b5;
	}
}
