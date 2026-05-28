using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Generic_add_or_sub_false_Float16_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic10add_or_subILb0EDF16_dEENS_3cpp9enable_ifIXaaaasr3cppE19is_floating_point_vIT0_Esr3cppE19is_floating_point_vIT1_ElestS5_stS6_ES5_E4typeES6_S6_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16> && cpp::is_floating_point_v<double> && sizeof (_Float16) <= sizeof (double), _Float16>::type __llvm_libc_20_1_2_::fputil::generic::add_or_sub<false, _Float16, double>(double, double)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16> && cpp::is_floating_point_v<double> && sizeof (_Float16) <= sizeof (double), _Float16>::type")]
	public unsafe static Half Invoke([MangledName("x")][NativeType("double")] double X, [MangledName("y")][NativeType("double")] double Y)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm = default(Fputil_FPBits_wjhbrm);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(Fputil_FPBits_wjhbrm);
		sbyte b = 0;
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		long num4 = 0L;
		Fputil_FPBits_2fahva fputil_FPBits_2fahva = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		long num5 = 0L;
		Fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb4 = default(Anon_izyfb7);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva3 = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb5 = default(Anon_izyfb7);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva4 = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb6 = default(Anon_izyfb7);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva5 = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb7 = default(Anon_izyfb7);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva6 = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb8 = default(Anon_izyfb7);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva7 = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb9 = default(Anon_izyfb7);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva8 = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb10 = default(Anon_izyfb7);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva9 = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb11 = default(Anon_izyfb7);
		double x = 0.0;
		double x2 = 0.0;
		double num6 = 0.0;
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(Fputil_FPBits_wjhbrm);
		double num7 = 0.0;
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm4 = default(Fputil_FPBits_wjhbrm);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva10 = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb12 = default(Anon_izyfb7);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva11 = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb13 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb14 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb15 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb16 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb17 = default(Anon_izyfb7);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm5 = default(Fputil_FPBits_wjhbrm);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm6 = default(Fputil_FPBits_wjhbrm);
		long num8 = 0L;
		long num9 = 0L;
		long num10 = 0L;
		int num11 = 0;
		long num12 = 0L;
		sbyte b2 = 0;
		long num13 = 0L;
		int num14 = 0;
		Fputil_DyadicFloat_syracv fputil_DyadicFloat_syracv = default(Fputil_DyadicFloat_syracv);
		Anon_izyfb7 anon_izyfb18 = default(Anon_izyfb7);
		BigInt_555ggs bigInt_555ggs = default(BigInt_555ggs);
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = 3;
		Llvm_lifetime_start_p0.Invoke(4L, &num2);
		num2 = 55;
		Llvm_lifetime_start_p0.Invoke(4L, &num3);
		num3 = 56;
		Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
		Half result;
		unchecked
		{
			*(long*)(&fputil_FPBits_wjhbrm) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm, X);
			Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			*(long*)(&fputil_FPBits_wjhbrm2) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm2, Y);
			Llvm_lifetime_start_p0.Invoke(1L, &b);
			anon_izyfb.Val = FPStorage_fputil_FPType_2_sign.Invoke(&fputil_FPBits_wjhbrm);
			anon_izyfb2.Val = FPStorage_fputil_FPType_2_sign.Invoke(&fputil_FPBits_wjhbrm2);
			b = (Equals_fy8fvt.Invoke(anon_izyfb.Val, anon_izyfb2.Val) ? ((sbyte)1) : ((sbyte)0));
			if (!Details_expects_bool_condition_bool.Invoke(FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_inf_or_nan.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm)) || FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_inf_or_nan.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2)) || FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm)) || FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2)), Expected: false))
			{
				goto IL_07ea;
			}
			if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_nan.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm)) || FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_nan.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2)))
			{
				if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_signaling_nan.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm)) || FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_signaling_nan.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2)))
				{
					Fputil_raise_except_if_required.Invoke(1);
				}
				if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_quiet_nan.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm)))
				{
					Llvm_lifetime_start_p0.Invoke(8L, &num4);
					num4 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm));
					num4 >>>= 42;
					Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva);
					anon_izyfb3.Val = FPStorage_fputil_FPType_2_sign.Invoke(&fputil_FPBits_wjhbrm);
					short field_ = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan.Invoke(V: (short)num4, Sign: anon_izyfb3.Val);
					fputil_FPBits_2fahva.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
					result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva);
					Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva);
					Llvm_lifetime_end_p0.Invoke(8L, &num4);
				}
				else if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_quiet_nan.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2)))
				{
					Llvm_lifetime_start_p0.Invoke(8L, &num5);
					num5 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2));
					num5 >>>= 42;
					Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
					anon_izyfb4.Val = FPStorage_fputil_FPType_2_sign.Invoke(&fputil_FPBits_wjhbrm2);
					short field_2 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan.Invoke(V: (short)num5, Sign: anon_izyfb4.Val);
					fputil_FPBits_2fahva2.FPRepImpl.FPRepSem.FPStorage.field_0 = field_2;
					result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva2);
					Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
					Llvm_lifetime_end_p0.Invoke(8L, &num5);
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva3);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb5, Sign_POS.Pointer, 1L, isVolatile: false);
					short field_3 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan.Invoke(anon_izyfb5.Val, 0);
					fputil_FPBits_2fahva3.FPRepImpl.FPRepSem.FPStorage.field_0 = field_3;
					result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva3);
					Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva3);
				}
			}
			else if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_inf.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm)))
			{
				if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_inf.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2)))
				{
					if ((b & 1) != 1)
					{
						Fputil_raise_except_if_required.Invoke(1);
						Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva4);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb6, Sign_POS.Pointer, 1L, isVolatile: false);
						short field_4 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan.Invoke(anon_izyfb6.Val, 0);
						fputil_FPBits_2fahva4.FPRepImpl.FPRepSem.FPStorage.field_0 = field_4;
						result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva4);
						Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva4);
					}
					else
					{
						Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva5);
						anon_izyfb7.Val = FPStorage_fputil_FPType_2_sign.Invoke(&fputil_FPBits_wjhbrm);
						short field_5 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_inf.Invoke(anon_izyfb7.Val);
						fputil_FPBits_2fahva5.FPRepImpl.FPRepSem.FPStorage.field_0 = field_5;
						result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva5);
						Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva5);
					}
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva6);
					anon_izyfb8.Val = FPStorage_fputil_FPType_2_sign.Invoke(&fputil_FPBits_wjhbrm);
					short field_6 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_inf.Invoke(anon_izyfb8.Val);
					fputil_FPBits_2fahva6.FPRepImpl.FPRepSem.FPStorage.field_0 = field_6;
					result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva6);
					Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva6);
				}
			}
			else if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_inf.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2)))
			{
				Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva7);
				anon_izyfb9.Val = FPStorage_fputil_FPType_2_sign.Invoke(&fputil_FPBits_wjhbrm2);
				short field_7 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_inf.Invoke(anon_izyfb9.Val);
				fputil_FPBits_2fahva7.FPRepImpl.FPRepSem.FPStorage.field_0 = field_7;
				result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva7);
				Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva7);
			}
			else if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm)))
			{
				if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2)))
				{
					if (Fputil_quick_get_round.Invoke() == 1024)
					{
						Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva8);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb10, Sign_NEG.Pointer, 1L, isVolatile: false);
						short field_8 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_zero.Invoke(anon_izyfb10.Val);
						fputil_FPBits_2fahva8.FPRepImpl.FPRepSem.FPStorage.field_0 = field_8;
						result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva8);
						Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva8);
					}
					else
					{
						Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva9);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb11, Sign_POS.Pointer, 1L, isVolatile: false);
						short field_9 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_zero.Invoke(anon_izyfb11.Val);
						fputil_FPBits_2fahva9.FPRepImpl.FPRepSem.FPStorage.field_0 = field_9;
						result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva9);
						Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva9);
					}
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(8L, &x);
					x = Y;
					result = Fputil_cast_Float16_double.Invoke(x);
					Llvm_lifetime_end_p0.Invoke(8L, &x);
				}
			}
			else
			{
				if (!FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2)))
				{
					goto IL_07ea;
				}
				Llvm_lifetime_start_p0.Invoke(8L, &x2);
				x2 = Y;
				result = Fputil_cast_Float16_double.Invoke(x2);
				Llvm_lifetime_end_p0.Invoke(8L, &x2);
			}
			goto IL_0e8c;
		}
		IL_0e8c:
		Llvm_lifetime_end_p0.Invoke(1L, &b);
		Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
		Llvm_lifetime_end_p0.Invoke(4L, &num3);
		Llvm_lifetime_end_p0.Invoke(4L, &num2);
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
		IL_07ea:
		Llvm_lifetime_start_p0.Invoke(8L, &num6);
		Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
		unchecked
		{
			long val = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_abs.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm));
			fputil_FPBits_wjhbrm3.FPRepImpl.FPRepSem.FPStorage.Val = val;
			double num15 = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm3);
			Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
			num6 = num15;
			Llvm_lifetime_start_p0.Invoke(8L, &num7);
			Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
			long val2 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_abs.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2));
			fputil_FPBits_wjhbrm4.FPRepImpl.FPRepSem.FPStorage.Val = val2;
			double num16 = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm4);
			Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
			num7 = num16;
			if (num6 == num7 && (b & 1) != 1)
			{
				if (Fputil_quick_get_round.Invoke() == 1024)
				{
					Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva10);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb12, Sign_NEG.Pointer, 1L, isVolatile: false);
					short field_10 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_zero.Invoke(anon_izyfb12.Val);
					fputil_FPBits_2fahva10.FPRepImpl.FPRepSem.FPStorage.field_0 = field_10;
					result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva10);
					Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva10);
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva11);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb13, Sign_POS.Pointer, 1L, isVolatile: false);
					short field_11 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_zero.Invoke(anon_izyfb13.Val);
					fputil_FPBits_2fahva11.FPRepImpl.FPRepSem.FPStorage.field_0 = field_11;
					result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva11);
					Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva11);
				}
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb14);
				*(sbyte*)(&anon_izyfb14) = -86;
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb14, Sign_POS.Pointer, 1L, isVolatile: false);
				if (num6 > num7)
				{
					Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb15);
					anon_izyfb15.Val = FPStorage_fputil_FPType_2_sign.Invoke(&fputil_FPBits_wjhbrm);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb14, &anon_izyfb15, 1L, isVolatile: false);
					Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb15);
				}
				else if (num6 < num7)
				{
					if ((b & 1) == 1)
					{
						Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb16);
						anon_izyfb16.Val = FPStorage_fputil_FPType_2_sign.Invoke(&fputil_FPBits_wjhbrm2);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb14, &anon_izyfb16, 1L, isVolatile: false);
						Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb16);
					}
					else if (FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_pos.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2)))
					{
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb14, Sign_NEG.Pointer, 1L, isVolatile: false);
					}
				}
				else if ((b & 1) == 1)
				{
					Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb17);
					anon_izyfb17.Val = FPStorage_fputil_FPType_2_sign.Invoke(&fputil_FPBits_wjhbrm);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb14, &anon_izyfb17, 1L, isVolatile: false);
					Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb17);
				}
				Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
				*(long*)(&fputil_FPBits_wjhbrm5) = -6148914691236517206L;
				FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm5, *(double*)Cpp_max_double.Invoke(&num6, &num7));
				Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm6);
				*(long*)(&fputil_FPBits_wjhbrm6) = -6148914691236517206L;
				FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm6, *(double*)Cpp_min_double.Invoke(&num6, &num7));
				Llvm_lifetime_start_p0.Invoke(8L, &num8);
				num8 = -6148914691236517206L;
				if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_subnormal.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm5)))
				{
					num8 = (((b & 1) != 1) ? (FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm5)) - FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm6))) : (FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm5)) + FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm6))));
					num8 <<= 3;
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(8L, &num9);
					num9 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_get_explicit_mantissa.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm5)) << 3;
					Llvm_lifetime_start_p0.Invoke(8L, &num10);
					num10 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_get_explicit_mantissa.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm6)) << 3;
					Llvm_lifetime_start_p0.Invoke(4L, &num11);
					checked
					{
						num11 = unchecked((ushort)FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_biased_exponent.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm5))) - unchecked((ushort)FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_biased_exponent.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm6)));
						Llvm_lifetime_start_p0.Invoke(8L, &num12);
					}
					num12 = num10 >>> (int)(uint)(*(int*)Cpp_min_int.Invoke(&num11, &num3));
					Llvm_lifetime_start_p0.Invoke(1L, &b2);
					b2 = -86;
					b2 = ((num11 > 3 && (num11 > 55 || num10 << (int)(uint)checked(64 - num11) != 0L)) ? ((sbyte)1) : ((sbyte)0));
					Llvm_lifetime_start_p0.Invoke(8L, &num13);
					num13 = (((b2 & 1) == 1) ? 1 : 0);
					num8 = (((b & 1) != 1) ? (num9 - (num12 | num13)) : (num9 + (num12 | num13)));
					Llvm_lifetime_end_p0.Invoke(8L, &num13);
					Llvm_lifetime_end_p0.Invoke(1L, &b2);
					Llvm_lifetime_end_p0.Invoke(8L, &num12);
					Llvm_lifetime_end_p0.Invoke(4L, &num11);
					Llvm_lifetime_end_p0.Invoke(8L, &num10);
					Llvm_lifetime_end_p0.Invoke(8L, &num9);
				}
				Llvm_lifetime_start_p0.Invoke(4L, &num14);
				checked
				{
					num14 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_exponent.Invoke(unchecked((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm5))) - 55;
					Llvm_lifetime_start_p0.Invoke(16L, &fputil_DyadicFloat_syracv);
				}
				*(sbyte*)(&fputil_DyadicFloat_syracv) = -86;
				sbyte* ptr = (sbyte*)(&fputil_DyadicFloat_syracv) + 1;
				*ptr = -86;
				ptr[1] = -86;
				ptr[2] = -86;
				((int*)(&fputil_DyadicFloat_syracv))[1] = -1431655766;
				((long*)(&fputil_DyadicFloat_syracv))[1] = -6148914691236517206L;
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb18, &anon_izyfb14, 1L, isVolatile: false);
				int e = num14;
				BigInt_64ul_false_unsigned_long_BigInt_unsigned_long_void.Invoke(&bigInt_555ggs, num8);
				DyadicFloat_64ul_Constructor.Invoke(&fputil_DyadicFloat_syracv, anon_izyfb18.Val, e, *(long*)(&bigInt_555ggs.Val.Data));
				result = DyadicFloat_64ul_as_Float16_true_void.Invoke(&fputil_DyadicFloat_syracv);
				Llvm_lifetime_end_p0.Invoke(16L, &fputil_DyadicFloat_syracv);
				Llvm_lifetime_end_p0.Invoke(4L, &num14);
				Llvm_lifetime_end_p0.Invoke(8L, &num8);
				Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm6);
				Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
				Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb14);
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num7);
			Llvm_lifetime_end_p0.Invoke(8L, &num6);
			goto IL_0e8c;
		}
	}
}
