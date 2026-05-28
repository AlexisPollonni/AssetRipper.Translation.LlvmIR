using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_remquo_float128_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil6remquoIgTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_S4_Ri")]
	[DemangledName("__float128 __llvm_libc_20_1_2_::fputil::remquo<__float128, 0>(__float128, __float128, int&)")]
	[return: NativeType("__float128")]
	public unsafe static double Invoke([MangledName("x")][NativeType("__float128")] double X, [MangledName("y")][NativeType("__float128")] double Y, [MangledName("q")][NativeType("int&")] void* Q)
	{
		double result = 0.0;
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi = default(Fputil_FPBits_ubgsi2);
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi2 = default(Fputil_FPBits_ubgsi2);
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(Fputil_FPBits_ubgsi2);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Int128 @int = default(Int128);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb4 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb5 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb6 = default(Anon_izyfb7);
		Fputil_NormalFloat_wqb3ie fputil_NormalFloat_wqb3ie = default(Fputil_NormalFloat_wqb3ie);
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi4 = default(Fputil_FPBits_ubgsi2);
		Fputil_NormalFloat_wqb3ie fputil_NormalFloat_wqb3ie2 = default(Fputil_NormalFloat_wqb3ie);
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi5 = default(Fputil_FPBits_ubgsi2);
		int num = 0;
		Int128 int2 = default(Int128);
		Int128 y = default(Int128);
		int num2 = 0;
		Int128 x = default(Int128);
		Fputil_NormalFloat_wqb3ie fputil_NormalFloat_wqb3ie3 = default(Fputil_NormalFloat_wqb3ie);
		Anon_izyfb7 anon_izyfb7 = default(Anon_izyfb7);
		Int128 int3 = default(Int128);
		double num3 = 0.0;
		double num4 = 0.0;
		int num5 = 0;
		Fputil_NormalFloat_wqb3ie fputil_NormalFloat_wqb3ie4 = default(Fputil_NormalFloat_wqb3ie);
		Llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi);
		unchecked
		{
			*(Int128*)(&fputil_FPBits_ubgsi) = -6148914691236517206L;
			FPBits_float128_Constructor.Invoke(&fputil_FPBits_ubgsi, X);
			Llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi2);
			*(Int128*)(&fputil_FPBits_ubgsi2) = -6148914691236517206L;
			FPBits_float128_Constructor.Invoke(&fputil_FPBits_ubgsi2, Y);
			if (FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_nan.Invoke((Fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi)))
			{
				result = X;
			}
			else if (FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_nan.Invoke((Fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi2)))
			{
				result = Y;
			}
			else if (FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_inf.Invoke((Fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi)) || FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_zero.Invoke((Fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi2)))
			{
				Llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Sign_POS.Pointer, 1L, isVolatile: false);
				sbyte val = anon_izyfb.Val;
				@int = 0L;
				Struct_fiz2nb struct_fiz2nb = FPRepSem_fputil_FPType_3_fputil_FPBits_float128_quiet_nan.Invoke(val, *(long*)(&@int), ((long*)(&@int))[1]);
				Int128* ptr = &fputil_FPBits_ubgsi3.Val.Data.FPStorage.field_0;
				Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
				((Struct_fiz2nb*)ptr)->field_0 = struct_fiz2nb2.field_0;
				Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
				((Struct_fiz2nb*)ptr)->field_1 = struct_fiz2nb3.field_1;
				result = FPBits_float128_get_val.Invoke(&fputil_FPBits_ubgsi3);
				Llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
			}
			else if (FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_zero.Invoke((Fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi)))
			{
				*(int*)Q = 0;
				result = Fputil_copysign_float128_0.Invoke(0.0, X);
			}
			else if (FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_inf.Invoke((Fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi2)))
			{
				*(int*)Q = 0;
				result = X;
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb2);
				*(sbyte*)(&anon_izyfb2) = -86;
				anon_izyfb3.Val = FPStorage_fputil_FPType_3_sign.Invoke(&fputil_FPBits_ubgsi);
				anon_izyfb4.Val = FPStorage_fputil_FPType_3_sign.Invoke(&fputil_FPBits_ubgsi2);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, (!Equals_fy8fvt.Invoke(anon_izyfb3.Val, anon_izyfb4.Val)) ? Sign_NEG.Pointer : Sign_POS.Pointer, 1L, isVolatile: false);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb5, Sign_POS.Pointer, 1L, isVolatile: false);
				FPStorage_fputil_FPType_3_set_sign.Invoke(&fputil_FPBits_ubgsi, anon_izyfb5.Val);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb6, Sign_POS.Pointer, 1L, isVolatile: false);
				FPStorage_fputil_FPType_3_set_sign.Invoke(&fputil_FPBits_ubgsi2, anon_izyfb6.Val);
				Llvm_lifetime_start_p0.Invoke(48L, &fputil_NormalFloat_wqb3ie);
				Llvm_memset_p0_i64.Invoke(&fputil_NormalFloat_wqb3ie, -86, 48L, isVolatile: false);
				Llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi4, &fputil_FPBits_ubgsi, 16L, isVolatile: false);
				NormalFloat_float128_Constructor.Invoke(&fputil_NormalFloat_wqb3ie, *(long*)(&fputil_FPBits_ubgsi4), ((long*)(&fputil_FPBits_ubgsi4))[1]);
				Llvm_lifetime_start_p0.Invoke(48L, &fputil_NormalFloat_wqb3ie2);
				Llvm_memset_p0_i64.Invoke(&fputil_NormalFloat_wqb3ie2, -86, 48L, isVolatile: false);
				Llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi5, &fputil_FPBits_ubgsi2, 16L, isVolatile: false);
				NormalFloat_float128_Constructor.Invoke(&fputil_NormalFloat_wqb3ie2, *(long*)(&fputil_FPBits_ubgsi5), ((long*)(&fputil_FPBits_ubgsi5))[1]);
				Llvm_lifetime_start_p0.Invoke(4L, &num);
				num = checked(fputil_NormalFloat_wqb3ie.Exponent - fputil_NormalFloat_wqb3ie2.Exponent);
				Llvm_lifetime_start_p0.Invoke(16L, &int2);
				int2 = fputil_NormalFloat_wqb3ie.Mantissa;
				Llvm_lifetime_start_p0.Invoke(16L, &y);
				y = fputil_NormalFloat_wqb3ie2.Mantissa;
				*(int*)Q = 0;
				while (true)
				{
					if (num >= 0)
					{
						Llvm_lifetime_start_p0.Invoke(4L, &num2);
						num2 = 0;
						Llvm_lifetime_start_p0.Invoke(16L, &x);
						x = int2;
						num2 = 0;
						while (NumericHelper.IntCmpUlt(x, y))
						{
							x = NumericHelper.ShiftLeft(x, 1L);
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
								*(int*)Q |= 1 << num;
							}
							int2 = NumericHelper.Subtract(x, y);
							if (NumericHelper.IntCmpEq(int2, 0L))
							{
								*(int*)Q = ((!Sign_is_neg.Invoke(&anon_izyfb2)) ? (*(int*)Q) : checked(-(*unchecked((int*)Q))));
								result = Fputil_copysign_float128_0.Invoke(0.0, X);
								num6 = 1;
							}
							else
							{
								num6 = 0;
							}
						}
						Llvm_lifetime_end_p0.Invoke(16L, &x);
						Llvm_lifetime_end_p0.Invoke(4L, &num2);
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
					Llvm_lifetime_start_p0.Invoke(48L, &fputil_NormalFloat_wqb3ie3);
					Llvm_memset_p0_i64.Invoke(&fputil_NormalFloat_wqb3ie3, -86, 48L, isVolatile: false);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb7, Sign_POS.Pointer, 1L, isVolatile: false);
					int e = checked(num + fputil_NormalFloat_wqb3ie2.Exponent);
					Int128 int4 = int2;
					sbyte val2 = anon_izyfb7.Val;
					int3 = int4;
					NormalFloat_float128_Constructor.Invoke(&fputil_NormalFloat_wqb3ie3, val2, e, *(long*)(&int3), ((long*)(&int3))[1]);
					Llvm_lifetime_start_p0.Invoke(16L, &num3);
					num3 = NormalFloat_float128_Float128.Invoke(&fputil_NormalFloat_wqb3ie3);
					Llvm_lifetime_start_p0.Invoke(16L, &num4);
					num4 = FPBits_float128_get_val.Invoke(&fputil_FPBits_ubgsi2);
					Llvm_lifetime_start_p0.Invoke(4L, &num5);
					Llvm_lifetime_start_p0.Invoke(48L, &fputil_NormalFloat_wqb3ie4);
					NormalFloat_float128_mul2.Invoke(&fputil_NormalFloat_wqb3ie4, &fputil_NormalFloat_wqb3ie3, 1);
					int num8 = NormalFloat_float128_cmp.Invoke(&fputil_NormalFloat_wqb3ie4, &fputil_NormalFloat_wqb3ie2);
					Llvm_lifetime_end_p0.Invoke(48L, &fputil_NormalFloat_wqb3ie4);
					num5 = num8;
					checked
					{
						if (num5 > 0)
						{
							(*unchecked((int*)Q))++;
							num3 = ((X < 0.0) ? (num4 - num3) : (num3 - num4));
						}
						else if (num5 == 0)
						{
							if ((*unchecked((int*)Q) & 1) != 0)
							{
								(*unchecked((int*)Q))++;
								if (!(X < 0.0))
								{
									num3 = 0.0 - num3;
								}
							}
							else if (X < 0.0)
							{
								num3 = 0.0 - num3;
							}
						}
						else if (X < 0.0)
						{
							num3 = 0.0 - num3;
						}
						*unchecked((int*)Q) = ((!Sign_is_neg.Invoke(&anon_izyfb2)) ? (*unchecked((int*)Q)) : (-(*unchecked((int*)Q))));
						result = ((num3 != 0.0) ? num3 : Fputil_copysign_float128_0.Invoke(0.0, X));
						Llvm_lifetime_end_p0.Invoke(4L, &num5);
						Llvm_lifetime_end_p0.Invoke(16L, &num4);
						Llvm_lifetime_end_p0.Invoke(16L, &num3);
						Llvm_lifetime_end_p0.Invoke(48L, &fputil_NormalFloat_wqb3ie3);
						break;
					}
				}
				Llvm_lifetime_end_p0.Invoke(16L, &y);
				Llvm_lifetime_end_p0.Invoke(16L, &int2);
				Llvm_lifetime_end_p0.Invoke(4L, &num);
				Llvm_lifetime_end_p0.Invoke(48L, &fputil_NormalFloat_wqb3ie2);
				Llvm_lifetime_end_p0.Invoke(48L, &fputil_NormalFloat_wqb3ie);
				Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb2);
			}
			Llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi2);
			Llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi);
			return result;
		}
	}
}
