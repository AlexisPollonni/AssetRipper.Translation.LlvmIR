using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Generic_fma_Float16_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic3fmaIDF16_dEENS_3cpp9enable_ifIXaaaasr3cppE19is_floating_point_vIT_Esr3cppE19is_floating_point_vIT0_ElestS5_stS6_ES5_E4typeES6_S6_S6_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16> && cpp::is_floating_point_v<double> && sizeof (_Float16) <= sizeof (double), _Float16>::type __llvm_libc_20_1_2_::fputil::generic::fma<_Float16, double>(double, double, double)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16> && cpp::is_floating_point_v<double> && sizeof (_Float16) <= sizeof (double), _Float16>::type")]
	public unsafe static Half Invoke([MangledName("x")][NativeType("double")] double X, [MangledName("y")][NativeType("double")] double Y, [MangledName("z")][NativeType("double")] double Z)
	{
		int num = 0;
		long num2 = 0L;
		long num3 = 0L;
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm2 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm3 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		long num4 = 0L;
		Llvm_libc_20_1_2_fputil_FPBits_2fahva llvm_libc_20_1_2_fputil_FPBits_2fahva = default(Llvm_libc_20_1_2_fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		long num5 = 0L;
		Llvm_libc_20_1_2_fputil_FPBits_2fahva llvm_libc_20_1_2_fputil_FPBits_2fahva2 = default(Llvm_libc_20_1_2_fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		long num6 = 0L;
		Llvm_libc_20_1_2_fputil_FPBits_2fahva llvm_libc_20_1_2_fputil_FPBits_2fahva3 = default(Llvm_libc_20_1_2_fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_2fahva llvm_libc_20_1_2_fputil_FPBits_2fahva4 = default(Llvm_libc_20_1_2_fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb4 = default(Anon_izyfb7);
		int num7 = 0;
		int num8 = 0;
		int num9 = 0;
		long num10 = 0L;
		double num11 = 0.0;
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm4 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm5 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm6 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm7 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm8 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm9 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb5 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb6 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb7 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb8 = default(Anon_izyfb7);
		long v = 0L;
		long v2 = 0L;
		Llvm_libc_20_1_2_BigInt_qdkjbh llvm_libc_20_1_2_BigInt_qdkjbh = default(Llvm_libc_20_1_2_BigInt_qdkjbh);
		Llvm_libc_20_1_2_BigInt_qdkjbh llvm_libc_20_1_2_BigInt_qdkjbh2 = default(Llvm_libc_20_1_2_BigInt_qdkjbh);
		Llvm_libc_20_1_2_BigInt_qdkjbh llvm_libc_20_1_2_BigInt_qdkjbh3 = default(Llvm_libc_20_1_2_BigInt_qdkjbh);
		Llvm_libc_20_1_2_BigInt_qdkjbh llvm_libc_20_1_2_BigInt_qdkjbh4 = default(Llvm_libc_20_1_2_BigInt_qdkjbh);
		int num12 = 0;
		int num13 = 0;
		int num14 = 0;
		sbyte b = 0;
		sbyte b2 = 0;
		Anon_izyfb7 anon_izyfb9 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb10 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_BigInt_qdkjbh llvm_libc_20_1_2_BigInt_qdkjbh5 = default(Llvm_libc_20_1_2_BigInt_qdkjbh);
		Llvm_libc_20_1_2_BigInt_qdkjbh llvm_libc_20_1_2_BigInt_qdkjbh6 = default(Llvm_libc_20_1_2_BigInt_qdkjbh);
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Anon_izyfb7 anon_izyfb11 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_BigInt_qdkjbh llvm_libc_20_1_2_BigInt_qdkjbh7 = default(Llvm_libc_20_1_2_BigInt_qdkjbh);
		Llvm_libc_20_1_2_BigInt_qdkjbh llvm_libc_20_1_2_BigInt_qdkjbh8 = default(Llvm_libc_20_1_2_BigInt_qdkjbh);
		Llvm_libc_20_1_2_BigInt_qdkjbh llvm_libc_20_1_2_BigInt_qdkjbh9 = default(Llvm_libc_20_1_2_BigInt_qdkjbh);
		double num15 = X;
		double num16 = Y;
		double num17 = Z;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = 53;
		Llvm_lifetime_start_p0.Invoke(8L, &num2);
		num2 = 106L;
		Llvm_lifetime_start_p0.Invoke(8L, &num3);
		num3 = 128L;
		Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		unchecked
		{
			*(long*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm, num15);
			Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm2);
			*(long*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm2) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm2, num16);
			Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm3);
			*(long*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm3) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm3, num17);
			Half result;
			if (Details_expects_bool_condition_bool.Invoke(FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_nan.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm)) ? true : ((!FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_nan.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm2))) ? FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_nan.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm3)) : true), Expected: false) && (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_nan.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm)) || FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_nan.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm2))))
			{
				if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_signaling_nan.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm)) || FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_signaling_nan.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm2)) || FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_signaling_nan.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm3)))
				{
					Fputil_raise_except_if_required.Invoke(1);
				}
				if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_quiet_nan.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm)))
				{
					Llvm_lifetime_start_p0.Invoke(8L, &num4);
					num4 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm));
					num4 >>>= 42;
					Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva);
					anon_izyfb.Val = FPStorage_fputil_FPType_2_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
					short field_ = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan.Invoke(V: (short)num4, Sign: anon_izyfb.Val);
					llvm_libc_20_1_2_fputil_FPBits_2fahva.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
					result = FPBits_Float16_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva);
					Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva);
					Llvm_lifetime_end_p0.Invoke(8L, &num4);
				}
				else if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_quiet_nan.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm2)))
				{
					Llvm_lifetime_start_p0.Invoke(8L, &num5);
					num5 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm2));
					num5 >>>= 42;
					Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva2);
					anon_izyfb2.Val = FPStorage_fputil_FPType_2_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm2);
					short field_2 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan.Invoke(V: (short)num5, Sign: anon_izyfb2.Val);
					llvm_libc_20_1_2_fputil_FPBits_2fahva2.FPRepImpl.FPRepSem.FPStorage.field_0 = field_2;
					result = FPBits_Float16_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva2);
					Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva2);
					Llvm_lifetime_end_p0.Invoke(8L, &num5);
				}
				else if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_quiet_nan.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm3)))
				{
					Llvm_lifetime_start_p0.Invoke(8L, &num6);
					num6 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm3));
					num6 >>>= 42;
					Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva3);
					anon_izyfb3.Val = FPStorage_fputil_FPType_2_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm3);
					short field_3 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan.Invoke(V: (short)num6, Sign: anon_izyfb3.Val);
					llvm_libc_20_1_2_fputil_FPBits_2fahva3.FPRepImpl.FPRepSem.FPStorage.field_0 = field_3;
					result = FPBits_Float16_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva3);
					Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva3);
					Llvm_lifetime_end_p0.Invoke(8L, &num6);
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva4);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb4, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
					short field_4 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan.Invoke(anon_izyfb4.Val, 0);
					llvm_libc_20_1_2_fputil_FPBits_2fahva4.FPRepImpl.FPRepSem.FPStorage.field_0 = field_4;
					result = FPBits_Float16_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva4);
					Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva4);
				}
			}
			else if (Details_expects_bool_condition_bool.Invoke((num15 == 0.0) ? true : ((num16 != 0.0) ? (num17 == 0.0) : true), Expected: false))
			{
				result = Fputil_cast_Float16_double.Invoke(Llvm_fmuladd_f64.Invoke(num15, num16, num17));
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num7);
				num7 = 0;
				Llvm_lifetime_start_p0.Invoke(4L, &num8);
				num8 = 0;
				Llvm_lifetime_start_p0.Invoke(4L, &num9);
				num9 = 0;
				Llvm_lifetime_start_p0.Invoke(8L, &num10);
				num10 = 0L;
				Llvm_lifetime_start_p0.Invoke(8L, &num11);
				num11 = 4503599627370496.0;
				Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm4);
				FPBits_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm4, num15);
				bool num18 = Details_expects_bool_condition_bool.Invoke(FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_subnormal.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm4)), Expected: false);
				Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm4);
				if (num18)
				{
					num7 = checked(num7 - 52);
					num15 *= 4503599627370496.0;
				}
				Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm5);
				FPBits_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm5, num16);
				bool num19 = Details_expects_bool_condition_bool.Invoke(FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_subnormal.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm5)), Expected: false);
				Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm5);
				if (num19)
				{
					num8 = checked(num8 - 52);
					num16 *= 4503599627370496.0;
				}
				Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm6);
				FPBits_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm6, num17);
				bool num20 = Details_expects_bool_condition_bool.Invoke(FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_subnormal.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm6)), Expected: false);
				Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm6);
				if (num20)
				{
					num9 = checked(num9 - 52);
					num17 *= 4503599627370496.0;
				}
				Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm7);
				FPBits_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm7, num15);
				Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm7, 8L, isVolatile: false);
				Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm7);
				Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm8);
				FPBits_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm8, num16);
				Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm2, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm8, 8L, isVolatile: false);
				Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm8);
				Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm9);
				FPBits_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm9, num17);
				Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm3, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm9, 8L, isVolatile: false);
				Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm9);
				Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb5);
				*(sbyte*)(&anon_izyfb5) = -86;
				anon_izyfb5.Val = FPStorage_fputil_FPType_2_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm3);
				Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb6);
				*(sbyte*)(&anon_izyfb6) = -86;
				anon_izyfb7.Val = FPStorage_fputil_FPType_2_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
				anon_izyfb8.Val = FPStorage_fputil_FPType_2_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm2);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb6, (!Llvm_libc_20_1_2_Equals_fy8fvt.Invoke(anon_izyfb7.Val, anon_izyfb8.Val)) ? Llvm_libc_20_1_2_Sign_NEG.Pointer : Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
				int num21 = (ushort)FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_biased_exponent.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm));
				num7 = checked(num7 + num21);
				int num22 = (ushort)FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_biased_exponent.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm2));
				num8 = checked(num8 + num22);
				int num23 = (ushort)FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_biased_exponent.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm3));
				num9 = checked(num9 + num23);
				if (Details_expects_bool_condition_bool.Invoke((num7 == 2047) ? true : ((num8 != 2047) ? (num9 == 2047) : true), Expected: false))
				{
					result = Fputil_cast_Float16_double.Invoke(Llvm_fmuladd_f64.Invoke(num15, num16, num17));
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(8L, &v);
					v = FPRepSem_fputil_FPType_2_fputil_FPBits_double_get_explicit_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm));
					Llvm_lifetime_start_p0.Invoke(8L, &v2);
					v2 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_get_explicit_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm2));
					Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh);
					sbyte* ptr = (sbyte*)(&llvm_libc_20_1_2_BigInt_qdkjbh);
					*(long*)ptr = -6148914691236517206L;
					((long*)ptr)[1] = -6148914691236517206L;
					BigInt_128ul_false_unsigned_long_BigInt_unsigned_long_void.Invoke((Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh), FPRepSem_fputil_FPType_2_fputil_FPBits_double_get_explicit_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm3)));
					Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh2);
					sbyte* ptr2 = (sbyte*)(&llvm_libc_20_1_2_BigInt_qdkjbh2);
					*(long*)ptr2 = -6148914691236517206L;
					((long*)ptr2)[1] = -6148914691236517206L;
					Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh3);
					BigInt_128ul_false_unsigned_long_BigInt_unsigned_long_void.Invoke((Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh3), v);
					Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh4);
					BigInt_128ul_false_unsigned_long_BigInt_unsigned_long_void.Invoke((Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh4), v2);
					Struct_fiz2nb struct_fiz2nb = BigInt_128ul_false_unsigned_long_Multiply.Invoke((Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh3), (Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh4));
					InlineArray2_Int64* ptr3 = &llvm_libc_20_1_2_BigInt_qdkjbh2.Val.Data;
					Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
					((Struct_fiz2nb*)ptr3)->field_0 = struct_fiz2nb2.field_0;
					Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
					((Struct_fiz2nb*)ptr3)->field_1 = struct_fiz2nb3.field_1;
					Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh4);
					Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh3);
					Llvm_lifetime_start_p0.Invoke(4L, &num12);
					num12 = checked(num7 + num8 - 1127);
					Llvm_lifetime_start_p0.Invoke(4L, &num13);
					num13 = 54;
					BigInt_128ul_false_unsigned_long_Operator_89tuvz.Invoke((Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh), 54L);
					Llvm_lifetime_start_p0.Invoke(4L, &num14);
					num14 = checked(num9 - 106);
					Llvm_lifetime_start_p0.Invoke(1L, &b);
					b = 0;
					Llvm_lifetime_start_p0.Invoke(1L, &b2);
					b2 = 0;
					if (num12 < num14)
					{
						b = (Internal_shift_mantissa_BigInt_128ul_false_unsigned_long.Invoke(checked(num14 - num12), (Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh2)) ? ((sbyte)1) : ((sbyte)0));
						num12 = num14;
					}
					else if (num14 < num12)
					{
						b2 = 1;
						b = (Internal_shift_mantissa_BigInt_128ul_false_unsigned_long.Invoke(checked(num12 - num14), (Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh)) ? ((sbyte)1) : ((sbyte)0));
					}
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, &anon_izyfb6, 1L, isVolatile: false);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb10, &anon_izyfb5, 1L, isVolatile: false);
					if (Llvm_libc_20_1_2_Equals_fy8fvt.Invoke(anon_izyfb9.Val, anon_izyfb10.Val))
					{
						BigInt_128ul_false_unsigned_long_Operator_hkgjni.Invoke((Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh2), (Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh));
					}
					else if (Llvm_libc_20_1_2_GreaterThanOrEquals_crwxpm.Invoke((Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh2), (Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh)))
					{
						if ((b2 & 1) == 1 && (b & 1) == 1)
						{
							BigInt_128ul_false_unsigned_long_Increment.Invoke((Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh));
						}
						BigInt_128ul_false_unsigned_long_Operator_qwctfr.Invoke((Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh2), (Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh));
					}
					else
					{
						if ((b2 & 1) != 1 && (b & 1) == 1)
						{
							BigInt_128ul_false_unsigned_long_Increment.Invoke((Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh2));
						}
						Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh5);
						Struct_fiz2nb struct_fiz2nb4 = BigInt_128ul_false_unsigned_long_Subtract_wqmyif.Invoke((Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh), (Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh2));
						InlineArray2_Int64* ptr4 = &llvm_libc_20_1_2_BigInt_qdkjbh5.Val.Data;
						Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
						((Struct_fiz2nb*)ptr4)->field_0 = struct_fiz2nb5.field_0;
						Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
						((Struct_fiz2nb*)ptr4)->field_1 = struct_fiz2nb6.field_1;
						Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_BigInt_qdkjbh2, &llvm_libc_20_1_2_BigInt_qdkjbh5, 16L, isVolatile: false);
						Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh5);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb6, &anon_izyfb5, 1L, isVolatile: false);
					}
					Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh6);
					BigInt_128ul_false_unsigned_long_BigInt_int_void.Invoke((Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh6), 0);
					bool num24 = Llvm_libc_20_1_2_Equals_s36iku.Invoke((Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh2), (Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh6));
					Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh6);
					if (num24)
					{
						if (Fputil_quick_get_round.Invoke() == 1024)
						{
							Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb6, Llvm_libc_20_1_2_Sign_NEG.Pointer, 1L, isVolatile: false);
						}
						else
						{
							Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb6, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
						}
					}
					Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd);
					*(sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd) = -86;
					sbyte* ptr5 = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd) + 1;
					*ptr5 = -86;
					ptr5[1] = -86;
					ptr5[2] = -86;
					((int*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd))[1] = -1431655766;
					sbyte* ptr6 = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd) + 8;
					*(long*)ptr6 = -6148914691236517206L;
					((long*)ptr6)[1] = -6148914691236517206L;
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb11, &anon_izyfb6, 1L, isVolatile: false);
					int e = checked(num12 - 1023);
					Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_BigInt_qdkjbh7, &llvm_libc_20_1_2_BigInt_qdkjbh2, 16L, isVolatile: false);
					DyadicFloat_128ul_Constructor.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd, anon_izyfb11.Val, e, *(long*)(&llvm_libc_20_1_2_BigInt_qdkjbh7), ((long*)(&llvm_libc_20_1_2_BigInt_qdkjbh7))[1]);
					Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh8);
					BigInt_128ul_false_unsigned_long_BigInt_unsigned_int_void.Invoke((Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh8), ((b & 1) == 1) ? 1 : 0);
					Struct_fiz2nb struct_fiz2nb7 = Llvm_libc_20_1_2_Operator_66fhg9.Invoke((Anon_izyfb7*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd.Mantissa), (Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh8));
					InlineArray2_Int64* ptr7 = &llvm_libc_20_1_2_BigInt_qdkjbh9.Val.Data;
					Struct_fiz2nb struct_fiz2nb8 = struct_fiz2nb7;
					((Struct_fiz2nb*)ptr7)->field_0 = struct_fiz2nb8.field_0;
					Struct_fiz2nb struct_fiz2nb9 = struct_fiz2nb7;
					((Struct_fiz2nb*)ptr7)->field_1 = struct_fiz2nb9.field_1;
					Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh8);
					result = DyadicFloat_128ul_as_Float16_true_void.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd);
					Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd);
					Llvm_lifetime_end_p0.Invoke(1L, &b2);
					Llvm_lifetime_end_p0.Invoke(1L, &b);
					Llvm_lifetime_end_p0.Invoke(4L, &num14);
					Llvm_lifetime_end_p0.Invoke(4L, &num13);
					Llvm_lifetime_end_p0.Invoke(4L, &num12);
					Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh2);
					Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh);
					Llvm_lifetime_end_p0.Invoke(8L, &v2);
					Llvm_lifetime_end_p0.Invoke(8L, &v);
				}
				Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb6);
				Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb5);
				Llvm_lifetime_end_p0.Invoke(8L, &num11);
				Llvm_lifetime_end_p0.Invoke(8L, &num10);
				Llvm_lifetime_end_p0.Invoke(4L, &num9);
				Llvm_lifetime_end_p0.Invoke(4L, &num8);
				Llvm_lifetime_end_p0.Invoke(4L, &num7);
			}
			Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm3);
			Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm2);
			Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
			Llvm_lifetime_end_p0.Invoke(8L, &num3);
			Llvm_lifetime_end_p0.Invoke(8L, &num2);
			Llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}
