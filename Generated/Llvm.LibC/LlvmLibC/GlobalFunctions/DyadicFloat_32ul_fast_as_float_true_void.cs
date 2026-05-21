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
	public unsafe static float Invoke(void* @this)
	{
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		float num4 = 0f;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		float num5 = 0f;
		float num6 = 0f;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs4 = default(fputil_FPBits_5nkvcs);
		sbyte b = 0;
		int num7 = 0;
		int num8 = 0;
		BigInt_vtm4cw bigInt_vtm4cw = default(BigInt_vtm4cw);
		float num9 = 0f;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs5 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		BigInt_vtm4cw bigInt_vtm4cw2 = default(BigInt_vtm4cw);
		BigInt_vtm4cw bigInt_vtm4cw3 = default(BigInt_vtm4cw);
		BigInt_vtm4cw bigInt_vtm4cw4 = default(BigInt_vtm4cw);
		BigInt_vtm4cw bigInt_vtm4cw5 = default(BigInt_vtm4cw);
		sbyte b2 = 0;
		BigInt_vtm4cw bigInt_vtm4cw6 = default(BigInt_vtm4cw);
		sbyte b3 = 0;
		BigInt_vtm4cw bigInt_vtm4cw7 = default(BigInt_vtm4cw);
		int num10 = 0;
		float x = 0f;
		int num11 = 0;
		float num12 = 0f;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs6 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb11 = default(anon_izyfb7);
		float num13 = 0f;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs7 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb12 = default(anon_izyfb7);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs8 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb13 = default(anon_izyfb7);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs9 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb14 = default(anon_izyfb7);
		float num14 = 0f;
		int num15 = 0;
		int num16 = 0;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs10 = default(fputil_FPBits_5nkvcs);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs11 = default(fputil_FPBits_5nkvcs);
		unchecked
		{
			float result;
			if (details_expects_bool_condition_bool.Invoke(BigInt_32ul_false_unsigned_int_is_zero.Invoke(&((fputil_DyadicFloat_cs3nhs*)@this)->mantissa), expected: false))
			{
				llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, &((fputil_DyadicFloat_cs3nhs*)@this)->sign, 1L, isVolatile: false);
				int field_ = FPRepSem_fputil_FPType_1_fputil_FPBits_float_zero.Invoke(anon_izyfb8.val);
				fputil_FPBits_5nkvcs2.FPRepImpl.FPRepSem.field_0.field_0 = field_;
				result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs2);
				llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(4L, &num);
				num = 24;
				llvm_lifetime_start_p0.Invoke(4L, &num2);
				num2 = 0;
				llvm_lifetime_start_p0.Invoke(4L, &num3);
				checked
				{
					num3 = unchecked((fputil_DyadicFloat_cs3nhs*)@this)->exponent + 158;
				}
				if (details_expects_bool_condition_bool.Invoke(num3 > 254, expected: false))
				{
					llvm_lifetime_start_p0.Invoke(4L, &num4);
					llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, &((fputil_DyadicFloat_cs3nhs*)@this)->sign, 1L, isVolatile: false);
					int field_2 = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_create_value.Invoke(anon_izyfb9.val, 254, 0);
					fputil_FPBits_5nkvcs3.FPRepImpl.FPRepSem.field_0.field_0 = field_2;
					float num17 = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs3);
					llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
					num4 = num17;
					llvm_lifetime_start_p0.Invoke(4L, &num5);
					num5 = 2f;
					llvm_lifetime_start_p0.Invoke(4L, &num6);
					num6 = num5 * num4;
					llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
					FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs4, num6);
					bool num18 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_inf.Invoke(&fputil_FPBits_5nkvcs4);
					llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
					if (num18)
					{
						fputil_set_errno_if_required.Invoke(34);
					}
					result = num6;
					llvm_lifetime_end_p0.Invoke(4L, &num6);
					llvm_lifetime_end_p0.Invoke(4L, &num5);
					llvm_lifetime_end_p0.Invoke(4L, &num4);
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(1L, &b);
					b = 0;
					llvm_lifetime_start_p0.Invoke(4L, &num7);
					num7 = 8;
					if (details_expects_bool_condition_bool.Invoke(num3 <= 0, expected: false))
					{
						b = 1;
						num7 = (int)(8L + (long)(uint)checked(1 - num3));
						num3 = 127;
					}
					llvm_lifetime_start_p0.Invoke(4L, &num8);
					num8 = checked(num3 - 24 - 1);
					llvm_lifetime_start_p0.Invoke(4L, &bigInt_vtm4cw);
					*(int*)(&bigInt_vtm4cw) = -1431655766;
					if ((ulong)(uint)num7 >= 32uL)
					{
						BigInt_32ul_false_unsigned_int_BigInt_int_void.Invoke(&bigInt_vtm4cw, 0);
					}
					else
					{
						int data = BigInt_32ul_false_unsigned_int_RightShift.Invoke(&((fputil_DyadicFloat_cs3nhs*)@this)->mantissa, (uint)num7);
						*(int*)(&bigInt_vtm4cw.val.Data) = data;
					}
					llvm_lifetime_start_p0.Invoke(4L, &num9);
					llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs5);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb10, &((fputil_DyadicFloat_cs3nhs*)@this)->sign, 1L, isVolatile: false);
					int field_3 = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_create_value.Invoke(biased_exp: num3, mantissa: (BigInt_32ul_false_unsigned_int_unsigned_int_unsigned_int.Invoke(&bigInt_vtm4cw) & 0x7FFFFF) | 0, sign: anon_izyfb10.val);
					fputil_FPBits_5nkvcs5.FPRepImpl.FPRepSem.field_0.field_0 = field_3;
					float num19 = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs5);
					llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs5);
					num9 = num19;
					llvm_lifetime_start_p0.Invoke(4L, &bigInt_vtm4cw2);
					*(int*)(&bigInt_vtm4cw2) = -1431655766;
					bool num20 = (ulong)(uint)num7 > 32uL;
					llvm_lifetime_start_p0.Invoke(4L, &bigInt_vtm4cw3);
					if (num20)
					{
						BigInt_32ul_false_unsigned_int_BigInt_int_void.Invoke(&bigInt_vtm4cw2, 0);
					}
					else
					{
						BigInt_32ul_false_unsigned_int_BigInt_int_void.Invoke(&bigInt_vtm4cw3, 1);
						int data2 = BigInt_32ul_false_unsigned_int_LeftShift.Invoke(&bigInt_vtm4cw3, (uint)(num7 - 1));
						*(int*)(&bigInt_vtm4cw2.val.Data) = data2;
					}
					llvm_lifetime_end_p0.Invoke(4L, &bigInt_vtm4cw3);
					llvm_lifetime_start_p0.Invoke(4L, &bigInt_vtm4cw4);
					*(int*)(&bigInt_vtm4cw4) = -1431655766;
					llvm_lifetime_start_p0.Invoke(4L, &bigInt_vtm4cw5);
					BigInt_32ul_false_unsigned_int_BigInt_int_void.Invoke(&bigInt_vtm4cw5, 1);
					int data3 = BigInt_32ul_false_unsigned_int_Subtract.Invoke(&bigInt_vtm4cw2, &bigInt_vtm4cw5);
					*(int*)(&bigInt_vtm4cw4.val.Data) = data3;
					llvm_lifetime_end_p0.Invoke(4L, &bigInt_vtm4cw5);
					llvm_lifetime_start_p0.Invoke(1L, &b2);
					llvm_lifetime_start_p0.Invoke(4L, &bigInt_vtm4cw6);
					int data4 = BitwiseAnd.Invoke(&((fputil_DyadicFloat_cs3nhs*)@this)->mantissa, &bigInt_vtm4cw2);
					*(int*)(&bigInt_vtm4cw6.val.Data) = data4;
					int num21 = (BigInt_32ul_false_unsigned_int_is_zero.Invoke(&bigInt_vtm4cw6) ? 1 : 0) ^ -1;
					llvm_lifetime_end_p0.Invoke(4L, &bigInt_vtm4cw6);
					b2 = (sbyte)(byte)num21;
					llvm_lifetime_start_p0.Invoke(1L, &b3);
					llvm_lifetime_start_p0.Invoke(4L, &bigInt_vtm4cw7);
					int data5 = BitwiseAnd.Invoke(&((fputil_DyadicFloat_cs3nhs*)@this)->mantissa, &bigInt_vtm4cw4);
					*(int*)(&bigInt_vtm4cw7.val.Data) = data5;
					int num22 = (BigInt_32ul_false_unsigned_int_is_zero.Invoke(&bigInt_vtm4cw7) ? 1 : 0) ^ -1;
					llvm_lifetime_end_p0.Invoke(4L, &bigInt_vtm4cw7);
					b3 = (sbyte)(byte)num22;
					llvm_lifetime_start_p0.Invoke(4L, &num10);
					num10 = checked((((b2 & 1) == 1) ? 1 : 0) * 2 + (((b3 & 1) == 1) ? 1 : 0));
					llvm_lifetime_start_p0.Invoke(4L, &x);
					x = float.NaN;
					if (details_expects_bool_condition_bool.Invoke(num8 <= 0, expected: false))
					{
						llvm_lifetime_start_p0.Invoke(4L, &num11);
						checked
						{
							num11 = 1 - num8;
							llvm_lifetime_start_p0.Invoke(4L, &num12);
							llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs6);
							llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb11, Sign_POS.Pointer, 1L, isVolatile: false);
							int field_4 = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_create_value.Invoke(biased_exp: 127 + num11, sign: anon_izyfb11.val, mantissa: 0);
							fputil_FPBits_5nkvcs6.FPRepImpl.FPRepSem.field_0.field_0 = field_4;
							float num23 = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs6);
							llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs6);
							num12 = num23;
							llvm_lifetime_start_p0.Invoke(4L, &num13);
							llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs7);
							llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb12, Sign_POS.Pointer, 1L, isVolatile: false);
							int field_5 = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_create_value.Invoke(biased_exp: 127 - num11, sign: anon_izyfb12.val, mantissa: 0);
							fputil_FPBits_5nkvcs7.FPRepImpl.FPRepSem.field_0.field_0 = field_5;
							float num24 = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs7);
							llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs7);
							num13 = num24;
							llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs8);
							llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb13, &unchecked((fputil_DyadicFloat_cs3nhs*)@this)->sign, 1L, isVolatile: false);
							int field_6 = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_create_value.Invoke(biased_exp: num8 + num11, sign: anon_izyfb13.val, mantissa: 0);
							fputil_FPBits_5nkvcs8.FPRepImpl.FPRepSem.field_0.field_0 = field_6;
							x = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs8);
							llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs8);
							result = fputil_multiply_add_float.Invoke(x, num10, num9 * num12) * num13;
							llvm_lifetime_end_p0.Invoke(4L, &num13);
							llvm_lifetime_end_p0.Invoke(4L, &num12);
							llvm_lifetime_end_p0.Invoke(4L, &num11);
						}
					}
					else
					{
						llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs9);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb14, &((fputil_DyadicFloat_cs3nhs*)@this)->sign, 1L, isVolatile: false);
						int field_7 = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_create_value.Invoke(biased_exp: num8, sign: anon_izyfb14.val, mantissa: 0);
						fputil_FPBits_5nkvcs9.FPRepImpl.FPRepSem.field_0.field_0 = field_7;
						x = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs9);
						llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs9);
						llvm_lifetime_start_p0.Invoke(4L, &num14);
						num14 = fputil_multiply_add_float.Invoke(x, num10, num9);
						if (details_expects_bool_condition_bool.Invoke((b & 1) == 1, expected: false))
						{
							llvm_lifetime_start_p0.Invoke(4L, &num15);
							num15 = num3 << 23;
							llvm_lifetime_start_p0.Invoke(4L, &num16);
							llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs10);
							FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs10, num14);
							int num25 = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs10)) - num15;
							llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs10);
							num16 = num25;
							if ((num16 & 0x7F800000) == 0)
							{
								num16 -= 0;
								if (num10 != 0)
								{
									fputil_set_errno_if_required.Invoke(34);
									fputil_raise_except_if_required.Invoke(16);
								}
							}
							llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs11);
							FPBits_float_FPBits_unsigned_int.Invoke(&fputil_FPBits_5nkvcs11, num16);
							result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs11);
							llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs11);
							llvm_lifetime_end_p0.Invoke(4L, &num16);
							llvm_lifetime_end_p0.Invoke(4L, &num15);
						}
						else
						{
							result = num14;
						}
						llvm_lifetime_end_p0.Invoke(4L, &num14);
					}
					llvm_lifetime_end_p0.Invoke(4L, &x);
					llvm_lifetime_end_p0.Invoke(4L, &num10);
					llvm_lifetime_end_p0.Invoke(1L, &b3);
					llvm_lifetime_end_p0.Invoke(1L, &b2);
					llvm_lifetime_end_p0.Invoke(4L, &bigInt_vtm4cw4);
					llvm_lifetime_end_p0.Invoke(4L, &bigInt_vtm4cw2);
					llvm_lifetime_end_p0.Invoke(4L, &num9);
					llvm_lifetime_end_p0.Invoke(4L, &bigInt_vtm4cw);
					llvm_lifetime_end_p0.Invoke(4L, &num8);
					llvm_lifetime_end_p0.Invoke(4L, &num7);
					llvm_lifetime_end_p0.Invoke(1L, &b);
				}
				llvm_lifetime_end_p0.Invoke(4L, &num3);
				llvm_lifetime_end_p0.Invoke(4L, &num2);
				llvm_lifetime_end_p0.Invoke(4L, &num);
			}
			return result;
		}
	}
}
