using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Generic_add_or_sub_false_double_float128
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic10add_or_subILb0EdgEENS_3cpp9enable_ifIXaaaasr3cppE19is_floating_point_vIT0_Esr3cppE19is_floating_point_vIT1_ElestS5_stS6_ES5_E4typeES6_S6_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<double> && cpp::is_floating_point_v<__float128> && sizeof (double) <= sizeof (__float128), double>::type __llvm_libc_20_1_2_::fputil::generic::add_or_sub<false, double, __float128>(__float128, __float128)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<double> && cpp::is_floating_point_v<__float128> && sizeof (double) <= sizeof (__float128), double>::type")]
	public unsafe static double Invoke([MangledName("x")][NativeType("__float128")] double X, [MangledName("y")][NativeType("__float128")] double Y)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi = default(Fputil_FPBits_ubgsi2);
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi2 = default(Fputil_FPBits_ubgsi2);
		sbyte b = 0;
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Int128 @int = default(Int128);
		Int128 int2 = default(Int128);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm = default(Fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		Int128 int3 = default(Int128);
		Int128 int4 = default(Int128);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(Fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb4 = default(Anon_izyfb7);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(Fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb5 = default(Anon_izyfb7);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm4 = default(Fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb6 = default(Anon_izyfb7);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm5 = default(Fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb7 = default(Anon_izyfb7);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm6 = default(Fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb8 = default(Anon_izyfb7);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm7 = default(Fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb9 = default(Anon_izyfb7);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm8 = default(Fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb10 = default(Anon_izyfb7);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm9 = default(Fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb11 = default(Anon_izyfb7);
		double x = 0.0;
		double x2 = 0.0;
		double num4 = 0.0;
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(Fputil_FPBits_ubgsi2);
		double num5 = 0.0;
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi4 = default(Fputil_FPBits_ubgsi2);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm10 = default(Fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb12 = default(Anon_izyfb7);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm11 = default(Fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb13 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb14 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb15 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb16 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb17 = default(Anon_izyfb7);
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi5 = default(Fputil_FPBits_ubgsi2);
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi6 = default(Fputil_FPBits_ubgsi2);
		Int128 int5 = default(Int128);
		Int128 int6 = default(Int128);
		Int128 y = default(Int128);
		Int128 int7 = default(Int128);
		Int128 y2 = default(Int128);
		Int128 x3 = default(Int128);
		Int128 x4 = default(Int128);
		Int128 x5 = default(Int128);
		Int128 x6 = default(Int128);
		int num6 = 0;
		Int128 x7 = default(Int128);
		sbyte b2 = 0;
		Int128 y3 = default(Int128);
		int num7 = 0;
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd = default(Fputil_DyadicFloat_kt2kd4);
		Anon_izyfb7 anon_izyfb18 = default(Anon_izyfb7);
		BigInt_qdkjbh bigInt_qdkjbh = default(BigInt_qdkjbh);
		Int128 int8 = default(Int128);
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = 3;
		Llvm_lifetime_start_p0.Invoke(4L, &num2);
		num2 = 115;
		Llvm_lifetime_start_p0.Invoke(4L, &num3);
		num3 = 116;
		Llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi);
		double result;
		unchecked
		{
			*(Int128*)(&fputil_FPBits_ubgsi) = -6148914691236517206L;
			FPBits_float128_Constructor.Invoke(&fputil_FPBits_ubgsi, X);
			Llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi2);
			*(Int128*)(&fputil_FPBits_ubgsi2) = -6148914691236517206L;
			FPBits_float128_Constructor.Invoke(&fputil_FPBits_ubgsi2, Y);
			Llvm_lifetime_start_p0.Invoke(1L, &b);
			anon_izyfb.Val = FPStorage_fputil_FPType_3_sign.Invoke(&fputil_FPBits_ubgsi);
			anon_izyfb2.Val = FPStorage_fputil_FPType_3_sign.Invoke(&fputil_FPBits_ubgsi2);
			b = (Equals_fy8fvt.Invoke(anon_izyfb.Val, anon_izyfb2.Val) ? ((sbyte)1) : ((sbyte)0));
			if (!Details_expects_bool_condition_bool.Invoke(FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_is_inf_or_nan.Invoke(&fputil_FPBits_ubgsi) || FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_is_inf_or_nan.Invoke(&fputil_FPBits_ubgsi2) || FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_zero.Invoke((Fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi)) || FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_zero.Invoke((Fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi2)), Expected: false))
			{
				goto IL_08d6;
			}
			if (FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_nan.Invoke((Fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi)) || FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_nan.Invoke((Fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi2)))
			{
				if (FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_signaling_nan.Invoke((Fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi)) || FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_signaling_nan.Invoke((Fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi2)))
				{
					Fputil_raise_except_if_required.Invoke(1);
				}
				if (FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_quiet_nan.Invoke((Fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi)))
				{
					Llvm_lifetime_start_p0.Invoke(16L, &@int);
					Struct_fiz2nb struct_fiz2nb = FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_get_mantissa.Invoke(&fputil_FPBits_ubgsi);
					Int128* num8 = &int2;
					Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
					*(long*)num8 = struct_fiz2nb2.field_0;
					byte* num9 = (byte*)(&int2) + 8u;
					Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
					*(long*)num9 = struct_fiz2nb3.field_1;
					@int = int2;
					@int = NumericHelper.ShiftRightLogical(@int, 60L);
					Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
					anon_izyfb3.Val = FPStorage_fputil_FPType_3_sign.Invoke(&fputil_FPBits_ubgsi);
					long val = FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan.Invoke(V: (long)@int, Sign: anon_izyfb3.Val);
					fputil_FPBits_wjhbrm.FPRepImpl.FPRepSem.FPStorage.Val = val;
					result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm);
					Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
					Llvm_lifetime_end_p0.Invoke(16L, &@int);
				}
				else if (FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_quiet_nan.Invoke((Fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi2)))
				{
					Llvm_lifetime_start_p0.Invoke(16L, &int3);
					Struct_fiz2nb struct_fiz2nb4 = FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_get_mantissa.Invoke(&fputil_FPBits_ubgsi2);
					Int128* num10 = &int4;
					Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
					*(long*)num10 = struct_fiz2nb5.field_0;
					byte* num11 = (byte*)(&int4) + 8u;
					Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
					*(long*)num11 = struct_fiz2nb6.field_1;
					int3 = int4;
					int3 = NumericHelper.ShiftRightLogical(int3, 60L);
					Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
					anon_izyfb4.Val = FPStorage_fputil_FPType_3_sign.Invoke(&fputil_FPBits_ubgsi2);
					long val2 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan.Invoke(V: (long)int3, Sign: anon_izyfb4.Val);
					fputil_FPBits_wjhbrm2.FPRepImpl.FPRepSem.FPStorage.Val = val2;
					result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm2);
					Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
					Llvm_lifetime_end_p0.Invoke(16L, &int3);
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb5, Sign_POS.Pointer, 1L, isVolatile: false);
					long val3 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan.Invoke(anon_izyfb5.Val, 0L);
					fputil_FPBits_wjhbrm3.FPRepImpl.FPRepSem.FPStorage.Val = val3;
					result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm3);
					Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
				}
			}
			else if (FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_inf.Invoke((Fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi)))
			{
				if (FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_inf.Invoke((Fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi2)))
				{
					if ((b & 1) != 1)
					{
						Fputil_raise_except_if_required.Invoke(1);
						Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb6, Sign_POS.Pointer, 1L, isVolatile: false);
						long val4 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan.Invoke(anon_izyfb6.Val, 0L);
						fputil_FPBits_wjhbrm4.FPRepImpl.FPRepSem.FPStorage.Val = val4;
						result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm4);
						Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
					}
					else
					{
						Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
						anon_izyfb7.Val = FPStorage_fputil_FPType_3_sign.Invoke(&fputil_FPBits_ubgsi);
						long val5 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_inf.Invoke(anon_izyfb7.Val);
						fputil_FPBits_wjhbrm5.FPRepImpl.FPRepSem.FPStorage.Val = val5;
						result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm5);
						Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
					}
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm6);
					anon_izyfb8.Val = FPStorage_fputil_FPType_3_sign.Invoke(&fputil_FPBits_ubgsi);
					long val6 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_inf.Invoke(anon_izyfb8.Val);
					fputil_FPBits_wjhbrm6.FPRepImpl.FPRepSem.FPStorage.Val = val6;
					result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm6);
					Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm6);
				}
			}
			else if (FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_inf.Invoke((Fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi2)))
			{
				Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm7);
				anon_izyfb9.Val = FPStorage_fputil_FPType_3_sign.Invoke(&fputil_FPBits_ubgsi2);
				long val7 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_inf.Invoke(anon_izyfb9.Val);
				fputil_FPBits_wjhbrm7.FPRepImpl.FPRepSem.FPStorage.Val = val7;
				result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm7);
				Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm7);
			}
			else if (FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_zero.Invoke((Fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi)))
			{
				if (FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_zero.Invoke((Fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi2)))
				{
					if (Fputil_quick_get_round.Invoke() == 1024)
					{
						Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm8);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb10, Sign_NEG.Pointer, 1L, isVolatile: false);
						long val8 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_zero.Invoke(anon_izyfb10.Val);
						fputil_FPBits_wjhbrm8.FPRepImpl.FPRepSem.FPStorage.Val = val8;
						result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm8);
						Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm8);
					}
					else
					{
						Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm9);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb11, Sign_POS.Pointer, 1L, isVolatile: false);
						long val9 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_zero.Invoke(anon_izyfb11.Val);
						fputil_FPBits_wjhbrm9.FPRepImpl.FPRepSem.FPStorage.Val = val9;
						result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm9);
						Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm9);
					}
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(16L, &x);
					x = Y;
					result = Fputil_cast_double_float128.Invoke(x);
					Llvm_lifetime_end_p0.Invoke(16L, &x);
				}
			}
			else
			{
				if (!FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_zero.Invoke((Fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi2)))
				{
					goto IL_08d6;
				}
				Llvm_lifetime_start_p0.Invoke(16L, &x2);
				x2 = Y;
				result = Fputil_cast_double_float128.Invoke(x2);
				Llvm_lifetime_end_p0.Invoke(16L, &x2);
			}
			goto IL_1137;
		}
		IL_1137:
		Llvm_lifetime_end_p0.Invoke(1L, &b);
		Llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi2);
		Llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi);
		Llvm_lifetime_end_p0.Invoke(4L, &num3);
		Llvm_lifetime_end_p0.Invoke(4L, &num2);
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
		IL_08d6:
		Llvm_lifetime_start_p0.Invoke(16L, &num4);
		Llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		Struct_fiz2nb struct_fiz2nb7 = FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_abs.Invoke(&fputil_FPBits_ubgsi);
		Int128* ptr = &fputil_FPBits_ubgsi3.Val.Data.FPStorage.field_0;
		Struct_fiz2nb struct_fiz2nb8 = struct_fiz2nb7;
		unchecked
		{
			((Struct_fiz2nb*)ptr)->field_0 = struct_fiz2nb8.field_0;
			Struct_fiz2nb struct_fiz2nb9 = struct_fiz2nb7;
			((Struct_fiz2nb*)ptr)->field_1 = struct_fiz2nb9.field_1;
			double num12 = FPBits_float128_get_val.Invoke(&fputil_FPBits_ubgsi3);
			Llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
			num4 = num12;
			Llvm_lifetime_start_p0.Invoke(16L, &num5);
			Llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
			Struct_fiz2nb struct_fiz2nb10 = FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_abs.Invoke(&fputil_FPBits_ubgsi2);
			Int128* ptr2 = &fputil_FPBits_ubgsi4.Val.Data.FPStorage.field_0;
			Struct_fiz2nb struct_fiz2nb11 = struct_fiz2nb10;
			((Struct_fiz2nb*)ptr2)->field_0 = struct_fiz2nb11.field_0;
			Struct_fiz2nb struct_fiz2nb12 = struct_fiz2nb10;
			((Struct_fiz2nb*)ptr2)->field_1 = struct_fiz2nb12.field_1;
			double num13 = FPBits_float128_get_val.Invoke(&fputil_FPBits_ubgsi4);
			Llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
			num5 = num13;
			if (num4 == num5 && (b & 1) != 1)
			{
				if (Fputil_quick_get_round.Invoke() == 1024)
				{
					Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm10);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb12, Sign_NEG.Pointer, 1L, isVolatile: false);
					long val10 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_zero.Invoke(anon_izyfb12.Val);
					fputil_FPBits_wjhbrm10.FPRepImpl.FPRepSem.FPStorage.Val = val10;
					result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm10);
					Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm10);
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm11);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb13, Sign_POS.Pointer, 1L, isVolatile: false);
					long val11 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_zero.Invoke(anon_izyfb13.Val);
					fputil_FPBits_wjhbrm11.FPRepImpl.FPRepSem.FPStorage.Val = val11;
					result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm11);
					Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm11);
				}
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb14);
				*(sbyte*)(&anon_izyfb14) = -86;
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb14, Sign_POS.Pointer, 1L, isVolatile: false);
				if (num4 > num5)
				{
					Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb15);
					anon_izyfb15.Val = FPStorage_fputil_FPType_3_sign.Invoke(&fputil_FPBits_ubgsi);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb14, &anon_izyfb15, 1L, isVolatile: false);
					Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb15);
				}
				else if (num4 < num5)
				{
					if ((b & 1) == 1)
					{
						Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb16);
						anon_izyfb16.Val = FPStorage_fputil_FPType_3_sign.Invoke(&fputil_FPBits_ubgsi2);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb14, &anon_izyfb16, 1L, isVolatile: false);
						Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb16);
					}
					else if (FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_is_pos.Invoke(&fputil_FPBits_ubgsi2))
					{
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb14, Sign_NEG.Pointer, 1L, isVolatile: false);
					}
				}
				else if ((b & 1) == 1)
				{
					Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb17);
					anon_izyfb17.Val = FPStorage_fputil_FPType_3_sign.Invoke(&fputil_FPBits_ubgsi);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb14, &anon_izyfb17, 1L, isVolatile: false);
					Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb17);
				}
				Llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi5);
				*(Int128*)(&fputil_FPBits_ubgsi5) = -6148914691236517206L;
				FPBits_float128_Constructor.Invoke(&fputil_FPBits_ubgsi5, *(double*)Cpp_max_float128.Invoke(&num4, &num5));
				Llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi6);
				*(Int128*)(&fputil_FPBits_ubgsi6) = -6148914691236517206L;
				FPBits_float128_Constructor.Invoke(&fputil_FPBits_ubgsi6, *(double*)Cpp_min_float128.Invoke(&num4, &num5));
				Llvm_lifetime_start_p0.Invoke(16L, &int5);
				int5 = -6148914691236517206L;
				if (FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_subnormal.Invoke((Fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi5)))
				{
					if ((b & 1) == 1)
					{
						Struct_fiz2nb struct_fiz2nb13 = FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_get_mantissa.Invoke(&fputil_FPBits_ubgsi5);
						Int128* num14 = &int6;
						Struct_fiz2nb struct_fiz2nb14 = struct_fiz2nb13;
						*(long*)num14 = struct_fiz2nb14.field_0;
						byte* num15 = (byte*)(&int6) + 8u;
						Struct_fiz2nb struct_fiz2nb15 = struct_fiz2nb13;
						*(long*)num15 = struct_fiz2nb15.field_1;
						Int128 x8 = int6;
						Struct_fiz2nb struct_fiz2nb16 = FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_get_mantissa.Invoke(&fputil_FPBits_ubgsi6);
						Int128* num16 = &y;
						Struct_fiz2nb struct_fiz2nb17 = struct_fiz2nb16;
						*(long*)num16 = struct_fiz2nb17.field_0;
						byte* num17 = (byte*)(&y) + 8u;
						Struct_fiz2nb struct_fiz2nb18 = struct_fiz2nb16;
						*(long*)num17 = struct_fiz2nb18.field_1;
						int5 = NumericHelper.Add(x8, y);
					}
					else
					{
						Struct_fiz2nb struct_fiz2nb19 = FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_get_mantissa.Invoke(&fputil_FPBits_ubgsi5);
						Int128* num18 = &int7;
						Struct_fiz2nb struct_fiz2nb20 = struct_fiz2nb19;
						*(long*)num18 = struct_fiz2nb20.field_0;
						byte* num19 = (byte*)(&int7) + 8u;
						Struct_fiz2nb struct_fiz2nb21 = struct_fiz2nb19;
						*(long*)num19 = struct_fiz2nb21.field_1;
						Int128 x9 = int7;
						Struct_fiz2nb struct_fiz2nb22 = FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_get_mantissa.Invoke(&fputil_FPBits_ubgsi6);
						Int128* num20 = &y2;
						Struct_fiz2nb struct_fiz2nb23 = struct_fiz2nb22;
						*(long*)num20 = struct_fiz2nb23.field_0;
						byte* num21 = (byte*)(&y2) + 8u;
						Struct_fiz2nb struct_fiz2nb24 = struct_fiz2nb22;
						*(long*)num21 = struct_fiz2nb24.field_1;
						int5 = NumericHelper.Subtract(x9, y2);
					}
					int5 = NumericHelper.ShiftLeft(int5, 3L);
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(16L, &x3);
					Struct_fiz2nb struct_fiz2nb25 = FPRepSem_fputil_FPType_3_fputil_FPBits_float128_get_explicit_mantissa.Invoke((Fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi5));
					Int128* num22 = &x4;
					Struct_fiz2nb struct_fiz2nb26 = struct_fiz2nb25;
					*(long*)num22 = struct_fiz2nb26.field_0;
					byte* num23 = (byte*)(&x4) + 8u;
					Struct_fiz2nb struct_fiz2nb27 = struct_fiz2nb25;
					*(long*)num23 = struct_fiz2nb27.field_1;
					x3 = NumericHelper.ShiftLeft(x4, 3L);
					Llvm_lifetime_start_p0.Invoke(16L, &x5);
					Struct_fiz2nb struct_fiz2nb28 = FPRepSem_fputil_FPType_3_fputil_FPBits_float128_get_explicit_mantissa.Invoke((Fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi6));
					Int128* num24 = &x6;
					Struct_fiz2nb struct_fiz2nb29 = struct_fiz2nb28;
					*(long*)num24 = struct_fiz2nb29.field_0;
					byte* num25 = (byte*)(&x6) + 8u;
					Struct_fiz2nb struct_fiz2nb30 = struct_fiz2nb28;
					*(long*)num25 = struct_fiz2nb30.field_1;
					x5 = NumericHelper.ShiftLeft(x6, 3L);
					Llvm_lifetime_start_p0.Invoke(4L, &num6);
					checked
					{
						num6 = unchecked((ushort)FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_get_biased_exponent.Invoke(&fputil_FPBits_ubgsi5)) - unchecked((ushort)FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_get_biased_exponent.Invoke(&fputil_FPBits_ubgsi6));
						Llvm_lifetime_start_p0.Invoke(16L, &x7);
					}
					x7 = NumericHelper.ShiftRightLogical(x5, (Int128)(UInt128)(*(uint*)Cpp_min_int.Invoke(&num6, &num3)));
					Llvm_lifetime_start_p0.Invoke(1L, &b2);
					b2 = -86;
					b2 = ((num6 > 3 && (num6 > 115 || NumericHelper.IntCmpNe(NumericHelper.ShiftLeft(x5, (Int128)(UInt128)(uint)checked(128 - num6)), 0L))) ? ((sbyte)1) : ((sbyte)0));
					Llvm_lifetime_start_p0.Invoke(16L, &y3);
					y3 = (((b2 & 1) == 1) ? 1 : 0);
					int5 = (((b & 1) != 1) ? NumericHelper.Subtract(x3, NumericHelper.BitwiseOr(x7, y3)) : NumericHelper.Add(x3, NumericHelper.BitwiseOr(x7, y3)));
					Llvm_lifetime_end_p0.Invoke(16L, &y3);
					Llvm_lifetime_end_p0.Invoke(1L, &b2);
					Llvm_lifetime_end_p0.Invoke(16L, &x7);
					Llvm_lifetime_end_p0.Invoke(4L, &num6);
					Llvm_lifetime_end_p0.Invoke(16L, &x5);
					Llvm_lifetime_end_p0.Invoke(16L, &x3);
				}
				Llvm_lifetime_start_p0.Invoke(4L, &num7);
				num7 = checked(FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_get_exponent.Invoke(&fputil_FPBits_ubgsi5) - 115);
				Llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd);
				*(sbyte*)(&fputil_DyadicFloat_kt2kd) = -86;
				sbyte* ptr3 = (sbyte*)(&fputil_DyadicFloat_kt2kd) + 1;
				*ptr3 = -86;
				ptr3[1] = -86;
				ptr3[2] = -86;
				((int*)(&fputil_DyadicFloat_kt2kd))[1] = -1431655766;
				sbyte* ptr4 = (sbyte*)(&fputil_DyadicFloat_kt2kd) + 8;
				*(long*)ptr4 = -6148914691236517206L;
				((long*)ptr4)[1] = -6148914691236517206L;
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb18, &anon_izyfb14, 1L, isVolatile: false);
				int e = num7;
				int8 = int5;
				BigInt_128ul_false_unsigned_long_BigInt_unsigned_int128_void.Invoke((Anon_izyfb7*)(&bigInt_qdkjbh), *(long*)(&int8), ((long*)(&int8))[1]);
				DyadicFloat_128ul_Constructor.Invoke(&fputil_DyadicFloat_kt2kd, anon_izyfb18.Val, e, *(long*)(&bigInt_qdkjbh), ((long*)(&bigInt_qdkjbh))[1]);
				result = DyadicFloat_128ul_as_double_true_void.Invoke(&fputil_DyadicFloat_kt2kd);
				Llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd);
				Llvm_lifetime_end_p0.Invoke(4L, &num7);
				Llvm_lifetime_end_p0.Invoke(16L, &int5);
				Llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi6);
				Llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi5);
				Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb14);
			}
			Llvm_lifetime_end_p0.Invoke(16L, &num5);
			Llvm_lifetime_end_p0.Invoke(16L, &num4);
			goto IL_1137;
		}
	}
}
