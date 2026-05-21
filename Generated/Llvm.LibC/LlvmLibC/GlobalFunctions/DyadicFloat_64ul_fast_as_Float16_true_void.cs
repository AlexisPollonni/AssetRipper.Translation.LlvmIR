using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class DyadicFloat_64ul_fast_as_Float16_true_void
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil11DyadicFloatILm64EE7fast_asIDF16_Lb1EvEET_v")]
	[DemangledName("_Float16 __llvm_libc_20_1_2_::fputil::DyadicFloat<64ul>::fast_as<_Float16, true, void>() const")]
	[return: NativeType("_Float16")]
	public unsafe static Half Invoke([MangledName("this")] Llvm_libc_20_1_2_fputil_DyadicFloat_syracv* This)
	{
		Llvm_libc_20_1_2_fputil_FPBits_2fahva llvm_libc_20_1_2_fputil_FPBits_2fahva = default(Llvm_libc_20_1_2_fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		int num = 0;
		short num2 = 0;
		int num3 = 0;
		Half half = default(Half);
		Llvm_libc_20_1_2_fputil_FPBits_2fahva llvm_libc_20_1_2_fputil_FPBits_2fahva2 = default(Llvm_libc_20_1_2_fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Half half2 = default(Half);
		Half half3 = default(Half);
		Llvm_libc_20_1_2_fputil_FPBits_2fahva llvm_libc_20_1_2_fputil_FPBits_2fahva3 = default(Llvm_libc_20_1_2_fputil_FPBits_2fahva);
		sbyte b = 0;
		int num4 = 0;
		int num5 = 0;
		Llvm_libc_20_1_2_BigInt_555ggs llvm_libc_20_1_2_BigInt_555ggs = default(Llvm_libc_20_1_2_BigInt_555ggs);
		Half half4 = default(Half);
		Llvm_libc_20_1_2_fputil_FPBits_2fahva llvm_libc_20_1_2_fputil_FPBits_2fahva4 = default(Llvm_libc_20_1_2_fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_BigInt_555ggs llvm_libc_20_1_2_BigInt_555ggs2 = default(Llvm_libc_20_1_2_BigInt_555ggs);
		Llvm_libc_20_1_2_BigInt_555ggs llvm_libc_20_1_2_BigInt_555ggs3 = default(Llvm_libc_20_1_2_BigInt_555ggs);
		Llvm_libc_20_1_2_BigInt_555ggs llvm_libc_20_1_2_BigInt_555ggs4 = default(Llvm_libc_20_1_2_BigInt_555ggs);
		Llvm_libc_20_1_2_BigInt_555ggs llvm_libc_20_1_2_BigInt_555ggs5 = default(Llvm_libc_20_1_2_BigInt_555ggs);
		sbyte b2 = 0;
		Llvm_libc_20_1_2_BigInt_555ggs llvm_libc_20_1_2_BigInt_555ggs6 = default(Llvm_libc_20_1_2_BigInt_555ggs);
		sbyte b3 = 0;
		Llvm_libc_20_1_2_BigInt_555ggs llvm_libc_20_1_2_BigInt_555ggs7 = default(Llvm_libc_20_1_2_BigInt_555ggs);
		int num6 = 0;
		Half x = default(Half);
		int num7 = 0;
		Half half5 = default(Half);
		Llvm_libc_20_1_2_fputil_FPBits_2fahva llvm_libc_20_1_2_fputil_FPBits_2fahva5 = default(Llvm_libc_20_1_2_fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb4 = default(Anon_izyfb7);
		Half half6 = default(Half);
		Llvm_libc_20_1_2_fputil_FPBits_2fahva llvm_libc_20_1_2_fputil_FPBits_2fahva6 = default(Llvm_libc_20_1_2_fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb5 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_2fahva llvm_libc_20_1_2_fputil_FPBits_2fahva7 = default(Llvm_libc_20_1_2_fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb6 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_2fahva llvm_libc_20_1_2_fputil_FPBits_2fahva8 = default(Llvm_libc_20_1_2_fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb7 = default(Anon_izyfb7);
		Half half7 = default(Half);
		short num8 = 0;
		short num9 = 0;
		Llvm_libc_20_1_2_fputil_FPBits_2fahva llvm_libc_20_1_2_fputil_FPBits_2fahva9 = default(Llvm_libc_20_1_2_fputil_FPBits_2fahva);
		Llvm_libc_20_1_2_fputil_FPBits_2fahva llvm_libc_20_1_2_fputil_FPBits_2fahva10 = default(Llvm_libc_20_1_2_fputil_FPBits_2fahva);
		Half result;
		if (Details_expects_bool_condition_bool.Invoke(BigInt_64ul_false_unsigned_long_is_zero.Invoke(&This->Mantissa), Expected: false))
		{
			Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva);
			Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, &This->Sign, 1L, isVolatile: false);
			short field_ = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_zero.Invoke(anon_izyfb.Val);
			llvm_libc_20_1_2_fputil_FPBits_2fahva.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
			result = FPBits_Float16_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva);
			Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva);
		}
		else
		{
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = 11;
			Llvm_lifetime_start_p0.Invoke(2L, &num2);
			num2 = 0;
			Llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = This->Exponent + 78;
			unchecked
			{
				if (Details_expects_bool_condition_bool.Invoke(num3 > 30, Expected: false))
				{
					Llvm_lifetime_start_p0.Invoke(2L, &half);
					Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva2);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, &This->Sign, 1L, isVolatile: false);
					short field_2 = FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_create_value.Invoke(anon_izyfb2.Val, 30, 0);
					llvm_libc_20_1_2_fputil_FPBits_2fahva2.FPRepImpl.FPRepSem.FPStorage.field_0 = field_2;
					Half half8 = FPBits_Float16_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva2);
					Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva2);
					half = half8;
					Llvm_lifetime_start_p0.Invoke(2L, &half2);
					half2 = default(Half);
					Llvm_lifetime_start_p0.Invoke(2L, &half3);
					half3 = (Half)((float)half2 * (float)half);
					Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva3);
					FPBits_Float16_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva3, half3);
					bool num10 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_inf.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_i7nz4h*)(&llvm_libc_20_1_2_fputil_FPBits_2fahva3));
					Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva3);
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
					num4 = 53;
					if (Details_expects_bool_condition_bool.Invoke(num3 <= 0, Expected: false))
					{
						b = 1;
						num4 = (int)(53L + (long)(uint)checked(1 - num3));
						num3 = 15;
					}
					Llvm_lifetime_start_p0.Invoke(4L, &num5);
					num5 = checked(num3 - 11 - 1);
					Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_BigInt_555ggs);
					*(long*)(&llvm_libc_20_1_2_BigInt_555ggs) = -6148914691236517206L;
					if ((ulong)(uint)num4 >= 64uL)
					{
						BigInt_64ul_false_unsigned_long_BigInt_int_void.Invoke(&llvm_libc_20_1_2_BigInt_555ggs, 0);
					}
					else
					{
						long data = BigInt_64ul_false_unsigned_long_RightShift.Invoke(&This->Mantissa, (uint)num4);
						*(long*)(&llvm_libc_20_1_2_BigInt_555ggs.Val.Data) = data;
					}
					Llvm_lifetime_start_p0.Invoke(2L, &half4);
					Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva4);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb3, &This->Sign, 1L, isVolatile: false);
					short field_3 = FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_create_value.Invoke(Biased_exp: (short)num3, Mantissa: (short)(((ushort)BigInt_64ul_false_unsigned_long_Unsigned_short_unsigned_short.Invoke(&llvm_libc_20_1_2_BigInt_555ggs) & 0x3FF) | 0), Sign: anon_izyfb3.Val);
					llvm_libc_20_1_2_fputil_FPBits_2fahva4.FPRepImpl.FPRepSem.FPStorage.field_0 = field_3;
					Half half9 = FPBits_Float16_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva4);
					Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva4);
					half4 = half9;
					Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_BigInt_555ggs2);
					*(long*)(&llvm_libc_20_1_2_BigInt_555ggs2) = -6148914691236517206L;
					bool num11 = (ulong)(uint)num4 > 64uL;
					Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_BigInt_555ggs3);
					if (num11)
					{
						BigInt_64ul_false_unsigned_long_BigInt_int_void.Invoke(&llvm_libc_20_1_2_BigInt_555ggs2, 0);
					}
					else
					{
						BigInt_64ul_false_unsigned_long_BigInt_int_void.Invoke(&llvm_libc_20_1_2_BigInt_555ggs3, 1);
						long data2 = BigInt_64ul_false_unsigned_long_LeftShift.Invoke(&llvm_libc_20_1_2_BigInt_555ggs3, (uint)(num4 - 1));
						*(long*)(&llvm_libc_20_1_2_BigInt_555ggs2.Val.Data) = data2;
					}
					Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_BigInt_555ggs3);
					Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_BigInt_555ggs4);
					*(long*)(&llvm_libc_20_1_2_BigInt_555ggs4) = -6148914691236517206L;
					Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_BigInt_555ggs5);
					BigInt_64ul_false_unsigned_long_BigInt_int_void.Invoke(&llvm_libc_20_1_2_BigInt_555ggs5, 1);
					long data3 = BigInt_64ul_false_unsigned_long_Subtract_dhppwb.Invoke(&llvm_libc_20_1_2_BigInt_555ggs2, &llvm_libc_20_1_2_BigInt_555ggs5);
					*(long*)(&llvm_libc_20_1_2_BigInt_555ggs4.Val.Data) = data3;
					Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_BigInt_555ggs5);
					Llvm_lifetime_start_p0.Invoke(1L, &b2);
					Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_BigInt_555ggs6);
					long data4 = Llvm_libc_20_1_2_BitwiseAnd.Invoke(&This->Mantissa, &llvm_libc_20_1_2_BigInt_555ggs2);
					*(long*)(&llvm_libc_20_1_2_BigInt_555ggs6.Val.Data) = data4;
					int num12 = (BigInt_64ul_false_unsigned_long_is_zero.Invoke(&llvm_libc_20_1_2_BigInt_555ggs6) ? 1 : 0) ^ -1;
					Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_BigInt_555ggs6);
					b2 = (sbyte)(byte)num12;
					Llvm_lifetime_start_p0.Invoke(1L, &b3);
					Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_BigInt_555ggs7);
					long data5 = Llvm_libc_20_1_2_BitwiseAnd.Invoke(&This->Mantissa, &llvm_libc_20_1_2_BigInt_555ggs4);
					*(long*)(&llvm_libc_20_1_2_BigInt_555ggs7.Val.Data) = data5;
					int num13 = (BigInt_64ul_false_unsigned_long_is_zero.Invoke(&llvm_libc_20_1_2_BigInt_555ggs7) ? 1 : 0) ^ -1;
					Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_BigInt_555ggs7);
					b3 = (sbyte)(byte)num13;
					Llvm_lifetime_start_p0.Invoke(4L, &num6);
					num6 = checked((((b2 & 1) == 1) ? 1 : 0) * 2 + (((b3 & 1) == 1) ? 1 : 0));
					Llvm_lifetime_start_p0.Invoke(2L, &x);
					x = default(Half);
					if (Details_expects_bool_condition_bool.Invoke(num5 <= 0, Expected: false))
					{
						Llvm_lifetime_start_p0.Invoke(4L, &num7);
						num7 = checked(1 - num5);
						Llvm_lifetime_start_p0.Invoke(2L, &half5);
						Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva5);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb4, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
						short field_4 = FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_create_value.Invoke(Biased_exp: (short)checked(15 + num7), Sign: anon_izyfb4.Val, Mantissa: 0);
						llvm_libc_20_1_2_fputil_FPBits_2fahva5.FPRepImpl.FPRepSem.FPStorage.field_0 = field_4;
						Half half10 = FPBits_Float16_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva5);
						Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva5);
						half5 = half10;
						Llvm_lifetime_start_p0.Invoke(2L, &half6);
						Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva6);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb5, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
						short field_5 = FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_create_value.Invoke(Biased_exp: (short)checked(15 - num7), Sign: anon_izyfb5.Val, Mantissa: 0);
						llvm_libc_20_1_2_fputil_FPBits_2fahva6.FPRepImpl.FPRepSem.FPStorage.field_0 = field_5;
						Half half11 = FPBits_Float16_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva6);
						Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva6);
						half6 = half11;
						Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva7);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb6, &This->Sign, 1L, isVolatile: false);
						short field_6 = FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_create_value.Invoke(Biased_exp: (short)checked(num5 + num7), Sign: anon_izyfb6.Val, Mantissa: 0);
						llvm_libc_20_1_2_fputil_FPBits_2fahva7.FPRepImpl.FPRepSem.FPStorage.field_0 = field_6;
						x = FPBits_Float16_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva7);
						Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva7);
						result = (Half)((float)Fputil_multiply_add_Float16.Invoke(x, (Half)num6, (Half)((float)half4 * (float)half5)) * (float)half6);
						Llvm_lifetime_end_p0.Invoke(2L, &half6);
						Llvm_lifetime_end_p0.Invoke(2L, &half5);
						Llvm_lifetime_end_p0.Invoke(4L, &num7);
					}
					else
					{
						Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva8);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb7, &This->Sign, 1L, isVolatile: false);
						short field_7 = FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_create_value.Invoke(Biased_exp: (short)num5, Sign: anon_izyfb7.Val, Mantissa: 0);
						llvm_libc_20_1_2_fputil_FPBits_2fahva8.FPRepImpl.FPRepSem.FPStorage.field_0 = field_7;
						x = FPBits_Float16_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva8);
						Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva8);
						Llvm_lifetime_start_p0.Invoke(2L, &half7);
						half7 = Fputil_multiply_add_Float16.Invoke(x, (Half)num6, half4);
						if (Details_expects_bool_condition_bool.Invoke((b & 1) == 1, Expected: false))
						{
							Llvm_lifetime_start_p0.Invoke(2L, &num8);
							num8 = (short)((ushort)(short)num3 << 10);
							Llvm_lifetime_start_p0.Invoke(2L, &num9);
							Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva9);
							FPBits_Float16_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva9, half7);
							short num14 = (short)checked(unchecked((ushort)FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_7z3gh9*)(&llvm_libc_20_1_2_fputil_FPBits_2fahva9))) - unchecked((ushort)num8));
							Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva9);
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
							Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva10);
							FPBits_Float16_FPBits_unsigned_short.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva10, num9);
							result = FPBits_Float16_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva10);
							Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva10);
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
					Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_BigInt_555ggs4);
					Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_BigInt_555ggs2);
					Llvm_lifetime_end_p0.Invoke(2L, &half4);
					Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_BigInt_555ggs);
					Llvm_lifetime_end_p0.Invoke(4L, &num5);
					Llvm_lifetime_end_p0.Invoke(4L, &num4);
					Llvm_lifetime_end_p0.Invoke(1L, &b);
				}
				Llvm_lifetime_end_p0.Invoke(4L, &num3);
				Llvm_lifetime_end_p0.Invoke(2L, &num2);
				Llvm_lifetime_end_p0.Invoke(4L, &num);
			}
		}
		return result;
	}
}
