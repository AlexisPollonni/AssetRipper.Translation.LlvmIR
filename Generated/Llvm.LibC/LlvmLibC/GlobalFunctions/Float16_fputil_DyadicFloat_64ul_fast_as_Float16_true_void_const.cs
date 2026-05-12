using System;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil11DyadicFloatILm64EE7fast_asIDF16_Lb1EvEET_v")]
[DemangledName("_Float16 __llvm_libc_20_1_2_::fputil::DyadicFloat<64ul>::fast_as<_Float16, true, void>() const")]
internal static partial class Float16_fputil_DyadicFloat_64ul_fast_as_Float16_true_void_const
{
	public unsafe static Half Invoke(fputil_DyadicFloat_374hpp* @this)
	{
		fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		int num = 0;
		short num2 = 0;
		int num3 = 0;
		Half half = default(Half);
		fputil_FPBits_2fahva fputil_FPBits_2fahva3 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		Half half2 = default(Half);
		Half half3 = default(Half);
		fputil_FPBits_2fahva fputil_FPBits_2fahva4 = default(fputil_FPBits_2fahva);
		sbyte b = 0;
		int num4 = 0;
		int num5 = 0;
		BigInt_nx6qdt bigInt_nx6qdt = default(BigInt_nx6qdt);
		Half half4 = default(Half);
		fputil_FPBits_2fahva fputil_FPBits_2fahva5 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		BigInt_nx6qdt bigInt_nx6qdt2 = default(BigInt_nx6qdt);
		BigInt_nx6qdt bigInt_nx6qdt3 = default(BigInt_nx6qdt);
		BigInt_nx6qdt bigInt_nx6qdt4 = default(BigInt_nx6qdt);
		BigInt_nx6qdt bigInt_nx6qdt5 = default(BigInt_nx6qdt);
		sbyte b2 = 0;
		BigInt_nx6qdt bigInt_nx6qdt6 = default(BigInt_nx6qdt);
		sbyte b3 = 0;
		BigInt_nx6qdt bigInt_nx6qdt7 = default(BigInt_nx6qdt);
		int num6 = 0;
		Half x = default(Half);
		int num7 = 0;
		Half half5 = default(Half);
		fputil_FPBits_2fahva fputil_FPBits_2fahva6 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb11 = default(anon_izyfb7);
		Half half6 = default(Half);
		fputil_FPBits_2fahva fputil_FPBits_2fahva7 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb12 = default(anon_izyfb7);
		fputil_FPBits_2fahva fputil_FPBits_2fahva8 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb13 = default(anon_izyfb7);
		fputil_FPBits_2fahva fputil_FPBits_2fahva9 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb14 = default(anon_izyfb7);
		Half half7 = default(Half);
		short num8 = 0;
		short num9 = 0;
		fputil_FPBits_2fahva fputil_FPBits_2fahva10 = default(fputil_FPBits_2fahva);
		fputil_FPBits_2fahva fputil_FPBits_2fahva11 = default(fputil_FPBits_2fahva);
		Half result;
		if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(BigInt_64ul_false_unsigned_long_is_zero_const.Invoke(&@this->mantissa), expected: false))
		{
			llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
			llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, &@this->sign, 1L, isVolatile: false);
			short field_ = fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_zero_Sign.Invoke(anon_izyfb8.val);
			fputil_FPBits_2fahva2.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
			result = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva2);
			llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
		}
		else
		{
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = 11;
			llvm_lifetime_start_p0.Invoke(2L, &num2);
			num2 = 0;
			llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = @this->exponent + 78;
			unchecked
			{
				if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(num3 > 30, expected: false))
				{
					llvm_lifetime_start_p0.Invoke(2L, &half);
					llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva3);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, &@this->sign, 1L, isVolatile: false);
					short field_2 = fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_create_value_Sign_unsigned_short_unsigned_short.Invoke(anon_izyfb9.val, 30, 0);
					fputil_FPBits_2fahva3.FPRepImpl.FPRepSem.FPStorage.field_0 = field_2;
					Half half8 = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva3);
					llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva3);
					half = half8;
					llvm_lifetime_start_p0.Invoke(2L, &half2);
					half2 = default(Half);
					llvm_lifetime_start_p0.Invoke(2L, &half3);
					half3 = (Half)((float)half2 * (float)half);
					llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva4);
					fputil_FPBits_Float16_FPBits_Float16_Float16.Invoke(&fputil_FPBits_2fahva4, half3);
					bool num10 = fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_inf_const.Invoke((fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva4));
					llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva4);
					if (num10)
					{
						fputil_set_errno_if_required_int.Invoke(34);
					}
					result = half3;
					llvm_lifetime_end_p0.Invoke(2L, &half3);
					llvm_lifetime_end_p0.Invoke(2L, &half2);
					llvm_lifetime_end_p0.Invoke(2L, &half);
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(1L, &b);
					b = 0;
					llvm_lifetime_start_p0.Invoke(4L, &num4);
					num4 = 53;
					if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(num3 <= 0, expected: false))
					{
						b = 1;
						num4 = (int)(53L + (long)(uint)checked(1 - num3));
						num3 = 15;
					}
					llvm_lifetime_start_p0.Invoke(4L, &num5);
					num5 = checked(num3 - 11 - 1);
					llvm_lifetime_start_p0.Invoke(8L, &bigInt_nx6qdt);
					*(long*)(&bigInt_nx6qdt) = -6148914691236517206L;
					if ((ulong)(uint)num4 >= 64uL)
					{
						BigInt_64ul_false_unsigned_long_BigInt_int_void_int.Invoke(&bigInt_nx6qdt, 0);
					}
					else
					{
						long data = BigInt_64ul_false_unsigned_long_operator_unsigned_long_const_5vdftb.Invoke(&@this->mantissa, (uint)num4);
						*(long*)(&bigInt_nx6qdt.val.Data) = data;
					}
					llvm_lifetime_start_p0.Invoke(2L, &half4);
					llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva5);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb10, &@this->sign, 1L, isVolatile: false);
					short field_3 = fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_create_value_Sign_unsigned_short_unsigned_short.Invoke(biased_exp: (short)num3, mantissa: (short)(((ushort)BigInt_64ul_false_unsigned_long_operator_unsigned_short_unsigned_short_const.Invoke(&bigInt_nx6qdt) & 0x3FF) | 0), sign: anon_izyfb10.val);
					fputil_FPBits_2fahva5.FPRepImpl.FPRepSem.FPStorage.field_0 = field_3;
					Half half9 = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva5);
					llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva5);
					half4 = half9;
					llvm_lifetime_start_p0.Invoke(8L, &bigInt_nx6qdt2);
					*(long*)(&bigInt_nx6qdt2) = -6148914691236517206L;
					bool num11 = (ulong)(uint)num4 > 64uL;
					llvm_lifetime_start_p0.Invoke(8L, &bigInt_nx6qdt3);
					if (num11)
					{
						BigInt_64ul_false_unsigned_long_BigInt_int_void_int.Invoke(&bigInt_nx6qdt2, 0);
					}
					else
					{
						BigInt_64ul_false_unsigned_long_BigInt_int_void_int.Invoke(&bigInt_nx6qdt3, 1);
						long data2 = BigInt_64ul_false_unsigned_long_operator_unsigned_long_const_vswmz5.Invoke(&bigInt_nx6qdt3, (uint)(num4 - 1));
						*(long*)(&bigInt_nx6qdt2.val.Data) = data2;
					}
					llvm_lifetime_end_p0.Invoke(8L, &bigInt_nx6qdt3);
					llvm_lifetime_start_p0.Invoke(8L, &bigInt_nx6qdt4);
					*(long*)(&bigInt_nx6qdt4) = -6148914691236517206L;
					llvm_lifetime_start_p0.Invoke(8L, &bigInt_nx6qdt5);
					BigInt_64ul_false_unsigned_long_BigInt_int_void_int.Invoke(&bigInt_nx6qdt5, 1);
					long data3 = BigInt_64ul_false_unsigned_long_operator_BigInt_64ul_false_unsigned_long_const_dhppwb.Invoke(&bigInt_nx6qdt2, &bigInt_nx6qdt5);
					*(long*)(&bigInt_nx6qdt4.val.Data) = data3;
					llvm_lifetime_end_p0.Invoke(8L, &bigInt_nx6qdt5);
					llvm_lifetime_start_p0.Invoke(1L, &b2);
					llvm_lifetime_start_p0.Invoke(8L, &bigInt_nx6qdt6);
					long data4 = operator_BigInt_64ul_false_unsigned_long_const_BigInt_64ul_false_unsigned_long_const_ufy43f.Invoke(&@this->mantissa, &bigInt_nx6qdt2);
					*(long*)(&bigInt_nx6qdt6.val.Data) = data4;
					int num12 = (BigInt_64ul_false_unsigned_long_is_zero_const.Invoke(&bigInt_nx6qdt6) ? 1 : 0) ^ -1;
					llvm_lifetime_end_p0.Invoke(8L, &bigInt_nx6qdt6);
					b2 = (sbyte)(byte)num12;
					llvm_lifetime_start_p0.Invoke(1L, &b3);
					llvm_lifetime_start_p0.Invoke(8L, &bigInt_nx6qdt7);
					long data5 = operator_BigInt_64ul_false_unsigned_long_const_BigInt_64ul_false_unsigned_long_const_ufy43f.Invoke(&@this->mantissa, &bigInt_nx6qdt4);
					*(long*)(&bigInt_nx6qdt7.val.Data) = data5;
					int num13 = (BigInt_64ul_false_unsigned_long_is_zero_const.Invoke(&bigInt_nx6qdt7) ? 1 : 0) ^ -1;
					llvm_lifetime_end_p0.Invoke(8L, &bigInt_nx6qdt7);
					b3 = (sbyte)(byte)num13;
					llvm_lifetime_start_p0.Invoke(4L, &num6);
					num6 = checked((((b2 & 1) == 1) ? 1 : 0) * 2 + (((b3 & 1) == 1) ? 1 : 0));
					llvm_lifetime_start_p0.Invoke(2L, &x);
					x = default(Half);
					if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(num5 <= 0, expected: false))
					{
						llvm_lifetime_start_p0.Invoke(4L, &num7);
						num7 = checked(1 - num5);
						llvm_lifetime_start_p0.Invoke(2L, &half5);
						llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva6);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb11, Sign_POS.Pointer, 1L, isVolatile: false);
						short field_4 = fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_create_value_Sign_unsigned_short_unsigned_short.Invoke(biased_exp: (short)checked(15 + num7), sign: anon_izyfb11.val, mantissa: 0);
						fputil_FPBits_2fahva6.FPRepImpl.FPRepSem.FPStorage.field_0 = field_4;
						Half half10 = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva6);
						llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva6);
						half5 = half10;
						llvm_lifetime_start_p0.Invoke(2L, &half6);
						llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva7);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb12, Sign_POS.Pointer, 1L, isVolatile: false);
						short field_5 = fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_create_value_Sign_unsigned_short_unsigned_short.Invoke(biased_exp: (short)checked(15 - num7), sign: anon_izyfb12.val, mantissa: 0);
						fputil_FPBits_2fahva7.FPRepImpl.FPRepSem.FPStorage.field_0 = field_5;
						Half half11 = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva7);
						llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva7);
						half6 = half11;
						llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva8);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb13, &@this->sign, 1L, isVolatile: false);
						short field_6 = fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_create_value_Sign_unsigned_short_unsigned_short.Invoke(biased_exp: (short)checked(num5 + num7), sign: anon_izyfb13.val, mantissa: 0);
						fputil_FPBits_2fahva8.FPRepImpl.FPRepSem.FPStorage.field_0 = field_6;
						x = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva8);
						llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva8);
						result = (Half)((float)cpp_enable_if_sizeof_Float16_8ul_Float16_type_fputil_multiply_add_Float16_Float16_Float16_Float16.Invoke(x, (Half)num6, (Half)((float)half4 * (float)half5)) * (float)half6);
						llvm_lifetime_end_p0.Invoke(2L, &half6);
						llvm_lifetime_end_p0.Invoke(2L, &half5);
						llvm_lifetime_end_p0.Invoke(4L, &num7);
					}
					else
					{
						llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva9);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb14, &@this->sign, 1L, isVolatile: false);
						short field_7 = fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_create_value_Sign_unsigned_short_unsigned_short.Invoke(biased_exp: (short)num5, sign: anon_izyfb14.val, mantissa: 0);
						fputil_FPBits_2fahva9.FPRepImpl.FPRepSem.FPStorage.field_0 = field_7;
						x = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva9);
						llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva9);
						llvm_lifetime_start_p0.Invoke(2L, &half7);
						half7 = cpp_enable_if_sizeof_Float16_8ul_Float16_type_fputil_multiply_add_Float16_Float16_Float16_Float16.Invoke(x, (Half)num6, half4);
						if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((b & 1) == 1, expected: false))
						{
							llvm_lifetime_start_p0.Invoke(2L, &num8);
							num8 = (short)((ushort)(short)num3 << 10);
							llvm_lifetime_start_p0.Invoke(2L, &num9);
							llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva10);
							fputil_FPBits_Float16_FPBits_Float16_Float16.Invoke(&fputil_FPBits_2fahva10, half7);
							short num14 = (short)checked(unchecked((ushort)fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_uintval_const.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva10))) - unchecked((ushort)num8));
							llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva10);
							num9 = num14;
							if (((ushort)num9 & 0x7C00) == 0)
							{
								num9 = (short)checked(unchecked((ushort)num9) - 0);
								if (num6 != 0)
								{
									fputil_set_errno_if_required_int.Invoke(34);
									fputil_raise_except_if_required_int.Invoke(16);
								}
							}
							llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva11);
							fputil_FPBits_Float16_FPBits_unsigned_short_unsigned_short.Invoke(&fputil_FPBits_2fahva11, num9);
							result = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva11);
							llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva11);
							llvm_lifetime_end_p0.Invoke(2L, &num9);
							llvm_lifetime_end_p0.Invoke(2L, &num8);
						}
						else
						{
							result = half7;
						}
						llvm_lifetime_end_p0.Invoke(2L, &half7);
					}
					llvm_lifetime_end_p0.Invoke(2L, &x);
					llvm_lifetime_end_p0.Invoke(4L, &num6);
					llvm_lifetime_end_p0.Invoke(1L, &b3);
					llvm_lifetime_end_p0.Invoke(1L, &b2);
					llvm_lifetime_end_p0.Invoke(8L, &bigInt_nx6qdt4);
					llvm_lifetime_end_p0.Invoke(8L, &bigInt_nx6qdt2);
					llvm_lifetime_end_p0.Invoke(2L, &half4);
					llvm_lifetime_end_p0.Invoke(8L, &bigInt_nx6qdt);
					llvm_lifetime_end_p0.Invoke(4L, &num5);
					llvm_lifetime_end_p0.Invoke(4L, &num4);
					llvm_lifetime_end_p0.Invoke(1L, &b);
				}
				llvm_lifetime_end_p0.Invoke(4L, &num3);
				llvm_lifetime_end_p0.Invoke(2L, &num2);
				llvm_lifetime_end_p0.Invoke(4L, &num);
			}
		}
		return result;
	}
}
