using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil6remquoIdTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_S4_Ri")]
[DemangledName("double __llvm_libc_20_1_2_::fputil::remquo<double, 0>(double, double, int&)")]
internal static partial class double_fputil_remquo_double_0_double_double_int
{
	public unsafe static double Invoke(double x, double y, void* q)
	{
		double result = 0.0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm4 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb11 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb12 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb13 = default(anon_izyfb7);
		fputil_NormalFloat_n2h9ta fputil_NormalFloat_n2h9ta2 = default(fputil_NormalFloat_n2h9ta);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm5 = default(fputil_FPBits_wjhbrm);
		fputil_NormalFloat_n2h9ta fputil_NormalFloat_n2h9ta3 = default(fputil_NormalFloat_n2h9ta);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm6 = default(fputil_FPBits_wjhbrm);
		int num = 0;
		long num2 = 0L;
		long num3 = 0L;
		int num4 = 0;
		long num5 = 0L;
		fputil_NormalFloat_n2h9ta fputil_NormalFloat_n2h9ta4 = default(fputil_NormalFloat_n2h9ta);
		anon_izyfb7 anon_izyfb14 = default(anon_izyfb7);
		double num6 = 0.0;
		double num7 = 0.0;
		int num8 = 0;
		fputil_NormalFloat_n2h9ta fputil_NormalFloat_n2h9ta5 = default(fputil_NormalFloat_n2h9ta);
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		unchecked
		{
			*(long*)(&fputil_FPBits_wjhbrm2) = -6148914691236517206L;
			fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm2, x);
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
			*(long*)(&fputil_FPBits_wjhbrm3) = -6148914691236517206L;
			fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm3, y);
			if (fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_nan_const.Invoke(&fputil_FPBits_wjhbrm2))
			{
				result = x;
			}
			else if (fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_nan_const.Invoke(&fputil_FPBits_wjhbrm3))
			{
				result = y;
			}
			else if (fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_inf_const.Invoke(&fputil_FPBits_wjhbrm2) || fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero_const.Invoke(&fputil_FPBits_wjhbrm3))
			{
				llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
				long val = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan_Sign_unsigned_long.Invoke(anon_izyfb8.val, 0L);
				fputil_FPBits_wjhbrm4.FPRepImpl.FPRepSem.FPStorage.val = val;
				result = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm4);
				llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
			}
			else if (fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero_const.Invoke(&fputil_FPBits_wjhbrm2))
			{
				*(int*)q = 0;
				result = double_fputil_copysign_double_0_double_double.Invoke(0.0, x);
			}
			else if (fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_inf_const.Invoke(&fputil_FPBits_wjhbrm3))
			{
				*(int*)q = 0;
				result = x;
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb9);
				*(sbyte*)(&anon_izyfb9) = -86;
				anon_izyfb10.val = fputil_internal_FPStorage_fputil_FPType_2_sign_const.Invoke(&fputil_FPBits_wjhbrm2);
				anon_izyfb11.val = fputil_internal_FPStorage_fputil_FPType_2_sign_const.Invoke(&fputil_FPBits_wjhbrm3);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, (!operator_Sign_Sign_fy8fvt.Invoke(anon_izyfb10.val, anon_izyfb11.val)) ? Sign_NEG.Pointer : Sign_POS.Pointer, 1L, isVolatile: false);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb12, Sign_POS.Pointer, 1L, isVolatile: false);
				fputil_internal_FPStorage_fputil_FPType_2_set_sign_Sign.Invoke(&fputil_FPBits_wjhbrm2, anon_izyfb12.val);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb13, Sign_POS.Pointer, 1L, isVolatile: false);
				fputil_internal_FPStorage_fputil_FPType_2_set_sign_Sign.Invoke(&fputil_FPBits_wjhbrm3, anon_izyfb13.val);
				llvm_lifetime_start_p0.Invoke(24L, &fputil_NormalFloat_n2h9ta2);
				*(int*)(&fputil_NormalFloat_n2h9ta2) = -1431655766;
				sbyte* ptr = (sbyte*)(&fputil_NormalFloat_n2h9ta2) + 4;
				*ptr = -86;
				ptr[1] = -86;
				ptr[2] = -86;
				ptr[3] = -86;
				((long*)(&fputil_NormalFloat_n2h9ta2))[1] = -6148914691236517206L;
				((sbyte*)(&fputil_NormalFloat_n2h9ta2))[16] = -86;
				sbyte* ptr2 = (sbyte*)(&fputil_NormalFloat_n2h9ta2) + 17;
				*ptr2 = -86;
				ptr2[1] = -86;
				ptr2[2] = -86;
				ptr2[3] = -86;
				ptr2[4] = -86;
				ptr2[5] = -86;
				ptr2[6] = -86;
				llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_wjhbrm5, &fputil_FPBits_wjhbrm2, 8L, isVolatile: false);
				fputil_NormalFloat_double_NormalFloat_fputil_FPBits_double.Invoke(&fputil_NormalFloat_n2h9ta2, fputil_FPBits_wjhbrm5.FPRepImpl.FPRepSem.FPStorage.val);
				llvm_lifetime_start_p0.Invoke(24L, &fputil_NormalFloat_n2h9ta3);
				*(int*)(&fputil_NormalFloat_n2h9ta3) = -1431655766;
				sbyte* ptr3 = (sbyte*)(&fputil_NormalFloat_n2h9ta3) + 4;
				*ptr3 = -86;
				ptr3[1] = -86;
				ptr3[2] = -86;
				ptr3[3] = -86;
				((long*)(&fputil_NormalFloat_n2h9ta3))[1] = -6148914691236517206L;
				((sbyte*)(&fputil_NormalFloat_n2h9ta3))[16] = -86;
				sbyte* ptr4 = (sbyte*)(&fputil_NormalFloat_n2h9ta3) + 17;
				*ptr4 = -86;
				ptr4[1] = -86;
				ptr4[2] = -86;
				ptr4[3] = -86;
				ptr4[4] = -86;
				ptr4[5] = -86;
				ptr4[6] = -86;
				llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_wjhbrm6, &fputil_FPBits_wjhbrm3, 8L, isVolatile: false);
				fputil_NormalFloat_double_NormalFloat_fputil_FPBits_double.Invoke(&fputil_NormalFloat_n2h9ta3, fputil_FPBits_wjhbrm6.FPRepImpl.FPRepSem.FPStorage.val);
				llvm_lifetime_start_p0.Invoke(4L, &num);
				num = checked(fputil_NormalFloat_n2h9ta2.exponent - fputil_NormalFloat_n2h9ta3.exponent);
				llvm_lifetime_start_p0.Invoke(8L, &num2);
				num2 = fputil_NormalFloat_n2h9ta2.mantissa;
				llvm_lifetime_start_p0.Invoke(8L, &num3);
				num3 = fputil_NormalFloat_n2h9ta3.mantissa;
				*(int*)q = 0;
				while (true)
				{
					if (num >= 0)
					{
						llvm_lifetime_start_p0.Invoke(4L, &num4);
						num4 = 0;
						llvm_lifetime_start_p0.Invoke(8L, &num5);
						num5 = num2;
						num4 = 0;
						while ((ulong)num5 < (ulong)num3)
						{
							num5 <<= 1;
							num4++;
						}
						int num9;
						if (num4 > num)
						{
							num9 = 3;
						}
						else
						{
							num -= num4;
							if (0 <= num && num < 3)
							{
								*(int*)q |= 1 << num;
							}
							num2 = num5 - num3;
							if (num2 == 0L)
							{
								*(int*)q = ((!Sign_is_neg_const.Invoke(&anon_izyfb9)) ? (*(int*)q) : checked(-(*unchecked((int*)q))));
								result = double_fputil_copysign_double_0_double_double.Invoke(0.0, x);
								num9 = 1;
							}
							else
							{
								num9 = 0;
							}
						}
						llvm_lifetime_end_p0.Invoke(8L, &num5);
						llvm_lifetime_end_p0.Invoke(4L, &num4);
						int num10 = num9;
						if (num10 == 0)
						{
							continue;
						}
						if (num10 != 3)
						{
							break;
						}
					}
					llvm_lifetime_start_p0.Invoke(24L, &fputil_NormalFloat_n2h9ta4);
					*(int*)(&fputil_NormalFloat_n2h9ta4) = -1431655766;
					sbyte* ptr5 = (sbyte*)(&fputil_NormalFloat_n2h9ta4) + 4;
					*ptr5 = -86;
					ptr5[1] = -86;
					ptr5[2] = -86;
					ptr5[3] = -86;
					((long*)(&fputil_NormalFloat_n2h9ta4))[1] = -6148914691236517206L;
					((sbyte*)(&fputil_NormalFloat_n2h9ta4))[16] = -86;
					sbyte* ptr6 = (sbyte*)(&fputil_NormalFloat_n2h9ta4) + 17;
					*ptr6 = -86;
					ptr6[1] = -86;
					ptr6[2] = -86;
					ptr6[3] = -86;
					ptr6[4] = -86;
					ptr6[5] = -86;
					ptr6[6] = -86;
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb14, Sign_POS.Pointer, 1L, isVolatile: false);
					checked
					{
						fputil_NormalFloat_double_NormalFloat_Sign_int_unsigned_long.Invoke(e: num + fputil_NormalFloat_n2h9ta3.exponent, m: num2, @this: &fputil_NormalFloat_n2h9ta4, s: anon_izyfb14.val);
						llvm_lifetime_start_p0.Invoke(8L, &num6);
						num6 = fputil_NormalFloat_double_operator_double_const.Invoke(&fputil_NormalFloat_n2h9ta4);
						llvm_lifetime_start_p0.Invoke(8L, &num7);
						num7 = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm3);
						llvm_lifetime_start_p0.Invoke(4L, &num8);
						llvm_lifetime_start_p0.Invoke(24L, &fputil_NormalFloat_n2h9ta5);
						fputil_NormalFloat_double_mul2_int_const.Invoke(&fputil_NormalFloat_n2h9ta5, &fputil_NormalFloat_n2h9ta4, 1);
						int num11 = fputil_NormalFloat_double_cmp_fputil_NormalFloat_double_const_const.Invoke(&fputil_NormalFloat_n2h9ta5, &fputil_NormalFloat_n2h9ta3);
						llvm_lifetime_end_p0.Invoke(24L, &fputil_NormalFloat_n2h9ta5);
						num8 = num11;
						if (num8 > 0)
						{
							(*unchecked((int*)q))++;
							num6 = ((x < 0.0) ? (num7 - num6) : (num6 - num7));
						}
						else if (num8 == 0)
						{
							if ((*unchecked((int*)q) & 1) != 0)
							{
								(*unchecked((int*)q))++;
								if (!(x < 0.0))
								{
									num6 = 0.0 - num6;
								}
							}
							else if (x < 0.0)
							{
								num6 = 0.0 - num6;
							}
						}
						else if (x < 0.0)
						{
							num6 = 0.0 - num6;
						}
						*unchecked((int*)q) = ((!Sign_is_neg_const.Invoke(&anon_izyfb9)) ? (*unchecked((int*)q)) : (-(*unchecked((int*)q))));
						result = ((num6 != 0.0) ? num6 : double_fputil_copysign_double_0_double_double.Invoke(0.0, x));
						llvm_lifetime_end_p0.Invoke(4L, &num8);
						llvm_lifetime_end_p0.Invoke(8L, &num7);
						llvm_lifetime_end_p0.Invoke(8L, &num6);
						llvm_lifetime_end_p0.Invoke(24L, &fputil_NormalFloat_n2h9ta4);
						break;
					}
				}
				llvm_lifetime_end_p0.Invoke(8L, &num3);
				llvm_lifetime_end_p0.Invoke(8L, &num2);
				llvm_lifetime_end_p0.Invoke(4L, &num);
				llvm_lifetime_end_p0.Invoke(24L, &fputil_NormalFloat_n2h9ta3);
				llvm_lifetime_end_p0.Invoke(24L, &fputil_NormalFloat_n2h9ta2);
				llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb9);
			}
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			return result;
		}
	}
}
