using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_remquo_Float16_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil6remquoIDF16_TnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_S4_Ri")]
	[DemangledName("_Float16 __llvm_libc_20_1_2_::fputil::remquo<_Float16, 0>(_Float16, _Float16, int&)")]
	[return: NativeType("_Float16")]
	public unsafe static Half Invoke([MangledName("x")][NativeType("_Float16")] Half X, [MangledName("y")][NativeType("_Float16")] Half Y, [MangledName("q")][NativeType("int&")] void* Q)
	{
		Half result = default(Half);
		Llvm_libc_20_1_2_fputil_FPBits_2fahva llvm_libc_20_1_2_fputil_FPBits_2fahva = default(Llvm_libc_20_1_2_fputil_FPBits_2fahva);
		Llvm_libc_20_1_2_fputil_FPBits_2fahva llvm_libc_20_1_2_fputil_FPBits_2fahva2 = default(Llvm_libc_20_1_2_fputil_FPBits_2fahva);
		Llvm_libc_20_1_2_fputil_FPBits_2fahva llvm_libc_20_1_2_fputil_FPBits_2fahva3 = default(Llvm_libc_20_1_2_fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb4 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb5 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb6 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_NormalFloat_epbrnk llvm_libc_20_1_2_fputil_NormalFloat_epbrnk = default(Llvm_libc_20_1_2_fputil_NormalFloat_epbrnk);
		Llvm_libc_20_1_2_fputil_FPBits_2fahva llvm_libc_20_1_2_fputil_FPBits_2fahva4 = default(Llvm_libc_20_1_2_fputil_FPBits_2fahva);
		Llvm_libc_20_1_2_fputil_NormalFloat_epbrnk llvm_libc_20_1_2_fputil_NormalFloat_epbrnk2 = default(Llvm_libc_20_1_2_fputil_NormalFloat_epbrnk);
		Llvm_libc_20_1_2_fputil_FPBits_2fahva llvm_libc_20_1_2_fputil_FPBits_2fahva5 = default(Llvm_libc_20_1_2_fputil_FPBits_2fahva);
		int num = 0;
		short num2 = 0;
		short num3 = 0;
		int num4 = 0;
		short num5 = 0;
		Llvm_libc_20_1_2_fputil_NormalFloat_epbrnk llvm_libc_20_1_2_fputil_NormalFloat_epbrnk3 = default(Llvm_libc_20_1_2_fputil_NormalFloat_epbrnk);
		Anon_izyfb7 anon_izyfb7 = default(Anon_izyfb7);
		Half half = default(Half);
		Half half2 = default(Half);
		int num6 = 0;
		Llvm_libc_20_1_2_fputil_NormalFloat_epbrnk llvm_libc_20_1_2_fputil_NormalFloat_epbrnk4 = default(Llvm_libc_20_1_2_fputil_NormalFloat_epbrnk);
		Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva);
		unchecked
		{
			*(short*)(&llvm_libc_20_1_2_fputil_FPBits_2fahva) = -21846;
			FPBits_Float16_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva, X);
			Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva2);
			*(short*)(&llvm_libc_20_1_2_fputil_FPBits_2fahva2) = -21846;
			FPBits_Float16_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva2, Y);
			if (FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_nan.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_i7nz4h*)(&llvm_libc_20_1_2_fputil_FPBits_2fahva)))
			{
				result = X;
			}
			else if (FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_nan.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_i7nz4h*)(&llvm_libc_20_1_2_fputil_FPBits_2fahva2)))
			{
				result = Y;
			}
			else if (FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_inf.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_i7nz4h*)(&llvm_libc_20_1_2_fputil_FPBits_2fahva)) || FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_zero.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_i7nz4h*)(&llvm_libc_20_1_2_fputil_FPBits_2fahva2)))
			{
				Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva3);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
				short field_ = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan.Invoke(anon_izyfb.Val, 0);
				llvm_libc_20_1_2_fputil_FPBits_2fahva3.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
				result = FPBits_Float16_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva3);
				Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva3);
			}
			else if (FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_zero.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_i7nz4h*)(&llvm_libc_20_1_2_fputil_FPBits_2fahva)))
			{
				*(int*)Q = 0;
				result = Fputil_copysign_Float16_0.Invoke(default(Half), X);
			}
			else if (FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_inf.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_i7nz4h*)(&llvm_libc_20_1_2_fputil_FPBits_2fahva2)))
			{
				*(int*)Q = 0;
				result = X;
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb2);
				*(sbyte*)(&anon_izyfb2) = -86;
				anon_izyfb3.Val = FPStorage_fputil_FPType_0_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva);
				anon_izyfb4.Val = FPStorage_fputil_FPType_0_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva2);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, (!Llvm_libc_20_1_2_Equals_fy8fvt.Invoke(anon_izyfb3.Val, anon_izyfb4.Val)) ? Llvm_libc_20_1_2_Sign_NEG.Pointer : Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb5, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
				FPStorage_fputil_FPType_0_set_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva, anon_izyfb5.Val);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb6, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
				FPStorage_fputil_FPType_0_set_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva2, anon_izyfb6.Val);
				Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_NormalFloat_epbrnk);
				*(int*)(&llvm_libc_20_1_2_fputil_NormalFloat_epbrnk) = -1431655766;
				((short*)(&llvm_libc_20_1_2_fputil_NormalFloat_epbrnk))[2] = -21846;
				((sbyte*)(&llvm_libc_20_1_2_fputil_NormalFloat_epbrnk))[6] = -86;
				((sbyte*)(&llvm_libc_20_1_2_fputil_NormalFloat_epbrnk))[7] = -86;
				Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva4, &llvm_libc_20_1_2_fputil_FPBits_2fahva, 2L, isVolatile: false);
				NormalFloat_Float16_Constructor.Invoke(&llvm_libc_20_1_2_fputil_NormalFloat_epbrnk, llvm_libc_20_1_2_fputil_FPBits_2fahva4.FPRepImpl.FPRepSem.FPStorage.field_0);
				Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_NormalFloat_epbrnk2);
				*(int*)(&llvm_libc_20_1_2_fputil_NormalFloat_epbrnk2) = -1431655766;
				((short*)(&llvm_libc_20_1_2_fputil_NormalFloat_epbrnk2))[2] = -21846;
				((sbyte*)(&llvm_libc_20_1_2_fputil_NormalFloat_epbrnk2))[6] = -86;
				((sbyte*)(&llvm_libc_20_1_2_fputil_NormalFloat_epbrnk2))[7] = -86;
				Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva5, &llvm_libc_20_1_2_fputil_FPBits_2fahva2, 2L, isVolatile: false);
				NormalFloat_Float16_Constructor.Invoke(&llvm_libc_20_1_2_fputil_NormalFloat_epbrnk2, llvm_libc_20_1_2_fputil_FPBits_2fahva5.FPRepImpl.FPRepSem.FPStorage.field_0);
				Llvm_lifetime_start_p0.Invoke(4L, &num);
				num = checked(llvm_libc_20_1_2_fputil_NormalFloat_epbrnk.Exponent - llvm_libc_20_1_2_fputil_NormalFloat_epbrnk2.Exponent);
				Llvm_lifetime_start_p0.Invoke(2L, &num2);
				num2 = llvm_libc_20_1_2_fputil_NormalFloat_epbrnk.Mantissa;
				Llvm_lifetime_start_p0.Invoke(2L, &num3);
				num3 = llvm_libc_20_1_2_fputil_NormalFloat_epbrnk2.Mantissa;
				*(int*)Q = 0;
				while (true)
				{
					if (num >= 0)
					{
						Llvm_lifetime_start_p0.Invoke(4L, &num4);
						num4 = 0;
						Llvm_lifetime_start_p0.Invoke(2L, &num5);
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
								*(int*)Q |= 1 << num;
							}
							num2 = (short)checked(unchecked((ushort)num5) - unchecked((ushort)num3));
							if ((ushort)num2 == 0)
							{
								*(int*)Q = ((!Sign_is_neg.Invoke(&anon_izyfb2)) ? (*(int*)Q) : checked(-(*unchecked((int*)Q))));
								result = Fputil_copysign_Float16_0.Invoke(default(Half), X);
								num7 = 1;
							}
							else
							{
								num7 = 0;
							}
						}
						Llvm_lifetime_end_p0.Invoke(2L, &num5);
						Llvm_lifetime_end_p0.Invoke(4L, &num4);
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
					Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_NormalFloat_epbrnk3);
					*(int*)(&llvm_libc_20_1_2_fputil_NormalFloat_epbrnk3) = -1431655766;
					((short*)(&llvm_libc_20_1_2_fputil_NormalFloat_epbrnk3))[2] = -21846;
					((sbyte*)(&llvm_libc_20_1_2_fputil_NormalFloat_epbrnk3))[6] = -86;
					((sbyte*)(&llvm_libc_20_1_2_fputil_NormalFloat_epbrnk3))[7] = -86;
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb7, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
					NormalFloat_Float16_Constructor.Invoke(E: checked(num + llvm_libc_20_1_2_fputil_NormalFloat_epbrnk2.Exponent), M: num2, This: &llvm_libc_20_1_2_fputil_NormalFloat_epbrnk3, S: anon_izyfb7.Val);
					Llvm_lifetime_start_p0.Invoke(2L, &half);
					half = NormalFloat_Float16_Float16.Invoke(&llvm_libc_20_1_2_fputil_NormalFloat_epbrnk3);
					Llvm_lifetime_start_p0.Invoke(2L, &half2);
					half2 = FPBits_Float16_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva2);
					Llvm_lifetime_start_p0.Invoke(4L, &num6);
					Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_NormalFloat_epbrnk4);
					*(InlineArray7_Byte*)(&llvm_libc_20_1_2_fputil_NormalFloat_epbrnk4) = NumericHelper.TruncOrZextToBytes<long, InlineArray7_Byte>(NormalFloat_Float16_mul2.Invoke(&llvm_libc_20_1_2_fputil_NormalFloat_epbrnk3, 1));
					int num9 = NormalFloat_Float16_cmp.Invoke(&llvm_libc_20_1_2_fputil_NormalFloat_epbrnk4, &llvm_libc_20_1_2_fputil_NormalFloat_epbrnk2);
					Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_NormalFloat_epbrnk4);
					num6 = num9;
					if (num6 > 0)
					{
						checked
						{
							(*unchecked((int*)Q))++;
						}
						half = ((!NumericHelper.FcmpOge(X, default(Half))) ? ((Half)((float)half2 - (float)half)) : ((Half)((float)half - (float)half2)));
					}
					else if (num6 == 0)
					{
						if ((*(int*)Q & 1) != 0)
						{
							checked
							{
								(*unchecked((int*)Q))++;
							}
							if (NumericHelper.FcmpOge(X, default(Half)))
							{
								half = (Half)(0f - (float)half);
							}
						}
						else if (NumericHelper.FcmpOlt(X, default(Half)))
						{
							half = (Half)(0f - (float)half);
						}
					}
					else if (NumericHelper.FcmpOlt(X, default(Half)))
					{
						half = (Half)(0f - (float)half);
					}
					*(int*)Q = ((!Sign_is_neg.Invoke(&anon_izyfb2)) ? (*(int*)Q) : checked(-(*unchecked((int*)Q))));
					result = ((!NumericHelper.FcmpOeq(half, default(Half))) ? half : Fputil_copysign_Float16_0.Invoke(default(Half), X));
					Llvm_lifetime_end_p0.Invoke(4L, &num6);
					Llvm_lifetime_end_p0.Invoke(2L, &half2);
					Llvm_lifetime_end_p0.Invoke(2L, &half);
					Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_NormalFloat_epbrnk3);
					break;
				}
				Llvm_lifetime_end_p0.Invoke(2L, &num3);
				Llvm_lifetime_end_p0.Invoke(2L, &num2);
				Llvm_lifetime_end_p0.Invoke(4L, &num);
				Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_NormalFloat_epbrnk2);
				Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_NormalFloat_epbrnk);
				Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb2);
			}
			Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva2);
			Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva);
			return result;
		}
	}
}
