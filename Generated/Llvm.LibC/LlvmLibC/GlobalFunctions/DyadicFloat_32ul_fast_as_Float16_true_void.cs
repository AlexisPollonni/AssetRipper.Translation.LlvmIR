using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class DyadicFloat_32ul_fast_as_Float16_true_void
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil11DyadicFloatILm32EE7fast_asIDF16_Lb1EvEET_v")]
	[DemangledName("_Float16 __llvm_libc_20_1_2_::fputil::DyadicFloat<32ul>::fast_as<_Float16, true, void>() const")]
	[return: NativeType("_Float16")]
	public unsafe static Half Invoke([MangledName("this")] void* This)
	{
		Fputil_FPBits_2fahva fputil_FPBits_2fahva = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		int num = 0;
		short num2 = 0;
		int num3 = 0;
		Half half = default(Half);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Half half2 = default(Half);
		Half half3 = default(Half);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva3 = default(Fputil_FPBits_2fahva);
		sbyte b = 0;
		int num4 = 0;
		int num5 = 0;
		BigInt_vtm4cw bigInt_vtm4cw = default(BigInt_vtm4cw);
		Half half4 = default(Half);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva4 = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		BigInt_vtm4cw bigInt_vtm4cw2 = default(BigInt_vtm4cw);
		BigInt_vtm4cw bigInt_vtm4cw3 = default(BigInt_vtm4cw);
		BigInt_vtm4cw bigInt_vtm4cw4 = default(BigInt_vtm4cw);
		BigInt_vtm4cw bigInt_vtm4cw5 = default(BigInt_vtm4cw);
		sbyte b2 = 0;
		BigInt_vtm4cw bigInt_vtm4cw6 = default(BigInt_vtm4cw);
		sbyte b3 = 0;
		BigInt_vtm4cw bigInt_vtm4cw7 = default(BigInt_vtm4cw);
		int num6 = 0;
		Half x = default(Half);
		int num7 = 0;
		Half half5 = default(Half);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva5 = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb4 = default(Anon_izyfb7);
		Half half6 = default(Half);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva6 = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb5 = default(Anon_izyfb7);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva7 = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb6 = default(Anon_izyfb7);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva8 = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb7 = default(Anon_izyfb7);
		Half half7 = default(Half);
		short num8 = 0;
		short num9 = 0;
		Fputil_FPBits_2fahva fputil_FPBits_2fahva9 = default(Fputil_FPBits_2fahva);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva10 = default(Fputil_FPBits_2fahva);
		unchecked
		{
			Half result;
			if (Details_expects_bool_condition_bool.Invoke(BigInt_32ul_false_unsigned_int_is_zero.Invoke(&((Fputil_DyadicFloat_cs3nhs*)This)->Mantissa), Expected: false))
			{
				Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, &((Fputil_DyadicFloat_cs3nhs*)This)->Sign, 1L, isVolatile: false);
				short field_ = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_zero.Invoke(anon_izyfb.Val);
				fputil_FPBits_2fahva.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
				result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva);
				Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva);
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num);
				num = 11;
				Llvm_lifetime_start_p0.Invoke(2L, &num2);
				num2 = 0;
				Llvm_lifetime_start_p0.Invoke(4L, &num3);
				checked
				{
					num3 = unchecked((Fputil_DyadicFloat_cs3nhs*)This)->Exponent + 46;
				}
				if (Details_expects_bool_condition_bool.Invoke(num3 > 30, Expected: false))
				{
					Llvm_lifetime_start_p0.Invoke(2L, &half);
					Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, &((Fputil_DyadicFloat_cs3nhs*)This)->Sign, 1L, isVolatile: false);
					short field_2 = FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_create_value.Invoke(anon_izyfb2.Val, 30, 0);
					fputil_FPBits_2fahva2.FPRepImpl.FPRepSem.FPStorage.field_0 = field_2;
					Half half8 = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva2);
					Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
					half = half8;
					Llvm_lifetime_start_p0.Invoke(2L, &half2);
					half2 = default(Half);
					Llvm_lifetime_start_p0.Invoke(2L, &half3);
					half3 = (Half)((float)half2 * (float)half);
					Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva3);
					FPBits_Float16_Constructor.Invoke(&fputil_FPBits_2fahva3, half3);
					bool num10 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_inf.Invoke((Fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva3));
					Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva3);
					if (num10)
					{
						Fputil_set_errno_if_required.Invoke(34);
					}
					result = half3;
					Llvm_lifetime_end_p0.Invoke(2L, &half3);
					Llvm_lifetime_end_p0.Invoke(2L, &half2);
					Llvm_lifetime_end_p0.Invoke(2L, &half);
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(1L, &b);
					b = 0;
					Llvm_lifetime_start_p0.Invoke(4L, &num4);
					num4 = 21;
					if (Details_expects_bool_condition_bool.Invoke(num3 <= 0, Expected: false))
					{
						b = 1;
						num4 = (int)(21L + (long)(uint)checked(1 - num3));
						num3 = 15;
					}
					Llvm_lifetime_start_p0.Invoke(4L, &num5);
					num5 = checked(num3 - 11 - 1);
					Llvm_lifetime_start_p0.Invoke(4L, &bigInt_vtm4cw);
					*(int*)(&bigInt_vtm4cw) = -1431655766;
					if ((ulong)(uint)num4 >= 32uL)
					{
						BigInt_32ul_false_unsigned_int_BigInt_int_void.Invoke(&bigInt_vtm4cw, 0);
					}
					else
					{
						int data = BigInt_32ul_false_unsigned_int_RightShift.Invoke(&((Fputil_DyadicFloat_cs3nhs*)This)->Mantissa, (uint)num4);
						*(int*)(&bigInt_vtm4cw.Val.Data) = data;
					}
					Llvm_lifetime_start_p0.Invoke(2L, &half4);
					Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva4);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb3, &((Fputil_DyadicFloat_cs3nhs*)This)->Sign, 1L, isVolatile: false);
					short field_3 = FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_create_value.Invoke(Biased_exp: (short)num3, Mantissa: (short)(((ushort)BigInt_32ul_false_unsigned_int_Unsigned_short_unsigned_short.Invoke(&bigInt_vtm4cw) & 0x3FF) | 0), Sign: anon_izyfb3.Val);
					fputil_FPBits_2fahva4.FPRepImpl.FPRepSem.FPStorage.field_0 = field_3;
					Half half9 = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva4);
					Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva4);
					half4 = half9;
					Llvm_lifetime_start_p0.Invoke(4L, &bigInt_vtm4cw2);
					*(int*)(&bigInt_vtm4cw2) = -1431655766;
					bool num11 = (ulong)(uint)num4 > 32uL;
					Llvm_lifetime_start_p0.Invoke(4L, &bigInt_vtm4cw3);
					if (num11)
					{
						BigInt_32ul_false_unsigned_int_BigInt_int_void.Invoke(&bigInt_vtm4cw2, 0);
					}
					else
					{
						BigInt_32ul_false_unsigned_int_BigInt_int_void.Invoke(&bigInt_vtm4cw3, 1);
						int data2 = BigInt_32ul_false_unsigned_int_LeftShift.Invoke(&bigInt_vtm4cw3, (uint)(num4 - 1));
						*(int*)(&bigInt_vtm4cw2.Val.Data) = data2;
					}
					Llvm_lifetime_end_p0.Invoke(4L, &bigInt_vtm4cw3);
					Llvm_lifetime_start_p0.Invoke(4L, &bigInt_vtm4cw4);
					*(int*)(&bigInt_vtm4cw4) = -1431655766;
					Llvm_lifetime_start_p0.Invoke(4L, &bigInt_vtm4cw5);
					BigInt_32ul_false_unsigned_int_BigInt_int_void.Invoke(&bigInt_vtm4cw5, 1);
					int data3 = BigInt_32ul_false_unsigned_int_Subtract.Invoke(&bigInt_vtm4cw2, &bigInt_vtm4cw5);
					*(int*)(&bigInt_vtm4cw4.Val.Data) = data3;
					Llvm_lifetime_end_p0.Invoke(4L, &bigInt_vtm4cw5);
					Llvm_lifetime_start_p0.Invoke(1L, &b2);
					Llvm_lifetime_start_p0.Invoke(4L, &bigInt_vtm4cw6);
					int data4 = BitwiseAnd.Invoke(&((Fputil_DyadicFloat_cs3nhs*)This)->Mantissa, &bigInt_vtm4cw2);
					*(int*)(&bigInt_vtm4cw6.Val.Data) = data4;
					bool num12 = InstructionHelper.BooleanXor(BigInt_32ul_false_unsigned_int_is_zero.Invoke(&bigInt_vtm4cw6), right: true);
					Llvm_lifetime_end_p0.Invoke(4L, &bigInt_vtm4cw6);
					b2 = (num12 ? ((sbyte)1) : ((sbyte)0));
					Llvm_lifetime_start_p0.Invoke(1L, &b3);
					Llvm_lifetime_start_p0.Invoke(4L, &bigInt_vtm4cw7);
					int data5 = BitwiseAnd.Invoke(&((Fputil_DyadicFloat_cs3nhs*)This)->Mantissa, &bigInt_vtm4cw4);
					*(int*)(&bigInt_vtm4cw7.Val.Data) = data5;
					bool num13 = InstructionHelper.BooleanXor(BigInt_32ul_false_unsigned_int_is_zero.Invoke(&bigInt_vtm4cw7), right: true);
					Llvm_lifetime_end_p0.Invoke(4L, &bigInt_vtm4cw7);
					b3 = (num13 ? ((sbyte)1) : ((sbyte)0));
					Llvm_lifetime_start_p0.Invoke(4L, &num6);
					num6 = checked((((b2 & 1) == 1) ? 1 : 0) * 2 + (((b3 & 1) == 1) ? 1 : 0));
					Llvm_lifetime_start_p0.Invoke(2L, &x);
					x = default(Half);
					if (Details_expects_bool_condition_bool.Invoke(num5 <= 0, Expected: false))
					{
						Llvm_lifetime_start_p0.Invoke(4L, &num7);
						num7 = checked(1 - num5);
						Llvm_lifetime_start_p0.Invoke(2L, &half5);
						Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva5);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb4, Sign_POS.Pointer, 1L, isVolatile: false);
						short field_4 = FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_create_value.Invoke(Biased_exp: (short)checked(15 + num7), Sign: anon_izyfb4.Val, Mantissa: 0);
						fputil_FPBits_2fahva5.FPRepImpl.FPRepSem.FPStorage.field_0 = field_4;
						Half half10 = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva5);
						Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva5);
						half5 = half10;
						Llvm_lifetime_start_p0.Invoke(2L, &half6);
						Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva6);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb5, Sign_POS.Pointer, 1L, isVolatile: false);
						short field_5 = FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_create_value.Invoke(Biased_exp: (short)checked(15 - num7), Sign: anon_izyfb5.Val, Mantissa: 0);
						fputil_FPBits_2fahva6.FPRepImpl.FPRepSem.FPStorage.field_0 = field_5;
						Half half11 = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva6);
						Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva6);
						half6 = half11;
						Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva7);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb6, &((Fputil_DyadicFloat_cs3nhs*)This)->Sign, 1L, isVolatile: false);
						short field_6 = FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_create_value.Invoke(Biased_exp: (short)checked(num5 + num7), Sign: anon_izyfb6.Val, Mantissa: 0);
						fputil_FPBits_2fahva7.FPRepImpl.FPRepSem.FPStorage.field_0 = field_6;
						x = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva7);
						Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva7);
						result = (Half)((float)Fputil_multiply_add_Float16.Invoke(x, (Half)num6, (Half)((float)half4 * (float)half5)) * (float)half6);
						Llvm_lifetime_end_p0.Invoke(2L, &half6);
						Llvm_lifetime_end_p0.Invoke(2L, &half5);
						Llvm_lifetime_end_p0.Invoke(4L, &num7);
					}
					else
					{
						Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva8);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb7, &((Fputil_DyadicFloat_cs3nhs*)This)->Sign, 1L, isVolatile: false);
						short field_7 = FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_create_value.Invoke(Biased_exp: (short)num5, Sign: anon_izyfb7.Val, Mantissa: 0);
						fputil_FPBits_2fahva8.FPRepImpl.FPRepSem.FPStorage.field_0 = field_7;
						x = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva8);
						Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva8);
						Llvm_lifetime_start_p0.Invoke(2L, &half7);
						half7 = Fputil_multiply_add_Float16.Invoke(x, (Half)num6, half4);
						if (Details_expects_bool_condition_bool.Invoke((b & 1) == 1, Expected: false))
						{
							Llvm_lifetime_start_p0.Invoke(2L, &num8);
							num8 = (short)((ushort)(short)num3 << 10);
							Llvm_lifetime_start_p0.Invoke(2L, &num9);
							Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva9);
							FPBits_Float16_Constructor.Invoke(&fputil_FPBits_2fahva9, half7);
							short num14 = (short)checked(unchecked((ushort)FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_uintval.Invoke((Fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva9))) - unchecked((ushort)num8));
							Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva9);
							num9 = num14;
							if (((ushort)num9 & 0x7C00) == 0)
							{
								num9 = (short)checked(unchecked((ushort)num9) - 0);
								if (num6 != 0)
								{
									Fputil_set_errno_if_required.Invoke(34);
									Fputil_raise_except_if_required.Invoke(16);
								}
							}
							Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva10);
							FPBits_Float16_FPBits_unsigned_short.Invoke(&fputil_FPBits_2fahva10, num9);
							result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva10);
							Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva10);
							Llvm_lifetime_end_p0.Invoke(2L, &num9);
							Llvm_lifetime_end_p0.Invoke(2L, &num8);
						}
						else
						{
							result = half7;
						}
						Llvm_lifetime_end_p0.Invoke(2L, &half7);
					}
					Llvm_lifetime_end_p0.Invoke(2L, &x);
					Llvm_lifetime_end_p0.Invoke(4L, &num6);
					Llvm_lifetime_end_p0.Invoke(1L, &b3);
					Llvm_lifetime_end_p0.Invoke(1L, &b2);
					Llvm_lifetime_end_p0.Invoke(4L, &bigInt_vtm4cw4);
					Llvm_lifetime_end_p0.Invoke(4L, &bigInt_vtm4cw2);
					Llvm_lifetime_end_p0.Invoke(2L, &half4);
					Llvm_lifetime_end_p0.Invoke(4L, &bigInt_vtm4cw);
					Llvm_lifetime_end_p0.Invoke(4L, &num5);
					Llvm_lifetime_end_p0.Invoke(4L, &num4);
					Llvm_lifetime_end_p0.Invoke(1L, &b);
				}
				Llvm_lifetime_end_p0.Invoke(4L, &num3);
				Llvm_lifetime_end_p0.Invoke(2L, &num2);
				Llvm_lifetime_end_p0.Invoke(4L, &num);
			}
			return result;
		}
	}
}
