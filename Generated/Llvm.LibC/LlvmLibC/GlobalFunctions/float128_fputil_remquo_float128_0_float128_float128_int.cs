using System;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil6remquoIgTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_S4_Ri")]
[DemangledName("__float128 __llvm_libc_20_1_2_::fputil::remquo<__float128, 0>(__float128, __float128, int&)")]
internal static partial class float128_fputil_remquo_float128_0_float128_float128_int
{
	public unsafe static double Invoke(double x, double y, void* q)
	{
		double result = 0.0;
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(fputil_FPBits_ubgsi2);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi4 = default(fputil_FPBits_ubgsi2);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi5 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		Int128 @int = default(Int128);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb11 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb12 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb13 = default(anon_izyfb7);
		fputil_NormalFloat_wqb3ie fputil_NormalFloat_wqb3ie2 = default(fputil_NormalFloat_wqb3ie);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi6 = default(fputil_FPBits_ubgsi2);
		fputil_NormalFloat_wqb3ie fputil_NormalFloat_wqb3ie3 = default(fputil_NormalFloat_wqb3ie);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi7 = default(fputil_FPBits_ubgsi2);
		int num = 0;
		Int128 int2 = default(Int128);
		Int128 y2 = default(Int128);
		int num2 = 0;
		Int128 x2 = default(Int128);
		fputil_NormalFloat_wqb3ie fputil_NormalFloat_wqb3ie4 = default(fputil_NormalFloat_wqb3ie);
		anon_izyfb7 anon_izyfb14 = default(anon_izyfb7);
		Int128 int3 = default(Int128);
		double num3 = 0.0;
		double num4 = 0.0;
		int num5 = 0;
		fputil_NormalFloat_wqb3ie fputil_NormalFloat_wqb3ie5 = default(fputil_NormalFloat_wqb3ie);
		llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		unchecked
		{
			*(Int128*)(&fputil_FPBits_ubgsi3) = -6148914691236517206L;
			fputil_FPBits_float128_FPBits_float128_float128.Invoke(&fputil_FPBits_ubgsi3, x);
			llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
			*(Int128*)(&fputil_FPBits_ubgsi4) = -6148914691236517206L;
			fputil_FPBits_float128_FPBits_float128_float128.Invoke(&fputil_FPBits_ubgsi4, y);
			if (fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_nan_const.Invoke(&fputil_FPBits_ubgsi3))
			{
				result = x;
			}
			else if (fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_nan_const.Invoke(&fputil_FPBits_ubgsi4))
			{
				result = y;
			}
			else if (fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_inf_const.Invoke(&fputil_FPBits_ubgsi3) || fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_zero_const.Invoke(&fputil_FPBits_ubgsi4))
			{
				llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi5);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
				sbyte val = anon_izyfb8.val;
				@int = 0L;
				Struct_fiz2nb struct_fiz2nb = fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_quiet_nan_Sign_unsigned_int128.Invoke(val, *(long*)(&@int), ((long*)(&@int))[1]);
				Int128* ptr = &fputil_FPBits_ubgsi5.val.Data.FPStorage.field_0;
				Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
				((Struct_fiz2nb*)ptr)->field_0 = struct_fiz2nb2.field_0;
				Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
				((Struct_fiz2nb*)ptr)->field_1 = struct_fiz2nb3.field_1;
				result = fputil_FPBits_float128_get_val_const.Invoke(&fputil_FPBits_ubgsi5);
				llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi5);
			}
			else if (fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_zero_const.Invoke(&fputil_FPBits_ubgsi3))
			{
				*(int*)q = 0;
				result = float128_fputil_copysign_float128_0_float128_float128.Invoke(0.0, x);
			}
			else if (fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_inf_const.Invoke(&fputil_FPBits_ubgsi4))
			{
				*(int*)q = 0;
				result = x;
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb9);
				*(sbyte*)(&anon_izyfb9) = -86;
				anon_izyfb10.val = fputil_internal_FPStorage_fputil_FPType_3_sign_const.Invoke(&fputil_FPBits_ubgsi3);
				anon_izyfb11.val = fputil_internal_FPStorage_fputil_FPType_3_sign_const.Invoke(&fputil_FPBits_ubgsi4);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, (!operator_Sign_Sign_fy8fvt.Invoke(anon_izyfb10.val, anon_izyfb11.val)) ? Sign_NEG.Pointer : Sign_POS.Pointer, 1L, isVolatile: false);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb12, Sign_POS.Pointer, 1L, isVolatile: false);
				fputil_internal_FPStorage_fputil_FPType_3_set_sign_Sign.Invoke(&fputil_FPBits_ubgsi3, anon_izyfb12.val);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb13, Sign_POS.Pointer, 1L, isVolatile: false);
				fputil_internal_FPStorage_fputil_FPType_3_set_sign_Sign.Invoke(&fputil_FPBits_ubgsi4, anon_izyfb13.val);
				llvm_lifetime_start_p0.Invoke(48L, &fputil_NormalFloat_wqb3ie2);
				llvm_memset_p0_i64.Invoke(&fputil_NormalFloat_wqb3ie2, -86, 48L, isVolatile: false);
				llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi6, &fputil_FPBits_ubgsi3, 16L, isVolatile: false);
				fputil_NormalFloat_float128_NormalFloat_fputil_FPBits_float128.Invoke(&fputil_NormalFloat_wqb3ie2, *(long*)(&fputil_FPBits_ubgsi6), ((long*)(&fputil_FPBits_ubgsi6))[1]);
				llvm_lifetime_start_p0.Invoke(48L, &fputil_NormalFloat_wqb3ie3);
				llvm_memset_p0_i64.Invoke(&fputil_NormalFloat_wqb3ie3, -86, 48L, isVolatile: false);
				llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi7, &fputil_FPBits_ubgsi4, 16L, isVolatile: false);
				fputil_NormalFloat_float128_NormalFloat_fputil_FPBits_float128.Invoke(&fputil_NormalFloat_wqb3ie3, *(long*)(&fputil_FPBits_ubgsi7), ((long*)(&fputil_FPBits_ubgsi7))[1]);
				llvm_lifetime_start_p0.Invoke(4L, &num);
				num = checked(fputil_NormalFloat_wqb3ie2.exponent - fputil_NormalFloat_wqb3ie3.exponent);
				llvm_lifetime_start_p0.Invoke(16L, &int2);
				int2 = fputil_NormalFloat_wqb3ie2.mantissa;
				llvm_lifetime_start_p0.Invoke(16L, &y2);
				y2 = fputil_NormalFloat_wqb3ie3.mantissa;
				*(int*)q = 0;
				while (true)
				{
					if (num >= 0)
					{
						llvm_lifetime_start_p0.Invoke(4L, &num2);
						num2 = 0;
						llvm_lifetime_start_p0.Invoke(16L, &x2);
						x2 = int2;
						num2 = 0;
						while (NumericHelper.IntCmpUlt(x2, y2))
						{
							x2 = NumericHelper.ShiftLeft(x2, 1L);
							num2++;
						}
						int num6;
						if (num2 > num)
						{
							num6 = 3;
						}
						else
						{
							num -= num2;
							if (0 <= num && num < 3)
							{
								*(int*)q |= 1 << num;
							}
							int2 = NumericHelper.Subtract(x2, y2);
							if (NumericHelper.IntCmpEq(int2, 0L))
							{
								*(int*)q = ((!Sign_is_neg_const.Invoke(&anon_izyfb9)) ? (*(int*)q) : checked(-(*unchecked((int*)q))));
								result = float128_fputil_copysign_float128_0_float128_float128.Invoke(0.0, x);
								num6 = 1;
							}
							else
							{
								num6 = 0;
							}
						}
						llvm_lifetime_end_p0.Invoke(16L, &x2);
						llvm_lifetime_end_p0.Invoke(4L, &num2);
						int num7 = num6;
						if (num7 == 0)
						{
							continue;
						}
						if (num7 != 3)
						{
							break;
						}
					}
					llvm_lifetime_start_p0.Invoke(48L, &fputil_NormalFloat_wqb3ie4);
					llvm_memset_p0_i64.Invoke(&fputil_NormalFloat_wqb3ie4, -86, 48L, isVolatile: false);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb14, Sign_POS.Pointer, 1L, isVolatile: false);
					int e = checked(num + fputil_NormalFloat_wqb3ie3.exponent);
					Int128 int4 = int2;
					sbyte val2 = anon_izyfb14.val;
					int3 = int4;
					fputil_NormalFloat_float128_NormalFloat_Sign_int_unsigned_int128.Invoke(&fputil_NormalFloat_wqb3ie4, val2, e, *(long*)(&int3), ((long*)(&int3))[1]);
					llvm_lifetime_start_p0.Invoke(16L, &num3);
					num3 = fputil_NormalFloat_float128_operator_float128_const.Invoke(&fputil_NormalFloat_wqb3ie4);
					llvm_lifetime_start_p0.Invoke(16L, &num4);
					num4 = fputil_FPBits_float128_get_val_const.Invoke(&fputil_FPBits_ubgsi4);
					llvm_lifetime_start_p0.Invoke(4L, &num5);
					llvm_lifetime_start_p0.Invoke(48L, &fputil_NormalFloat_wqb3ie5);
					fputil_NormalFloat_float128_mul2_int_const.Invoke(&fputil_NormalFloat_wqb3ie5, &fputil_NormalFloat_wqb3ie4, 1);
					int num8 = fputil_NormalFloat_float128_cmp_fputil_NormalFloat_float128_const_const.Invoke(&fputil_NormalFloat_wqb3ie5, &fputil_NormalFloat_wqb3ie3);
					llvm_lifetime_end_p0.Invoke(48L, &fputil_NormalFloat_wqb3ie5);
					num5 = num8;
					checked
					{
						if (num5 > 0)
						{
							(*unchecked((int*)q))++;
							num3 = ((x < 0.0) ? (num4 - num3) : (num3 - num4));
						}
						else if (num5 == 0)
						{
							if ((*unchecked((int*)q) & 1) != 0)
							{
								(*unchecked((int*)q))++;
								if (!(x < 0.0))
								{
									num3 = 0.0 - num3;
								}
							}
							else if (x < 0.0)
							{
								num3 = 0.0 - num3;
							}
						}
						else if (x < 0.0)
						{
							num3 = 0.0 - num3;
						}
						*unchecked((int*)q) = ((!Sign_is_neg_const.Invoke(&anon_izyfb9)) ? (*unchecked((int*)q)) : (-(*unchecked((int*)q))));
						result = ((num3 != 0.0) ? num3 : float128_fputil_copysign_float128_0_float128_float128.Invoke(0.0, x));
						llvm_lifetime_end_p0.Invoke(4L, &num5);
						llvm_lifetime_end_p0.Invoke(16L, &num4);
						llvm_lifetime_end_p0.Invoke(16L, &num3);
						llvm_lifetime_end_p0.Invoke(48L, &fputil_NormalFloat_wqb3ie4);
						break;
					}
				}
				llvm_lifetime_end_p0.Invoke(16L, &y2);
				llvm_lifetime_end_p0.Invoke(16L, &int2);
				llvm_lifetime_end_p0.Invoke(4L, &num);
				llvm_lifetime_end_p0.Invoke(48L, &fputil_NormalFloat_wqb3ie3);
				llvm_lifetime_end_p0.Invoke(48L, &fputil_NormalFloat_wqb3ie2);
				llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb9);
			}
			llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
			llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
			return result;
		}
	}
}
