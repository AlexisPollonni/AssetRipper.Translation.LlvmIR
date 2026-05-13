using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic3fmaIfgEENS_3cpp9enable_ifIXaaaasr3cppE19is_floating_point_vIT_Esr3cppE19is_floating_point_vIT0_ElestS5_stS6_ES5_E4typeES6_S6_S6_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<float> && cpp::is_floating_point_v<__float128> && sizeof (float) <= sizeof (__float128), float>::type __llvm_libc_20_1_2_::fputil::generic::fma<float, __float128>(__float128, __float128, __float128)")]
internal static partial class cpp_enable_if_cpp_is_floating_point_v_float_cpp_is_floating_point_v_float128_sizeof_float_sizeof_float128_float_type_fputil_generic_fma_float_float128_float128_float128_float128
{
	public unsafe static float Invoke(double x, double y, double z)
	{
		int num = 0;
		long num2 = 0L;
		long num3 = 0L;
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(fputil_FPBits_ubgsi2);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi4 = default(fputil_FPBits_ubgsi2);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi5 = default(fputil_FPBits_ubgsi2);
		Int128 @int = default(Int128);
		Int128 int2 = default(Int128);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		Int128 int3 = default(Int128);
		Int128 int4 = default(Int128);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		Int128 int5 = default(Int128);
		Int128 int6 = default(Int128);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs4 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs5 = default(fputil_FPBits_5nkvcs);
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
		num = 113;
		llvm_lifetime_start_p0.Invoke(8L, &num2);
		num2 = 226L;
		llvm_lifetime_start_p0.Invoke(8L, &num3);
		num3 = 256L;
		llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		unchecked
		{
			*(Int128*)(&fputil_FPBits_ubgsi3) = -6148914691236517206L;
			fputil_FPBits_float128_FPBits_float128_float128.Invoke(&fputil_FPBits_ubgsi3, num11);
			llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
			*(Int128*)(&fputil_FPBits_ubgsi4) = -6148914691236517206L;
			fputil_FPBits_float128_FPBits_float128_float128.Invoke(&fputil_FPBits_ubgsi4, num12);
			llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi5);
			*(Int128*)(&fputil_FPBits_ubgsi5) = -6148914691236517206L;
			fputil_FPBits_float128_FPBits_float128_float128.Invoke(&fputil_FPBits_ubgsi5, num13);
			float result;
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_nan_const.Invoke((fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi3)) ? true : ((!fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_nan_const.Invoke((fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi4))) ? fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_nan_const.Invoke((fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi5)) : true), expected: false) && (fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_nan_const.Invoke((fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi3)) || fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_nan_const.Invoke((fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi4))))
			{
				if (fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_signaling_nan_const.Invoke((fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi3)) || fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_signaling_nan_const.Invoke((fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi4)) || fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_signaling_nan_const.Invoke((fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi5)))
				{
					fputil_raise_except_if_required_int.Invoke(1);
				}
				if (fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_quiet_nan_const.Invoke((fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi3)))
				{
					llvm_lifetime_start_p0.Invoke(16L, &@int);
					Struct_fiz2nb struct_fiz2nb = fputil_internal_FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_get_mantissa_const.Invoke(&fputil_FPBits_ubgsi3);
					Int128* num14 = &int2;
					Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
					*(long*)num14 = struct_fiz2nb2.field_0;
					byte* num15 = (byte*)(&int2) + 8u;
					Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
					*(long*)num15 = struct_fiz2nb3.field_1;
					@int = int2;
					@int = NumericHelper.ShiftRightLogical(@int, 89L);
					llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
					anon_izyfb8.val = fputil_internal_FPStorage_fputil_FPType_3_sign_const.Invoke(&fputil_FPBits_ubgsi3);
					int field_ = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan_Sign_unsigned_int.Invoke(v: (int)@int, sign: anon_izyfb8.val);
					fputil_FPBits_5nkvcs2.FPRepImpl.FPRepSem.field_0.field_0 = field_;
					result = fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs2);
					llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
					llvm_lifetime_end_p0.Invoke(16L, &@int);
				}
				else if (fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_quiet_nan_const.Invoke((fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi4)))
				{
					llvm_lifetime_start_p0.Invoke(16L, &int3);
					Struct_fiz2nb struct_fiz2nb4 = fputil_internal_FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_get_mantissa_const.Invoke(&fputil_FPBits_ubgsi4);
					Int128* num16 = &int4;
					Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
					*(long*)num16 = struct_fiz2nb5.field_0;
					byte* num17 = (byte*)(&int4) + 8u;
					Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
					*(long*)num17 = struct_fiz2nb6.field_1;
					int3 = int4;
					int3 = NumericHelper.ShiftRightLogical(int3, 89L);
					llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
					anon_izyfb9.val = fputil_internal_FPStorage_fputil_FPType_3_sign_const.Invoke(&fputil_FPBits_ubgsi4);
					int field_2 = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan_Sign_unsigned_int.Invoke(v: (int)int3, sign: anon_izyfb9.val);
					fputil_FPBits_5nkvcs3.FPRepImpl.FPRepSem.field_0.field_0 = field_2;
					result = fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs3);
					llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
					llvm_lifetime_end_p0.Invoke(16L, &int3);
				}
				else if (fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_quiet_nan_const.Invoke((fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi5)))
				{
					llvm_lifetime_start_p0.Invoke(16L, &int5);
					Struct_fiz2nb struct_fiz2nb7 = fputil_internal_FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_get_mantissa_const.Invoke(&fputil_FPBits_ubgsi5);
					Int128* num18 = &int6;
					Struct_fiz2nb struct_fiz2nb8 = struct_fiz2nb7;
					*(long*)num18 = struct_fiz2nb8.field_0;
					byte* num19 = (byte*)(&int6) + 8u;
					Struct_fiz2nb struct_fiz2nb9 = struct_fiz2nb7;
					*(long*)num19 = struct_fiz2nb9.field_1;
					int5 = int6;
					int5 = NumericHelper.ShiftRightLogical(int5, 89L);
					llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
					anon_izyfb10.val = fputil_internal_FPStorage_fputil_FPType_3_sign_const.Invoke(&fputil_FPBits_ubgsi5);
					int field_3 = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan_Sign_unsigned_int.Invoke(v: (int)int5, sign: anon_izyfb10.val);
					fputil_FPBits_5nkvcs4.FPRepImpl.FPRepSem.field_0.field_0 = field_3;
					result = fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs4);
					llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
					llvm_lifetime_end_p0.Invoke(16L, &int5);
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs5);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb11, Sign_POS.Pointer, 1L, isVolatile: false);
					int field_4 = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan_Sign_unsigned_int.Invoke(anon_izyfb11.val, 0);
					fputil_FPBits_5nkvcs5.FPRepImpl.FPRepSem.field_0.field_0 = field_4;
					result = fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs5);
					llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs5);
				}
			}
			else if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((num11 == 0.0) ? true : ((num12 != 0.0) ? (num13 == 0.0) : true), expected: false))
			{
				result = cpp_enable_if_cpp_is_floating_point_v_float_cpp_is_floating_point_v_float128_float_type_fputil_cast_float_float128_float128.Invoke(llvm_fmuladd_f128.Invoke(num11, num12, num13));
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
				int7 = 0L;
				llvm_lifetime_start_p0.Invoke(16L, &num7);
				num7 = 5.192296858534828E+33;
				llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi6);
				fputil_FPBits_float128_FPBits_float128_float128.Invoke(&fputil_FPBits_ubgsi6, num11);
				bool num20 = bool_details_expects_bool_condition_bool_bool_bool.Invoke(fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_subnormal_const.Invoke((fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi6)), expected: false);
				llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi6);
				if (num20)
				{
					num4 = checked(num4 - 112);
					num11 *= 5.192296858534828E+33;
				}
				llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi7);
				fputil_FPBits_float128_FPBits_float128_float128.Invoke(&fputil_FPBits_ubgsi7, num12);
				bool num21 = bool_details_expects_bool_condition_bool_bool_bool.Invoke(fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_subnormal_const.Invoke((fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi7)), expected: false);
				llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi7);
				if (num21)
				{
					num5 = checked(num5 - 112);
					num12 *= 5.192296858534828E+33;
				}
				llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi8);
				fputil_FPBits_float128_FPBits_float128_float128.Invoke(&fputil_FPBits_ubgsi8, num13);
				bool num22 = bool_details_expects_bool_condition_bool_bool_bool.Invoke(fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_subnormal_const.Invoke((fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi8)), expected: false);
				llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi8);
				if (num22)
				{
					num6 = checked(num6 - 112);
					num13 *= 5.192296858534828E+33;
				}
				llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi9);
				fputil_FPBits_float128_FPBits_float128_float128.Invoke(&fputil_FPBits_ubgsi9, num11);
				llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi3, &fputil_FPBits_ubgsi9, 16L, isVolatile: false);
				llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi9);
				llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi10);
				fputil_FPBits_float128_FPBits_float128_float128.Invoke(&fputil_FPBits_ubgsi10, num12);
				llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi4, &fputil_FPBits_ubgsi10, 16L, isVolatile: false);
				llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi10);
				llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi11);
				fputil_FPBits_float128_FPBits_float128_float128.Invoke(&fputil_FPBits_ubgsi11, num13);
				llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi5, &fputil_FPBits_ubgsi11, 16L, isVolatile: false);
				llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi11);
				llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb12);
				*(sbyte*)(&anon_izyfb12) = -86;
				anon_izyfb12.val = fputil_internal_FPStorage_fputil_FPType_3_sign_const.Invoke(&fputil_FPBits_ubgsi5);
				llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb13);
				*(sbyte*)(&anon_izyfb13) = -86;
				anon_izyfb14.val = fputil_internal_FPStorage_fputil_FPType_3_sign_const.Invoke(&fputil_FPBits_ubgsi3);
				anon_izyfb15.val = fputil_internal_FPStorage_fputil_FPType_3_sign_const.Invoke(&fputil_FPBits_ubgsi4);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb13, (!operator_Sign_Sign_fy8fvt.Invoke(anon_izyfb14.val, anon_izyfb15.val)) ? Sign_NEG.Pointer : Sign_POS.Pointer, 1L, isVolatile: false);
				int num23 = (ushort)fputil_internal_FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_get_biased_exponent_const.Invoke(&fputil_FPBits_ubgsi3);
				num4 = checked(num4 + num23);
				int num24 = (ushort)fputil_internal_FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_get_biased_exponent_const.Invoke(&fputil_FPBits_ubgsi4);
				num5 = checked(num5 + num24);
				int num25 = (ushort)fputil_internal_FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_get_biased_exponent_const.Invoke(&fputil_FPBits_ubgsi5);
				num6 = checked(num6 + num25);
				if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((num4 == 32767) ? true : ((num5 != 32767) ? (num6 == 32767) : true), expected: false))
				{
					result = cpp_enable_if_cpp_is_floating_point_v_float_cpp_is_floating_point_v_float128_float_type_fputil_cast_float_float128_float128.Invoke(llvm_fmuladd_f128.Invoke(num11, num12, num13));
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(16L, &int8);
					Struct_fiz2nb struct_fiz2nb10 = fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_get_explicit_mantissa_const.Invoke((fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi3));
					Int128* num26 = &int9;
					Struct_fiz2nb struct_fiz2nb11 = struct_fiz2nb10;
					*(long*)num26 = struct_fiz2nb11.field_0;
					byte* num27 = (byte*)(&int9) + 8u;
					Struct_fiz2nb struct_fiz2nb12 = struct_fiz2nb10;
					*(long*)num27 = struct_fiz2nb12.field_1;
					int8 = int9;
					llvm_lifetime_start_p0.Invoke(16L, &int10);
					Struct_fiz2nb struct_fiz2nb13 = fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_get_explicit_mantissa_const.Invoke((fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi4));
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
					Struct_fiz2nb struct_fiz2nb16 = fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_get_explicit_mantissa_const.Invoke((fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi5));
					Int128* num30 = &int12;
					Struct_fiz2nb struct_fiz2nb17 = struct_fiz2nb16;
					*(long*)num30 = struct_fiz2nb17.field_0;
					byte* num31 = (byte*)(&int12) + 8u;
					Struct_fiz2nb struct_fiz2nb18 = struct_fiz2nb16;
					*(long*)num31 = struct_fiz2nb18.field_1;
					int13 = int12;
					BigInt_256ul_false_unsigned_long_BigInt_unsigned_int128_void_unsigned_int128.Invoke(&bigInt_x9dsed, *(long*)(&int13), ((long*)(&int13))[1]);
					llvm_lifetime_start_p0.Invoke(32L, &bigInt_x9dsed2);
					sbyte* ptr2 = (sbyte*)(&bigInt_x9dsed2);
					*(long*)ptr2 = -6148914691236517206L;
					((long*)ptr2)[1] = -6148914691236517206L;
					((long*)ptr2)[2] = -6148914691236517206L;
					((long*)ptr2)[3] = -6148914691236517206L;
					llvm_lifetime_start_p0.Invoke(32L, &bigInt_x9dsed3);
					int14 = int8;
					BigInt_256ul_false_unsigned_long_BigInt_unsigned_int128_void_unsigned_int128.Invoke(&bigInt_x9dsed3, *(long*)(&int14), ((long*)(&int14))[1]);
					llvm_lifetime_start_p0.Invoke(32L, &bigInt_x9dsed4);
					int15 = int10;
					BigInt_256ul_false_unsigned_long_BigInt_unsigned_int128_void_unsigned_int128.Invoke(&bigInt_x9dsed4, *(long*)(&int15), ((long*)(&int15))[1]);
					BigInt_256ul_false_unsigned_long_operator_BigInt_256ul_false_unsigned_long_const_const_khz83e.Invoke(&bigInt_x9dsed2, &bigInt_x9dsed3, &bigInt_x9dsed4);
					llvm_lifetime_end_p0.Invoke(32L, &bigInt_x9dsed4);
					llvm_lifetime_end_p0.Invoke(32L, &bigInt_x9dsed3);
					llvm_lifetime_start_p0.Invoke(4L, &num8);
					checked
					{
						num8 = num4 + num5 - 16607;
						llvm_lifetime_start_p0.Invoke(4L, &num9);
						num9 = 114;
						BigInt_256ul_false_unsigned_long_operator_unsigned_long_d84zyi.Invoke(&bigInt_x9dsed, 114L);
						llvm_lifetime_start_p0.Invoke(4L, &num10);
						num10 = num6 - 226;
						llvm_lifetime_start_p0.Invoke(1L, &b);
						b = 0;
						llvm_lifetime_start_p0.Invoke(1L, &b2);
						b2 = 0;
						if (num8 < num10)
						{
							b = (cpp_enable_if_is_unsigned_integral_or_big_int_v_BigInt_256ul_false_unsigned_long_bool_type_fputil_generic_internal_shift_mantissa_BigInt_256ul_false_unsigned_long_int_BigInt_256ul_false_unsigned_long.Invoke(num10 - num8, &bigInt_x9dsed2) ? ((sbyte)1) : ((sbyte)0));
							num8 = num10;
						}
						else if (num10 < num8)
						{
							b2 = 1;
							b = (cpp_enable_if_is_unsigned_integral_or_big_int_v_BigInt_256ul_false_unsigned_long_bool_type_fputil_generic_internal_shift_mantissa_BigInt_256ul_false_unsigned_long_int_BigInt_256ul_false_unsigned_long.Invoke(num8 - num10, &bigInt_x9dsed) ? ((sbyte)1) : ((sbyte)0));
						}
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb16, &anon_izyfb13, 1L, isVolatile: false);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb17, &anon_izyfb12, 1L, isVolatile: false);
						if (operator_Sign_Sign_fy8fvt.Invoke(anon_izyfb16.val, anon_izyfb17.val))
						{
							BigInt_256ul_false_unsigned_long_operator_BigInt_256ul_false_unsigned_long_const_tunam8.Invoke(&bigInt_x9dsed2, &bigInt_x9dsed);
						}
						else if (operator_BigInt_256ul_false_unsigned_long_const_BigInt_256ul_false_unsigned_long_const_wawrhf.Invoke(&bigInt_x9dsed2, &bigInt_x9dsed))
						{
							if ((b2 & 1) == 1 && (b & 1) == 1)
							{
								BigInt_256ul_false_unsigned_long_operator.Invoke(&bigInt_x9dsed);
							}
							BigInt_256ul_false_unsigned_long_operator_BigInt_256ul_false_unsigned_long_const_9mt6kw.Invoke(&bigInt_x9dsed2, &bigInt_x9dsed);
						}
						else
						{
							if ((b2 & 1) != 1 && (b & 1) == 1)
							{
								BigInt_256ul_false_unsigned_long_operator.Invoke(&bigInt_x9dsed2);
							}
							llvm_lifetime_start_p0.Invoke(32L, &bigInt_x9dsed5);
							BigInt_256ul_false_unsigned_long_operator_BigInt_256ul_false_unsigned_long_const_const_vtxkz2.Invoke(&bigInt_x9dsed5, &bigInt_x9dsed, &bigInt_x9dsed2);
							llvm_memcpy_p0_p0_i64.Invoke(&bigInt_x9dsed2, &bigInt_x9dsed5, 32L, isVolatile: false);
							llvm_lifetime_end_p0.Invoke(32L, &bigInt_x9dsed5);
							llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb13, &anon_izyfb12, 1L, isVolatile: false);
						}
						llvm_lifetime_start_p0.Invoke(32L, &bigInt_x9dsed6);
						BigInt_256ul_false_unsigned_long_BigInt_int_void_int.Invoke(&bigInt_x9dsed6, 0);
						bool num32 = operator_BigInt_256ul_false_unsigned_long_const_BigInt_256ul_false_unsigned_long_const_nxrzhc.Invoke(&bigInt_x9dsed2, &bigInt_x9dsed6);
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
						fputil_DyadicFloat_256ul_DyadicFloat_Sign_int_BigInt_256ul_false_unsigned_long.Invoke(&fputil_DyadicFloat_jhcpjj2, anon_izyfb18.val, e, &bigInt_x9dsed7);
						llvm_lifetime_start_p0.Invoke(32L, &bigInt_x9dsed8);
						BigInt_256ul_false_unsigned_long_BigInt_unsigned_int_void_unsigned_int.Invoke(&bigInt_x9dsed8, ((b & 1) == 1) ? 1 : 0);
						BigInt_x9dsed* lhs = &fputil_DyadicFloat_jhcpjj2.mantissa;
						llvm_lifetime_start_p0.Invoke(32L, &bigInt_x9dsed9);
						operator_BigInt_256ul_false_unsigned_long_BigInt_256ul_false_unsigned_long_const.Invoke(&bigInt_x9dsed9, lhs, &bigInt_x9dsed8);
						llvm_lifetime_end_p0.Invoke(32L, &bigInt_x9dsed9);
						llvm_lifetime_end_p0.Invoke(32L, &bigInt_x9dsed8);
						result = float_fputil_DyadicFloat_256ul_as_float_true_void_const.Invoke(&fputil_DyadicFloat_jhcpjj2);
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
