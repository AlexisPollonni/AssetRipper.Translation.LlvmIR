using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class DyadicFloat_32ul_fast_as_float_true_void
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil11DyadicFloatILm32EE7fast_asIfLb1EvEET_v")]
	[DemangledName("float __llvm_libc_20_1_2_::fputil::DyadicFloat<32ul>::fast_as<float, true, void>() const")]
	[return: NativeType("float")]
	public unsafe static float Invoke([MangledName("this")] void* This)
	{
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		float num4 = 0f;
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs2 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		float num5 = 0f;
		float num6 = 0f;
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs3 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		sbyte b = 0;
		int num7 = 0;
		int num8 = 0;
		Llvm_libc_20_1_2_BigInt_vtm4cw llvm_libc_20_1_2_BigInt_vtm4cw = default(Llvm_libc_20_1_2_BigInt_vtm4cw);
		float num9 = 0f;
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs4 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_BigInt_vtm4cw llvm_libc_20_1_2_BigInt_vtm4cw2 = default(Llvm_libc_20_1_2_BigInt_vtm4cw);
		Llvm_libc_20_1_2_BigInt_vtm4cw llvm_libc_20_1_2_BigInt_vtm4cw3 = default(Llvm_libc_20_1_2_BigInt_vtm4cw);
		Llvm_libc_20_1_2_BigInt_vtm4cw llvm_libc_20_1_2_BigInt_vtm4cw4 = default(Llvm_libc_20_1_2_BigInt_vtm4cw);
		Llvm_libc_20_1_2_BigInt_vtm4cw llvm_libc_20_1_2_BigInt_vtm4cw5 = default(Llvm_libc_20_1_2_BigInt_vtm4cw);
		sbyte b2 = 0;
		Llvm_libc_20_1_2_BigInt_vtm4cw llvm_libc_20_1_2_BigInt_vtm4cw6 = default(Llvm_libc_20_1_2_BigInt_vtm4cw);
		sbyte b3 = 0;
		Llvm_libc_20_1_2_BigInt_vtm4cw llvm_libc_20_1_2_BigInt_vtm4cw7 = default(Llvm_libc_20_1_2_BigInt_vtm4cw);
		int num10 = 0;
		float x = 0f;
		int num11 = 0;
		float num12 = 0f;
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs5 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb4 = default(Anon_izyfb7);
		float num13 = 0f;
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs6 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb5 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs7 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb6 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs8 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb7 = default(Anon_izyfb7);
		float num14 = 0f;
		int num15 = 0;
		int num16 = 0;
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs9 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs10 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		unchecked
		{
			float result;
			if (Details_expects_bool_condition_bool.Invoke(BigInt_32ul_false_unsigned_int_is_zero.Invoke(&((Llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs*)This)->Mantissa), Expected: false))
			{
				Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, &((Llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs*)This)->Sign, 1L, isVolatile: false);
				int field_ = FPRepSem_fputil_FPType_1_fputil_FPBits_float_zero.Invoke(anon_izyfb.Val);
				llvm_libc_20_1_2_fputil_FPBits_5nkvcs.FPRepImpl.FPRepSem.field_0.field_0 = field_;
				result = FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
				Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num);
				num = 24;
				Llvm_lifetime_start_p0.Invoke(4L, &num2);
				num2 = 0;
				Llvm_lifetime_start_p0.Invoke(4L, &num3);
				checked
				{
					num3 = unchecked((Llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs*)This)->Exponent + 158;
				}
				if (Details_expects_bool_condition_bool.Invoke(num3 > 254, Expected: false))
				{
					Llvm_lifetime_start_p0.Invoke(4L, &num4);
					Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, &((Llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs*)This)->Sign, 1L, isVolatile: false);
					int field_2 = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_create_value.Invoke(anon_izyfb2.Val, 254, 0);
					llvm_libc_20_1_2_fputil_FPBits_5nkvcs2.FPRepImpl.FPRepSem.field_0.field_0 = field_2;
					float num17 = FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
					Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
					num4 = num17;
					Llvm_lifetime_start_p0.Invoke(4L, &num5);
					num5 = 2f;
					Llvm_lifetime_start_p0.Invoke(4L, &num6);
					num6 = num5 * num4;
					Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs3);
					FPBits_float_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs3, num6);
					bool num18 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_inf.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs3);
					Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs3);
					if (num18)
					{
						Fputil_set_errno_if_required.Invoke(34);
					}
					result = num6;
					Llvm_lifetime_end_p0.Invoke(4L, &num6);
					Llvm_lifetime_end_p0.Invoke(4L, &num5);
					Llvm_lifetime_end_p0.Invoke(4L, &num4);
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(1L, &b);
					b = 0;
					Llvm_lifetime_start_p0.Invoke(4L, &num7);
					num7 = 8;
					if (Details_expects_bool_condition_bool.Invoke(num3 <= 0, Expected: false))
					{
						b = 1;
						num7 = (int)(8L + (long)(uint)checked(1 - num3));
						num3 = 127;
					}
					Llvm_lifetime_start_p0.Invoke(4L, &num8);
					num8 = checked(num3 - 24 - 1);
					Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_BigInt_vtm4cw);
					*(int*)(&llvm_libc_20_1_2_BigInt_vtm4cw) = -1431655766;
					if ((ulong)(uint)num7 >= 32uL)
					{
						BigInt_32ul_false_unsigned_int_BigInt_int_void.Invoke(&llvm_libc_20_1_2_BigInt_vtm4cw, 0);
					}
					else
					{
						int data = BigInt_32ul_false_unsigned_int_RightShift.Invoke(&((Llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs*)This)->Mantissa, (uint)num7);
						*(int*)(&llvm_libc_20_1_2_BigInt_vtm4cw.Val.Data) = data;
					}
					Llvm_lifetime_start_p0.Invoke(4L, &num9);
					Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs4);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb3, &((Llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs*)This)->Sign, 1L, isVolatile: false);
					int field_3 = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_create_value.Invoke(Biased_exp: num3, Mantissa: (BigInt_32ul_false_unsigned_int_Unsigned_int_unsigned_int.Invoke(&llvm_libc_20_1_2_BigInt_vtm4cw) & 0x7FFFFF) | 0, Sign: anon_izyfb3.Val);
					llvm_libc_20_1_2_fputil_FPBits_5nkvcs4.FPRepImpl.FPRepSem.field_0.field_0 = field_3;
					float num19 = FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs4);
					Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs4);
					num9 = num19;
					Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_BigInt_vtm4cw2);
					*(int*)(&llvm_libc_20_1_2_BigInt_vtm4cw2) = -1431655766;
					bool num20 = (ulong)(uint)num7 > 32uL;
					Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_BigInt_vtm4cw3);
					if (num20)
					{
						BigInt_32ul_false_unsigned_int_BigInt_int_void.Invoke(&llvm_libc_20_1_2_BigInt_vtm4cw2, 0);
					}
					else
					{
						BigInt_32ul_false_unsigned_int_BigInt_int_void.Invoke(&llvm_libc_20_1_2_BigInt_vtm4cw3, 1);
						int data2 = BigInt_32ul_false_unsigned_int_LeftShift.Invoke(&llvm_libc_20_1_2_BigInt_vtm4cw3, (uint)(num7 - 1));
						*(int*)(&llvm_libc_20_1_2_BigInt_vtm4cw2.Val.Data) = data2;
					}
					Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_BigInt_vtm4cw3);
					Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_BigInt_vtm4cw4);
					*(int*)(&llvm_libc_20_1_2_BigInt_vtm4cw4) = -1431655766;
					Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_BigInt_vtm4cw5);
					BigInt_32ul_false_unsigned_int_BigInt_int_void.Invoke(&llvm_libc_20_1_2_BigInt_vtm4cw5, 1);
					int data3 = BigInt_32ul_false_unsigned_int_Subtract.Invoke(&llvm_libc_20_1_2_BigInt_vtm4cw2, &llvm_libc_20_1_2_BigInt_vtm4cw5);
					*(int*)(&llvm_libc_20_1_2_BigInt_vtm4cw4.Val.Data) = data3;
					Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_BigInt_vtm4cw5);
					Llvm_lifetime_start_p0.Invoke(1L, &b2);
					Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_BigInt_vtm4cw6);
					int data4 = Llvm_libc_20_1_2_BitwiseAnd.Invoke(&((Llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs*)This)->Mantissa, &llvm_libc_20_1_2_BigInt_vtm4cw2);
					*(int*)(&llvm_libc_20_1_2_BigInt_vtm4cw6.Val.Data) = data4;
					int num21 = (BigInt_32ul_false_unsigned_int_is_zero.Invoke(&llvm_libc_20_1_2_BigInt_vtm4cw6) ? 1 : 0) ^ -1;
					Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_BigInt_vtm4cw6);
					b2 = (sbyte)(byte)num21;
					Llvm_lifetime_start_p0.Invoke(1L, &b3);
					Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_BigInt_vtm4cw7);
					int data5 = Llvm_libc_20_1_2_BitwiseAnd.Invoke(&((Llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs*)This)->Mantissa, &llvm_libc_20_1_2_BigInt_vtm4cw4);
					*(int*)(&llvm_libc_20_1_2_BigInt_vtm4cw7.Val.Data) = data5;
					int num22 = (BigInt_32ul_false_unsigned_int_is_zero.Invoke(&llvm_libc_20_1_2_BigInt_vtm4cw7) ? 1 : 0) ^ -1;
					Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_BigInt_vtm4cw7);
					b3 = (sbyte)(byte)num22;
					Llvm_lifetime_start_p0.Invoke(4L, &num10);
					num10 = checked((((b2 & 1) == 1) ? 1 : 0) * 2 + (((b3 & 1) == 1) ? 1 : 0));
					Llvm_lifetime_start_p0.Invoke(4L, &x);
					x = float.NaN;
					if (Details_expects_bool_condition_bool.Invoke(num8 <= 0, Expected: false))
					{
						Llvm_lifetime_start_p0.Invoke(4L, &num11);
						checked
						{
							num11 = 1 - num8;
							Llvm_lifetime_start_p0.Invoke(4L, &num12);
							Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs5);
							Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb4, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
							int field_4 = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_create_value.Invoke(Biased_exp: 127 + num11, Sign: anon_izyfb4.Val, Mantissa: 0);
							llvm_libc_20_1_2_fputil_FPBits_5nkvcs5.FPRepImpl.FPRepSem.field_0.field_0 = field_4;
							float num23 = FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs5);
							Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs5);
							num12 = num23;
							Llvm_lifetime_start_p0.Invoke(4L, &num13);
							Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs6);
							Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb5, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
							int field_5 = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_create_value.Invoke(Biased_exp: 127 - num11, Sign: anon_izyfb5.Val, Mantissa: 0);
							llvm_libc_20_1_2_fputil_FPBits_5nkvcs6.FPRepImpl.FPRepSem.field_0.field_0 = field_5;
							float num24 = FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs6);
							Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs6);
							num13 = num24;
							Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs7);
							Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb6, &unchecked((Llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs*)This)->Sign, 1L, isVolatile: false);
							int field_6 = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_create_value.Invoke(Biased_exp: num8 + num11, Sign: anon_izyfb6.Val, Mantissa: 0);
							llvm_libc_20_1_2_fputil_FPBits_5nkvcs7.FPRepImpl.FPRepSem.field_0.field_0 = field_6;
							x = FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs7);
							Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs7);
							result = Fputil_multiply_add_float.Invoke(x, num10, num9 * num12) * num13;
							Llvm_lifetime_end_p0.Invoke(4L, &num13);
							Llvm_lifetime_end_p0.Invoke(4L, &num12);
							Llvm_lifetime_end_p0.Invoke(4L, &num11);
						}
					}
					else
					{
						Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs8);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb7, &((Llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs*)This)->Sign, 1L, isVolatile: false);
						int field_7 = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_create_value.Invoke(Biased_exp: num8, Sign: anon_izyfb7.Val, Mantissa: 0);
						llvm_libc_20_1_2_fputil_FPBits_5nkvcs8.FPRepImpl.FPRepSem.field_0.field_0 = field_7;
						x = FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs8);
						Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs8);
						Llvm_lifetime_start_p0.Invoke(4L, &num14);
						num14 = Fputil_multiply_add_float.Invoke(x, num10, num9);
						if (Details_expects_bool_condition_bool.Invoke((b & 1) == 1, Expected: false))
						{
							Llvm_lifetime_start_p0.Invoke(4L, &num15);
							num15 = num3 << 23;
							Llvm_lifetime_start_p0.Invoke(4L, &num16);
							Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs9);
							FPBits_float_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs9, num14);
							int num25 = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs9)) - num15;
							Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs9);
							num16 = num25;
							if ((num16 & 0x7F800000) == 0)
							{
								num16 -= 0;
								if (num10 != 0)
								{
									Fputil_set_errno_if_required.Invoke(34);
									Fputil_raise_except_if_required.Invoke(16);
								}
							}
							Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs10);
							FPBits_float_FPBits_unsigned_int.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs10, num16);
							result = FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs10);
							Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs10);
							Llvm_lifetime_end_p0.Invoke(4L, &num16);
							Llvm_lifetime_end_p0.Invoke(4L, &num15);
						}
						else
						{
							result = num14;
						}
						Llvm_lifetime_end_p0.Invoke(4L, &num14);
					}
					Llvm_lifetime_end_p0.Invoke(4L, &x);
					Llvm_lifetime_end_p0.Invoke(4L, &num10);
					Llvm_lifetime_end_p0.Invoke(1L, &b3);
					Llvm_lifetime_end_p0.Invoke(1L, &b2);
					Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_BigInt_vtm4cw4);
					Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_BigInt_vtm4cw2);
					Llvm_lifetime_end_p0.Invoke(4L, &num9);
					Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_BigInt_vtm4cw);
					Llvm_lifetime_end_p0.Invoke(4L, &num8);
					Llvm_lifetime_end_p0.Invoke(4L, &num7);
					Llvm_lifetime_end_p0.Invoke(1L, &b);
				}
				Llvm_lifetime_end_p0.Invoke(4L, &num3);
				Llvm_lifetime_end_p0.Invoke(4L, &num2);
				Llvm_lifetime_end_p0.Invoke(4L, &num);
			}
			return result;
		}
	}
}
