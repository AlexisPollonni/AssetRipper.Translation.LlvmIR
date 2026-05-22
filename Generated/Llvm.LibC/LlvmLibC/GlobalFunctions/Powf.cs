using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Powf
{
	[MangledName("powf")]
	[DemangledName("powf")]
	public unsafe static float Invoke([MangledName("x")] float X, [MangledName("y")] float Y)
	{
		float result = 0f;
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs2 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		int num = 0;
		int num2 = 0;
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs3 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		int num3 = 0;
		int num4 = 0;
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs4 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs5 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs6 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs7 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
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
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs8 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs9 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		sbyte b3 = 0;
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs10 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs11 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb4 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs12 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb5 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs13 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		double num14 = 0.0;
		int num15 = 0;
		int num16 = 0;
		float num17 = 0f;
		int num18 = 0;
		double num19 = 0.0;
		InlineArray6_Double inlineArray6_Double = default(InlineArray6_Double);
		double x = 0.0;
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
		double x2 = 0.0;
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
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs14 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs15 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair = default(Llvm_libc_20_1_2_NumberPair);
		long num39 = 0L;
		double num40 = 0.0;
		float num41 = X;
		float num42 = Y;
		Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		int num46;
		unchecked
		{
			*(int*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs) = -1431655766;
			FPBits_float_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs, num41);
			Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
			*(int*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2) = -1431655766;
			FPBits_float_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2, num42);
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs));
			Llvm_lifetime_start_p0.Invoke(4L, &num2);
			Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs3);
			int field_ = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_abs.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs));
			llvm_libc_20_1_2_fputil_FPBits_5nkvcs3.FPRepImpl.FPRepSem.field_0.field_0 = field_;
			int num43 = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs3));
			Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs3);
			num2 = num43;
			Llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2));
			Llvm_lifetime_start_p0.Invoke(4L, &num4);
			Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs4);
			int field_2 = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_abs.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2));
			llvm_libc_20_1_2_fputil_FPBits_5nkvcs4.FPRepImpl.FPRepSem.field_0.field_0 = field_2;
			int num44 = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs4));
			Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs4);
			num4 = num44;
			if (!Details_expects_bool_condition_bool.Invoke((num4 & 0x7FFFF) == 0, Expected: false) && (uint)num4 <= 1326907392u)
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
					Fputil_set_errno_if_required.Invoke(33);
					Fputil_raise_except_if_required.Invoke(4);
					Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs5);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
					int field_3 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_inf.Invoke(anon_izyfb.Val);
					llvm_libc_20_1_2_fputil_FPBits_5nkvcs5.FPRepImpl.FPRepSem.field_0.field_0 = field_3;
					result = FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs5);
					Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs5);
				}
				else
				{
					bool condition = (uint)num2 < 1065353216u == (num3 == -8388608);
					Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs6);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
					int field_4 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_inf.Invoke(anon_izyfb2.Val);
					llvm_libc_20_1_2_fputil_FPBits_5nkvcs6.FPRepImpl.FPRepSem.field_0.field_0 = field_4;
					result = InstructionHelper.Select(condition, FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs6), 0f);
					Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs6);
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
							if (Anonymous_namespace_is_integer.Invoke(num42) && (uint)num3 > 1073741824u && (uint)num3 <= 1103101952u)
							{
								Llvm_lifetime_start_p0.Invoke(4L, &num5);
								num5 = ((num2 != 0) ? Cpp_countl_zero_unsigned_int.Invoke(num2) : 30);
								num5 = ((num5 <= 8) ? 8 : num5);
								Llvm_lifetime_start_p0.Invoke(4L, &num6);
								num6 = ((num2 != 0) ? Cpp_countr_zero_unsigned_int.Invoke(num2) : 0);
								num6 = ((num6 <= 23) ? num6 : 23);
								Llvm_lifetime_start_p0.Invoke(4L, &num7);
								num7 = checked(30 - num6 - num5);
								Llvm_lifetime_start_p0.Invoke(4L, &num8);
								num8 = (int)num42;
								checked
								{
									if (num7 * num8 <= 25)
									{
										Llvm_lifetime_start_p0.Invoke(8L, &num9);
										num9 = num41;
										Llvm_lifetime_start_p0.Invoke(8L, &num10);
										num10 = num9;
										Llvm_lifetime_start_p0.Invoke(4L, &i);
										for (i = 1; i < num8; i++)
										{
											num10 *= num9;
										}
										Llvm_lifetime_end_p0.Invoke(4L, &i);
										result = (float)num10;
										num46 = 1;
										Llvm_lifetime_end_p0.Invoke(8L, &num10);
										Llvm_lifetime_end_p0.Invoke(8L, &num9);
									}
									else
									{
										num46 = 0;
									}
									Llvm_lifetime_end_p0.Invoke(4L, &num8);
									Llvm_lifetime_end_p0.Invoke(4L, &num7);
									Llvm_lifetime_end_p0.Invoke(4L, &num6);
									Llvm_lifetime_end_p0.Invoke(4L, &num5);
									switch (num46)
									{
									case 0:
										break;
									default:
										goto IL_1731;
									}
								}
							}
							if ((uint)num4 > 1326907392u)
							{
								if ((uint)num4 > 2139095040u)
								{
									result = ((num != 1065353216) ? num42 : 1f);
									goto IL_1731;
								}
								Llvm_lifetime_start_p0.Invoke(4L, &num11);
								num11 = (num3 & int.MinValue) + 1333788672;
								num42 = Cpp_bit_cast_float_unsigned_int.Invoke(&num11);
								Llvm_lifetime_end_p0.Invoke(4L, &num11);
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
				else if (Details_expects_bool_condition_bool.Invoke(num41 == 0f || num == -8388608, Expected: false))
				{
					result = num41 * num41;
				}
				else
				{
					float num47 = Fputil_sqrt_float_float.Invoke(num41);
					Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs7);
					FPBits_float_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs7, num47);
					result = ((FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs7)) == int.MinValue) ? 0f : num47);
					Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs7);
				}
			}
			goto IL_1731;
		}
		IL_170f:
		Llvm_lifetime_end_p0.Invoke(8L, &num13);
		Llvm_lifetime_end_p0.Invoke(4L, &num12);
		goto IL_1731;
		IL_0ca4:
		Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs13);
		FPBits_float_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs13, num41);
		unchecked
		{
			num = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs13));
			Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs13);
			num12 += num >>> 23;
			Llvm_lifetime_start_p0.Invoke(8L, &num14);
			num14 = num12;
			Llvm_lifetime_start_p0.Invoke(4L, &num15);
			num15 = num & 0x7FFFFF;
			Llvm_lifetime_start_p0.Invoke(4L, &num16);
			num16 = num15 >>> 16;
			Llvm_lifetime_start_p0.Invoke(4L, &num17);
			Llvm_lifetime_start_p0.Invoke(4L, &num18);
			num18 = num15 | 0x3F800000;
			float num48 = Cpp_bit_cast_float_unsigned_int.Invoke(&num18);
			Llvm_lifetime_end_p0.Invoke(4L, &num18);
			num17 = num48;
			Llvm_lifetime_start_p0.Invoke(8L, &num19);
			num19 = double.NaN;
			double x3 = num17;
			long num49 = num16;
			num19 = Fputil_multiply_add_double.Invoke(x3, ((double*)Llvm_libc_20_1_2_RD.Pointer)[num49], -1.0);
			Llvm_lifetime_start_p0.Invoke(48L, &inlineArray6_Double);
			Llvm_memset_p0_i64.Invoke(&inlineArray6_Double, 0, 48L, isVolatile: false);
			*(double*)(&inlineArray6_Double) = 1.4426950408889634;
			Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, sizeof(double))) = -0.7213475204442269;
			Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)2 * (nint)sizeof(double))) = 0.4808983470049624;
			Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)3 * (nint)sizeof(double))) = -0.3606738114118398;
			Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)4 * (nint)sizeof(double))) = 0.288538666318245;
			Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)5 * (nint)sizeof(double))) = -0.23813265214085774;
			Llvm_lifetime_start_p0.Invoke(8L, &x);
			x = num19 * num19;
			Llvm_lifetime_start_p0.Invoke(8L, &a);
			a = Fputil_multiply_add_double.Invoke(num19, Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, sizeof(double))), *(double*)(&inlineArray6_Double));
			Llvm_lifetime_start_p0.Invoke(8L, &a_yc74sk);
			a_yc74sk = Fputil_multiply_add_double.Invoke(num19, Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)3 * sizeof(double))), Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)2 * sizeof(double))));
			Llvm_lifetime_start_p0.Invoke(8L, &a_ijazrn);
			a_ijazrn = Fputil_multiply_add_double.Invoke(num19, Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)5 * sizeof(double))), Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)4 * sizeof(double))));
			Llvm_lifetime_start_p0.Invoke(8L, &num20);
			num20 = Fputil_polyeval_double_double_double.Invoke(x, a, a_yc74sk, a_ijazrn);
			Llvm_lifetime_start_p0.Invoke(8L, &num21);
			double x4 = num19;
			double y = num20;
			long num50 = num16;
			num21 = Fputil_multiply_add_double.Invoke(x4, y, ((double*)Llvm_libc_20_1_2_LOG2_R.Pointer)[num50] + num14);
			Llvm_lifetime_start_p0.Invoke(8L, &num22);
			num22 = num42 * 64f;
			Llvm_lifetime_start_p0.Invoke(8L, &num23);
			num23 = Fputil_nearest_integer.Invoke(num21 * num22);
			Llvm_lifetime_start_p0.Invoke(8L, &num24);
			double x5 = num22;
			double num51 = num14;
			long num52 = num16;
			num24 = Fputil_multiply_add_double.Invoke(x5, num51 + ((Llvm_libc_20_1_2_fputil_TripleDouble*)Llvm_libc_20_1_2_anonymous_namespace_LOG2_R_TD.Pointer)[num52].Hi, 0.0 - num23);
			Llvm_lifetime_start_p0.Invoke(8L, &num25);
			double x6 = num22;
			double x7 = num19;
			double y2 = num20;
			long num53 = num16;
			num25 = Fputil_multiply_add_double.Invoke(x6, Fputil_multiply_add_double.Invoke(x7, y2, ((Llvm_libc_20_1_2_fputil_TripleDouble*)Llvm_libc_20_1_2_anonymous_namespace_LOG2_R_TD.Pointer)[num53].Mid), num24);
			Llvm_lifetime_start_p0.Invoke(8L, &num26);
			num26 = (long)num23;
			num26 = ((num26 <= 32768L) ? ((num26 >= -32768L) ? num26 : (-32768L)) : 32768L);
			Llvm_lifetime_start_p0.Invoke(4L, &num27);
			num27 = (int)(num26 & 0x3FL);
			Llvm_lifetime_start_p0.Invoke(8L, &num28);
			num28 = num26 >> 6 << 52;
			Llvm_lifetime_start_p0.Invoke(8L, &num29);
			long num54 = num27;
			num29 = Cpp_bit_cast_unsigned_long_double.Invoke(&((Llvm_libc_20_1_2_fputil_TripleDouble*)Llvm_libc_20_1_2_EXP2_MID1.Pointer)[num54].Hi);
			Llvm_lifetime_start_p0.Invoke(8L, &num30);
			num30 = checked(num28 + num29) + num13;
			Llvm_lifetime_start_p0.Invoke(8L, &num31);
			num31 = Cpp_bit_cast_double_unsigned_long.Invoke(&num30);
			Llvm_lifetime_start_p0.Invoke(48L, &inlineArray6_Double2);
			Llvm_memset_p0_i64.Invoke(&inlineArray6_Double2, 0, 48L, isVolatile: false);
			*(double*)(&inlineArray6_Double2) = 1.0;
			Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double2, sizeof(double))) = 0.010830424696249145;
			Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double2, (nint)2 * (nint)sizeof(double))) = 5.864904955050041E-05;
			Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double2, (nint)3 * (nint)sizeof(double))) = 2.1173137155942948E-07;
			Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double2, (nint)4 * (nint)sizeof(double))) = 5.732859533818817E-10;
			Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double2, (nint)5 * (nint)sizeof(double))) = 1.241771242191526E-12;
			Llvm_lifetime_start_p0.Invoke(8L, &x2);
			x2 = num25 * num25;
			Llvm_lifetime_start_p0.Invoke(8L, &a2);
			a2 = Fputil_multiply_add_double.Invoke(num25, Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double2, sizeof(double))), *(double*)(&inlineArray6_Double2));
			Llvm_lifetime_start_p0.Invoke(8L, &a_yc74sk2);
			a_yc74sk2 = Fputil_multiply_add_double.Invoke(num25, Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double2, (nint)3 * sizeof(double))), Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double2, (nint)2 * sizeof(double))));
			Llvm_lifetime_start_p0.Invoke(8L, &a_ijazrn2);
			a_ijazrn2 = Fputil_multiply_add_double.Invoke(num25, Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double2, (nint)5 * sizeof(double))), Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double2, (nint)4 * sizeof(double))));
			Llvm_lifetime_start_p0.Invoke(8L, &num32);
			num32 = Fputil_polyeval_double_double_double.Invoke(x2, a2, a_yc74sk2, a_ijazrn2);
			Llvm_lifetime_start_p0.Invoke(8L, &num33);
			num33 = num32 * num31;
			Llvm_lifetime_start_p0.Invoke(8L, &num34);
			num34 = Cpp_bit_cast_unsigned_long_double.Invoke(&num33);
			Llvm_lifetime_start_p0.Invoke(4L, &num35);
			Llvm_lifetime_start_p0.Invoke(8L, &num36);
			num36 = num34 + 128L;
			float num55 = (float)Cpp_bit_cast_double_unsigned_long.Invoke(&num36);
			Llvm_lifetime_end_p0.Invoke(8L, &num36);
			num35 = num55;
			Llvm_lifetime_start_p0.Invoke(4L, &num37);
			Llvm_lifetime_start_p0.Invoke(8L, &num38);
			num38 = num34 - 128L;
			float num56 = (float)Cpp_bit_cast_double_unsigned_long.Invoke(&num38);
			Llvm_lifetime_end_p0.Invoke(8L, &num38);
			num37 = num56;
			if (Details_expects_bool_condition_bool.Invoke(num35 == num37, Expected: true))
			{
				Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs14);
				FPBits_float_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs14, num35);
				bool num57 = Details_expects_bool_condition_bool.Invoke(FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs14)) == 0, Expected: false);
				Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs14);
				if (num57)
				{
					Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs15);
					FPBits_float_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs15, num35);
					bool num58 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_inf.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs15);
					Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs15);
					if (num58)
					{
						Fputil_set_errno_if_required.Invoke(34);
						Fputil_raise_except_if_required.Invoke(8);
					}
					else if (num35 == 0f)
					{
						Fputil_set_errno_if_required.Invoke(34);
						Fputil_raise_except_if_required.Invoke(16);
					}
				}
				result = num35;
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair);
				*(double*)(&llvm_libc_20_1_2_NumberPair) = double.NaN;
				((double*)(&llvm_libc_20_1_2_NumberPair))[1] = double.NaN;
				NumberPair_double_Constructor.Invoke(&llvm_libc_20_1_2_NumberPair);
				bool num59 = num27 != 0;
				Llvm_lifetime_start_p0.Invoke(8L, &num39);
				checked
				{
					double lo;
					if (num59)
					{
						long num60 = num28;
						long num61 = num27;
						num39 = num60 + Cpp_bit_cast_long_double.Invoke(&unchecked((Llvm_libc_20_1_2_fputil_TripleDouble*)Llvm_libc_20_1_2_EXP2_MID1.Pointer)[num61].Mid);
						lo = Cpp_bit_cast_double_long.Invoke(&num39);
					}
					else
					{
						lo = 0.0;
					}
					llvm_libc_20_1_2_NumberPair.Lo = lo;
					Llvm_lifetime_end_p0.Invoke(8L, &num39);
					llvm_libc_20_1_2_NumberPair.Hi = num31;
					Llvm_lifetime_start_p0.Invoke(8L, &num40);
					num40 = Anonymous_namespace_powf_double_double.Invoke(num16, num19, num22, num24, &llvm_libc_20_1_2_NumberPair);
					result = (float)num40;
					Llvm_lifetime_end_p0.Invoke(8L, &num40);
					Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair);
				}
			}
			Llvm_lifetime_end_p0.Invoke(4L, &num37);
			Llvm_lifetime_end_p0.Invoke(4L, &num35);
			Llvm_lifetime_end_p0.Invoke(8L, &num34);
			Llvm_lifetime_end_p0.Invoke(8L, &num33);
			Llvm_lifetime_end_p0.Invoke(8L, &num32);
			Llvm_lifetime_end_p0.Invoke(8L, &a_ijazrn2);
			Llvm_lifetime_end_p0.Invoke(8L, &a_yc74sk2);
			Llvm_lifetime_end_p0.Invoke(8L, &a2);
			Llvm_lifetime_end_p0.Invoke(8L, &x2);
			Llvm_lifetime_end_p0.Invoke(48L, &inlineArray6_Double2);
			Llvm_lifetime_end_p0.Invoke(8L, &num31);
			Llvm_lifetime_end_p0.Invoke(8L, &num30);
			Llvm_lifetime_end_p0.Invoke(8L, &num29);
			Llvm_lifetime_end_p0.Invoke(8L, &num28);
			Llvm_lifetime_end_p0.Invoke(4L, &num27);
			Llvm_lifetime_end_p0.Invoke(8L, &num26);
			Llvm_lifetime_end_p0.Invoke(8L, &num25);
			Llvm_lifetime_end_p0.Invoke(8L, &num24);
			Llvm_lifetime_end_p0.Invoke(8L, &num23);
			Llvm_lifetime_end_p0.Invoke(8L, &num22);
			Llvm_lifetime_end_p0.Invoke(8L, &num21);
			Llvm_lifetime_end_p0.Invoke(8L, &num20);
			Llvm_lifetime_end_p0.Invoke(8L, &a_ijazrn);
			Llvm_lifetime_end_p0.Invoke(8L, &a_yc74sk);
			Llvm_lifetime_end_p0.Invoke(8L, &a);
			Llvm_lifetime_end_p0.Invoke(8L, &x);
			Llvm_lifetime_end_p0.Invoke(48L, &inlineArray6_Double);
			Llvm_lifetime_end_p0.Invoke(8L, &num19);
			Llvm_lifetime_end_p0.Invoke(4L, &num17);
			Llvm_lifetime_end_p0.Invoke(4L, &num16);
			Llvm_lifetime_end_p0.Invoke(4L, &num15);
			Llvm_lifetime_end_p0.Invoke(8L, &num14);
			goto IL_170f;
		}
		IL_1731:
		Llvm_lifetime_end_p0.Invoke(4L, &num4);
		Llvm_lifetime_end_p0.Invoke(4L, &num3);
		Llvm_lifetime_end_p0.Invoke(4L, &num2);
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
		Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		return result;
		IL_084b:
		Llvm_lifetime_start_p0.Invoke(4L, &num12);
		num12 = -127;
		Llvm_lifetime_start_p0.Invoke(8L, &num13);
		num13 = 0L;
		unchecked
		{
			if (!Details_expects_bool_condition_bool.Invoke((num & -2145386497) == 0 || (uint)num >= 2139095040u || (uint)num < 8388608u, Expected: false))
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
						Llvm_lifetime_start_p0.Invoke(1L, &b);
						b = (((uint)num >= 2147483648u) ? ((sbyte)1) : ((sbyte)0));
						if (num41 == 0f)
						{
							Llvm_lifetime_start_p0.Invoke(1L, &b2);
							bool num63 = (b & 1) == 1;
							Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs8);
							int num64;
							if (!num63)
							{
								num64 = 0;
							}
							else
							{
								FPBits_float_FPBits_unsigned_int.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs8, num3);
								num64 = (Anonymous_namespace_is_odd_integer.Invoke(FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs8)) ? 1 : 0);
							}
							Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs8);
							b2 = (sbyte)(byte)num64;
							if ((uint)num3 > 2147483648u)
							{
								Fputil_set_errno_if_required.Invoke(33);
								Fputil_raise_except_if_required.Invoke(4);
								Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs9);
								Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb3, ((b2 & 1) != 1) ? Llvm_libc_20_1_2_Sign_POS.Pointer : Llvm_libc_20_1_2_Sign_NEG.Pointer, 1L, isVolatile: false);
								int field_5 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_inf.Invoke(anon_izyfb3.Val);
								llvm_libc_20_1_2_fputil_FPBits_5nkvcs9.FPRepImpl.FPRepSem.field_0.field_0 = field_5;
								result = FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs9);
								Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs9);
								num46 = 1;
							}
							else
							{
								result = InstructionHelper.Select((b2 & 1) == 1, -0f, 0f);
								num46 = 1;
							}
							Llvm_lifetime_end_p0.Invoke(1L, &b2);
						}
						else if (num2 == 2139095040)
						{
							Llvm_lifetime_start_p0.Invoke(1L, &b3);
							bool num65 = (b & 1) == 1;
							Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs10);
							int num66;
							if (!num65)
							{
								num66 = 0;
							}
							else
							{
								FPBits_float_FPBits_unsigned_int.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs10, num3);
								num66 = (Anonymous_namespace_is_odd_integer.Invoke(FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs10)) ? 1 : 0);
							}
							Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs10);
							b3 = (sbyte)(byte)num66;
							if ((uint)num3 >= 2147483648u)
							{
								result = InstructionHelper.Select((b3 & 1) == 1, -0f, 0f);
								num46 = 1;
							}
							else
							{
								Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs11);
								Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb4, ((b3 & 1) != 1) ? Llvm_libc_20_1_2_Sign_POS.Pointer : Llvm_libc_20_1_2_Sign_NEG.Pointer, 1L, isVolatile: false);
								int field_6 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_inf.Invoke(anon_izyfb4.Val);
								llvm_libc_20_1_2_fputil_FPBits_5nkvcs11.FPRepImpl.FPRepSem.field_0.field_0 = field_6;
								result = FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs11);
								Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs11);
								num46 = 1;
							}
							Llvm_lifetime_end_p0.Invoke(1L, &b3);
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
								if (!Anonymous_namespace_is_integer.Invoke(num42))
								{
									Fputil_set_errno_if_required.Invoke(33);
									Fputil_raise_except_if_required.Invoke(1);
									Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs12);
									Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb5, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
									int field_7 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan.Invoke(anon_izyfb5.Val, 0);
									llvm_libc_20_1_2_fputil_FPBits_5nkvcs12.FPRepImpl.FPRepSem.field_0.field_0 = field_7;
									result = FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs12);
									Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs12);
									num46 = 1;
									goto IL_0c82;
								}
								num41 = 0f - num41;
								if (Anonymous_namespace_is_odd_integer.Invoke(num42))
								{
									num13 = long.MinValue;
								}
							}
							num46 = 0;
						}
						goto IL_0c82;
					}
					result = Generic_exp10f.Invoke(num42);
				}
				else
				{
					result = Generic_exp2f.Invoke(num42);
				}
			}
			else
			{
				result = 1f;
			}
			goto IL_170f;
		}
		IL_0c82:
		Llvm_lifetime_end_p0.Invoke(1L, &b);
		switch (num46)
		{
		case 0:
			break;
		default:
			goto IL_170f;
		}
		goto IL_0ca4;
	}
}
