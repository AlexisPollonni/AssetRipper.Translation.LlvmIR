using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class generic_fma_double_long_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic3fmaIdeEENS_3cpp9enable_ifIXaaaasr3cppE19is_floating_point_vIT_Esr3cppE19is_floating_point_vIT0_ElestS5_stS6_ES5_E4typeES6_S6_S6_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<double> && cpp::is_floating_point_v<long double> && sizeof (double) <= sizeof (long double), double>::type __llvm_libc_20_1_2_::fputil::generic::fma<double, long double>(long double, long double, long double)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<double> && cpp::is_floating_point_v<long double> && sizeof (double) <= sizeof (long double), double>::type")]
	public unsafe static double Invoke([NativeType("long double")] double x, [NativeType("long double")] double y, [NativeType("long double")] double z)
	{
		int num = 0;
		long num2 = 0L;
		long num3 = 0L;
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(fputil_FPBits_ubgsi2);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi4 = default(fputil_FPBits_ubgsi2);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi5 = default(fputil_FPBits_ubgsi2);
		Int128 @int = default(Int128);
		Int128 int2 = default(Int128);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		Int128 int3 = default(Int128);
		Int128 int4 = default(Int128);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		Int128 int5 = default(Int128);
		Int128 int6 = default(Int128);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm4 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm5 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb11 = default(anon_izyfb7);
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		Int128 int7 = default(Int128);
		double num7 = 0.0;
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi6 = default(fputil_FPBits_ubgsi2);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi7 = default(fputil_FPBits_ubgsi2);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi8 = default(fputil_FPBits_ubgsi2);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi9 = default(fputil_FPBits_ubgsi2);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi10 = default(fputil_FPBits_ubgsi2);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi11 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb12 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb13 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb14 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb15 = default(anon_izyfb7);
		Int128 int8 = default(Int128);
		Int128 int9 = default(Int128);
		Int128 int10 = default(Int128);
		Int128 int11 = default(Int128);
		BigInt_x9dsed bigInt_x9dsed = default(BigInt_x9dsed);
		Int128 int12 = default(Int128);
		Int128 int13 = default(Int128);
		BigInt_x9dsed bigInt_x9dsed2 = default(BigInt_x9dsed);
		BigInt_x9dsed bigInt_x9dsed3 = default(BigInt_x9dsed);
		Int128 int14 = default(Int128);
		BigInt_x9dsed bigInt_x9dsed4 = default(BigInt_x9dsed);
		Int128 int15 = default(Int128);
		int num8 = 0;
		int num9 = 0;
		int num10 = 0;
		sbyte b = 0;
		sbyte b2 = 0;
		anon_izyfb7 anon_izyfb16 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb17 = default(anon_izyfb7);
		BigInt_x9dsed bigInt_x9dsed5 = default(BigInt_x9dsed);
		BigInt_x9dsed bigInt_x9dsed6 = default(BigInt_x9dsed);
		fputil_DyadicFloat_jhcpjj fputil_DyadicFloat_jhcpjj2 = default(fputil_DyadicFloat_jhcpjj);
		anon_izyfb7 anon_izyfb18 = default(anon_izyfb7);
		BigInt_x9dsed bigInt_x9dsed7 = default(BigInt_x9dsed);
		BigInt_x9dsed bigInt_x9dsed8 = default(BigInt_x9dsed);
		BigInt_x9dsed bigInt_x9dsed9 = default(BigInt_x9dsed);
		double num11 = x;
		double num12 = y;
		double num13 = z;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = 64;
		llvm_lifetime_start_p0.Invoke(8L, &num2);
		num2 = 128L;
		llvm_lifetime_start_p0.Invoke(8L, &num3);
		num3 = 256L;
		llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		unchecked
		{
			*(Int128*)(&fputil_FPBits_ubgsi3) = -6148914691236517206L;
			FPBits_long_double_Constructor.Invoke(&fputil_FPBits_ubgsi3, num11);
			llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
			*(Int128*)(&fputil_FPBits_ubgsi4) = -6148914691236517206L;
			FPBits_long_double_Constructor.Invoke(&fputil_FPBits_ubgsi4, num12);
			llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi5);
			*(Int128*)(&fputil_FPBits_ubgsi5) = -6148914691236517206L;
			FPBits_long_double_Constructor.Invoke(&fputil_FPBits_ubgsi5, num13);
			double result;
			if (details_expects_bool_condition_bool.Invoke(FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_nan.Invoke(&fputil_FPBits_ubgsi3) ? true : ((!FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_nan.Invoke(&fputil_FPBits_ubgsi4)) ? FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_nan.Invoke(&fputil_FPBits_ubgsi5) : true), expected: false) && (FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_nan.Invoke(&fputil_FPBits_ubgsi3) || FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_nan.Invoke(&fputil_FPBits_ubgsi4)))
			{
				if (FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_signaling_nan.Invoke(&fputil_FPBits_ubgsi3) || FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_signaling_nan.Invoke(&fputil_FPBits_ubgsi4) || FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_signaling_nan.Invoke(&fputil_FPBits_ubgsi5))
				{
					fputil_raise_except_if_required.Invoke(1);
				}
				if (FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_quiet_nan.Invoke(&fputil_FPBits_ubgsi3))
				{
					llvm_lifetime_start_p0.Invoke(16L, &@int);
					Struct_fiz2nb struct_fiz2nb = FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_mantissa.Invoke(&fputil_FPBits_ubgsi3);
					Int128* num14 = &int2;
					Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
					*(long*)num14 = struct_fiz2nb2.field_0;
					byte* num15 = (byte*)(&int2) + 8u;
					Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
					*(long*)num15 = struct_fiz2nb3.field_1;
					@int = int2;
					@int = NumericHelper.ShiftRightLogical(@int, 11L);
					llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
					anon_izyfb8.val = FPStorage_fputil_FPType_4_sign.Invoke(&fputil_FPBits_ubgsi3);
					long val = FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan.Invoke(v: (long)@int, sign: anon_izyfb8.val);
					fputil_FPBits_wjhbrm2.FPRepImpl.FPRepSem.FPStorage.val = val;
					result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm2);
					llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
					llvm_lifetime_end_p0.Invoke(16L, &@int);
				}
				else if (FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_quiet_nan.Invoke(&fputil_FPBits_ubgsi4))
				{
					llvm_lifetime_start_p0.Invoke(16L, &int3);
					Struct_fiz2nb struct_fiz2nb4 = FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_mantissa.Invoke(&fputil_FPBits_ubgsi4);
					Int128* num16 = &int4;
					Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
					*(long*)num16 = struct_fiz2nb5.field_0;
					byte* num17 = (byte*)(&int4) + 8u;
					Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
					*(long*)num17 = struct_fiz2nb6.field_1;
					int3 = int4;
					int3 = NumericHelper.ShiftRightLogical(int3, 11L);
					llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
					anon_izyfb9.val = FPStorage_fputil_FPType_4_sign.Invoke(&fputil_FPBits_ubgsi4);
					long val2 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan.Invoke(v: (long)int3, sign: anon_izyfb9.val);
					fputil_FPBits_wjhbrm3.FPRepImpl.FPRepSem.FPStorage.val = val2;
					result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm3);
					llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
					llvm_lifetime_end_p0.Invoke(16L, &int3);
				}
				else if (FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_quiet_nan.Invoke(&fputil_FPBits_ubgsi5))
				{
					llvm_lifetime_start_p0.Invoke(16L, &int5);
					Struct_fiz2nb struct_fiz2nb7 = FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_mantissa.Invoke(&fputil_FPBits_ubgsi5);
					Int128* num18 = &int6;
					Struct_fiz2nb struct_fiz2nb8 = struct_fiz2nb7;
					*(long*)num18 = struct_fiz2nb8.field_0;
					byte* num19 = (byte*)(&int6) + 8u;
					Struct_fiz2nb struct_fiz2nb9 = struct_fiz2nb7;
					*(long*)num19 = struct_fiz2nb9.field_1;
					int5 = int6;
					int5 = NumericHelper.ShiftRightLogical(int5, 11L);
					llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
					anon_izyfb10.val = FPStorage_fputil_FPType_4_sign.Invoke(&fputil_FPBits_ubgsi5);
					long val3 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan.Invoke(v: (long)int5, sign: anon_izyfb10.val);
					fputil_FPBits_wjhbrm4.FPRepImpl.FPRepSem.FPStorage.val = val3;
					result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm4);
					llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
					llvm_lifetime_end_p0.Invoke(16L, &int5);
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb11, Sign_POS.Pointer, 1L, isVolatile: false);
					long val4 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan.Invoke(anon_izyfb11.val, 0L);
					fputil_FPBits_wjhbrm5.FPRepImpl.FPRepSem.FPStorage.val = val4;
					result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm5);
					llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
				}
			}
			else if (details_expects_bool_condition_bool.Invoke((num11 == 0.0) ? true : ((num12 != 0.0) ? (num13 == 0.0) : true), expected: false))
			{
				result = fputil_cast_double_long_double.Invoke(llvm_fmuladd_f80.Invoke(num11, num12, num13));
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(4L, &num4);
				num4 = 0;
				llvm_lifetime_start_p0.Invoke(4L, &num5);
				num5 = 0;
				llvm_lifetime_start_p0.Invoke(4L, &num6);
				num6 = 0;
				llvm_lifetime_start_p0.Invoke(16L, &int7);
				int7 = long.MinValue;
				llvm_lifetime_start_p0.Invoke(16L, &num7);
				num7 = 9.223372036854776E+18;
				llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi6);
				FPBits_long_double_Constructor.Invoke(&fputil_FPBits_ubgsi6, num11);
				bool num20 = details_expects_bool_condition_bool.Invoke(FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_subnormal.Invoke(&fputil_FPBits_ubgsi6), expected: false);
				llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi6);
				checked
				{
					if (num20)
					{
						num4 -= 63;
						num11 *= 9.223372036854776E+18;
					}
					llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi7);
					FPBits_long_double_Constructor.Invoke(&fputil_FPBits_ubgsi7, num12);
					bool num21 = details_expects_bool_condition_bool.Invoke(FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_subnormal.Invoke(&fputil_FPBits_ubgsi7), expected: false);
					llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi7);
					if (num21)
					{
						num5 -= 63;
						num12 *= 9.223372036854776E+18;
					}
					llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi8);
					FPBits_long_double_Constructor.Invoke(&fputil_FPBits_ubgsi8, num13);
					bool num22 = details_expects_bool_condition_bool.Invoke(FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_subnormal.Invoke(&fputil_FPBits_ubgsi8), expected: false);
					llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi8);
					if (num22)
					{
						num6 -= 63;
						num13 *= 9.223372036854776E+18;
					}
					llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi9);
					FPBits_long_double_Constructor.Invoke(&fputil_FPBits_ubgsi9, num11);
					llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi3, &fputil_FPBits_ubgsi9, 16L, isVolatile: false);
					llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi9);
					llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi10);
					FPBits_long_double_Constructor.Invoke(&fputil_FPBits_ubgsi10, num12);
					llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi4, &fputil_FPBits_ubgsi10, 16L, isVolatile: false);
					llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi10);
					llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi11);
					FPBits_long_double_Constructor.Invoke(&fputil_FPBits_ubgsi11, num13);
					llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi5, &fputil_FPBits_ubgsi11, 16L, isVolatile: false);
					llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi11);
					llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb12);
				}
				*(sbyte*)(&anon_izyfb12) = -86;
				anon_izyfb12.val = FPStorage_fputil_FPType_4_sign.Invoke(&fputil_FPBits_ubgsi5);
				llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb13);
				*(sbyte*)(&anon_izyfb13) = -86;
				anon_izyfb14.val = FPStorage_fputil_FPType_4_sign.Invoke(&fputil_FPBits_ubgsi3);
				anon_izyfb15.val = FPStorage_fputil_FPType_4_sign.Invoke(&fputil_FPBits_ubgsi4);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb13, (!Equals_fy8fvt.Invoke(anon_izyfb14.val, anon_izyfb15.val)) ? Sign_NEG.Pointer : Sign_POS.Pointer, 1L, isVolatile: false);
				int num23 = (ushort)FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_biased_exponent.Invoke(&fputil_FPBits_ubgsi3);
				num4 = checked(num4 + num23);
				int num24 = (ushort)FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_biased_exponent.Invoke(&fputil_FPBits_ubgsi4);
				num5 = checked(num5 + num24);
				int num25 = (ushort)FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_biased_exponent.Invoke(&fputil_FPBits_ubgsi5);
				num6 = checked(num6 + num25);
				if (details_expects_bool_condition_bool.Invoke((num4 == 32767) ? true : ((num5 != 32767) ? (num6 == 32767) : true), expected: false))
				{
					result = fputil_cast_double_long_double.Invoke(llvm_fmuladd_f80.Invoke(num11, num12, num13));
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(16L, &int8);
					Struct_fiz2nb struct_fiz2nb10 = FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_get_explicit_mantissa.Invoke(&fputil_FPBits_ubgsi3);
					Int128* num26 = &int9;
					Struct_fiz2nb struct_fiz2nb11 = struct_fiz2nb10;
					*(long*)num26 = struct_fiz2nb11.field_0;
					byte* num27 = (byte*)(&int9) + 8u;
					Struct_fiz2nb struct_fiz2nb12 = struct_fiz2nb10;
					*(long*)num27 = struct_fiz2nb12.field_1;
					int8 = int9;
					llvm_lifetime_start_p0.Invoke(16L, &int10);
					Struct_fiz2nb struct_fiz2nb13 = FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_get_explicit_mantissa.Invoke(&fputil_FPBits_ubgsi4);
					Int128* num28 = &int11;
					Struct_fiz2nb struct_fiz2nb14 = struct_fiz2nb13;
					*(long*)num28 = struct_fiz2nb14.field_0;
					byte* num29 = (byte*)(&int11) + 8u;
					Struct_fiz2nb struct_fiz2nb15 = struct_fiz2nb13;
					*(long*)num29 = struct_fiz2nb15.field_1;
					int10 = int11;
					llvm_lifetime_start_p0.Invoke(32L, &bigInt_x9dsed);
					sbyte* ptr = (sbyte*)(&bigInt_x9dsed);
					*(long*)ptr = -6148914691236517206L;
					((long*)ptr)[1] = -6148914691236517206L;
					((long*)ptr)[2] = -6148914691236517206L;
					((long*)ptr)[3] = -6148914691236517206L;
					Struct_fiz2nb struct_fiz2nb16 = FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_get_explicit_mantissa.Invoke(&fputil_FPBits_ubgsi5);
					Int128* num30 = &int12;
					Struct_fiz2nb struct_fiz2nb17 = struct_fiz2nb16;
					*(long*)num30 = struct_fiz2nb17.field_0;
					byte* num31 = (byte*)(&int12) + 8u;
					Struct_fiz2nb struct_fiz2nb18 = struct_fiz2nb16;
					*(long*)num31 = struct_fiz2nb18.field_1;
					int13 = int12;
					BigInt_256ul_false_unsigned_long_BigInt_unsigned_int128_void.Invoke(&bigInt_x9dsed, *(long*)(&int13), ((long*)(&int13))[1]);
					llvm_lifetime_start_p0.Invoke(32L, &bigInt_x9dsed2);
					sbyte* ptr2 = (sbyte*)(&bigInt_x9dsed2);
					*(long*)ptr2 = -6148914691236517206L;
					((long*)ptr2)[1] = -6148914691236517206L;
					((long*)ptr2)[2] = -6148914691236517206L;
					((long*)ptr2)[3] = -6148914691236517206L;
					llvm_lifetime_start_p0.Invoke(32L, &bigInt_x9dsed3);
					int14 = int8;
					BigInt_256ul_false_unsigned_long_BigInt_unsigned_int128_void.Invoke(&bigInt_x9dsed3, *(long*)(&int14), ((long*)(&int14))[1]);
					llvm_lifetime_start_p0.Invoke(32L, &bigInt_x9dsed4);
					int15 = int10;
					BigInt_256ul_false_unsigned_long_BigInt_unsigned_int128_void.Invoke(&bigInt_x9dsed4, *(long*)(&int15), ((long*)(&int15))[1]);
					BigInt_256ul_false_unsigned_long_Multiply.Invoke(&bigInt_x9dsed2, &bigInt_x9dsed3, &bigInt_x9dsed4);
					llvm_lifetime_end_p0.Invoke(32L, &bigInt_x9dsed4);
					llvm_lifetime_end_p0.Invoke(32L, &bigInt_x9dsed3);
					llvm_lifetime_start_p0.Invoke(4L, &num8);
					checked
					{
						num8 = num4 + num5 - 16509;
						llvm_lifetime_start_p0.Invoke(4L, &num9);
						num9 = 65;
						BigInt_256ul_false_unsigned_long_Operator_d84zyi.Invoke(&bigInt_x9dsed, 65L);
						llvm_lifetime_start_p0.Invoke(4L, &num10);
						num10 = num6 - 128;
						llvm_lifetime_start_p0.Invoke(1L, &b);
						b = 0;
						llvm_lifetime_start_p0.Invoke(1L, &b2);
						b2 = 0;
						if (num8 < num10)
						{
							b = (internal_shift_mantissa_BigInt_256ul_false_unsigned_long.Invoke(num10 - num8, &bigInt_x9dsed2) ? ((sbyte)1) : ((sbyte)0));
							num8 = num10;
						}
						else if (num10 < num8)
						{
							b2 = 1;
							b = (internal_shift_mantissa_BigInt_256ul_false_unsigned_long.Invoke(num8 - num10, &bigInt_x9dsed) ? ((sbyte)1) : ((sbyte)0));
						}
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb16, &anon_izyfb13, 1L, isVolatile: false);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb17, &anon_izyfb12, 1L, isVolatile: false);
						if (Equals_fy8fvt.Invoke(anon_izyfb16.val, anon_izyfb17.val))
						{
							BigInt_256ul_false_unsigned_long_Operator_erpdi4.Invoke(&bigInt_x9dsed2, &bigInt_x9dsed);
						}
						else if (GreaterThanOrEquals_wawrhf.Invoke(&bigInt_x9dsed2, &bigInt_x9dsed))
						{
							if ((b2 & 1) == 1 && (b & 1) == 1)
							{
								BigInt_256ul_false_unsigned_long_Increment.Invoke(&bigInt_x9dsed);
							}
							BigInt_256ul_false_unsigned_long_Operator_n8nv9c.Invoke(&bigInt_x9dsed2, &bigInt_x9dsed);
						}
						else
						{
							if ((b2 & 1) != 1 && (b & 1) == 1)
							{
								BigInt_256ul_false_unsigned_long_Increment.Invoke(&bigInt_x9dsed2);
							}
							llvm_lifetime_start_p0.Invoke(32L, &bigInt_x9dsed5);
							BigInt_256ul_false_unsigned_long_Subtract_zudad5.Invoke(&bigInt_x9dsed5, &bigInt_x9dsed, &bigInt_x9dsed2);
							llvm_memcpy_p0_p0_i64.Invoke(&bigInt_x9dsed2, &bigInt_x9dsed5, 32L, isVolatile: false);
							llvm_lifetime_end_p0.Invoke(32L, &bigInt_x9dsed5);
							llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb13, &anon_izyfb12, 1L, isVolatile: false);
						}
						llvm_lifetime_start_p0.Invoke(32L, &bigInt_x9dsed6);
						BigInt_256ul_false_unsigned_long_BigInt_int_void.Invoke(&bigInt_x9dsed6, 0);
						bool num32 = Equals_k3cteu.Invoke(&bigInt_x9dsed2, &bigInt_x9dsed6);
						llvm_lifetime_end_p0.Invoke(32L, &bigInt_x9dsed6);
						if (num32)
						{
							if (fputil_quick_get_round.Invoke() == 1024)
							{
								llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb13, Sign_NEG.Pointer, 1L, isVolatile: false);
							}
							else
							{
								llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb13, Sign_POS.Pointer, 1L, isVolatile: false);
							}
						}
						llvm_lifetime_start_p0.Invoke(40L, &fputil_DyadicFloat_jhcpjj2);
						llvm_memset_p0_i64.Invoke(&fputil_DyadicFloat_jhcpjj2, -86, 40L, isVolatile: false);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb18, &anon_izyfb13, 1L, isVolatile: false);
						int e = num8 - 16383;
						llvm_memcpy_p0_p0_i64.Invoke(&bigInt_x9dsed7, &bigInt_x9dsed2, 32L, isVolatile: false);
						DyadicFloat_256ul_Constructor.Invoke(&fputil_DyadicFloat_jhcpjj2, anon_izyfb18.val, e, &bigInt_x9dsed7);
						llvm_lifetime_start_p0.Invoke(32L, &bigInt_x9dsed8);
						BigInt_256ul_false_unsigned_long_BigInt_unsigned_int_void.Invoke(&bigInt_x9dsed8, ((b & 1) == 1) ? 1 : 0);
						BigInt_x9dsed* lhs = &fputil_DyadicFloat_jhcpjj2.mantissa;
						llvm_lifetime_start_p0.Invoke(32L, &bigInt_x9dsed9);
						Operator_dpx3t5.Invoke(&bigInt_x9dsed9, lhs, &bigInt_x9dsed8);
						llvm_lifetime_end_p0.Invoke(32L, &bigInt_x9dsed9);
						llvm_lifetime_end_p0.Invoke(32L, &bigInt_x9dsed8);
						result = DyadicFloat_256ul_as_double_true_void.Invoke(&fputil_DyadicFloat_jhcpjj2);
						llvm_lifetime_end_p0.Invoke(40L, &fputil_DyadicFloat_jhcpjj2);
						llvm_lifetime_end_p0.Invoke(1L, &b2);
						llvm_lifetime_end_p0.Invoke(1L, &b);
						llvm_lifetime_end_p0.Invoke(4L, &num10);
						llvm_lifetime_end_p0.Invoke(4L, &num9);
						llvm_lifetime_end_p0.Invoke(4L, &num8);
						llvm_lifetime_end_p0.Invoke(32L, &bigInt_x9dsed2);
						llvm_lifetime_end_p0.Invoke(32L, &bigInt_x9dsed);
						llvm_lifetime_end_p0.Invoke(16L, &int10);
						llvm_lifetime_end_p0.Invoke(16L, &int8);
					}
				}
				llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb13);
				llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb12);
				llvm_lifetime_end_p0.Invoke(16L, &num7);
				llvm_lifetime_end_p0.Invoke(16L, &int7);
				llvm_lifetime_end_p0.Invoke(4L, &num6);
				llvm_lifetime_end_p0.Invoke(4L, &num5);
				llvm_lifetime_end_p0.Invoke(4L, &num4);
			}
			llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi5);
			llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
			llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
			llvm_lifetime_end_p0.Invoke(8L, &num3);
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}
