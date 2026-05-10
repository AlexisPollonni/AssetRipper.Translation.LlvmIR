using System;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil6remquoIDF16_TnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_S4_Ri")]
[DemangledName("_Float16 __llvm_libc_20_1_2_::fputil::remquo<_Float16, 0>(_Float16, _Float16, int&)")]
internal static partial class Float16_fputil_remquo_Float16_0_Float16_Float16_int
{
	public unsafe static Half Invoke(Half x, Half y, void* q)
	{
		Half result = default(Half);
		fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(fputil_FPBits_2fahva);
		fputil_FPBits_2fahva fputil_FPBits_2fahva3 = default(fputil_FPBits_2fahva);
		fputil_FPBits_2fahva fputil_FPBits_2fahva4 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb11 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb12 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb13 = default(anon_izyfb7);
		fputil_NormalFloat_epbrnk fputil_NormalFloat_epbrnk2 = default(fputil_NormalFloat_epbrnk);
		fputil_FPBits_2fahva fputil_FPBits_2fahva5 = default(fputil_FPBits_2fahva);
		fputil_NormalFloat_epbrnk fputil_NormalFloat_epbrnk3 = default(fputil_NormalFloat_epbrnk);
		fputil_FPBits_2fahva fputil_FPBits_2fahva6 = default(fputil_FPBits_2fahva);
		int num = 0;
		short num2 = 0;
		short num3 = 0;
		int num4 = 0;
		short num5 = 0;
		fputil_NormalFloat_epbrnk fputil_NormalFloat_epbrnk4 = default(fputil_NormalFloat_epbrnk);
		anon_izyfb7 anon_izyfb14 = default(anon_izyfb7);
		Half half = default(Half);
		Half half2 = default(Half);
		int num6 = 0;
		fputil_NormalFloat_epbrnk fputil_NormalFloat_epbrnk5 = default(fputil_NormalFloat_epbrnk);
		llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
		unchecked
		{
			*(short*)(&fputil_FPBits_2fahva2) = -21846;
			fputil_FPBits_Float16_FPBits_Float16_Float16.Invoke(&fputil_FPBits_2fahva2, x);
			llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva3);
			*(short*)(&fputil_FPBits_2fahva3) = -21846;
			fputil_FPBits_Float16_FPBits_Float16_Float16.Invoke(&fputil_FPBits_2fahva3, y);
			if (fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_nan_const.Invoke(&fputil_FPBits_2fahva2))
			{
				result = x;
			}
			else if (fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_nan_const.Invoke(&fputil_FPBits_2fahva3))
			{
				result = y;
			}
			else if (fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_inf_const.Invoke(&fputil_FPBits_2fahva2) || fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_zero_const.Invoke(&fputil_FPBits_2fahva3))
			{
				llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva4);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
				short field_ = fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan_Sign_unsigned_short.Invoke(anon_izyfb8.val, 0);
				fputil_FPBits_2fahva4.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
				result = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva4);
				llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva4);
			}
			else if (fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_zero_const.Invoke(&fputil_FPBits_2fahva2))
			{
				*(int*)q = 0;
				result = Float16_fputil_copysign_Float16_0_Float16_Float16.Invoke(default(Half), x);
			}
			else if (fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_inf_const.Invoke(&fputil_FPBits_2fahva3))
			{
				*(int*)q = 0;
				result = x;
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb9);
				*(sbyte*)(&anon_izyfb9) = -86;
				anon_izyfb10.val = fputil_internal_FPStorage_fputil_FPType_0_sign_const.Invoke(&fputil_FPBits_2fahva2);
				anon_izyfb11.val = fputil_internal_FPStorage_fputil_FPType_0_sign_const.Invoke(&fputil_FPBits_2fahva3);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, (!operator_Sign_Sign_fy8fvt.Invoke(anon_izyfb10.val, anon_izyfb11.val)) ? Sign_NEG.Pointer : Sign_POS.Pointer, 1L, isVolatile: false);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb12, Sign_POS.Pointer, 1L, isVolatile: false);
				fputil_internal_FPStorage_fputil_FPType_0_set_sign_Sign.Invoke(&fputil_FPBits_2fahva2, anon_izyfb12.val);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb13, Sign_POS.Pointer, 1L, isVolatile: false);
				fputil_internal_FPStorage_fputil_FPType_0_set_sign_Sign.Invoke(&fputil_FPBits_2fahva3, anon_izyfb13.val);
				llvm_lifetime_start_p0.Invoke(8L, &fputil_NormalFloat_epbrnk2);
				*(int*)(&fputil_NormalFloat_epbrnk2) = -1431655766;
				((short*)(&fputil_NormalFloat_epbrnk2))[2] = -21846;
				((sbyte*)(&fputil_NormalFloat_epbrnk2))[6] = -86;
				((sbyte*)(&fputil_NormalFloat_epbrnk2))[7] = -86;
				llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_2fahva5, &fputil_FPBits_2fahva2, 2L, isVolatile: false);
				fputil_NormalFloat_Float16_NormalFloat_fputil_FPBits_Float16.Invoke(&fputil_NormalFloat_epbrnk2, fputil_FPBits_2fahva5.FPRepImpl.FPRepSem.FPStorage.field_0);
				llvm_lifetime_start_p0.Invoke(8L, &fputil_NormalFloat_epbrnk3);
				*(int*)(&fputil_NormalFloat_epbrnk3) = -1431655766;
				((short*)(&fputil_NormalFloat_epbrnk3))[2] = -21846;
				((sbyte*)(&fputil_NormalFloat_epbrnk3))[6] = -86;
				((sbyte*)(&fputil_NormalFloat_epbrnk3))[7] = -86;
				llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_2fahva6, &fputil_FPBits_2fahva3, 2L, isVolatile: false);
				fputil_NormalFloat_Float16_NormalFloat_fputil_FPBits_Float16.Invoke(&fputil_NormalFloat_epbrnk3, fputil_FPBits_2fahva6.FPRepImpl.FPRepSem.FPStorage.field_0);
				llvm_lifetime_start_p0.Invoke(4L, &num);
				num = checked(fputil_NormalFloat_epbrnk2.exponent - fputil_NormalFloat_epbrnk3.exponent);
				llvm_lifetime_start_p0.Invoke(2L, &num2);
				num2 = fputil_NormalFloat_epbrnk2.mantissa;
				llvm_lifetime_start_p0.Invoke(2L, &num3);
				num3 = fputil_NormalFloat_epbrnk3.mantissa;
				*(int*)q = 0;
				while (true)
				{
					if (num >= 0)
					{
						llvm_lifetime_start_p0.Invoke(4L, &num4);
						num4 = 0;
						llvm_lifetime_start_p0.Invoke(2L, &num5);
						num5 = num2;
						num4 = 0;
						while ((ushort)num5 < (ushort)num3)
						{
							num5 = (short)((ushort)num5 << 1);
							num4++;
						}
						int num7;
						if (num4 > num)
						{
							num7 = 3;
						}
						else
						{
							num -= num4;
							if (0 <= num && num < 3)
							{
								*(int*)q |= 1 << num;
							}
							num2 = (short)checked(unchecked((ushort)num5) - unchecked((ushort)num3));
							if ((ushort)num2 == 0)
							{
								*(int*)q = ((!Sign_is_neg_const.Invoke(&anon_izyfb9)) ? (*(int*)q) : checked(-(*unchecked((int*)q))));
								result = Float16_fputil_copysign_Float16_0_Float16_Float16.Invoke(default(Half), x);
								num7 = 1;
							}
							else
							{
								num7 = 0;
							}
						}
						llvm_lifetime_end_p0.Invoke(2L, &num5);
						llvm_lifetime_end_p0.Invoke(4L, &num4);
						int num8 = num7;
						if (num8 == 0)
						{
							continue;
						}
						if (num8 != 3)
						{
							break;
						}
					}
					llvm_lifetime_start_p0.Invoke(8L, &fputil_NormalFloat_epbrnk4);
					*(int*)(&fputil_NormalFloat_epbrnk4) = -1431655766;
					((short*)(&fputil_NormalFloat_epbrnk4))[2] = -21846;
					((sbyte*)(&fputil_NormalFloat_epbrnk4))[6] = -86;
					((sbyte*)(&fputil_NormalFloat_epbrnk4))[7] = -86;
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb14, Sign_POS.Pointer, 1L, isVolatile: false);
					fputil_NormalFloat_Float16_NormalFloat_Sign_int_unsigned_short.Invoke(e: checked(num + fputil_NormalFloat_epbrnk3.exponent), m: num2, @this: &fputil_NormalFloat_epbrnk4, s: anon_izyfb14.val);
					llvm_lifetime_start_p0.Invoke(2L, &half);
					half = fputil_NormalFloat_Float16_operator_Float16_const.Invoke(&fputil_NormalFloat_epbrnk4);
					llvm_lifetime_start_p0.Invoke(2L, &half2);
					half2 = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva3);
					llvm_lifetime_start_p0.Invoke(4L, &num6);
					llvm_lifetime_start_p0.Invoke(8L, &fputil_NormalFloat_epbrnk5);
					*(InlineArray7_Byte*)(&fputil_NormalFloat_epbrnk5) = NumericHelper.TruncOrZextToBytes<long, InlineArray7_Byte>(fputil_NormalFloat_Float16_mul2_int_const.Invoke(&fputil_NormalFloat_epbrnk4, 1));
					int num9 = fputil_NormalFloat_Float16_cmp_fputil_NormalFloat_Float16_const_const.Invoke(&fputil_NormalFloat_epbrnk5, &fputil_NormalFloat_epbrnk3);
					llvm_lifetime_end_p0.Invoke(8L, &fputil_NormalFloat_epbrnk5);
					num6 = num9;
					if (num6 > 0)
					{
						checked
						{
							(*unchecked((int*)q))++;
						}
						half = ((!NumericHelper.FcmpOge(x, default(Half))) ? ((Half)((float)half2 - (float)half)) : ((Half)((float)half - (float)half2)));
					}
					else if (num6 == 0)
					{
						if ((*(int*)q & 1) != 0)
						{
							checked
							{
								(*unchecked((int*)q))++;
							}
							if (NumericHelper.FcmpOge(x, default(Half)))
							{
								half = (Half)(0f - (float)half);
							}
						}
						else if (NumericHelper.FcmpOlt(x, default(Half)))
						{
							half = (Half)(0f - (float)half);
						}
					}
					else if (NumericHelper.FcmpOlt(x, default(Half)))
					{
						half = (Half)(0f - (float)half);
					}
					*(int*)q = ((!Sign_is_neg_const.Invoke(&anon_izyfb9)) ? (*(int*)q) : checked(-(*unchecked((int*)q))));
					result = ((!NumericHelper.FcmpOeq(half, default(Half))) ? half : Float16_fputil_copysign_Float16_0_Float16_Float16.Invoke(default(Half), x));
					llvm_lifetime_end_p0.Invoke(4L, &num6);
					llvm_lifetime_end_p0.Invoke(2L, &half2);
					llvm_lifetime_end_p0.Invoke(2L, &half);
					llvm_lifetime_end_p0.Invoke(8L, &fputil_NormalFloat_epbrnk4);
					break;
				}
				llvm_lifetime_end_p0.Invoke(2L, &num3);
				llvm_lifetime_end_p0.Invoke(2L, &num2);
				llvm_lifetime_end_p0.Invoke(4L, &num);
				llvm_lifetime_end_p0.Invoke(8L, &fputil_NormalFloat_epbrnk3);
				llvm_lifetime_end_p0.Invoke(8L, &fputil_NormalFloat_epbrnk2);
				llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb9);
			}
			llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva3);
			llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
			return result;
		}
	}
}
