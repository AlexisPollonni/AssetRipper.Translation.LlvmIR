using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil6remquoIfTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_S4_Ri")]
[DemangledName("float __llvm_libc_20_1_2_::fputil::remquo<float, 0>(float, float, int&)")]
internal static partial class float_fputil_remquo_float_0_float_float_int
{
	public unsafe static float Invoke(float x, float y, void* q)
	{
		float result = 0f;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(fputil_FPBits_5nkvcs);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs4 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb11 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb12 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb13 = default(anon_izyfb7);
		fputil_NormalFloat_i65f6x fputil_NormalFloat_i65f6x2 = default(fputil_NormalFloat_i65f6x);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs5 = default(fputil_FPBits_5nkvcs);
		fputil_NormalFloat_i65f6x fputil_NormalFloat_i65f6x3 = default(fputil_NormalFloat_i65f6x);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs6 = default(fputil_FPBits_5nkvcs);
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		fputil_NormalFloat_i65f6x fputil_NormalFloat_i65f6x4 = default(fputil_NormalFloat_i65f6x);
		anon_izyfb7 anon_izyfb14 = default(anon_izyfb7);
		float num6 = 0f;
		float num7 = 0f;
		int num8 = 0;
		fputil_NormalFloat_i65f6x fputil_NormalFloat_i65f6x5 = default(fputil_NormalFloat_i65f6x);
		Struct_8myw6y struct_8myw6y = default(Struct_8myw6y);
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs2) = -1431655766;
			fputil_FPBits_float_FPBits_float_float.Invoke(&fputil_FPBits_5nkvcs2, x);
			llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
			*(int*)(&fputil_FPBits_5nkvcs3) = -1431655766;
			fputil_FPBits_float_FPBits_float_float.Invoke(&fputil_FPBits_5nkvcs3, y);
			if (fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan_const.Invoke(&fputil_FPBits_5nkvcs2))
			{
				result = x;
			}
			else if (fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan_const.Invoke(&fputil_FPBits_5nkvcs3))
			{
				result = y;
			}
			else if (fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_inf_const.Invoke(&fputil_FPBits_5nkvcs2) || fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_zero_const.Invoke(&fputil_FPBits_5nkvcs3))
			{
				llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
				int field_ = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan_Sign_unsigned_int.Invoke(anon_izyfb8.val, 0);
				fputil_FPBits_5nkvcs4.FPRepImpl.FPRepSem.field_0.field_0 = field_;
				result = fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs4);
				llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
			}
			else if (fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_zero_const.Invoke(&fputil_FPBits_5nkvcs2))
			{
				*(int*)q = 0;
				result = float_fputil_copysign_float_0_float_float.Invoke(0f, x);
			}
			else if (fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_inf_const.Invoke(&fputil_FPBits_5nkvcs3))
			{
				*(int*)q = 0;
				result = x;
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb9);
				*(sbyte*)(&anon_izyfb9) = -86;
				anon_izyfb10.val = fputil_internal_FPStorage_fputil_FPType_1_sign_const.Invoke(&fputil_FPBits_5nkvcs2);
				anon_izyfb11.val = fputil_internal_FPStorage_fputil_FPType_1_sign_const.Invoke(&fputil_FPBits_5nkvcs3);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, (!operator_Sign_Sign_fy8fvt.Invoke(anon_izyfb10.val, anon_izyfb11.val)) ? Sign_NEG.Pointer : Sign_POS.Pointer, 1L, isVolatile: false);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb12, Sign_POS.Pointer, 1L, isVolatile: false);
				fputil_internal_FPStorage_fputil_FPType_1_set_sign_Sign.Invoke(&fputil_FPBits_5nkvcs2, anon_izyfb12.val);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb13, Sign_POS.Pointer, 1L, isVolatile: false);
				fputil_internal_FPStorage_fputil_FPType_1_set_sign_Sign.Invoke(&fputil_FPBits_5nkvcs3, anon_izyfb13.val);
				llvm_lifetime_start_p0.Invoke(12L, &fputil_NormalFloat_i65f6x2);
				*(int*)(&fputil_NormalFloat_i65f6x2) = -1431655766;
				((int*)(&fputil_NormalFloat_i65f6x2))[1] = -1431655766;
				((sbyte*)(&fputil_NormalFloat_i65f6x2))[8] = -86;
				sbyte* ptr = (sbyte*)(&fputil_NormalFloat_i65f6x2) + 9;
				*ptr = -86;
				ptr[1] = -86;
				ptr[2] = -86;
				llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_5nkvcs5, &fputil_FPBits_5nkvcs2, 4L, isVolatile: false);
				fputil_NormalFloat_float_NormalFloat_fputil_FPBits_float.Invoke(&fputil_NormalFloat_i65f6x2, fputil_FPBits_5nkvcs5.FPRepImpl.FPRepSem.field_0.field_0);
				llvm_lifetime_start_p0.Invoke(12L, &fputil_NormalFloat_i65f6x3);
				*(int*)(&fputil_NormalFloat_i65f6x3) = -1431655766;
				((int*)(&fputil_NormalFloat_i65f6x3))[1] = -1431655766;
				((sbyte*)(&fputil_NormalFloat_i65f6x3))[8] = -86;
				sbyte* ptr2 = (sbyte*)(&fputil_NormalFloat_i65f6x3) + 9;
				*ptr2 = -86;
				ptr2[1] = -86;
				ptr2[2] = -86;
				llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_5nkvcs6, &fputil_FPBits_5nkvcs3, 4L, isVolatile: false);
				fputil_NormalFloat_float_NormalFloat_fputil_FPBits_float.Invoke(&fputil_NormalFloat_i65f6x3, fputil_FPBits_5nkvcs6.FPRepImpl.FPRepSem.field_0.field_0);
				llvm_lifetime_start_p0.Invoke(4L, &num);
				num = checked(fputil_NormalFloat_i65f6x2.exponent - fputil_NormalFloat_i65f6x3.exponent);
				llvm_lifetime_start_p0.Invoke(4L, &num2);
				num2 = fputil_NormalFloat_i65f6x2.mantissa;
				llvm_lifetime_start_p0.Invoke(4L, &num3);
				num3 = fputil_NormalFloat_i65f6x3.mantissa;
				*(int*)q = 0;
				while (true)
				{
					if (num >= 0)
					{
						llvm_lifetime_start_p0.Invoke(4L, &num4);
						num4 = 0;
						llvm_lifetime_start_p0.Invoke(4L, &num5);
						num5 = num2;
						num4 = 0;
						while ((uint)num5 < (uint)num3)
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
							if (num2 == 0)
							{
								*(int*)q = ((!Sign_is_neg_const.Invoke(&anon_izyfb9)) ? (*(int*)q) : checked(-(*unchecked((int*)q))));
								result = float_fputil_copysign_float_0_float_float.Invoke(0f, x);
								num9 = 1;
							}
							else
							{
								num9 = 0;
							}
						}
						llvm_lifetime_end_p0.Invoke(4L, &num5);
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
					llvm_lifetime_start_p0.Invoke(12L, &fputil_NormalFloat_i65f6x4);
					*(int*)(&fputil_NormalFloat_i65f6x4) = -1431655766;
					((int*)(&fputil_NormalFloat_i65f6x4))[1] = -1431655766;
					((sbyte*)(&fputil_NormalFloat_i65f6x4))[8] = -86;
					sbyte* ptr3 = (sbyte*)(&fputil_NormalFloat_i65f6x4) + 9;
					*ptr3 = -86;
					ptr3[1] = -86;
					ptr3[2] = -86;
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb14, Sign_POS.Pointer, 1L, isVolatile: false);
					checked
					{
						fputil_NormalFloat_float_NormalFloat_Sign_int_unsigned_int.Invoke(e: num + fputil_NormalFloat_i65f6x3.exponent, m: num2, @this: &fputil_NormalFloat_i65f6x4, s: anon_izyfb14.val);
						llvm_lifetime_start_p0.Invoke(4L, &num6);
						num6 = fputil_NormalFloat_float_operator_float_const.Invoke(&fputil_NormalFloat_i65f6x4);
						llvm_lifetime_start_p0.Invoke(4L, &num7);
						num7 = fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs3);
						llvm_lifetime_start_p0.Invoke(4L, &num8);
						llvm_lifetime_start_p0.Invoke(12L, &fputil_NormalFloat_i65f6x5);
						struct_8myw6y = fputil_NormalFloat_float_mul2_int_const.Invoke(&fputil_NormalFloat_i65f6x4, 1);
						llvm_memcpy_p0_p0_i64.Invoke(&fputil_NormalFloat_i65f6x5, &struct_8myw6y, 9L, isVolatile: false);
						int num11 = fputil_NormalFloat_float_cmp_fputil_NormalFloat_float_const_const.Invoke(&fputil_NormalFloat_i65f6x5, &fputil_NormalFloat_i65f6x3);
						llvm_lifetime_end_p0.Invoke(12L, &fputil_NormalFloat_i65f6x5);
						num8 = num11;
						if (num8 > 0)
						{
							(*unchecked((int*)q))++;
							num6 = ((x < 0f) ? (num7 - num6) : (num6 - num7));
						}
						else if (num8 == 0)
						{
							if ((*unchecked((int*)q) & 1) != 0)
							{
								(*unchecked((int*)q))++;
								if (!(x < 0f))
								{
									num6 = 0f - num6;
								}
							}
							else if (x < 0f)
							{
								num6 = 0f - num6;
							}
						}
						else if (x < 0f)
						{
							num6 = 0f - num6;
						}
						*unchecked((int*)q) = ((!Sign_is_neg_const.Invoke(&anon_izyfb9)) ? (*unchecked((int*)q)) : (-(*unchecked((int*)q))));
						result = ((num6 != 0f) ? num6 : float_fputil_copysign_float_0_float_float.Invoke(0f, x));
						llvm_lifetime_end_p0.Invoke(4L, &num8);
						llvm_lifetime_end_p0.Invoke(4L, &num7);
						llvm_lifetime_end_p0.Invoke(4L, &num6);
						llvm_lifetime_end_p0.Invoke(12L, &fputil_NormalFloat_i65f6x4);
						break;
					}
				}
				llvm_lifetime_end_p0.Invoke(4L, &num3);
				llvm_lifetime_end_p0.Invoke(4L, &num2);
				llvm_lifetime_end_p0.Invoke(4L, &num);
				llvm_lifetime_end_p0.Invoke(12L, &fputil_NormalFloat_i65f6x3);
				llvm_lifetime_end_p0.Invoke(12L, &fputil_NormalFloat_i65f6x2);
				llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb9);
			}
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
			return result;
		}
	}
}
