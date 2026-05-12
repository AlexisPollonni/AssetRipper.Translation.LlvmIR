using System.Runtime.CompilerServices;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class powf
{
	public unsafe static float Invoke(float x, float y)
	{
		float result = 0f;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(fputil_FPBits_5nkvcs);
		int num = 0;
		int num2 = 0;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs4 = default(fputil_FPBits_5nkvcs);
		int num3 = 0;
		int num4 = 0;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs5 = default(fputil_FPBits_5nkvcs);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs6 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs7 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs8 = default(fputil_FPBits_5nkvcs);
		int num5 = 0;
		int num6 = 0;
		int num7 = 0;
		int num8 = 0;
		double num9 = 0.0;
		double num10 = 0.0;
		int i = 0;
		int num11 = 0;
		int num12 = 0;
		long num13 = 0L;
		sbyte b = 0;
		sbyte b2 = 0;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs9 = default(fputil_FPBits_5nkvcs);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs10 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		sbyte b3 = 0;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs11 = default(fputil_FPBits_5nkvcs);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs12 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb11 = default(anon_izyfb7);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs13 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb12 = default(anon_izyfb7);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs14 = default(fputil_FPBits_5nkvcs);
		double num14 = 0.0;
		int num15 = 0;
		int num16 = 0;
		float num17 = 0f;
		int num18 = 0;
		double num19 = 0.0;
		InlineArray6_Double inlineArray6_Double = default(InlineArray6_Double);
		double x2 = 0.0;
		double a = 0.0;
		double a_yc74sk = 0.0;
		double a_ijazrn = 0.0;
		double num20 = 0.0;
		double num21 = 0.0;
		double num22 = 0.0;
		double num23 = 0.0;
		double num24 = 0.0;
		double num25 = 0.0;
		long num26 = 0L;
		int num27 = 0;
		long num28 = 0L;
		long num29 = 0L;
		long num30 = 0L;
		double num31 = 0.0;
		InlineArray6_Double inlineArray6_Double2 = default(InlineArray6_Double);
		double x3 = 0.0;
		double a2 = 0.0;
		double a_yc74sk2 = 0.0;
		double a_ijazrn2 = 0.0;
		double num32 = 0.0;
		double num33 = 0.0;
		long num34 = 0L;
		float num35 = 0f;
		long num36 = 0L;
		float num37 = 0f;
		long num38 = 0L;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs15 = default(fputil_FPBits_5nkvcs);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs16 = default(fputil_FPBits_5nkvcs);
		NumberPair numberPair = default(NumberPair);
		long num39 = 0L;
		double num40 = 0.0;
		float num41 = x;
		float num42 = y;
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		int num46;
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs2) = -1431655766;
			fputil_FPBits_float_FPBits_float_float.Invoke(&fputil_FPBits_5nkvcs2, num41);
			llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
			*(int*)(&fputil_FPBits_5nkvcs3) = -1431655766;
			fputil_FPBits_float_FPBits_float_float.Invoke(&fputil_FPBits_5nkvcs3, num42);
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2));
			llvm_lifetime_start_p0.Invoke(4L, &num2);
			llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
			int field_ = fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_abs_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2));
			fputil_FPBits_5nkvcs4.FPRepImpl.FPRepSem.field_0.field_0 = field_;
			int num43 = fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs4));
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
			num2 = num43;
			llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs3));
			llvm_lifetime_start_p0.Invoke(4L, &num4);
			llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs5);
			int field_2 = fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_abs_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs3));
			fputil_FPBits_5nkvcs5.FPRepImpl.FPRepSem.field_0.field_0 = field_2;
			int num44 = fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs5));
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs5);
			num4 = num44;
			if (!bool_details_expects_bool_condition_bool_bool_bool.Invoke((num4 & 0x7FFFF) == 0, expected: false) && (uint)num4 <= 1326907392u)
			{
				goto IL_084b;
			}
			if (num42 == 0f)
			{
				result = 1f;
			}
			else if (num4 == 2139095040)
			{
				if ((uint)num2 > 2139095040u)
				{
					result = num41;
				}
				else if (num2 == 1065353216)
				{
					result = 1f;
				}
				else if (num41 == 0f && num3 == -8388608)
				{
					fputil_set_errno_if_required_int.Invoke(33);
					fputil_raise_except_if_required_int.Invoke(4);
					llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs6);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
					int field_3 = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_inf_Sign.Invoke(anon_izyfb8.val);
					fputil_FPBits_5nkvcs6.FPRepImpl.FPRepSem.field_0.field_0 = field_3;
					result = fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs6);
					llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs6);
				}
				else
				{
					bool condition = (uint)num2 < 1065353216u == (num3 == -8388608);
					llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs7);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, Sign_POS.Pointer, 1L, isVolatile: false);
					int field_4 = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_inf_Sign.Invoke(anon_izyfb9.val);
					fputil_FPBits_5nkvcs7.FPRepImpl.FPRepSem.field_0.field_0 = field_4;
					result = InstructionHelper.Select(condition, fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs7), 0f);
					llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs7);
				}
			}
			else
			{
				int num45 = num3;
				if (num45 != 1056964608)
				{
					if (num45 != 1065353216)
					{
						if (num45 != 1073741824)
						{
							if (anonymous_namespace_is_integer_float.Invoke(num42) && (uint)num3 > 1073741824u && (uint)num3 <= 1103101952u)
							{
								llvm_lifetime_start_p0.Invoke(4L, &num5);
								num5 = ((num2 != 0) ? cpp_enable_if_cpp_is_unsigned_v_unsigned_int_int_type_cpp_countl_zero_unsigned_int_unsigned_int.Invoke(num2) : 30);
								num5 = ((num5 <= 8) ? 8 : num5);
								llvm_lifetime_start_p0.Invoke(4L, &num6);
								num6 = ((num2 != 0) ? cpp_enable_if_cpp_is_unsigned_v_unsigned_int_int_type_cpp_countr_zero_unsigned_int_unsigned_int.Invoke(num2) : 0);
								num6 = ((num6 <= 23) ? num6 : 23);
								llvm_lifetime_start_p0.Invoke(4L, &num7);
								num7 = checked(30 - num6 - num5);
								llvm_lifetime_start_p0.Invoke(4L, &num8);
								num8 = (int)num42;
								checked
								{
									if (num7 * num8 <= 25)
									{
										llvm_lifetime_start_p0.Invoke(8L, &num9);
										num9 = num41;
										llvm_lifetime_start_p0.Invoke(8L, &num10);
										num10 = num9;
										llvm_lifetime_start_p0.Invoke(4L, &i);
										for (i = 1; i < num8; i++)
										{
											num10 *= num9;
										}
										llvm_lifetime_end_p0.Invoke(4L, &i);
										result = (float)num10;
										num46 = 1;
										llvm_lifetime_end_p0.Invoke(8L, &num10);
										llvm_lifetime_end_p0.Invoke(8L, &num9);
									}
									else
									{
										num46 = 0;
									}
									llvm_lifetime_end_p0.Invoke(4L, &num8);
									llvm_lifetime_end_p0.Invoke(4L, &num7);
									llvm_lifetime_end_p0.Invoke(4L, &num6);
									llvm_lifetime_end_p0.Invoke(4L, &num5);
									switch (num46)
									{
									case 0:
										break;
									default:
										goto IL_172d;
									}
								}
							}
							if ((uint)num4 > 1326907392u)
							{
								if ((uint)num4 > 2139095040u)
								{
									result = ((num != 1065353216) ? num42 : 1f);
									goto IL_172d;
								}
								llvm_lifetime_start_p0.Invoke(4L, &num11);
								num11 = (num3 & int.MinValue) + 1333788672;
								num42 = cpp_enable_if_sizeof_float_sizeof_unsigned_int_cpp_is_trivially_constructible_float_value_cpp_is_trivially_copyable_float_value_cpp_is_trivially_copyable_unsigned_int_value_float_type_cpp_bit_cast_float_unsigned_int_unsigned_int_const.Invoke(&num11);
								llvm_lifetime_end_p0.Invoke(4L, &num11);
							}
							goto IL_084b;
						}
						result = num41 * num41;
					}
					else
					{
						result = num41;
					}
				}
				else if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((num41 != 0f) ? (num == -8388608) : true, expected: false))
				{
					result = num41 * num41;
				}
				else
				{
					float num47 = cpp_enable_if_cpp_is_floating_point_v_float_cpp_is_floating_point_v_float_sizeof_float_sizeof_float_float_type_fputil_sqrt_float_float_float.Invoke(num41);
					llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs8);
					fputil_FPBits_float_FPBits_float_float.Invoke(&fputil_FPBits_5nkvcs8, num47);
					result = ((fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs8)) == int.MinValue) ? 0f : num47);
					llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs8);
				}
			}
			goto IL_172d;
		}
		IL_170b:
		llvm_lifetime_end_p0.Invoke(8L, &num13);
		llvm_lifetime_end_p0.Invoke(4L, &num12);
		goto IL_172d;
		IL_0ca4:
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs14);
		fputil_FPBits_float_FPBits_float_float.Invoke(&fputil_FPBits_5nkvcs14, num41);
		unchecked
		{
			num = fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs14));
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs14);
			num12 += num >>> 23;
			llvm_lifetime_start_p0.Invoke(8L, &num14);
			num14 = num12;
			llvm_lifetime_start_p0.Invoke(4L, &num15);
			num15 = num & 0x7FFFFF;
			llvm_lifetime_start_p0.Invoke(4L, &num16);
			num16 = num15 >>> 16;
			llvm_lifetime_start_p0.Invoke(4L, &num17);
			llvm_lifetime_start_p0.Invoke(4L, &num18);
			num18 = num15 | 0x3F800000;
			float num48 = cpp_enable_if_sizeof_float_sizeof_unsigned_int_cpp_is_trivially_constructible_float_value_cpp_is_trivially_copyable_float_value_cpp_is_trivially_copyable_unsigned_int_value_float_type_cpp_bit_cast_float_unsigned_int_unsigned_int_const.Invoke(&num18);
			llvm_lifetime_end_p0.Invoke(4L, &num18);
			num17 = num48;
			llvm_lifetime_start_p0.Invoke(8L, &num19);
			num19 = double.NaN;
			float x4 = num17;
			long num49 = num16;
			num19 = fputil_multiply_add_float_float_float.Invoke(x4, ((float*)R.Pointer)[num49], -1f);
			llvm_lifetime_start_p0.Invoke(48L, &inlineArray6_Double);
			llvm_memset_p0_i64.Invoke(&inlineArray6_Double, 0, 48L, isVolatile: false);
			*(double*)(&inlineArray6_Double) = 1.4426950408889634;
			Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, sizeof(double))) = -0.7213475204442269;
			Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)2 * (nint)sizeof(double))) = 0.4808983470049624;
			Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)3 * (nint)sizeof(double))) = -0.3606738114118398;
			Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)4 * (nint)sizeof(double))) = 0.288538666318245;
			Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)5 * (nint)sizeof(double))) = -0.23813265214085774;
			llvm_lifetime_start_p0.Invoke(8L, &x2);
			x2 = num19 * num19;
			llvm_lifetime_start_p0.Invoke(8L, &a);
			a = fputil_multiply_add_double_double_double.Invoke(num19, Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, sizeof(double))), *(double*)(&inlineArray6_Double));
			llvm_lifetime_start_p0.Invoke(8L, &a_yc74sk);
			a_yc74sk = fputil_multiply_add_double_double_double.Invoke(num19, Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)3 * sizeof(double))), Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)2 * sizeof(double))));
			llvm_lifetime_start_p0.Invoke(8L, &a_ijazrn);
			a_ijazrn = fputil_multiply_add_double_double_double.Invoke(num19, Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)5 * sizeof(double))), Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)4 * sizeof(double))));
			llvm_lifetime_start_p0.Invoke(8L, &num20);
			num20 = cpp_enable_if_sizeof_double_8ul_double_type_fputil_polyeval_double_double_double_double_double_double_double.Invoke(x2, a, a_yc74sk, a_ijazrn);
			llvm_lifetime_start_p0.Invoke(8L, &num21);
			double x5 = num19;
			double y2 = num20;
			long num50 = num16;
			num21 = fputil_multiply_add_double_double_double.Invoke(x5, y2, ((double*)LOG2_R.Pointer)[num50] + num14);
			llvm_lifetime_start_p0.Invoke(8L, &num22);
			num22 = num42 * 64f;
			llvm_lifetime_start_p0.Invoke(8L, &num23);
			num23 = fputil_nearest_integer_double.Invoke(num21 * num22);
			llvm_lifetime_start_p0.Invoke(8L, &num24);
			double x6 = num22;
			double num51 = num14;
			long num52 = num16;
			num24 = fputil_multiply_add_double_double_double.Invoke(x6, num51 + ((fputil_TripleDouble*)anonymous_namespace_LOG2_R_TD.Pointer)[num52].hi, 0.0 - num23);
			llvm_lifetime_start_p0.Invoke(8L, &num25);
			double x7 = num22;
			double x8 = num19;
			double y3 = num20;
			long num53 = num16;
			num25 = fputil_multiply_add_double_double_double.Invoke(x7, fputil_multiply_add_double_double_double.Invoke(x8, y3, ((fputil_TripleDouble*)anonymous_namespace_LOG2_R_TD.Pointer)[num53].mid), num24);
			llvm_lifetime_start_p0.Invoke(8L, &num26);
			num26 = (long)num23;
			num26 = ((num26 <= 32768L) ? ((num26 >= -32768L) ? num26 : (-32768L)) : 32768L);
			llvm_lifetime_start_p0.Invoke(4L, &num27);
			num27 = (int)(num26 & 0x3FL);
			llvm_lifetime_start_p0.Invoke(8L, &num28);
			num28 = num26 >> 6 << 52;
			llvm_lifetime_start_p0.Invoke(8L, &num29);
			long num54 = num27;
			num29 = cpp_enable_if_sizeof_unsigned_long_sizeof_double_cpp_is_trivially_constructible_unsigned_long_value_cpp_is_trivially_copyable_unsigned_long_value_cpp_is_trivially_copyable_double_value_unsigned_long_type_cpp_bit_cast_unsigned_long_double_double_const.Invoke(&((fputil_TripleDouble*)EXP2_MID1.Pointer)[num54].hi);
			llvm_lifetime_start_p0.Invoke(8L, &num30);
			num30 = checked(num28 + num29) + num13;
			llvm_lifetime_start_p0.Invoke(8L, &num31);
			num31 = cpp_enable_if_sizeof_double_sizeof_unsigned_long_cpp_is_trivially_constructible_double_value_cpp_is_trivially_copyable_double_value_cpp_is_trivially_copyable_unsigned_long_value_double_type_cpp_bit_cast_double_unsigned_long_unsigned_long_const.Invoke(&num30);
			llvm_lifetime_start_p0.Invoke(48L, &inlineArray6_Double2);
			llvm_memset_p0_i64.Invoke(&inlineArray6_Double2, 0, 48L, isVolatile: false);
			*(double*)(&inlineArray6_Double2) = 1.0;
			Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double2, sizeof(double))) = 0.010830424696249145;
			Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double2, (nint)2 * (nint)sizeof(double))) = 5.864904955050041E-05;
			Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double2, (nint)3 * (nint)sizeof(double))) = 2.1173137155942948E-07;
			Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double2, (nint)4 * (nint)sizeof(double))) = 5.732859533818817E-10;
			Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double2, (nint)5 * (nint)sizeof(double))) = 1.241771242191526E-12;
			llvm_lifetime_start_p0.Invoke(8L, &x3);
			x3 = num25 * num25;
			llvm_lifetime_start_p0.Invoke(8L, &a2);
			a2 = fputil_multiply_add_double_double_double.Invoke(num25, Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double2, sizeof(double))), *(double*)(&inlineArray6_Double2));
			llvm_lifetime_start_p0.Invoke(8L, &a_yc74sk2);
			a_yc74sk2 = fputil_multiply_add_double_double_double.Invoke(num25, Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double2, (nint)3 * sizeof(double))), Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double2, (nint)2 * sizeof(double))));
			llvm_lifetime_start_p0.Invoke(8L, &a_ijazrn2);
			a_ijazrn2 = fputil_multiply_add_double_double_double.Invoke(num25, Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double2, (nint)5 * sizeof(double))), Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double2, (nint)4 * sizeof(double))));
			llvm_lifetime_start_p0.Invoke(8L, &num32);
			num32 = cpp_enable_if_sizeof_double_8ul_double_type_fputil_polyeval_double_double_double_double_double_double_double.Invoke(x3, a2, a_yc74sk2, a_ijazrn2);
			llvm_lifetime_start_p0.Invoke(8L, &num33);
			num33 = num32 * num31;
			llvm_lifetime_start_p0.Invoke(8L, &num34);
			num34 = cpp_enable_if_sizeof_unsigned_long_sizeof_double_cpp_is_trivially_constructible_unsigned_long_value_cpp_is_trivially_copyable_unsigned_long_value_cpp_is_trivially_copyable_double_value_unsigned_long_type_cpp_bit_cast_unsigned_long_double_double_const.Invoke(&num33);
			llvm_lifetime_start_p0.Invoke(4L, &num35);
			llvm_lifetime_start_p0.Invoke(8L, &num36);
			num36 = num34 + 64L;
			float num55 = (float)cpp_enable_if_sizeof_double_sizeof_unsigned_long_cpp_is_trivially_constructible_double_value_cpp_is_trivially_copyable_double_value_cpp_is_trivially_copyable_unsigned_long_value_double_type_cpp_bit_cast_double_unsigned_long_unsigned_long_const.Invoke(&num36);
			llvm_lifetime_end_p0.Invoke(8L, &num36);
			num35 = num55;
			llvm_lifetime_start_p0.Invoke(4L, &num37);
			llvm_lifetime_start_p0.Invoke(8L, &num38);
			num38 = num34 - 64L;
			float num56 = (float)cpp_enable_if_sizeof_double_sizeof_unsigned_long_cpp_is_trivially_constructible_double_value_cpp_is_trivially_copyable_double_value_cpp_is_trivially_copyable_unsigned_long_value_double_type_cpp_bit_cast_double_unsigned_long_unsigned_long_const.Invoke(&num38);
			llvm_lifetime_end_p0.Invoke(8L, &num38);
			num37 = num56;
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(num35 == num37, expected: true))
			{
				llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs15);
				fputil_FPBits_float_FPBits_float_float.Invoke(&fputil_FPBits_5nkvcs15, num35);
				bool num57 = bool_details_expects_bool_condition_bool_bool_bool.Invoke(fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_mantissa_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs15)) == 0, expected: false);
				llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs15);
				if (num57)
				{
					llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs16);
					fputil_FPBits_float_FPBits_float_float.Invoke(&fputil_FPBits_5nkvcs16, num35);
					bool num58 = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_inf_const.Invoke(&fputil_FPBits_5nkvcs16);
					llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs16);
					if (num58)
					{
						fputil_set_errno_if_required_int.Invoke(34);
						fputil_raise_except_if_required_int.Invoke(8);
					}
					else if (num35 == 0f)
					{
						fputil_set_errno_if_required_int.Invoke(34);
						fputil_raise_except_if_required_int.Invoke(16);
					}
				}
				result = num35;
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(16L, &numberPair);
				*(double*)(&numberPair) = double.NaN;
				((double*)(&numberPair))[1] = double.NaN;
				NumberPair_double_NumberPair.Invoke(&numberPair);
				bool num59 = num27 != 0;
				llvm_lifetime_start_p0.Invoke(8L, &num39);
				checked
				{
					double lo;
					if (num59)
					{
						long num60 = num28;
						long num61 = num27;
						num39 = num60 + cpp_enable_if_sizeof_long_sizeof_double_cpp_is_trivially_constructible_long_value_cpp_is_trivially_copyable_long_value_cpp_is_trivially_copyable_double_value_long_type_cpp_bit_cast_long_double_double_const.Invoke(&unchecked((fputil_TripleDouble*)EXP2_MID1.Pointer)[num61].mid);
						lo = cpp_enable_if_sizeof_double_sizeof_long_cpp_is_trivially_constructible_double_value_cpp_is_trivially_copyable_double_value_cpp_is_trivially_copyable_long_value_double_type_cpp_bit_cast_double_long_long_const.Invoke(&num39);
					}
					else
					{
						lo = 0.0;
					}
					numberPair.lo = lo;
					llvm_lifetime_end_p0.Invoke(8L, &num39);
					numberPair.hi = num31;
					llvm_lifetime_start_p0.Invoke(8L, &num40);
					num40 = anonymous_namespace_powf_double_double_int_double_double_double_NumberPair_double_const.Invoke(num16, num19, num22, num24, &numberPair);
					result = (float)num40;
					llvm_lifetime_end_p0.Invoke(8L, &num40);
					llvm_lifetime_end_p0.Invoke(16L, &numberPair);
				}
			}
			llvm_lifetime_end_p0.Invoke(4L, &num37);
			llvm_lifetime_end_p0.Invoke(4L, &num35);
			llvm_lifetime_end_p0.Invoke(8L, &num34);
			llvm_lifetime_end_p0.Invoke(8L, &num33);
			llvm_lifetime_end_p0.Invoke(8L, &num32);
			llvm_lifetime_end_p0.Invoke(8L, &a_ijazrn2);
			llvm_lifetime_end_p0.Invoke(8L, &a_yc74sk2);
			llvm_lifetime_end_p0.Invoke(8L, &a2);
			llvm_lifetime_end_p0.Invoke(8L, &x3);
			llvm_lifetime_end_p0.Invoke(48L, &inlineArray6_Double2);
			llvm_lifetime_end_p0.Invoke(8L, &num31);
			llvm_lifetime_end_p0.Invoke(8L, &num30);
			llvm_lifetime_end_p0.Invoke(8L, &num29);
			llvm_lifetime_end_p0.Invoke(8L, &num28);
			llvm_lifetime_end_p0.Invoke(4L, &num27);
			llvm_lifetime_end_p0.Invoke(8L, &num26);
			llvm_lifetime_end_p0.Invoke(8L, &num25);
			llvm_lifetime_end_p0.Invoke(8L, &num24);
			llvm_lifetime_end_p0.Invoke(8L, &num23);
			llvm_lifetime_end_p0.Invoke(8L, &num22);
			llvm_lifetime_end_p0.Invoke(8L, &num21);
			llvm_lifetime_end_p0.Invoke(8L, &num20);
			llvm_lifetime_end_p0.Invoke(8L, &a_ijazrn);
			llvm_lifetime_end_p0.Invoke(8L, &a_yc74sk);
			llvm_lifetime_end_p0.Invoke(8L, &a);
			llvm_lifetime_end_p0.Invoke(8L, &x2);
			llvm_lifetime_end_p0.Invoke(48L, &inlineArray6_Double);
			llvm_lifetime_end_p0.Invoke(8L, &num19);
			llvm_lifetime_end_p0.Invoke(4L, &num17);
			llvm_lifetime_end_p0.Invoke(4L, &num16);
			llvm_lifetime_end_p0.Invoke(4L, &num15);
			llvm_lifetime_end_p0.Invoke(8L, &num14);
			goto IL_170b;
		}
		IL_172d:
		llvm_lifetime_end_p0.Invoke(4L, &num4);
		llvm_lifetime_end_p0.Invoke(4L, &num3);
		llvm_lifetime_end_p0.Invoke(4L, &num2);
		llvm_lifetime_end_p0.Invoke(4L, &num);
		llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
		llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		return result;
		IL_084b:
		llvm_lifetime_start_p0.Invoke(4L, &num12);
		num12 = -127;
		llvm_lifetime_start_p0.Invoke(8L, &num13);
		num13 = 0L;
		unchecked
		{
			if (!bool_details_expects_bool_condition_bool_bool_bool.Invoke(((num & -2145386497) == 0) ? true : (((uint)num < 2139095040u) ? ((uint)num < 8388608u) : true), expected: false))
			{
				goto IL_0ca4;
			}
			int num62 = num;
			if (num62 != 1065353216)
			{
				if (num62 != 1073741824)
				{
					if (num62 != 1092616192)
					{
						llvm_lifetime_start_p0.Invoke(1L, &b);
						b = (((uint)num >= 2147483648u) ? ((sbyte)1) : ((sbyte)0));
						if (num41 == 0f)
						{
							llvm_lifetime_start_p0.Invoke(1L, &b2);
							bool num63 = (b & 1) == 1;
							llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs9);
							int num64;
							if (!num63)
							{
								num64 = 0;
							}
							else
							{
								fputil_FPBits_float_FPBits_unsigned_int_unsigned_int.Invoke(&fputil_FPBits_5nkvcs9, num3);
								num64 = (anonymous_namespace_is_odd_integer_float.Invoke(fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs9)) ? 1 : 0);
							}
							llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs9);
							b2 = (sbyte)(byte)num64;
							if ((uint)num3 > 2147483648u)
							{
								fputil_set_errno_if_required_int.Invoke(33);
								fputil_raise_except_if_required_int.Invoke(4);
								llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs10);
								llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb10, ((b2 & 1) != 1) ? Sign_POS.Pointer : Sign_NEG.Pointer, 1L, isVolatile: false);
								int field_5 = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_inf_Sign.Invoke(anon_izyfb10.val);
								fputil_FPBits_5nkvcs10.FPRepImpl.FPRepSem.field_0.field_0 = field_5;
								result = fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs10);
								llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs10);
								num46 = 1;
							}
							else
							{
								result = InstructionHelper.Select((b2 & 1) == 1, -0f, 0f);
								num46 = 1;
							}
							llvm_lifetime_end_p0.Invoke(1L, &b2);
						}
						else if (num2 == 2139095040)
						{
							llvm_lifetime_start_p0.Invoke(1L, &b3);
							bool num65 = (b & 1) == 1;
							llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs11);
							int num66;
							if (!num65)
							{
								num66 = 0;
							}
							else
							{
								fputil_FPBits_float_FPBits_unsigned_int_unsigned_int.Invoke(&fputil_FPBits_5nkvcs11, num3);
								num66 = (anonymous_namespace_is_odd_integer_float.Invoke(fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs11)) ? 1 : 0);
							}
							llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs11);
							b3 = (sbyte)(byte)num66;
							if ((uint)num3 >= 2147483648u)
							{
								result = InstructionHelper.Select((b3 & 1) == 1, -0f, 0f);
								num46 = 1;
							}
							else
							{
								llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs12);
								llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb11, ((b3 & 1) != 1) ? Sign_POS.Pointer : Sign_NEG.Pointer, 1L, isVolatile: false);
								int field_6 = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_inf_Sign.Invoke(anon_izyfb11.val);
								fputil_FPBits_5nkvcs12.FPRepImpl.FPRepSem.field_0.field_0 = field_6;
								result = fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs12);
								llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs12);
								num46 = 1;
							}
							llvm_lifetime_end_p0.Invoke(1L, &b3);
						}
						else if ((uint)num2 > 2139095040u)
						{
							result = num41;
							num46 = 1;
						}
						else
						{
							if ((uint)num2 < 8388608u)
							{
								num12 = checked(num12 - 64);
								num41 *= 1.8446744E+19f;
							}
							if ((b & 1) == 1)
							{
								if (!anonymous_namespace_is_integer_float.Invoke(num42))
								{
									fputil_set_errno_if_required_int.Invoke(33);
									fputil_raise_except_if_required_int.Invoke(1);
									llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs13);
									llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb12, Sign_POS.Pointer, 1L, isVolatile: false);
									int field_7 = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan_Sign_unsigned_int.Invoke(anon_izyfb12.val, 0);
									fputil_FPBits_5nkvcs13.FPRepImpl.FPRepSem.field_0.field_0 = field_7;
									result = fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs13);
									llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs13);
									num46 = 1;
									goto IL_0c82;
								}
								num41 = 0f - num41;
								if (anonymous_namespace_is_odd_integer_float.Invoke(num42))
								{
									num13 = long.MinValue;
								}
							}
							num46 = 0;
						}
						goto IL_0c82;
					}
					result = generic_exp10f_float.Invoke(num42);
				}
				else
				{
					result = generic_exp2f_float.Invoke(num42);
				}
			}
			else
			{
				result = 1f;
			}
			goto IL_170b;
		}
		IL_0c82:
		llvm_lifetime_end_p0.Invoke(1L, &b);
		switch (num46)
		{
		case 0:
			break;
		default:
			goto IL_170b;
		}
		goto IL_0ca4;
	}
}
