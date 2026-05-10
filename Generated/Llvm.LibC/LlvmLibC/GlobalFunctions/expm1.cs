using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class expm1
{
	public unsafe static double Invoke(double x)
	{
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		sbyte b = 0;
		long num = 0L;
		double num2 = 0.0;
		int num3 = 0;
		double num4 = 0.0;
		int num5 = 0;
		int num6 = 0;
		int num7 = 0;
		NumberPair numberPair = default(NumberPair);
		NumberPair numberPair2 = default(NumberPair);
		NumberPair numberPair3 = default(NumberPair);
		double num8 = 0.0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		NumberPair numberPair4 = default(NumberPair);
		double z = 0.0;
		double num9 = 0.0;
		double y = 0.0;
		double x2 = 0.0;
		double num10 = 0.0;
		long num11 = 0L;
		double num12 = 0.0;
		long num13 = 0L;
		double num14 = 0.0;
		double num15 = 0.0;
		long num16 = 0L;
		double num17 = 0.0;
		long num18 = 0L;
		NumberPair numberPair5 = default(NumberPair);
		double num19 = 0.0;
		long num20 = 0L;
		double num21 = 0.0;
		double num22 = 0.0;
		long num23 = 0L;
		double num24 = 0.0;
		long num25 = 0L;
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd5 = default(fputil_DyadicFloat_kt2kd4);
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		unchecked
		{
			*(long*)(&fputil_FPBits_wjhbrm2) = -6148914691236517206L;
			fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm2, x);
			llvm_lifetime_start_p0.Invoke(1L, &b);
			b = (fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_neg_const.Invoke(&fputil_FPBits_wjhbrm2) ? ((sbyte)1) : ((sbyte)0));
			llvm_lifetime_start_p0.Invoke(8L, &num);
			num = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval_const.Invoke(&fputil_FPBits_wjhbrm2);
			double result;
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(((ulong)num >= 13853836650999914722uL) ? true : (((ulong)num > 13591863675404156928uL || (ulong)num < 4649454530587146736uL) ? ((ulong)num <= 4368491638549381120uL) : true), expected: false))
			{
				result = anonymous_namespace_set_exceptional_double.Invoke(x);
			}
			else
			{
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
				llvm_lifetime_start_p0.Invoke(16L, &numberPair);
				*(double*)(&numberPair) = double.NaN;
				((double*)(&numberPair))[1] = double.NaN;
				long num26 = (uint)num5;
				numberPair.lo = ((fputil_TripleDouble*)EXP2_MID1.Pointer)[num26].mid;
				long num27 = (uint)num5;
				numberPair.hi = ((fputil_TripleDouble*)EXP2_MID1.Pointer)[num27].hi;
				llvm_lifetime_start_p0.Invoke(16L, &numberPair2);
				*(double*)(&numberPair2) = double.NaN;
				((double*)(&numberPair2))[1] = double.NaN;
				long num28 = (uint)num6;
				numberPair2.lo = ((fputil_TripleDouble*)EXP2_MID2.Pointer)[num28].mid;
				long num29 = (uint)num6;
				numberPair2.hi = ((fputil_TripleDouble*)EXP2_MID2.Pointer)[num29].hi;
				llvm_lifetime_start_p0.Invoke(16L, &numberPair3);
				*(double*)(&numberPair3) = double.NaN;
				((double*)(&numberPair3))[1] = double.NaN;
				Struct_4ydhja struct_4ydhja = NumberPair_double_fputil_quick_mult_27ul_NumberPair_double_const_NumberPair_double_const.Invoke(&numberPair, &numberPair2);
				NumberPair* num30 = &numberPair3;
				Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
				*(double*)num30 = struct_4ydhja2.field_0;
				byte* num31 = (byte*)(&numberPair3) + 8u;
				Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
				*(double*)num31 = struct_4ydhja3.field_1;
				llvm_lifetime_start_p0.Invoke(8L, &num8);
				llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_NEG.Pointer, 1L, isVolatile: false);
				long val = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_create_value_Sign_unsigned_long_unsigned_long.Invoke(biased_exp: checked(1023 - num7), sign: anon_izyfb8.val, mantissa: 0L);
				fputil_FPBits_wjhbrm3.FPRepImpl.FPRepSem.FPStorage.val = val;
				double num32 = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm3);
				llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
				num8 = num32;
				llvm_lifetime_start_p0.Invoke(16L, &numberPair4);
				*(double*)(&numberPair4) = double.NaN;
				((double*)(&numberPair4))[1] = double.NaN;
				if ((b & 1) == 1)
				{
					Struct_4ydhja struct_4ydhja4 = NumberPair_double_fputil_exact_add_true_double_double.Invoke(num8, numberPair3.hi);
					NumberPair* num33 = &numberPair4;
					Struct_4ydhja struct_4ydhja5 = struct_4ydhja4;
					*(double*)num33 = struct_4ydhja5.field_0;
					byte* num34 = (byte*)(&numberPair4) + 8u;
					Struct_4ydhja struct_4ydhja6 = struct_4ydhja4;
					*(double*)num34 = struct_4ydhja6.field_1;
				}
				else
				{
					Struct_4ydhja struct_4ydhja7 = NumberPair_double_fputil_exact_add_true_double_double.Invoke(numberPair3.hi, num8);
					NumberPair* num35 = &numberPair4;
					Struct_4ydhja struct_4ydhja8 = struct_4ydhja7;
					*(double*)num35 = struct_4ydhja8.field_0;
					byte* num36 = (byte*)(&numberPair4) + 8u;
					Struct_4ydhja struct_4ydhja9 = struct_4ydhja7;
					*(double*)num36 = struct_4ydhja9.field_1;
				}
				double lo = numberPair3.lo;
				numberPair4.lo += lo;
				llvm_lifetime_start_p0.Invoke(8L, &z);
				z = fputil_multiply_add_double_double_double.Invoke(num4, -0.00016922538588914904, x);
				llvm_lifetime_start_p0.Invoke(8L, &num9);
				num9 = fputil_multiply_add_double_double_double.Invoke(num4, 1.0256140314162804E-14, z);
				llvm_lifetime_start_p0.Invoke(8L, &y);
				y = num9 * numberPair3.hi;
				llvm_lifetime_start_p0.Invoke(8L, &x2);
				x2 = anonymous_namespace_poly_approx_d_double.Invoke(num9);
				llvm_lifetime_start_p0.Invoke(8L, &num10);
				num10 = fputil_multiply_add_double_double_double.Invoke(x2, y, numberPair4.lo);
				llvm_lifetime_start_p0.Invoke(8L, &num11);
				num11 = (((b & 1) != 1) ? 0L : ((long)checked(-num7) << 52));
				llvm_lifetime_start_p0.Invoke(8L, &num12);
				llvm_lifetime_start_p0.Invoke(8L, &num13);
				num13 = 4325707442089361408L + num11;
				double num37 = cpp_enable_if_sizeof_double_sizeof_unsigned_long_cpp_is_trivially_constructible_double_value_cpp_is_trivially_copyable_double_value_cpp_is_trivially_copyable_unsigned_long_value_double_type_cpp_bit_cast_double_unsigned_long_unsigned_long_const.Invoke(&num13);
				llvm_lifetime_end_p0.Invoke(8L, &num13);
				num12 = num37;
				llvm_lifetime_start_p0.Invoke(8L, &num14);
				num14 = numberPair4.hi + (num10 + num12);
				llvm_lifetime_start_p0.Invoke(8L, &num15);
				num15 = numberPair4.hi + (num10 - num12);
				if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(num14 == num15, expected: true))
				{
					llvm_lifetime_start_p0.Invoke(8L, &num16);
					num16 = (long)num7 << 52;
					llvm_lifetime_start_p0.Invoke(8L, &num17);
					llvm_lifetime_start_p0.Invoke(8L, &num18);
					num18 = checked(num16 + cpp_enable_if_sizeof_long_sizeof_double_cpp_is_trivially_constructible_long_value_cpp_is_trivially_copyable_long_value_cpp_is_trivially_copyable_double_value_long_type_cpp_bit_cast_long_double_double_const.Invoke(&num14));
					double num38 = cpp_enable_if_sizeof_double_sizeof_long_cpp_is_trivially_constructible_double_value_cpp_is_trivially_copyable_double_value_cpp_is_trivially_copyable_long_value_double_type_cpp_bit_cast_double_long_long_const.Invoke(&num18);
					llvm_lifetime_end_p0.Invoke(8L, &num18);
					num17 = num38;
					result = num17;
					llvm_lifetime_end_p0.Invoke(8L, &num17);
					llvm_lifetime_end_p0.Invoke(8L, &num16);
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(16L, &numberPair5);
					*(double*)(&numberPair5) = double.NaN;
					((double*)(&numberPair5))[1] = double.NaN;
					Struct_4ydhja struct_4ydhja10 = anonymous_namespace_exp_double_double_double_double_NumberPair_double_const_NumberPair_double_const.Invoke(x, num4, &numberPair3, &numberPair4);
					NumberPair* num39 = &numberPair5;
					Struct_4ydhja struct_4ydhja11 = struct_4ydhja10;
					*(double*)num39 = struct_4ydhja11.field_0;
					byte* num40 = (byte*)(&numberPair5) + 8u;
					Struct_4ydhja struct_4ydhja12 = struct_4ydhja10;
					*(double*)num40 = struct_4ydhja12.field_1;
					llvm_lifetime_start_p0.Invoke(8L, &num19);
					llvm_lifetime_start_p0.Invoke(8L, &num20);
					num20 = 4161326055690338304L + num11;
					double num41 = cpp_enable_if_sizeof_double_sizeof_unsigned_long_cpp_is_trivially_constructible_double_value_cpp_is_trivially_copyable_double_value_cpp_is_trivially_copyable_unsigned_long_value_double_type_cpp_bit_cast_double_unsigned_long_unsigned_long_const.Invoke(&num20);
					llvm_lifetime_end_p0.Invoke(8L, &num20);
					num19 = num41;
					llvm_lifetime_start_p0.Invoke(8L, &num21);
					num21 = numberPair5.hi + (numberPair5.lo + num19);
					llvm_lifetime_start_p0.Invoke(8L, &num22);
					num22 = numberPair5.hi + (numberPair5.lo - num19);
					if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(num21 == num22, expected: true))
					{
						llvm_lifetime_start_p0.Invoke(8L, &num23);
						num23 = (long)num7 << 52;
						llvm_lifetime_start_p0.Invoke(8L, &num24);
						llvm_lifetime_start_p0.Invoke(8L, &num25);
						num25 = checked(num23 + cpp_enable_if_sizeof_long_sizeof_double_cpp_is_trivially_constructible_long_value_cpp_is_trivially_copyable_long_value_cpp_is_trivially_copyable_double_value_long_type_cpp_bit_cast_long_double_double_const.Invoke(&num21));
						double num42 = cpp_enable_if_sizeof_double_sizeof_long_cpp_is_trivially_constructible_double_value_cpp_is_trivially_copyable_double_value_cpp_is_trivially_copyable_long_value_double_type_cpp_bit_cast_double_long_long_const.Invoke(&num25);
						llvm_lifetime_end_p0.Invoke(8L, &num25);
						num24 = num42;
						result = num24;
						llvm_lifetime_end_p0.Invoke(8L, &num24);
						llvm_lifetime_end_p0.Invoke(8L, &num23);
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
						anonymous_namespace_expm1_f128_double_double_int_int.Invoke(&fputil_DyadicFloat_kt2kd5, x, num4, num5, num6);
						result = fputil_DyadicFloat_128ul_operator_double_double_void_const.Invoke(&fputil_DyadicFloat_kt2kd5);
						llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd5);
					}
					llvm_lifetime_end_p0.Invoke(8L, &num22);
					llvm_lifetime_end_p0.Invoke(8L, &num21);
					llvm_lifetime_end_p0.Invoke(8L, &num19);
					llvm_lifetime_end_p0.Invoke(16L, &numberPair5);
				}
				llvm_lifetime_end_p0.Invoke(8L, &num15);
				llvm_lifetime_end_p0.Invoke(8L, &num14);
				llvm_lifetime_end_p0.Invoke(8L, &num12);
				llvm_lifetime_end_p0.Invoke(8L, &num11);
				llvm_lifetime_end_p0.Invoke(8L, &num10);
				llvm_lifetime_end_p0.Invoke(8L, &x2);
				llvm_lifetime_end_p0.Invoke(8L, &y);
				llvm_lifetime_end_p0.Invoke(8L, &num9);
				llvm_lifetime_end_p0.Invoke(8L, &z);
				llvm_lifetime_end_p0.Invoke(16L, &numberPair4);
				llvm_lifetime_end_p0.Invoke(8L, &num8);
				llvm_lifetime_end_p0.Invoke(16L, &numberPair3);
				llvm_lifetime_end_p0.Invoke(16L, &numberPair2);
				llvm_lifetime_end_p0.Invoke(16L, &numberPair);
				llvm_lifetime_end_p0.Invoke(4L, &num7);
				llvm_lifetime_end_p0.Invoke(4L, &num6);
				llvm_lifetime_end_p0.Invoke(4L, &num5);
				llvm_lifetime_end_p0.Invoke(8L, &num4);
				llvm_lifetime_end_p0.Invoke(4L, &num3);
				llvm_lifetime_end_p0.Invoke(8L, &num2);
			}
			llvm_lifetime_end_p0.Invoke(8L, &num);
			llvm_lifetime_end_p0.Invoke(1L, &b);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			return result;
		}
	}
}
