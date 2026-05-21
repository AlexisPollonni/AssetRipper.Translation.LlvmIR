using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_remquo_double_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil6remquoIdTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_S4_Ri")]
	[DemangledName("double __llvm_libc_20_1_2_::fputil::remquo<double, 0>(double, double, int&)")]
	[return: NativeType("double")]
	public unsafe static double Invoke([MangledName("x")][NativeType("double")] double X, [MangledName("y")][NativeType("double")] double Y, [MangledName("q")][NativeType("int&")] void* Q)
	{
		double result = 0.0;
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm2 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm3 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb4 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb5 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb6 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_NormalFloat_vc4yvk llvm_libc_20_1_2_fputil_NormalFloat_vc4yvk = default(Llvm_libc_20_1_2_fputil_NormalFloat_vc4yvk);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm4 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Llvm_libc_20_1_2_fputil_NormalFloat_vc4yvk llvm_libc_20_1_2_fputil_NormalFloat_vc4yvk2 = default(Llvm_libc_20_1_2_fputil_NormalFloat_vc4yvk);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm5 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		int num = 0;
		long num2 = 0L;
		long num3 = 0L;
		int num4 = 0;
		long num5 = 0L;
		Llvm_libc_20_1_2_fputil_NormalFloat_vc4yvk llvm_libc_20_1_2_fputil_NormalFloat_vc4yvk3 = default(Llvm_libc_20_1_2_fputil_NormalFloat_vc4yvk);
		Anon_izyfb7 anon_izyfb7 = default(Anon_izyfb7);
		double num6 = 0.0;
		double num7 = 0.0;
		int num8 = 0;
		Llvm_libc_20_1_2_fputil_NormalFloat_vc4yvk llvm_libc_20_1_2_fputil_NormalFloat_vc4yvk4 = default(Llvm_libc_20_1_2_fputil_NormalFloat_vc4yvk);
		Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		unchecked
		{
			*(long*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm, X);
			Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm2);
			*(long*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm2) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm2, Y);
			if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_nan.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm)))
			{
				result = X;
			}
			else if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_nan.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm2)))
			{
				result = Y;
			}
			else if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_inf.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm)) || FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm2)))
			{
				Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm3);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
				long val = FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan.Invoke(anon_izyfb.Val, 0L);
				llvm_libc_20_1_2_fputil_FPBits_wjhbrm3.FPRepImpl.FPRepSem.FPStorage.Val = val;
				result = FPBits_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm3);
				Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm3);
			}
			else if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm)))
			{
				*(int*)Q = 0;
				result = Fputil_copysign_double_0.Invoke(0.0, X);
			}
			else if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_inf.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm2)))
			{
				*(int*)Q = 0;
				result = X;
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb2);
				*(sbyte*)(&anon_izyfb2) = -86;
				anon_izyfb3.Val = FPStorage_fputil_FPType_2_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
				anon_izyfb4.Val = FPStorage_fputil_FPType_2_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm2);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, (!Llvm_libc_20_1_2_Equals_fy8fvt.Invoke(anon_izyfb3.Val, anon_izyfb4.Val)) ? Llvm_libc_20_1_2_Sign_NEG.Pointer : Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb5, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
				FPStorage_fputil_FPType_2_set_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm, anon_izyfb5.Val);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb6, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
				FPStorage_fputil_FPType_2_set_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm2, anon_izyfb6.Val);
				Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_NormalFloat_vc4yvk);
				*(int*)(&llvm_libc_20_1_2_fputil_NormalFloat_vc4yvk) = -1431655766;
				sbyte* ptr = (sbyte*)(&llvm_libc_20_1_2_fputil_NormalFloat_vc4yvk) + 4;
				*ptr = -86;
				ptr[1] = -86;
				ptr[2] = -86;
				ptr[3] = -86;
				((long*)(&llvm_libc_20_1_2_fputil_NormalFloat_vc4yvk))[1] = -6148914691236517206L;
				((sbyte*)(&llvm_libc_20_1_2_fputil_NormalFloat_vc4yvk))[16] = -86;
				sbyte* ptr2 = (sbyte*)(&llvm_libc_20_1_2_fputil_NormalFloat_vc4yvk) + 17;
				*ptr2 = -86;
				ptr2[1] = -86;
				ptr2[2] = -86;
				ptr2[3] = -86;
				ptr2[4] = -86;
				ptr2[5] = -86;
				ptr2[6] = -86;
				Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm4, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm, 8L, isVolatile: false);
				NormalFloat_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_NormalFloat_vc4yvk, llvm_libc_20_1_2_fputil_FPBits_wjhbrm4.FPRepImpl.FPRepSem.FPStorage.Val);
				Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_NormalFloat_vc4yvk2);
				*(int*)(&llvm_libc_20_1_2_fputil_NormalFloat_vc4yvk2) = -1431655766;
				sbyte* ptr3 = (sbyte*)(&llvm_libc_20_1_2_fputil_NormalFloat_vc4yvk2) + 4;
				*ptr3 = -86;
				ptr3[1] = -86;
				ptr3[2] = -86;
				ptr3[3] = -86;
				((long*)(&llvm_libc_20_1_2_fputil_NormalFloat_vc4yvk2))[1] = -6148914691236517206L;
				((sbyte*)(&llvm_libc_20_1_2_fputil_NormalFloat_vc4yvk2))[16] = -86;
				sbyte* ptr4 = (sbyte*)(&llvm_libc_20_1_2_fputil_NormalFloat_vc4yvk2) + 17;
				*ptr4 = -86;
				ptr4[1] = -86;
				ptr4[2] = -86;
				ptr4[3] = -86;
				ptr4[4] = -86;
				ptr4[5] = -86;
				ptr4[6] = -86;
				Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm5, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm2, 8L, isVolatile: false);
				NormalFloat_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_NormalFloat_vc4yvk2, llvm_libc_20_1_2_fputil_FPBits_wjhbrm5.FPRepImpl.FPRepSem.FPStorage.Val);
				Llvm_lifetime_start_p0.Invoke(4L, &num);
				num = checked(llvm_libc_20_1_2_fputil_NormalFloat_vc4yvk.Exponent - llvm_libc_20_1_2_fputil_NormalFloat_vc4yvk2.Exponent);
				Llvm_lifetime_start_p0.Invoke(8L, &num2);
				num2 = llvm_libc_20_1_2_fputil_NormalFloat_vc4yvk.Mantissa;
				Llvm_lifetime_start_p0.Invoke(8L, &num3);
				num3 = llvm_libc_20_1_2_fputil_NormalFloat_vc4yvk2.Mantissa;
				*(int*)Q = 0;
				while (true)
				{
					if (num >= 0)
					{
						Llvm_lifetime_start_p0.Invoke(4L, &num4);
						num4 = 0;
						Llvm_lifetime_start_p0.Invoke(8L, &num5);
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
								*(int*)Q |= 1 << num;
							}
							num2 = num5 - num3;
							if (num2 == 0L)
							{
								*(int*)Q = ((!Sign_is_neg.Invoke(&anon_izyfb2)) ? (*(int*)Q) : checked(-(*unchecked((int*)Q))));
								result = Fputil_copysign_double_0.Invoke(0.0, X);
								num9 = 1;
							}
							else
							{
								num9 = 0;
							}
						}
						Llvm_lifetime_end_p0.Invoke(8L, &num5);
						Llvm_lifetime_end_p0.Invoke(4L, &num4);
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
					Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_NormalFloat_vc4yvk3);
					*(int*)(&llvm_libc_20_1_2_fputil_NormalFloat_vc4yvk3) = -1431655766;
					sbyte* ptr5 = (sbyte*)(&llvm_libc_20_1_2_fputil_NormalFloat_vc4yvk3) + 4;
					*ptr5 = -86;
					ptr5[1] = -86;
					ptr5[2] = -86;
					ptr5[3] = -86;
					((long*)(&llvm_libc_20_1_2_fputil_NormalFloat_vc4yvk3))[1] = -6148914691236517206L;
					((sbyte*)(&llvm_libc_20_1_2_fputil_NormalFloat_vc4yvk3))[16] = -86;
					sbyte* ptr6 = (sbyte*)(&llvm_libc_20_1_2_fputil_NormalFloat_vc4yvk3) + 17;
					*ptr6 = -86;
					ptr6[1] = -86;
					ptr6[2] = -86;
					ptr6[3] = -86;
					ptr6[4] = -86;
					ptr6[5] = -86;
					ptr6[6] = -86;
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb7, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
					checked
					{
						NormalFloat_double_Constructor.Invoke(E: num + llvm_libc_20_1_2_fputil_NormalFloat_vc4yvk2.Exponent, M: num2, This: &llvm_libc_20_1_2_fputil_NormalFloat_vc4yvk3, S: anon_izyfb7.Val);
						Llvm_lifetime_start_p0.Invoke(8L, &num6);
						num6 = NormalFloat_double_ToDouble.Invoke(&llvm_libc_20_1_2_fputil_NormalFloat_vc4yvk3);
						Llvm_lifetime_start_p0.Invoke(8L, &num7);
						num7 = FPBits_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm2);
						Llvm_lifetime_start_p0.Invoke(4L, &num8);
						Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_NormalFloat_vc4yvk4);
						NormalFloat_double_mul2.Invoke(&llvm_libc_20_1_2_fputil_NormalFloat_vc4yvk4, &llvm_libc_20_1_2_fputil_NormalFloat_vc4yvk3, 1);
						int num11 = NormalFloat_double_cmp.Invoke(&llvm_libc_20_1_2_fputil_NormalFloat_vc4yvk4, &llvm_libc_20_1_2_fputil_NormalFloat_vc4yvk2);
						Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_NormalFloat_vc4yvk4);
						num8 = num11;
						if (num8 > 0)
						{
							(*unchecked((int*)Q))++;
							num6 = ((X < 0.0) ? (num7 - num6) : (num6 - num7));
						}
						else if (num8 == 0)
						{
							if ((*unchecked((int*)Q) & 1) != 0)
							{
								(*unchecked((int*)Q))++;
								if (!(X < 0.0))
								{
									num6 = 0.0 - num6;
								}
							}
							else if (X < 0.0)
							{
								num6 = 0.0 - num6;
							}
						}
						else if (X < 0.0)
						{
							num6 = 0.0 - num6;
						}
						*unchecked((int*)Q) = ((!Sign_is_neg.Invoke(&anon_izyfb2)) ? (*unchecked((int*)Q)) : (-(*unchecked((int*)Q))));
						result = ((num6 != 0.0) ? num6 : Fputil_copysign_double_0.Invoke(0.0, X));
						Llvm_lifetime_end_p0.Invoke(4L, &num8);
						Llvm_lifetime_end_p0.Invoke(8L, &num7);
						Llvm_lifetime_end_p0.Invoke(8L, &num6);
						Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_NormalFloat_vc4yvk3);
						break;
					}
				}
				Llvm_lifetime_end_p0.Invoke(8L, &num3);
				Llvm_lifetime_end_p0.Invoke(8L, &num2);
				Llvm_lifetime_end_p0.Invoke(4L, &num);
				Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_NormalFloat_vc4yvk2);
				Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_NormalFloat_vc4yvk);
				Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb2);
			}
			Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm2);
			Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
			return result;
		}
	}
}
