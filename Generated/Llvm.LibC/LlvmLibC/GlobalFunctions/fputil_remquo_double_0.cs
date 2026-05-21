using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_remquo_double_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil6remquoIdTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_S4_Ri")]
	[DemangledName("double __llvm_libc_20_1_2_::fputil::remquo<double, 0>(double, double, int&)")]
	[return: NativeType("double")]
	public unsafe static double Invoke([NativeType("double")] double x, [NativeType("double")] double y, [NativeType("int&")] void* q)
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
		fputil_NormalFloat_vc4yvk fputil_NormalFloat_vc4yvk2 = default(fputil_NormalFloat_vc4yvk);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm5 = default(fputil_FPBits_wjhbrm);
		fputil_NormalFloat_vc4yvk fputil_NormalFloat_vc4yvk3 = default(fputil_NormalFloat_vc4yvk);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm6 = default(fputil_FPBits_wjhbrm);
		int num = 0;
		long num2 = 0L;
		long num3 = 0L;
		int num4 = 0;
		long num5 = 0L;
		fputil_NormalFloat_vc4yvk fputil_NormalFloat_vc4yvk4 = default(fputil_NormalFloat_vc4yvk);
		anon_izyfb7 anon_izyfb14 = default(anon_izyfb7);
		double num6 = 0.0;
		double num7 = 0.0;
		int num8 = 0;
		fputil_NormalFloat_vc4yvk fputil_NormalFloat_vc4yvk5 = default(fputil_NormalFloat_vc4yvk);
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		unchecked
		{
			*(long*)(&fputil_FPBits_wjhbrm2) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm2, x);
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
			*(long*)(&fputil_FPBits_wjhbrm3) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm3, y);
			if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_nan.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2)))
			{
				result = x;
			}
			else if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_nan.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm3)))
			{
				result = y;
			}
			else if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_inf.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2)) || FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm3)))
			{
				llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
				long val = FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan.Invoke(anon_izyfb8.val, 0L);
				fputil_FPBits_wjhbrm4.FPRepImpl.FPRepSem.FPStorage.val = val;
				result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm4);
				llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
			}
			else if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2)))
			{
				*(int*)q = 0;
				result = fputil_copysign_double_0.Invoke(0.0, x);
			}
			else if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_inf.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm3)))
			{
				*(int*)q = 0;
				result = x;
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb9);
				*(sbyte*)(&anon_izyfb9) = -86;
				anon_izyfb10.val = FPStorage_fputil_FPType_2_sign.Invoke(&fputil_FPBits_wjhbrm2);
				anon_izyfb11.val = FPStorage_fputil_FPType_2_sign.Invoke(&fputil_FPBits_wjhbrm3);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, (!Equals_fy8fvt.Invoke(anon_izyfb10.val, anon_izyfb11.val)) ? Sign_NEG.Pointer : Sign_POS.Pointer, 1L, isVolatile: false);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb12, Sign_POS.Pointer, 1L, isVolatile: false);
				FPStorage_fputil_FPType_2_set_sign.Invoke(&fputil_FPBits_wjhbrm2, anon_izyfb12.val);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb13, Sign_POS.Pointer, 1L, isVolatile: false);
				FPStorage_fputil_FPType_2_set_sign.Invoke(&fputil_FPBits_wjhbrm3, anon_izyfb13.val);
				llvm_lifetime_start_p0.Invoke(24L, &fputil_NormalFloat_vc4yvk2);
				*(int*)(&fputil_NormalFloat_vc4yvk2) = -1431655766;
				sbyte* ptr = (sbyte*)(&fputil_NormalFloat_vc4yvk2) + 4;
				*ptr = -86;
				ptr[1] = -86;
				ptr[2] = -86;
				ptr[3] = -86;
				((long*)(&fputil_NormalFloat_vc4yvk2))[1] = -6148914691236517206L;
				((sbyte*)(&fputil_NormalFloat_vc4yvk2))[16] = -86;
				sbyte* ptr2 = (sbyte*)(&fputil_NormalFloat_vc4yvk2) + 17;
				*ptr2 = -86;
				ptr2[1] = -86;
				ptr2[2] = -86;
				ptr2[3] = -86;
				ptr2[4] = -86;
				ptr2[5] = -86;
				ptr2[6] = -86;
				llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_wjhbrm5, &fputil_FPBits_wjhbrm2, 8L, isVolatile: false);
				NormalFloat_double_Constructor.Invoke(&fputil_NormalFloat_vc4yvk2, fputil_FPBits_wjhbrm5.FPRepImpl.FPRepSem.FPStorage.val);
				llvm_lifetime_start_p0.Invoke(24L, &fputil_NormalFloat_vc4yvk3);
				*(int*)(&fputil_NormalFloat_vc4yvk3) = -1431655766;
				sbyte* ptr3 = (sbyte*)(&fputil_NormalFloat_vc4yvk3) + 4;
				*ptr3 = -86;
				ptr3[1] = -86;
				ptr3[2] = -86;
				ptr3[3] = -86;
				((long*)(&fputil_NormalFloat_vc4yvk3))[1] = -6148914691236517206L;
				((sbyte*)(&fputil_NormalFloat_vc4yvk3))[16] = -86;
				sbyte* ptr4 = (sbyte*)(&fputil_NormalFloat_vc4yvk3) + 17;
				*ptr4 = -86;
				ptr4[1] = -86;
				ptr4[2] = -86;
				ptr4[3] = -86;
				ptr4[4] = -86;
				ptr4[5] = -86;
				ptr4[6] = -86;
				llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_wjhbrm6, &fputil_FPBits_wjhbrm3, 8L, isVolatile: false);
				NormalFloat_double_Constructor.Invoke(&fputil_NormalFloat_vc4yvk3, fputil_FPBits_wjhbrm6.FPRepImpl.FPRepSem.FPStorage.val);
				llvm_lifetime_start_p0.Invoke(4L, &num);
				num = checked(fputil_NormalFloat_vc4yvk2.exponent - fputil_NormalFloat_vc4yvk3.exponent);
				llvm_lifetime_start_p0.Invoke(8L, &num2);
				num2 = fputil_NormalFloat_vc4yvk2.mantissa;
				llvm_lifetime_start_p0.Invoke(8L, &num3);
				num3 = fputil_NormalFloat_vc4yvk3.mantissa;
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
								*(int*)q = ((!Sign_is_neg.Invoke(&anon_izyfb9)) ? (*(int*)q) : checked(-(*unchecked((int*)q))));
								result = fputil_copysign_double_0.Invoke(0.0, x);
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
					llvm_lifetime_start_p0.Invoke(24L, &fputil_NormalFloat_vc4yvk4);
					*(int*)(&fputil_NormalFloat_vc4yvk4) = -1431655766;
					sbyte* ptr5 = (sbyte*)(&fputil_NormalFloat_vc4yvk4) + 4;
					*ptr5 = -86;
					ptr5[1] = -86;
					ptr5[2] = -86;
					ptr5[3] = -86;
					((long*)(&fputil_NormalFloat_vc4yvk4))[1] = -6148914691236517206L;
					((sbyte*)(&fputil_NormalFloat_vc4yvk4))[16] = -86;
					sbyte* ptr6 = (sbyte*)(&fputil_NormalFloat_vc4yvk4) + 17;
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
						NormalFloat_double_Constructor.Invoke(e: num + fputil_NormalFloat_vc4yvk3.exponent, m: num2, @this: &fputil_NormalFloat_vc4yvk4, s: anon_izyfb14.val);
						llvm_lifetime_start_p0.Invoke(8L, &num6);
						num6 = NormalFloat_double_ToDouble.Invoke(&fputil_NormalFloat_vc4yvk4);
						llvm_lifetime_start_p0.Invoke(8L, &num7);
						num7 = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm3);
						llvm_lifetime_start_p0.Invoke(4L, &num8);
						llvm_lifetime_start_p0.Invoke(24L, &fputil_NormalFloat_vc4yvk5);
						NormalFloat_double_mul2.Invoke(&fputil_NormalFloat_vc4yvk5, &fputil_NormalFloat_vc4yvk4, 1);
						int num11 = NormalFloat_double_cmp.Invoke(&fputil_NormalFloat_vc4yvk5, &fputil_NormalFloat_vc4yvk3);
						llvm_lifetime_end_p0.Invoke(24L, &fputil_NormalFloat_vc4yvk5);
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
						*unchecked((int*)q) = ((!Sign_is_neg.Invoke(&anon_izyfb9)) ? (*unchecked((int*)q)) : (-(*unchecked((int*)q))));
						result = ((num6 != 0.0) ? num6 : fputil_copysign_double_0.Invoke(0.0, x));
						llvm_lifetime_end_p0.Invoke(4L, &num8);
						llvm_lifetime_end_p0.Invoke(8L, &num7);
						llvm_lifetime_end_p0.Invoke(8L, &num6);
						llvm_lifetime_end_p0.Invoke(24L, &fputil_NormalFloat_vc4yvk4);
						break;
					}
				}
				llvm_lifetime_end_p0.Invoke(8L, &num3);
				llvm_lifetime_end_p0.Invoke(8L, &num2);
				llvm_lifetime_end_p0.Invoke(4L, &num);
				llvm_lifetime_end_p0.Invoke(24L, &fputil_NormalFloat_vc4yvk3);
				llvm_lifetime_end_p0.Invoke(24L, &fputil_NormalFloat_vc4yvk2);
				llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb9);
			}
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			return result;
		}
	}
}
