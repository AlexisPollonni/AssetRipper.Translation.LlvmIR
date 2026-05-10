using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class exp2
{
	public unsafe static double Invoke(double x)
	{
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		long num = 0L;
		int num2 = 0;
		double num3 = 0.0;
		double x2 = 0.0;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		NumberPair numberPair = default(NumberPair);
		NumberPair numberPair2 = default(NumberPair);
		NumberPair numberPair3 = default(NumberPair);
		double num7 = 0.0;
		double y = 0.0;
		double x3 = 0.0;
		double num8 = 0.0;
		double num9 = 0.0;
		double num10 = 0.0;
		long num11 = 0L;
		double num12 = 0.0;
		long num13 = 0L;
		NumberPair numberPair4 = default(NumberPair);
		double num14 = 0.0;
		double num15 = 0.0;
		long num16 = 0L;
		double num17 = 0.0;
		long num18 = 0L;
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd5 = default(fputil_DyadicFloat_kt2kd4);
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		unchecked
		{
			*(long*)(&fputil_FPBits_wjhbrm2) = -6148914691236517206L;
			fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm2, x);
			llvm_lifetime_start_p0.Invoke(8L, &num);
			num = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval_const.Invoke(&fputil_FPBits_wjhbrm2);
			double result;
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(((ulong)num > 13875572859742453760uL) ? true : (((ulong)num > 13589353796997972734uL || (ulong)num < 4652218415073722368uL) ? ((ulong)num <= 4370485359770567421uL) : true), expected: false))
			{
				result = anonymous_namespace_set_exceptional_double_38.Invoke(x);
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(4L, &num2);
				llvm_lifetime_start_p0.Invoke(8L, &num3);
				num3 = x + 3145728.0001220703;
				int num19 = (int)(cpp_enable_if_sizeof_unsigned_long_sizeof_double_cpp_is_trivially_constructible_unsigned_long_value_cpp_is_trivially_copyable_unsigned_long_value_cpp_is_trivially_copyable_double_value_unsigned_long_type_cpp_bit_cast_unsigned_long_double_double_const.Invoke(&num3) >>> 19);
				llvm_lifetime_end_p0.Invoke(8L, &num3);
				num2 = num19;
				llvm_lifetime_start_p0.Invoke(8L, &x2);
				x2 = num2;
				llvm_lifetime_start_p0.Invoke(4L, &num4);
				num4 = (num2 >> 6) & 0x3F;
				llvm_lifetime_start_p0.Invoke(4L, &num5);
				num5 = num2 & 0x3F;
				llvm_lifetime_start_p0.Invoke(4L, &num6);
				num6 = num2 >> 12;
				llvm_lifetime_start_p0.Invoke(16L, &numberPair);
				*(double*)(&numberPair) = double.NaN;
				((double*)(&numberPair))[1] = double.NaN;
				long num20 = (uint)num4;
				numberPair.lo = ((fputil_TripleDouble*)EXP2_MID1.Pointer)[num20].mid;
				long num21 = (uint)num4;
				numberPair.hi = ((fputil_TripleDouble*)EXP2_MID1.Pointer)[num21].hi;
				llvm_lifetime_start_p0.Invoke(16L, &numberPair2);
				*(double*)(&numberPair2) = double.NaN;
				((double*)(&numberPair2))[1] = double.NaN;
				long num22 = (uint)num5;
				numberPair2.lo = ((fputil_TripleDouble*)EXP2_MID2.Pointer)[num22].mid;
				long num23 = (uint)num5;
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
				llvm_lifetime_start_p0.Invoke(8L, &num7);
				num7 = fputil_multiply_add_double_double_double.Invoke(x2, -0.000244140625, x);
				llvm_lifetime_start_p0.Invoke(8L, &y);
				y = num7 * numberPair3.hi;
				llvm_lifetime_start_p0.Invoke(8L, &x3);
				x3 = anonymous_namespace_poly_approx_d_double_39.Invoke(num7);
				llvm_lifetime_start_p0.Invoke(8L, &num8);
				num8 = fputil_multiply_add_double_double_double.Invoke(x3, y, numberPair3.lo);
				llvm_lifetime_start_p0.Invoke(8L, &num9);
				num9 = numberPair3.hi + (num8 + 1.0842021724855044E-19);
				llvm_lifetime_start_p0.Invoke(8L, &num10);
				num10 = numberPair3.hi + (num8 - 1.0842021724855044E-19);
				if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(num9 == num10, expected: true))
				{
					llvm_lifetime_start_p0.Invoke(8L, &num11);
					num11 = (long)num6 << 52;
					llvm_lifetime_start_p0.Invoke(8L, &num12);
					llvm_lifetime_start_p0.Invoke(8L, &num13);
					num13 = checked(num11 + cpp_enable_if_sizeof_long_sizeof_double_cpp_is_trivially_constructible_long_value_cpp_is_trivially_copyable_long_value_cpp_is_trivially_copyable_double_value_long_type_cpp_bit_cast_long_double_double_const.Invoke(&num9));
					double num26 = cpp_enable_if_sizeof_double_sizeof_long_cpp_is_trivially_constructible_double_value_cpp_is_trivially_copyable_double_value_cpp_is_trivially_copyable_long_value_double_type_cpp_bit_cast_double_long_long_const.Invoke(&num13);
					llvm_lifetime_end_p0.Invoke(8L, &num13);
					num12 = num26;
					result = num12;
					llvm_lifetime_end_p0.Invoke(8L, &num12);
					llvm_lifetime_end_p0.Invoke(8L, &num11);
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(16L, &numberPair4);
					*(double*)(&numberPair4) = double.NaN;
					((double*)(&numberPair4))[1] = double.NaN;
					Struct_4ydhja struct_4ydhja4 = anonymous_namespace_exp2_double_double_double_NumberPair_double_const.Invoke(num7, &numberPair3);
					NumberPair* num27 = &numberPair4;
					Struct_4ydhja struct_4ydhja5 = struct_4ydhja4;
					*(double*)num27 = struct_4ydhja5.field_0;
					byte* num28 = (byte*)(&numberPair4) + 8u;
					Struct_4ydhja struct_4ydhja6 = struct_4ydhja4;
					*(double*)num28 = struct_4ydhja6.field_1;
					llvm_lifetime_start_p0.Invoke(8L, &num14);
					num14 = numberPair4.hi + (numberPair4.lo + 7.888609052210118E-31);
					llvm_lifetime_start_p0.Invoke(8L, &num15);
					num15 = numberPair4.hi + (numberPair4.lo - 7.888609052210118E-31);
					if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(num14 == num15, expected: true))
					{
						llvm_lifetime_start_p0.Invoke(8L, &num16);
						num16 = (long)num6 << 52;
						llvm_lifetime_start_p0.Invoke(8L, &num17);
						llvm_lifetime_start_p0.Invoke(8L, &num18);
						num18 = checked(num16 + cpp_enable_if_sizeof_long_sizeof_double_cpp_is_trivially_constructible_long_value_cpp_is_trivially_copyable_long_value_cpp_is_trivially_copyable_double_value_long_type_cpp_bit_cast_long_double_double_const.Invoke(&num14));
						double num29 = cpp_enable_if_sizeof_double_sizeof_long_cpp_is_trivially_constructible_double_value_cpp_is_trivially_copyable_double_value_cpp_is_trivially_copyable_long_value_double_type_cpp_bit_cast_double_long_long_const.Invoke(&num18);
						llvm_lifetime_end_p0.Invoke(8L, &num18);
						num17 = num29;
						result = num17;
						llvm_lifetime_end_p0.Invoke(8L, &num17);
						llvm_lifetime_end_p0.Invoke(8L, &num16);
					}
					else
					{
						llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd5);
						*(sbyte*)(&fputil_DyadicFloat_kt2kd5) = -86;
						sbyte* ptr = (sbyte*)(&fputil_DyadicFloat_kt2kd5) + 1;
						*ptr = -86;
						ptr[1] = -86;
						ptr[2] = -86;
						((int*)(&fputil_DyadicFloat_kt2kd5))[1] = -1431655766;
						sbyte* ptr2 = (sbyte*)(&fputil_DyadicFloat_kt2kd5) + 8;
						*(long*)ptr2 = -6148914691236517206L;
						((long*)ptr2)[1] = -6148914691236517206L;
						anonymous_namespace_exp2_f128_double_int_int_int.Invoke(&fputil_DyadicFloat_kt2kd5, num7, num6, num4, num5);
						result = fputil_DyadicFloat_128ul_operator_double_double_void_const.Invoke(&fputil_DyadicFloat_kt2kd5);
						llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd5);
					}
					llvm_lifetime_end_p0.Invoke(8L, &num15);
					llvm_lifetime_end_p0.Invoke(8L, &num14);
					llvm_lifetime_end_p0.Invoke(16L, &numberPair4);
				}
				llvm_lifetime_end_p0.Invoke(8L, &num10);
				llvm_lifetime_end_p0.Invoke(8L, &num9);
				llvm_lifetime_end_p0.Invoke(8L, &num8);
				llvm_lifetime_end_p0.Invoke(8L, &x3);
				llvm_lifetime_end_p0.Invoke(8L, &y);
				llvm_lifetime_end_p0.Invoke(8L, &num7);
				llvm_lifetime_end_p0.Invoke(16L, &numberPair3);
				llvm_lifetime_end_p0.Invoke(16L, &numberPair2);
				llvm_lifetime_end_p0.Invoke(16L, &numberPair);
				llvm_lifetime_end_p0.Invoke(4L, &num6);
				llvm_lifetime_end_p0.Invoke(4L, &num5);
				llvm_lifetime_end_p0.Invoke(4L, &num4);
				llvm_lifetime_end_p0.Invoke(8L, &x2);
				llvm_lifetime_end_p0.Invoke(4L, &num2);
			}
			llvm_lifetime_end_p0.Invoke(8L, &num);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			return result;
		}
	}
}
