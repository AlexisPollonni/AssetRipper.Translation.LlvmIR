using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_remquo_float_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil6remquoIfTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_S4_Ri")]
	[DemangledName("float __llvm_libc_20_1_2_::fputil::remquo<float, 0>(float, float, int&)")]
	[return: NativeType("float")]
	public unsafe static float Invoke([MangledName("x")][NativeType("float")] float X, [MangledName("y")][NativeType("float")] float Y, [MangledName("q")][NativeType("int&")] void* Q)
	{
		float result = 0f;
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs2 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs3 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb4 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb5 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb6 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_NormalFloat_phu2qv llvm_libc_20_1_2_fputil_NormalFloat_phu2qv = default(Llvm_libc_20_1_2_fputil_NormalFloat_phu2qv);
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs4 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Llvm_libc_20_1_2_fputil_NormalFloat_phu2qv llvm_libc_20_1_2_fputil_NormalFloat_phu2qv2 = default(Llvm_libc_20_1_2_fputil_NormalFloat_phu2qv);
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs5 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		Llvm_libc_20_1_2_fputil_NormalFloat_phu2qv llvm_libc_20_1_2_fputil_NormalFloat_phu2qv3 = default(Llvm_libc_20_1_2_fputil_NormalFloat_phu2qv);
		Anon_izyfb7 anon_izyfb7 = default(Anon_izyfb7);
		float num6 = 0f;
		float num7 = 0f;
		int num8 = 0;
		Llvm_libc_20_1_2_fputil_NormalFloat_phu2qv llvm_libc_20_1_2_fputil_NormalFloat_phu2qv4 = default(Llvm_libc_20_1_2_fputil_NormalFloat_phu2qv);
		Struct_8myw6y struct_8myw6y = default(Struct_8myw6y);
		Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		unchecked
		{
			*(int*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs) = -1431655766;
			FPBits_float_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs, X);
			Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
			*(int*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2) = -1431655766;
			FPBits_float_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2, Y);
			if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs))
			{
				result = X;
			}
			else if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2))
			{
				result = Y;
			}
			else if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_inf.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs) || FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_zero.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2))
			{
				Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs3);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
				int field_ = FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan.Invoke(anon_izyfb.Val, 0);
				llvm_libc_20_1_2_fputil_FPBits_5nkvcs3.FPRepImpl.FPRepSem.field_0.field_0 = field_;
				result = FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs3);
				Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs3);
			}
			else if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_zero.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs))
			{
				*(int*)Q = 0;
				result = Fputil_copysign_float_0.Invoke(0f, X);
			}
			else if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_inf.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2))
			{
				*(int*)Q = 0;
				result = X;
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb2);
				*(sbyte*)(&anon_izyfb2) = -86;
				anon_izyfb3.Val = FPStorage_fputil_FPType_1_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
				anon_izyfb4.Val = FPStorage_fputil_FPType_1_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, (!Llvm_libc_20_1_2_Equals_fy8fvt.Invoke(anon_izyfb3.Val, anon_izyfb4.Val)) ? Llvm_libc_20_1_2_Sign_NEG.Pointer : Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb5, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
				FPStorage_fputil_FPType_1_set_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs, anon_izyfb5.Val);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb6, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
				FPStorage_fputil_FPType_1_set_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2, anon_izyfb6.Val);
				Llvm_lifetime_start_p0.Invoke(12L, &llvm_libc_20_1_2_fputil_NormalFloat_phu2qv);
				*(int*)(&llvm_libc_20_1_2_fputil_NormalFloat_phu2qv) = -1431655766;
				((int*)(&llvm_libc_20_1_2_fputil_NormalFloat_phu2qv))[1] = -1431655766;
				((sbyte*)(&llvm_libc_20_1_2_fputil_NormalFloat_phu2qv))[8] = -86;
				sbyte* ptr = (sbyte*)(&llvm_libc_20_1_2_fputil_NormalFloat_phu2qv) + 9;
				*ptr = -86;
				ptr[1] = -86;
				ptr[2] = -86;
				Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs4, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs, 4L, isVolatile: false);
				NormalFloat_float_Constructor.Invoke(&llvm_libc_20_1_2_fputil_NormalFloat_phu2qv, llvm_libc_20_1_2_fputil_FPBits_5nkvcs4.FPRepImpl.FPRepSem.field_0.field_0);
				Llvm_lifetime_start_p0.Invoke(12L, &llvm_libc_20_1_2_fputil_NormalFloat_phu2qv2);
				*(int*)(&llvm_libc_20_1_2_fputil_NormalFloat_phu2qv2) = -1431655766;
				((int*)(&llvm_libc_20_1_2_fputil_NormalFloat_phu2qv2))[1] = -1431655766;
				((sbyte*)(&llvm_libc_20_1_2_fputil_NormalFloat_phu2qv2))[8] = -86;
				sbyte* ptr2 = (sbyte*)(&llvm_libc_20_1_2_fputil_NormalFloat_phu2qv2) + 9;
				*ptr2 = -86;
				ptr2[1] = -86;
				ptr2[2] = -86;
				Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs5, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs2, 4L, isVolatile: false);
				NormalFloat_float_Constructor.Invoke(&llvm_libc_20_1_2_fputil_NormalFloat_phu2qv2, llvm_libc_20_1_2_fputil_FPBits_5nkvcs5.FPRepImpl.FPRepSem.field_0.field_0);
				Llvm_lifetime_start_p0.Invoke(4L, &num);
				num = checked(llvm_libc_20_1_2_fputil_NormalFloat_phu2qv.Exponent - llvm_libc_20_1_2_fputil_NormalFloat_phu2qv2.Exponent);
				Llvm_lifetime_start_p0.Invoke(4L, &num2);
				num2 = llvm_libc_20_1_2_fputil_NormalFloat_phu2qv.Mantissa;
				Llvm_lifetime_start_p0.Invoke(4L, &num3);
				num3 = llvm_libc_20_1_2_fputil_NormalFloat_phu2qv2.Mantissa;
				*(int*)Q = 0;
				while (true)
				{
					if (num >= 0)
					{
						Llvm_lifetime_start_p0.Invoke(4L, &num4);
						num4 = 0;
						Llvm_lifetime_start_p0.Invoke(4L, &num5);
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
								*(int*)Q |= 1 << num;
							}
							num2 = num5 - num3;
							if (num2 == 0)
							{
								*(int*)Q = ((!Sign_is_neg.Invoke(&anon_izyfb2)) ? (*(int*)Q) : checked(-(*unchecked((int*)Q))));
								result = Fputil_copysign_float_0.Invoke(0f, X);
								num9 = 1;
							}
							else
							{
								num9 = 0;
							}
						}
						Llvm_lifetime_end_p0.Invoke(4L, &num5);
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
					Llvm_lifetime_start_p0.Invoke(12L, &llvm_libc_20_1_2_fputil_NormalFloat_phu2qv3);
					*(int*)(&llvm_libc_20_1_2_fputil_NormalFloat_phu2qv3) = -1431655766;
					((int*)(&llvm_libc_20_1_2_fputil_NormalFloat_phu2qv3))[1] = -1431655766;
					((sbyte*)(&llvm_libc_20_1_2_fputil_NormalFloat_phu2qv3))[8] = -86;
					sbyte* ptr3 = (sbyte*)(&llvm_libc_20_1_2_fputil_NormalFloat_phu2qv3) + 9;
					*ptr3 = -86;
					ptr3[1] = -86;
					ptr3[2] = -86;
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb7, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
					checked
					{
						NormalFloat_float_Constructor.Invoke(E: num + llvm_libc_20_1_2_fputil_NormalFloat_phu2qv2.Exponent, M: num2, This: &llvm_libc_20_1_2_fputil_NormalFloat_phu2qv3, S: anon_izyfb7.Val);
						Llvm_lifetime_start_p0.Invoke(4L, &num6);
						num6 = NormalFloat_float_ToSingle.Invoke(&llvm_libc_20_1_2_fputil_NormalFloat_phu2qv3);
						Llvm_lifetime_start_p0.Invoke(4L, &num7);
						num7 = FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
						Llvm_lifetime_start_p0.Invoke(4L, &num8);
						Llvm_lifetime_start_p0.Invoke(12L, &llvm_libc_20_1_2_fputil_NormalFloat_phu2qv4);
						struct_8myw6y = NormalFloat_float_mul2.Invoke(&llvm_libc_20_1_2_fputil_NormalFloat_phu2qv3, 1);
						Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_NormalFloat_phu2qv4, &struct_8myw6y, 9L, isVolatile: false);
						int num11 = NormalFloat_float_cmp.Invoke(&llvm_libc_20_1_2_fputil_NormalFloat_phu2qv4, &llvm_libc_20_1_2_fputil_NormalFloat_phu2qv2);
						Llvm_lifetime_end_p0.Invoke(12L, &llvm_libc_20_1_2_fputil_NormalFloat_phu2qv4);
						num8 = num11;
						if (num8 > 0)
						{
							(*unchecked((int*)Q))++;
							num6 = ((X < 0f) ? (num7 - num6) : (num6 - num7));
						}
						else if (num8 == 0)
						{
							if ((*unchecked((int*)Q) & 1) != 0)
							{
								(*unchecked((int*)Q))++;
								if (!(X < 0f))
								{
									num6 = 0f - num6;
								}
							}
							else if (X < 0f)
							{
								num6 = 0f - num6;
							}
						}
						else if (X < 0f)
						{
							num6 = 0f - num6;
						}
						*unchecked((int*)Q) = ((!Sign_is_neg.Invoke(&anon_izyfb2)) ? (*unchecked((int*)Q)) : (-(*unchecked((int*)Q))));
						result = ((num6 != 0f) ? num6 : Fputil_copysign_float_0.Invoke(0f, X));
						Llvm_lifetime_end_p0.Invoke(4L, &num8);
						Llvm_lifetime_end_p0.Invoke(4L, &num7);
						Llvm_lifetime_end_p0.Invoke(4L, &num6);
						Llvm_lifetime_end_p0.Invoke(12L, &llvm_libc_20_1_2_fputil_NormalFloat_phu2qv3);
						break;
					}
				}
				Llvm_lifetime_end_p0.Invoke(4L, &num3);
				Llvm_lifetime_end_p0.Invoke(4L, &num2);
				Llvm_lifetime_end_p0.Invoke(4L, &num);
				Llvm_lifetime_end_p0.Invoke(12L, &llvm_libc_20_1_2_fputil_NormalFloat_phu2qv2);
				Llvm_lifetime_end_p0.Invoke(12L, &llvm_libc_20_1_2_fputil_NormalFloat_phu2qv);
				Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb2);
			}
			Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
			Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
			return result;
		}
	}
}
