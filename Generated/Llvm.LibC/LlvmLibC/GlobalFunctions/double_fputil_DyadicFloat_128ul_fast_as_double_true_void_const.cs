using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil11DyadicFloatILm128EE7fast_asIdLb1EvEET_v")]
[DemangledName("double __llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>::fast_as<double, true, void>() const")]
internal static partial class double_fputil_DyadicFloat_128ul_fast_as_double_true_void_const
{
	public unsafe static double Invoke(void* @this)
	{
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		int num = 0;
		long num2 = 0L;
		int num3 = 0;
		double num4 = 0.0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		double num5 = 0.0;
		double num6 = 0.0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm4 = default(fputil_FPBits_wjhbrm);
		sbyte b = 0;
		int num7 = 0;
		int num8 = 0;
		BigInt_qdkjbh bigInt_qdkjbh = default(BigInt_qdkjbh);
		double num9 = 0.0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm5 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		BigInt_qdkjbh bigInt_qdkjbh2 = default(BigInt_qdkjbh);
		BigInt_qdkjbh bigInt_qdkjbh3 = default(BigInt_qdkjbh);
		BigInt_qdkjbh bigInt_qdkjbh4 = default(BigInt_qdkjbh);
		BigInt_qdkjbh bigInt_qdkjbh5 = default(BigInt_qdkjbh);
		sbyte b2 = 0;
		BigInt_qdkjbh bigInt_qdkjbh6 = default(BigInt_qdkjbh);
		sbyte b3 = 0;
		BigInt_qdkjbh bigInt_qdkjbh7 = default(BigInt_qdkjbh);
		int num10 = 0;
		double x = 0.0;
		int num11 = 0;
		double num12 = 0.0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm6 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb11 = default(anon_izyfb7);
		double num13 = 0.0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm7 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb12 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm8 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb13 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm9 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb14 = default(anon_izyfb7);
		double num14 = 0.0;
		long num15 = 0L;
		long num16 = 0L;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm10 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm11 = default(fputil_FPBits_wjhbrm);
		unchecked
		{
			double result;
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(BigInt_128ul_false_unsigned_long_is_zero_const.Invoke(&((fputil_DyadicFloat_kt2kd4*)@this)->mantissa), expected: false))
			{
				llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, &((fputil_DyadicFloat_kt2kd4*)@this)->sign, 1L, isVolatile: false);
				long val = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_zero_Sign.Invoke(anon_izyfb8.val);
				fputil_FPBits_wjhbrm2.FPRepImpl.FPRepSem.FPStorage.val = val;
				result = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm2);
				llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(4L, &num);
				num = 53;
				llvm_lifetime_start_p0.Invoke(8L, &num2);
				num2 = 0L;
				llvm_lifetime_start_p0.Invoke(4L, &num3);
				checked
				{
					num3 = unchecked((fputil_DyadicFloat_kt2kd4*)@this)->exponent + 1150;
				}
				if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(num3 > 2046, expected: false))
				{
					llvm_lifetime_start_p0.Invoke(8L, &num4);
					llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, &((fputil_DyadicFloat_kt2kd4*)@this)->sign, 1L, isVolatile: false);
					long val2 = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_create_value_Sign_unsigned_long_unsigned_long.Invoke(anon_izyfb9.val, 2046L, 0L);
					fputil_FPBits_wjhbrm3.FPRepImpl.FPRepSem.FPStorage.val = val2;
					double num17 = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm3);
					llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
					num4 = num17;
					llvm_lifetime_start_p0.Invoke(8L, &num5);
					num5 = 2.0;
					llvm_lifetime_start_p0.Invoke(8L, &num6);
					num6 = num5 * num4;
					llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
					fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm4, num6);
					bool num18 = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_inf_const.Invoke(&fputil_FPBits_wjhbrm4);
					llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
					if (num18)
					{
						fputil_set_errno_if_required_int.Invoke(34);
					}
					result = num6;
					llvm_lifetime_end_p0.Invoke(8L, &num6);
					llvm_lifetime_end_p0.Invoke(8L, &num5);
					llvm_lifetime_end_p0.Invoke(8L, &num4);
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(1L, &b);
					b = 0;
					llvm_lifetime_start_p0.Invoke(4L, &num7);
					num7 = 75;
					if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(num3 <= 0, expected: false))
					{
						b = 1;
						num7 = (int)(75L + (long)(uint)checked(1 - num3));
						num3 = 1023;
					}
					llvm_lifetime_start_p0.Invoke(4L, &num8);
					num8 = checked(num3 - 53 - 1);
					llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh);
					sbyte* ptr = (sbyte*)(&bigInt_qdkjbh);
					*(long*)ptr = -6148914691236517206L;
					((long*)ptr)[1] = -6148914691236517206L;
					if ((ulong)(uint)num7 >= 128uL)
					{
						BigInt_128ul_false_unsigned_long_BigInt_int_void_int.Invoke(&bigInt_qdkjbh, 0);
					}
					else
					{
						Struct_fiz2nb struct_fiz2nb = BigInt_128ul_false_unsigned_long_operator_unsigned_long_const_99u38u.Invoke(&((fputil_DyadicFloat_kt2kd4*)@this)->mantissa, (uint)num7);
						InlineArray2_Int64* ptr2 = &bigInt_qdkjbh.val.Data;
						Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
						((Struct_fiz2nb*)ptr2)->field_0 = struct_fiz2nb2.field_0;
						Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
						((Struct_fiz2nb*)ptr2)->field_1 = struct_fiz2nb3.field_1;
					}
					llvm_lifetime_start_p0.Invoke(8L, &num9);
					llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb10, &((fputil_DyadicFloat_kt2kd4*)@this)->sign, 1L, isVolatile: false);
					long val3 = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_create_value_Sign_unsigned_long_unsigned_long.Invoke(biased_exp: num3, mantissa: (BigInt_128ul_false_unsigned_long_operator_unsigned_long_unsigned_long_const.Invoke(&bigInt_qdkjbh) & 0xFFFFFFFFFFFFFL) | 0L, sign: anon_izyfb10.val);
					fputil_FPBits_wjhbrm5.FPRepImpl.FPRepSem.FPStorage.val = val3;
					double num19 = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm5);
					llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
					num9 = num19;
					llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh2);
					sbyte* ptr3 = (sbyte*)(&bigInt_qdkjbh2);
					*(long*)ptr3 = -6148914691236517206L;
					((long*)ptr3)[1] = -6148914691236517206L;
					bool num20 = (ulong)(uint)num7 > 128uL;
					llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh3);
					if (num20)
					{
						BigInt_128ul_false_unsigned_long_BigInt_int_void_int.Invoke(&bigInt_qdkjbh2, 0);
					}
					else
					{
						BigInt_128ul_false_unsigned_long_BigInt_int_void_int.Invoke(&bigInt_qdkjbh3, 1);
						Struct_fiz2nb struct_fiz2nb4 = BigInt_128ul_false_unsigned_long_operator_unsigned_long_const_dnm495.Invoke(&bigInt_qdkjbh3, (uint)(num7 - 1));
						InlineArray2_Int64* ptr4 = &bigInt_qdkjbh2.val.Data;
						Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
						((Struct_fiz2nb*)ptr4)->field_0 = struct_fiz2nb5.field_0;
						Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
						((Struct_fiz2nb*)ptr4)->field_1 = struct_fiz2nb6.field_1;
					}
					llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh3);
					llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh4);
					sbyte* ptr5 = (sbyte*)(&bigInt_qdkjbh4);
					*(long*)ptr5 = -6148914691236517206L;
					((long*)ptr5)[1] = -6148914691236517206L;
					llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh5);
					BigInt_128ul_false_unsigned_long_BigInt_int_void_int.Invoke(&bigInt_qdkjbh5, 1);
					Struct_fiz2nb struct_fiz2nb7 = BigInt_128ul_false_unsigned_long_operator_BigInt_128ul_false_unsigned_long_const_gydwfz.Invoke(&bigInt_qdkjbh2, &bigInt_qdkjbh5);
					InlineArray2_Int64* ptr6 = &bigInt_qdkjbh4.val.Data;
					Struct_fiz2nb struct_fiz2nb8 = struct_fiz2nb7;
					((Struct_fiz2nb*)ptr6)->field_0 = struct_fiz2nb8.field_0;
					Struct_fiz2nb struct_fiz2nb9 = struct_fiz2nb7;
					((Struct_fiz2nb*)ptr6)->field_1 = struct_fiz2nb9.field_1;
					llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh5);
					llvm_lifetime_start_p0.Invoke(1L, &b2);
					llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh6);
					Struct_fiz2nb struct_fiz2nb10 = operator_BigInt_128ul_false_unsigned_long_const_BigInt_128ul_false_unsigned_long_const_bs7s6m.Invoke(&((fputil_DyadicFloat_kt2kd4*)@this)->mantissa, &bigInt_qdkjbh2);
					InlineArray2_Int64* ptr7 = &bigInt_qdkjbh6.val.Data;
					Struct_fiz2nb struct_fiz2nb11 = struct_fiz2nb10;
					((Struct_fiz2nb*)ptr7)->field_0 = struct_fiz2nb11.field_0;
					Struct_fiz2nb struct_fiz2nb12 = struct_fiz2nb10;
					((Struct_fiz2nb*)ptr7)->field_1 = struct_fiz2nb12.field_1;
					int num21 = (BigInt_128ul_false_unsigned_long_is_zero_const.Invoke(&bigInt_qdkjbh6) ? 1 : 0) ^ -1;
					llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh6);
					b2 = (sbyte)(byte)num21;
					llvm_lifetime_start_p0.Invoke(1L, &b3);
					llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh7);
					Struct_fiz2nb struct_fiz2nb13 = operator_BigInt_128ul_false_unsigned_long_const_BigInt_128ul_false_unsigned_long_const_bs7s6m.Invoke(&((fputil_DyadicFloat_kt2kd4*)@this)->mantissa, &bigInt_qdkjbh4);
					InlineArray2_Int64* ptr8 = &bigInt_qdkjbh7.val.Data;
					Struct_fiz2nb struct_fiz2nb14 = struct_fiz2nb13;
					((Struct_fiz2nb*)ptr8)->field_0 = struct_fiz2nb14.field_0;
					Struct_fiz2nb struct_fiz2nb15 = struct_fiz2nb13;
					((Struct_fiz2nb*)ptr8)->field_1 = struct_fiz2nb15.field_1;
					int num22 = (BigInt_128ul_false_unsigned_long_is_zero_const.Invoke(&bigInt_qdkjbh7) ? 1 : 0) ^ -1;
					llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh7);
					b3 = (sbyte)(byte)num22;
					llvm_lifetime_start_p0.Invoke(4L, &num10);
					num10 = checked((((b2 & 1) == 1) ? 1 : 0) * 2 + (((b3 & 1) == 1) ? 1 : 0));
					llvm_lifetime_start_p0.Invoke(8L, &x);
					x = double.NaN;
					if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(num8 <= 0, expected: false))
					{
						llvm_lifetime_start_p0.Invoke(4L, &num11);
						checked
						{
							num11 = 1 - num8;
							llvm_lifetime_start_p0.Invoke(8L, &num12);
							llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm6);
							llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb11, Sign_POS.Pointer, 1L, isVolatile: false);
							long val4 = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_create_value_Sign_unsigned_long_unsigned_long.Invoke(biased_exp: 1023 + num11, sign: anon_izyfb11.val, mantissa: 0L);
							fputil_FPBits_wjhbrm6.FPRepImpl.FPRepSem.FPStorage.val = val4;
							double num23 = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm6);
							llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm6);
							num12 = num23;
							llvm_lifetime_start_p0.Invoke(8L, &num13);
							llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm7);
							llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb12, Sign_POS.Pointer, 1L, isVolatile: false);
							long val5 = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_create_value_Sign_unsigned_long_unsigned_long.Invoke(biased_exp: 1023 - num11, sign: anon_izyfb12.val, mantissa: 0L);
							fputil_FPBits_wjhbrm7.FPRepImpl.FPRepSem.FPStorage.val = val5;
							double num24 = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm7);
							llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm7);
							num13 = num24;
							llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm8);
							llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb13, &unchecked((fputil_DyadicFloat_kt2kd4*)@this)->sign, 1L, isVolatile: false);
							long val6 = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_create_value_Sign_unsigned_long_unsigned_long.Invoke(biased_exp: num8 + num11, sign: anon_izyfb13.val, mantissa: 0L);
							fputil_FPBits_wjhbrm8.FPRepImpl.FPRepSem.FPStorage.val = val6;
							x = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm8);
							llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm8);
							result = fputil_multiply_add_double_double_double.Invoke(x, num10, num9 * num12) * num13;
							llvm_lifetime_end_p0.Invoke(8L, &num13);
							llvm_lifetime_end_p0.Invoke(8L, &num12);
							llvm_lifetime_end_p0.Invoke(4L, &num11);
						}
					}
					else
					{
						llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm9);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb14, &((fputil_DyadicFloat_kt2kd4*)@this)->sign, 1L, isVolatile: false);
						long val7 = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_create_value_Sign_unsigned_long_unsigned_long.Invoke(biased_exp: num8, sign: anon_izyfb14.val, mantissa: 0L);
						fputil_FPBits_wjhbrm9.FPRepImpl.FPRepSem.FPStorage.val = val7;
						x = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm9);
						llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm9);
						llvm_lifetime_start_p0.Invoke(8L, &num14);
						num14 = fputil_multiply_add_double_double_double.Invoke(x, num10, num9);
						if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((b & 1) == 1, expected: false))
						{
							llvm_lifetime_start_p0.Invoke(8L, &num15);
							num15 = (long)num3 << 52;
							llvm_lifetime_start_p0.Invoke(8L, &num16);
							llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm10);
							fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm10, num14);
							long num25 = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval_const.Invoke(&fputil_FPBits_wjhbrm10) - num15;
							llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm10);
							num16 = num25;
							if ((num16 & 0x7FF0000000000000L) == 0L)
							{
								num16 -= 0L;
								if (num10 != 0)
								{
									fputil_set_errno_if_required_int.Invoke(34);
									fputil_raise_except_if_required_int.Invoke(16);
								}
							}
							llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm11);
							fputil_FPBits_double_FPBits_unsigned_long_unsigned_long.Invoke(&fputil_FPBits_wjhbrm11, num16);
							result = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm11);
							llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm11);
							llvm_lifetime_end_p0.Invoke(8L, &num16);
							llvm_lifetime_end_p0.Invoke(8L, &num15);
						}
						else
						{
							result = num14;
						}
						llvm_lifetime_end_p0.Invoke(8L, &num14);
					}
					llvm_lifetime_end_p0.Invoke(8L, &x);
					llvm_lifetime_end_p0.Invoke(4L, &num10);
					llvm_lifetime_end_p0.Invoke(1L, &b3);
					llvm_lifetime_end_p0.Invoke(1L, &b2);
					llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh4);
					llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh2);
					llvm_lifetime_end_p0.Invoke(8L, &num9);
					llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh);
					llvm_lifetime_end_p0.Invoke(4L, &num8);
					llvm_lifetime_end_p0.Invoke(4L, &num7);
					llvm_lifetime_end_p0.Invoke(1L, &b);
				}
				llvm_lifetime_end_p0.Invoke(4L, &num3);
				llvm_lifetime_end_p0.Invoke(8L, &num2);
				llvm_lifetime_end_p0.Invoke(4L, &num);
			}
			return result;
		}
	}
}
