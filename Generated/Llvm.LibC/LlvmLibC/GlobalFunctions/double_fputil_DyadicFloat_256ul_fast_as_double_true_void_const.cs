using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil11DyadicFloatILm256EE7fast_asIdLb1EvEET_v")]
[DemangledName("double __llvm_libc_20_1_2_::fputil::DyadicFloat<256ul>::fast_as<double, true, void>() const")]
internal static partial class double_fputil_DyadicFloat_256ul_fast_as_double_true_void_const
{
	public unsafe static double Invoke(fputil_DyadicFloat_jhcpjj* @this)
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
		BigInt_x9dsed bigInt_x9dsed = default(BigInt_x9dsed);
		double num9 = 0.0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm5 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		BigInt_x9dsed bigInt_x9dsed2 = default(BigInt_x9dsed);
		BigInt_x9dsed bigInt_x9dsed3 = default(BigInt_x9dsed);
		BigInt_x9dsed bigInt_x9dsed4 = default(BigInt_x9dsed);
		BigInt_x9dsed bigInt_x9dsed5 = default(BigInt_x9dsed);
		sbyte b2 = 0;
		BigInt_x9dsed bigInt_x9dsed6 = default(BigInt_x9dsed);
		sbyte b3 = 0;
		BigInt_x9dsed bigInt_x9dsed7 = default(BigInt_x9dsed);
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
		double result;
		if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(BigInt_256ul_false_unsigned_long_is_zero_const.Invoke(&@this->mantissa), expected: false))
		{
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, &@this->sign, 1L, isVolatile: false);
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
			num3 = @this->exponent + 1278;
			unchecked
			{
				if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(num3 > 2046, expected: false))
				{
					llvm_lifetime_start_p0.Invoke(8L, &num4);
					llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, &@this->sign, 1L, isVolatile: false);
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
					bool num18 = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_inf_const.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm4));
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
					num7 = 203;
					if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(num3 <= 0, expected: false))
					{
						b = 1;
						num7 = (int)(203L + (long)(uint)checked(1 - num3));
						num3 = 1023;
					}
					llvm_lifetime_start_p0.Invoke(4L, &num8);
					num8 = checked(num3 - 53 - 1);
					llvm_lifetime_start_p0.Invoke(32L, &bigInt_x9dsed);
					sbyte* ptr = (sbyte*)(&bigInt_x9dsed);
					*(long*)ptr = -6148914691236517206L;
					((long*)ptr)[1] = -6148914691236517206L;
					((long*)ptr)[2] = -6148914691236517206L;
					((long*)ptr)[3] = -6148914691236517206L;
					if ((ulong)(uint)num7 >= 256uL)
					{
						BigInt_256ul_false_unsigned_long_BigInt_int_void_int.Invoke(&bigInt_x9dsed, 0);
					}
					else
					{
						BigInt_256ul_false_unsigned_long_operator_unsigned_long_const_68jeyu.Invoke(&bigInt_x9dsed, &@this->mantissa, (uint)num7);
					}
					llvm_lifetime_start_p0.Invoke(8L, &num9);
					llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb10, &@this->sign, 1L, isVolatile: false);
					long val3 = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_create_value_Sign_unsigned_long_unsigned_long.Invoke(biased_exp: num3, mantissa: (BigInt_256ul_false_unsigned_long_operator_unsigned_long_unsigned_long_const.Invoke(&bigInt_x9dsed) & 0xFFFFFFFFFFFFFL) | 0L, sign: anon_izyfb10.val);
					fputil_FPBits_wjhbrm5.FPRepImpl.FPRepSem.FPStorage.val = val3;
					double num19 = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm5);
					llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
					num9 = num19;
					llvm_lifetime_start_p0.Invoke(32L, &bigInt_x9dsed2);
					sbyte* ptr2 = (sbyte*)(&bigInt_x9dsed2);
					*(long*)ptr2 = -6148914691236517206L;
					((long*)ptr2)[1] = -6148914691236517206L;
					((long*)ptr2)[2] = -6148914691236517206L;
					((long*)ptr2)[3] = -6148914691236517206L;
					bool num20 = (ulong)(uint)num7 > 256uL;
					llvm_lifetime_start_p0.Invoke(32L, &bigInt_x9dsed3);
					if (num20)
					{
						BigInt_256ul_false_unsigned_long_BigInt_int_void_int.Invoke(&bigInt_x9dsed2, 0);
					}
					else
					{
						BigInt_256ul_false_unsigned_long_BigInt_int_void_int.Invoke(&bigInt_x9dsed3, 1);
						BigInt_256ul_false_unsigned_long_operator_unsigned_long_const_kxxaxj.Invoke(&bigInt_x9dsed2, &bigInt_x9dsed3, (uint)(num7 - 1));
					}
					llvm_lifetime_end_p0.Invoke(32L, &bigInt_x9dsed3);
					llvm_lifetime_start_p0.Invoke(32L, &bigInt_x9dsed4);
					sbyte* ptr3 = (sbyte*)(&bigInt_x9dsed4);
					*(long*)ptr3 = -6148914691236517206L;
					((long*)ptr3)[1] = -6148914691236517206L;
					((long*)ptr3)[2] = -6148914691236517206L;
					((long*)ptr3)[3] = -6148914691236517206L;
					llvm_lifetime_start_p0.Invoke(32L, &bigInt_x9dsed5);
					BigInt_256ul_false_unsigned_long_BigInt_int_void_int.Invoke(&bigInt_x9dsed5, 1);
					BigInt_256ul_false_unsigned_long_operator_BigInt_256ul_false_unsigned_long_const_nar9qw.Invoke(&bigInt_x9dsed4, &bigInt_x9dsed2, &bigInt_x9dsed5);
					llvm_lifetime_end_p0.Invoke(32L, &bigInt_x9dsed5);
					llvm_lifetime_start_p0.Invoke(1L, &b2);
					llvm_lifetime_start_p0.Invoke(32L, &bigInt_x9dsed6);
					operator_BigInt_256ul_false_unsigned_long_const_BigInt_256ul_false_unsigned_long_const_abg3um.Invoke(&bigInt_x9dsed6, &@this->mantissa, &bigInt_x9dsed2);
					int num21 = (BigInt_256ul_false_unsigned_long_is_zero_const.Invoke(&bigInt_x9dsed6) ? 1 : 0) ^ -1;
					llvm_lifetime_end_p0.Invoke(32L, &bigInt_x9dsed6);
					b2 = (sbyte)(byte)num21;
					llvm_lifetime_start_p0.Invoke(1L, &b3);
					llvm_lifetime_start_p0.Invoke(32L, &bigInt_x9dsed7);
					operator_BigInt_256ul_false_unsigned_long_const_BigInt_256ul_false_unsigned_long_const_abg3um.Invoke(&bigInt_x9dsed7, &@this->mantissa, &bigInt_x9dsed4);
					int num22 = (BigInt_256ul_false_unsigned_long_is_zero_const.Invoke(&bigInt_x9dsed7) ? 1 : 0) ^ -1;
					llvm_lifetime_end_p0.Invoke(32L, &bigInt_x9dsed7);
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
							llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb13, &@this->sign, 1L, isVolatile: false);
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
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb14, &@this->sign, 1L, isVolatile: false);
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
							long num25 = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm10)) - num15;
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
					llvm_lifetime_end_p0.Invoke(32L, &bigInt_x9dsed4);
					llvm_lifetime_end_p0.Invoke(32L, &bigInt_x9dsed2);
					llvm_lifetime_end_p0.Invoke(8L, &num9);
					llvm_lifetime_end_p0.Invoke(32L, &bigInt_x9dsed);
					llvm_lifetime_end_p0.Invoke(4L, &num8);
					llvm_lifetime_end_p0.Invoke(4L, &num7);
					llvm_lifetime_end_p0.Invoke(1L, &b);
				}
				llvm_lifetime_end_p0.Invoke(4L, &num3);
				llvm_lifetime_end_p0.Invoke(8L, &num2);
				llvm_lifetime_end_p0.Invoke(4L, &num);
			}
		}
		return result;
	}
}
