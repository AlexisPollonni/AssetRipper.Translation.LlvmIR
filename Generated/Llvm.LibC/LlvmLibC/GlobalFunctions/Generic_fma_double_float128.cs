using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Generic_fma_double_float128
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic3fmaIdgEENS_3cpp9enable_ifIXaaaasr3cppE19is_floating_point_vIT_Esr3cppE19is_floating_point_vIT0_ElestS5_stS6_ES5_E4typeES6_S6_S6_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<double> && cpp::is_floating_point_v<__float128> && sizeof (double) <= sizeof (__float128), double>::type __llvm_libc_20_1_2_::fputil::generic::fma<double, __float128>(__float128, __float128, __float128)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<double> && cpp::is_floating_point_v<__float128> && sizeof (double) <= sizeof (__float128), double>::type")]
	public unsafe static double Invoke([MangledName("x")][NativeType("__float128")] double X, [MangledName("y")][NativeType("__float128")] double Y, [MangledName("z")][NativeType("__float128")] double Z)
	{
		int num = 0;
		long num2 = 0L;
		long num3 = 0L;
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi2 = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi3 = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Int128 @int = default(Int128);
		Int128 int2 = default(Int128);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Int128 int3 = default(Int128);
		Int128 int4 = default(Int128);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm2 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Int128 int5 = default(Int128);
		Int128 int6 = default(Int128);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm3 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm4 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb4 = default(Anon_izyfb7);
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		Int128 int7 = default(Int128);
		double num7 = 0.0;
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi4 = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi5 = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi6 = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi7 = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi8 = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi9 = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Anon_izyfb7 anon_izyfb5 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb6 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb7 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb8 = default(Anon_izyfb7);
		Int128 int8 = default(Int128);
		Int128 int9 = default(Int128);
		Int128 int10 = default(Int128);
		Int128 int11 = default(Int128);
		Llvm_libc_20_1_2_BigInt_x9dsed llvm_libc_20_1_2_BigInt_x9dsed = default(Llvm_libc_20_1_2_BigInt_x9dsed);
		Int128 int12 = default(Int128);
		Int128 int13 = default(Int128);
		Llvm_libc_20_1_2_BigInt_x9dsed llvm_libc_20_1_2_BigInt_x9dsed2 = default(Llvm_libc_20_1_2_BigInt_x9dsed);
		Llvm_libc_20_1_2_BigInt_x9dsed llvm_libc_20_1_2_BigInt_x9dsed3 = default(Llvm_libc_20_1_2_BigInt_x9dsed);
		Int128 int14 = default(Int128);
		Llvm_libc_20_1_2_BigInt_x9dsed llvm_libc_20_1_2_BigInt_x9dsed4 = default(Llvm_libc_20_1_2_BigInt_x9dsed);
		Int128 int15 = default(Int128);
		int num8 = 0;
		int num9 = 0;
		int num10 = 0;
		sbyte b = 0;
		sbyte b2 = 0;
		Anon_izyfb7 anon_izyfb9 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb10 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_BigInt_x9dsed llvm_libc_20_1_2_BigInt_x9dsed5 = default(Llvm_libc_20_1_2_BigInt_x9dsed);
		Llvm_libc_20_1_2_BigInt_x9dsed llvm_libc_20_1_2_BigInt_x9dsed6 = default(Llvm_libc_20_1_2_BigInt_x9dsed);
		Llvm_libc_20_1_2_fputil_DyadicFloat_jhcpjj llvm_libc_20_1_2_fputil_DyadicFloat_jhcpjj = default(Llvm_libc_20_1_2_fputil_DyadicFloat_jhcpjj);
		Anon_izyfb7 anon_izyfb11 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_BigInt_x9dsed llvm_libc_20_1_2_BigInt_x9dsed7 = default(Llvm_libc_20_1_2_BigInt_x9dsed);
		Llvm_libc_20_1_2_BigInt_x9dsed llvm_libc_20_1_2_BigInt_x9dsed8 = default(Llvm_libc_20_1_2_BigInt_x9dsed);
		Llvm_libc_20_1_2_BigInt_x9dsed llvm_libc_20_1_2_BigInt_x9dsed9 = default(Llvm_libc_20_1_2_BigInt_x9dsed);
		double num11 = X;
		double num12 = Y;
		double num13 = Z;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = 113;
		Llvm_lifetime_start_p0.Invoke(8L, &num2);
		num2 = 226L;
		Llvm_lifetime_start_p0.Invoke(8L, &num3);
		num3 = 256L;
		Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi);
		unchecked
		{
			*(Int128*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi) = -6148914691236517206L;
			FPBits_float128_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi, num11);
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
			*(Int128*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi2) = -6148914691236517206L;
			FPBits_float128_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi2, num12);
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi3);
			*(Int128*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi3) = -6148914691236517206L;
			FPBits_float128_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi3, num13);
			double result;
			if (Details_expects_bool_condition_bool.Invoke(FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_nan.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi)) ? true : ((!FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_nan.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi2))) ? FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_nan.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi3)) : true), Expected: false) && (FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_nan.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi)) || FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_nan.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi2))))
			{
				if (FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_signaling_nan.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi)) || FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_signaling_nan.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi2)) || FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_signaling_nan.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi3)))
				{
					Fputil_raise_except_if_required.Invoke(1);
				}
				if (FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_quiet_nan.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi)))
				{
					Llvm_lifetime_start_p0.Invoke(16L, &@int);
					Struct_fiz2nb struct_fiz2nb = FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_get_mantissa.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi);
					Int128* num14 = &int2;
					Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
					*(long*)num14 = struct_fiz2nb2.field_0;
					byte* num15 = (byte*)(&int2) + 8u;
					Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
					*(long*)num15 = struct_fiz2nb3.field_1;
					@int = int2;
					@int = NumericHelper.ShiftRightLogical(@int, 60L);
					Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
					anon_izyfb.Val = FPStorage_fputil_FPType_3_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi);
					long val = FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan.Invoke(V: (long)@int, Sign: anon_izyfb.Val);
					llvm_libc_20_1_2_fputil_FPBits_wjhbrm.FPRepImpl.FPRepSem.FPStorage.Val = val;
					result = FPBits_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
					Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
					Llvm_lifetime_end_p0.Invoke(16L, &@int);
				}
				else if (FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_quiet_nan.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi2)))
				{
					Llvm_lifetime_start_p0.Invoke(16L, &int3);
					Struct_fiz2nb struct_fiz2nb4 = FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_get_mantissa.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
					Int128* num16 = &int4;
					Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
					*(long*)num16 = struct_fiz2nb5.field_0;
					byte* num17 = (byte*)(&int4) + 8u;
					Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
					*(long*)num17 = struct_fiz2nb6.field_1;
					int3 = int4;
					int3 = NumericHelper.ShiftRightLogical(int3, 60L);
					Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm2);
					anon_izyfb2.Val = FPStorage_fputil_FPType_3_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
					long val2 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan.Invoke(V: (long)int3, Sign: anon_izyfb2.Val);
					llvm_libc_20_1_2_fputil_FPBits_wjhbrm2.FPRepImpl.FPRepSem.FPStorage.Val = val2;
					result = FPBits_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm2);
					Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm2);
					Llvm_lifetime_end_p0.Invoke(16L, &int3);
				}
				else if (FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_quiet_nan.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi3)))
				{
					Llvm_lifetime_start_p0.Invoke(16L, &int5);
					Struct_fiz2nb struct_fiz2nb7 = FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_get_mantissa.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi3);
					Int128* num18 = &int6;
					Struct_fiz2nb struct_fiz2nb8 = struct_fiz2nb7;
					*(long*)num18 = struct_fiz2nb8.field_0;
					byte* num19 = (byte*)(&int6) + 8u;
					Struct_fiz2nb struct_fiz2nb9 = struct_fiz2nb7;
					*(long*)num19 = struct_fiz2nb9.field_1;
					int5 = int6;
					int5 = NumericHelper.ShiftRightLogical(int5, 60L);
					Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm3);
					anon_izyfb3.Val = FPStorage_fputil_FPType_3_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi3);
					long val3 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan.Invoke(V: (long)int5, Sign: anon_izyfb3.Val);
					llvm_libc_20_1_2_fputil_FPBits_wjhbrm3.FPRepImpl.FPRepSem.FPStorage.Val = val3;
					result = FPBits_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm3);
					Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm3);
					Llvm_lifetime_end_p0.Invoke(16L, &int5);
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm4);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb4, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
					long val4 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan.Invoke(anon_izyfb4.Val, 0L);
					llvm_libc_20_1_2_fputil_FPBits_wjhbrm4.FPRepImpl.FPRepSem.FPStorage.Val = val4;
					result = FPBits_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm4);
					Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm4);
				}
			}
			else if (Details_expects_bool_condition_bool.Invoke((num11 == 0.0) ? true : ((num12 != 0.0) ? (num13 == 0.0) : true), Expected: false))
			{
				result = Fputil_cast_double_float128.Invoke(Llvm_fmuladd_f128.Invoke(num11, num12, num13));
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num4);
				num4 = 0;
				Llvm_lifetime_start_p0.Invoke(4L, &num5);
				num5 = 0;
				Llvm_lifetime_start_p0.Invoke(4L, &num6);
				num6 = 0;
				Llvm_lifetime_start_p0.Invoke(16L, &int7);
				int7 = 0L;
				Llvm_lifetime_start_p0.Invoke(16L, &num7);
				num7 = 5.192296858534828E+33;
				Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi4);
				FPBits_float128_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi4, num11);
				bool num20 = Details_expects_bool_condition_bool.Invoke(FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_subnormal.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi4)), Expected: false);
				Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi4);
				if (num20)
				{
					num4 = checked(num4 - 112);
					num11 *= 5.192296858534828E+33;
				}
				Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi5);
				FPBits_float128_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi5, num12);
				bool num21 = Details_expects_bool_condition_bool.Invoke(FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_subnormal.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi5)), Expected: false);
				Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi5);
				if (num21)
				{
					num5 = checked(num5 - 112);
					num12 *= 5.192296858534828E+33;
				}
				Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi6);
				FPBits_float128_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi6, num13);
				bool num22 = Details_expects_bool_condition_bool.Invoke(FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_subnormal.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi6)), Expected: false);
				Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi6);
				if (num22)
				{
					num6 = checked(num6 - 112);
					num13 *= 5.192296858534828E+33;
				}
				Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi7);
				FPBits_float128_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi7, num11);
				Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi, &llvm_libc_20_1_2_fputil_FPBits_ubgsi7, 16L, isVolatile: false);
				Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi7);
				Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi8);
				FPBits_float128_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi8, num12);
				Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi2, &llvm_libc_20_1_2_fputil_FPBits_ubgsi8, 16L, isVolatile: false);
				Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi8);
				Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi9);
				FPBits_float128_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi9, num13);
				Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi3, &llvm_libc_20_1_2_fputil_FPBits_ubgsi9, 16L, isVolatile: false);
				Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi9);
				Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb5);
				*(sbyte*)(&anon_izyfb5) = -86;
				anon_izyfb5.Val = FPStorage_fputil_FPType_3_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi3);
				Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb6);
				*(sbyte*)(&anon_izyfb6) = -86;
				anon_izyfb7.Val = FPStorage_fputil_FPType_3_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi);
				anon_izyfb8.Val = FPStorage_fputil_FPType_3_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb6, (!Llvm_libc_20_1_2_Equals_fy8fvt.Invoke(anon_izyfb7.Val, anon_izyfb8.Val)) ? Llvm_libc_20_1_2_Sign_NEG.Pointer : Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
				int num23 = (ushort)FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_get_biased_exponent.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi);
				num4 = checked(num4 + num23);
				int num24 = (ushort)FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_get_biased_exponent.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
				num5 = checked(num5 + num24);
				int num25 = (ushort)FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_get_biased_exponent.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi3);
				num6 = checked(num6 + num25);
				if (Details_expects_bool_condition_bool.Invoke((num4 == 32767) ? true : ((num5 != 32767) ? (num6 == 32767) : true), Expected: false))
				{
					result = Fputil_cast_double_float128.Invoke(Llvm_fmuladd_f128.Invoke(num11, num12, num13));
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(16L, &int8);
					Struct_fiz2nb struct_fiz2nb10 = FPRepSem_fputil_FPType_3_fputil_FPBits_float128_get_explicit_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi));
					Int128* num26 = &int9;
					Struct_fiz2nb struct_fiz2nb11 = struct_fiz2nb10;
					*(long*)num26 = struct_fiz2nb11.field_0;
					byte* num27 = (byte*)(&int9) + 8u;
					Struct_fiz2nb struct_fiz2nb12 = struct_fiz2nb10;
					*(long*)num27 = struct_fiz2nb12.field_1;
					int8 = int9;
					Llvm_lifetime_start_p0.Invoke(16L, &int10);
					Struct_fiz2nb struct_fiz2nb13 = FPRepSem_fputil_FPType_3_fputil_FPBits_float128_get_explicit_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi2));
					Int128* num28 = &int11;
					Struct_fiz2nb struct_fiz2nb14 = struct_fiz2nb13;
					*(long*)num28 = struct_fiz2nb14.field_0;
					byte* num29 = (byte*)(&int11) + 8u;
					Struct_fiz2nb struct_fiz2nb15 = struct_fiz2nb13;
					*(long*)num29 = struct_fiz2nb15.field_1;
					int10 = int11;
					Llvm_lifetime_start_p0.Invoke(32L, &llvm_libc_20_1_2_BigInt_x9dsed);
					sbyte* ptr = (sbyte*)(&llvm_libc_20_1_2_BigInt_x9dsed);
					*(long*)ptr = -6148914691236517206L;
					((long*)ptr)[1] = -6148914691236517206L;
					((long*)ptr)[2] = -6148914691236517206L;
					((long*)ptr)[3] = -6148914691236517206L;
					Struct_fiz2nb struct_fiz2nb16 = FPRepSem_fputil_FPType_3_fputil_FPBits_float128_get_explicit_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi3));
					Int128* num30 = &int12;
					Struct_fiz2nb struct_fiz2nb17 = struct_fiz2nb16;
					*(long*)num30 = struct_fiz2nb17.field_0;
					byte* num31 = (byte*)(&int12) + 8u;
					Struct_fiz2nb struct_fiz2nb18 = struct_fiz2nb16;
					*(long*)num31 = struct_fiz2nb18.field_1;
					int13 = int12;
					BigInt_256ul_false_unsigned_long_BigInt_unsigned_int128_void.Invoke(&llvm_libc_20_1_2_BigInt_x9dsed, *(long*)(&int13), ((long*)(&int13))[1]);
					Llvm_lifetime_start_p0.Invoke(32L, &llvm_libc_20_1_2_BigInt_x9dsed2);
					sbyte* ptr2 = (sbyte*)(&llvm_libc_20_1_2_BigInt_x9dsed2);
					*(long*)ptr2 = -6148914691236517206L;
					((long*)ptr2)[1] = -6148914691236517206L;
					((long*)ptr2)[2] = -6148914691236517206L;
					((long*)ptr2)[3] = -6148914691236517206L;
					Llvm_lifetime_start_p0.Invoke(32L, &llvm_libc_20_1_2_BigInt_x9dsed3);
					int14 = int8;
					BigInt_256ul_false_unsigned_long_BigInt_unsigned_int128_void.Invoke(&llvm_libc_20_1_2_BigInt_x9dsed3, *(long*)(&int14), ((long*)(&int14))[1]);
					Llvm_lifetime_start_p0.Invoke(32L, &llvm_libc_20_1_2_BigInt_x9dsed4);
					int15 = int10;
					BigInt_256ul_false_unsigned_long_BigInt_unsigned_int128_void.Invoke(&llvm_libc_20_1_2_BigInt_x9dsed4, *(long*)(&int15), ((long*)(&int15))[1]);
					BigInt_256ul_false_unsigned_long_Multiply.Invoke(&llvm_libc_20_1_2_BigInt_x9dsed2, &llvm_libc_20_1_2_BigInt_x9dsed3, &llvm_libc_20_1_2_BigInt_x9dsed4);
					Llvm_lifetime_end_p0.Invoke(32L, &llvm_libc_20_1_2_BigInt_x9dsed4);
					Llvm_lifetime_end_p0.Invoke(32L, &llvm_libc_20_1_2_BigInt_x9dsed3);
					Llvm_lifetime_start_p0.Invoke(4L, &num8);
					checked
					{
						num8 = num4 + num5 - 16607;
						Llvm_lifetime_start_p0.Invoke(4L, &num9);
						num9 = 114;
						BigInt_256ul_false_unsigned_long_Operator_d84zyi.Invoke(&llvm_libc_20_1_2_BigInt_x9dsed, 114L);
						Llvm_lifetime_start_p0.Invoke(4L, &num10);
						num10 = num6 - 226;
						Llvm_lifetime_start_p0.Invoke(1L, &b);
						b = 0;
						Llvm_lifetime_start_p0.Invoke(1L, &b2);
						b2 = 0;
						if (num8 < num10)
						{
							b = (Internal_shift_mantissa_BigInt_256ul_false_unsigned_long.Invoke(num10 - num8, &llvm_libc_20_1_2_BigInt_x9dsed2) ? ((sbyte)1) : ((sbyte)0));
							num8 = num10;
						}
						else if (num10 < num8)
						{
							b2 = 1;
							b = (Internal_shift_mantissa_BigInt_256ul_false_unsigned_long.Invoke(num8 - num10, &llvm_libc_20_1_2_BigInt_x9dsed) ? ((sbyte)1) : ((sbyte)0));
						}
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, &anon_izyfb6, 1L, isVolatile: false);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb10, &anon_izyfb5, 1L, isVolatile: false);
						if (Llvm_libc_20_1_2_Equals_fy8fvt.Invoke(anon_izyfb9.Val, anon_izyfb10.Val))
						{
							BigInt_256ul_false_unsigned_long_Operator_erpdi4.Invoke(&llvm_libc_20_1_2_BigInt_x9dsed2, &llvm_libc_20_1_2_BigInt_x9dsed);
						}
						else if (Llvm_libc_20_1_2_GreaterThanOrEquals_wawrhf.Invoke(&llvm_libc_20_1_2_BigInt_x9dsed2, &llvm_libc_20_1_2_BigInt_x9dsed))
						{
							if ((b2 & 1) == 1 && (b & 1) == 1)
							{
								BigInt_256ul_false_unsigned_long_Increment.Invoke(&llvm_libc_20_1_2_BigInt_x9dsed);
							}
							BigInt_256ul_false_unsigned_long_Operator_n8nv9c.Invoke(&llvm_libc_20_1_2_BigInt_x9dsed2, &llvm_libc_20_1_2_BigInt_x9dsed);
						}
						else
						{
							if ((b2 & 1) != 1 && (b & 1) == 1)
							{
								BigInt_256ul_false_unsigned_long_Increment.Invoke(&llvm_libc_20_1_2_BigInt_x9dsed2);
							}
							Llvm_lifetime_start_p0.Invoke(32L, &llvm_libc_20_1_2_BigInt_x9dsed5);
							BigInt_256ul_false_unsigned_long_Subtract_zudad5.Invoke(&llvm_libc_20_1_2_BigInt_x9dsed5, &llvm_libc_20_1_2_BigInt_x9dsed, &llvm_libc_20_1_2_BigInt_x9dsed2);
							Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_BigInt_x9dsed2, &llvm_libc_20_1_2_BigInt_x9dsed5, 32L, isVolatile: false);
							Llvm_lifetime_end_p0.Invoke(32L, &llvm_libc_20_1_2_BigInt_x9dsed5);
							Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb6, &anon_izyfb5, 1L, isVolatile: false);
						}
						Llvm_lifetime_start_p0.Invoke(32L, &llvm_libc_20_1_2_BigInt_x9dsed6);
						BigInt_256ul_false_unsigned_long_BigInt_int_void.Invoke(&llvm_libc_20_1_2_BigInt_x9dsed6, 0);
						bool num32 = Llvm_libc_20_1_2_Equals_k3cteu.Invoke(&llvm_libc_20_1_2_BigInt_x9dsed2, &llvm_libc_20_1_2_BigInt_x9dsed6);
						Llvm_lifetime_end_p0.Invoke(32L, &llvm_libc_20_1_2_BigInt_x9dsed6);
						if (num32)
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
						Llvm_lifetime_start_p0.Invoke(40L, &llvm_libc_20_1_2_fputil_DyadicFloat_jhcpjj);
						Llvm_memset_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_jhcpjj, -86, 40L, isVolatile: false);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb11, &anon_izyfb6, 1L, isVolatile: false);
						int e = num8 - 16383;
						Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_BigInt_x9dsed7, &llvm_libc_20_1_2_BigInt_x9dsed2, 32L, isVolatile: false);
						DyadicFloat_256ul_Constructor.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_jhcpjj, anon_izyfb11.Val, e, &llvm_libc_20_1_2_BigInt_x9dsed7);
						Llvm_lifetime_start_p0.Invoke(32L, &llvm_libc_20_1_2_BigInt_x9dsed8);
						BigInt_256ul_false_unsigned_long_BigInt_unsigned_int_void.Invoke(&llvm_libc_20_1_2_BigInt_x9dsed8, ((b & 1) == 1) ? 1 : 0);
						Llvm_libc_20_1_2_BigInt_x9dsed* lhs = &llvm_libc_20_1_2_fputil_DyadicFloat_jhcpjj.Mantissa;
						Llvm_lifetime_start_p0.Invoke(32L, &llvm_libc_20_1_2_BigInt_x9dsed9);
						Llvm_libc_20_1_2_Operator_dpx3t5.Invoke(&llvm_libc_20_1_2_BigInt_x9dsed9, lhs, &llvm_libc_20_1_2_BigInt_x9dsed8);
						Llvm_lifetime_end_p0.Invoke(32L, &llvm_libc_20_1_2_BigInt_x9dsed9);
						Llvm_lifetime_end_p0.Invoke(32L, &llvm_libc_20_1_2_BigInt_x9dsed8);
						result = DyadicFloat_256ul_as_double_true_void.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_jhcpjj);
						Llvm_lifetime_end_p0.Invoke(40L, &llvm_libc_20_1_2_fputil_DyadicFloat_jhcpjj);
						Llvm_lifetime_end_p0.Invoke(1L, &b2);
						Llvm_lifetime_end_p0.Invoke(1L, &b);
						Llvm_lifetime_end_p0.Invoke(4L, &num10);
						Llvm_lifetime_end_p0.Invoke(4L, &num9);
						Llvm_lifetime_end_p0.Invoke(4L, &num8);
						Llvm_lifetime_end_p0.Invoke(32L, &llvm_libc_20_1_2_BigInt_x9dsed2);
						Llvm_lifetime_end_p0.Invoke(32L, &llvm_libc_20_1_2_BigInt_x9dsed);
						Llvm_lifetime_end_p0.Invoke(16L, &int10);
						Llvm_lifetime_end_p0.Invoke(16L, &int8);
					}
				}
				Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb6);
				Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb5);
				Llvm_lifetime_end_p0.Invoke(16L, &num7);
				Llvm_lifetime_end_p0.Invoke(16L, &int7);
				Llvm_lifetime_end_p0.Invoke(4L, &num6);
				Llvm_lifetime_end_p0.Invoke(4L, &num5);
				Llvm_lifetime_end_p0.Invoke(4L, &num4);
			}
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi3);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi);
			Llvm_lifetime_end_p0.Invoke(8L, &num3);
			Llvm_lifetime_end_p0.Invoke(8L, &num2);
			Llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}
