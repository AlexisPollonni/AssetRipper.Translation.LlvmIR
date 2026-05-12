using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic3fmaIfdEENS_3cpp9enable_ifIXaaaasr3cppE19is_floating_point_vIT_Esr3cppE19is_floating_point_vIT0_ElestS5_stS6_ES5_E4typeES6_S6_S6_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<float> && cpp::is_floating_point_v<double> && sizeof (float) <= sizeof (double), float>::type __llvm_libc_20_1_2_::fputil::generic::fma<float, double>(double, double, double)")]
internal static partial class cpp_enable_if_cpp_is_floating_point_v_float_cpp_is_floating_point_v_double_sizeof_float_sizeof_double_float_type_fputil_generic_fma_float_double_double_double_double
{
	public unsafe static float Invoke(double x, double y, double z)
	{
		int num = 0;
		long num2 = 0L;
		long num3 = 0L;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm4 = default(fputil_FPBits_wjhbrm);
		long num4 = 0L;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		long num5 = 0L;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		long num6 = 0L;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs4 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs5 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb11 = default(anon_izyfb7);
		int num7 = 0;
		int num8 = 0;
		int num9 = 0;
		long num10 = 0L;
		double num11 = 0.0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm5 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm6 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm7 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm8 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm9 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm10 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb12 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb13 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb14 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb15 = default(anon_izyfb7);
		long v = 0L;
		long v2 = 0L;
		BigInt_qdkjbh bigInt_qdkjbh = default(BigInt_qdkjbh);
		BigInt_qdkjbh bigInt_qdkjbh2 = default(BigInt_qdkjbh);
		BigInt_qdkjbh bigInt_qdkjbh3 = default(BigInt_qdkjbh);
		BigInt_qdkjbh bigInt_qdkjbh4 = default(BigInt_qdkjbh);
		int num12 = 0;
		int num13 = 0;
		int num14 = 0;
		sbyte b = 0;
		sbyte b2 = 0;
		anon_izyfb7 anon_izyfb16 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb17 = default(anon_izyfb7);
		BigInt_qdkjbh bigInt_qdkjbh5 = default(BigInt_qdkjbh);
		BigInt_qdkjbh bigInt_qdkjbh6 = default(BigInt_qdkjbh);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd5 = default(fputil_DyadicFloat_kt2kd4);
		anon_izyfb7 anon_izyfb18 = default(anon_izyfb7);
		BigInt_qdkjbh bigInt_qdkjbh7 = default(BigInt_qdkjbh);
		BigInt_qdkjbh bigInt_qdkjbh8 = default(BigInt_qdkjbh);
		BigInt_qdkjbh bigInt_qdkjbh9 = default(BigInt_qdkjbh);
		double num15 = x;
		double num16 = y;
		double num17 = z;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = 53;
		llvm_lifetime_start_p0.Invoke(8L, &num2);
		num2 = 106L;
		llvm_lifetime_start_p0.Invoke(8L, &num3);
		num3 = 128L;
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		unchecked
		{
			*(long*)(&fputil_FPBits_wjhbrm2) = -6148914691236517206L;
			fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm2, num15);
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
			*(long*)(&fputil_FPBits_wjhbrm3) = -6148914691236517206L;
			fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm3, num16);
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
			*(long*)(&fputil_FPBits_wjhbrm4) = -6148914691236517206L;
			fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm4, num17);
			float result;
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_nan_const.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2)) ? true : ((!fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_nan_const.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm3))) ? fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_nan_const.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm4)) : true), expected: false) && (fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_nan_const.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2)) || fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_nan_const.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm3))))
			{
				if (fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_signaling_nan_const.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2)) || fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_signaling_nan_const.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm3)) || fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_signaling_nan_const.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm4)))
				{
					fputil_raise_except_if_required_int.Invoke(1);
				}
				if (fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_quiet_nan_const.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2)))
				{
					llvm_lifetime_start_p0.Invoke(8L, &num4);
					num4 = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2));
					num4 >>>= 29;
					llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
					anon_izyfb8.val = fputil_internal_FPStorage_fputil_FPType_2_sign_const.Invoke(&fputil_FPBits_wjhbrm2);
					int field_ = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan_Sign_unsigned_int.Invoke(v: (int)num4, sign: anon_izyfb8.val);
					fputil_FPBits_5nkvcs2.FPRepImpl.FPRepSem.field_0.field_0 = field_;
					result = fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs2);
					llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
					llvm_lifetime_end_p0.Invoke(8L, &num4);
				}
				else if (fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_quiet_nan_const.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm3)))
				{
					llvm_lifetime_start_p0.Invoke(8L, &num5);
					num5 = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm3));
					num5 >>>= 29;
					llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
					anon_izyfb9.val = fputil_internal_FPStorage_fputil_FPType_2_sign_const.Invoke(&fputil_FPBits_wjhbrm3);
					int field_2 = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan_Sign_unsigned_int.Invoke(v: (int)num5, sign: anon_izyfb9.val);
					fputil_FPBits_5nkvcs3.FPRepImpl.FPRepSem.field_0.field_0 = field_2;
					result = fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs3);
					llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
					llvm_lifetime_end_p0.Invoke(8L, &num5);
				}
				else if (fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_quiet_nan_const.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm4)))
				{
					llvm_lifetime_start_p0.Invoke(8L, &num6);
					num6 = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm4));
					num6 >>>= 29;
					llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
					anon_izyfb10.val = fputil_internal_FPStorage_fputil_FPType_2_sign_const.Invoke(&fputil_FPBits_wjhbrm4);
					int field_3 = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan_Sign_unsigned_int.Invoke(v: (int)num6, sign: anon_izyfb10.val);
					fputil_FPBits_5nkvcs4.FPRepImpl.FPRepSem.field_0.field_0 = field_3;
					result = fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs4);
					llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
					llvm_lifetime_end_p0.Invoke(8L, &num6);
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
			else if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((num15 == 0.0) ? true : ((num16 != 0.0) ? (num17 == 0.0) : true), expected: false))
			{
				result = cpp_enable_if_cpp_is_floating_point_v_float_cpp_is_floating_point_v_double_float_type_fputil_cast_float_double_double.Invoke(llvm_fmuladd_f64.Invoke(num15, num16, num17));
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(4L, &num7);
				num7 = 0;
				llvm_lifetime_start_p0.Invoke(4L, &num8);
				num8 = 0;
				llvm_lifetime_start_p0.Invoke(4L, &num9);
				num9 = 0;
				llvm_lifetime_start_p0.Invoke(8L, &num10);
				num10 = 0L;
				llvm_lifetime_start_p0.Invoke(8L, &num11);
				num11 = 4503599627370496.0;
				llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
				fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm5, num15);
				bool num18 = bool_details_expects_bool_condition_bool_bool_bool.Invoke(fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_subnormal_const.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm5)), expected: false);
				llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
				if (num18)
				{
					num7 = checked(num7 - 52);
					num15 *= 4503599627370496.0;
				}
				llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm6);
				fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm6, num16);
				bool num19 = bool_details_expects_bool_condition_bool_bool_bool.Invoke(fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_subnormal_const.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm6)), expected: false);
				llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm6);
				if (num19)
				{
					num8 = checked(num8 - 52);
					num16 *= 4503599627370496.0;
				}
				llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm7);
				fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm7, num17);
				bool num20 = bool_details_expects_bool_condition_bool_bool_bool.Invoke(fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_subnormal_const.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm7)), expected: false);
				llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm7);
				if (num20)
				{
					num9 = checked(num9 - 52);
					num17 *= 4503599627370496.0;
				}
				llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm8);
				fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm8, num15);
				llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_wjhbrm2, &fputil_FPBits_wjhbrm8, 8L, isVolatile: false);
				llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm8);
				llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm9);
				fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm9, num16);
				llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_wjhbrm3, &fputil_FPBits_wjhbrm9, 8L, isVolatile: false);
				llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm9);
				llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm10);
				fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm10, num17);
				llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_wjhbrm4, &fputil_FPBits_wjhbrm10, 8L, isVolatile: false);
				llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm10);
				llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb12);
				*(sbyte*)(&anon_izyfb12) = -86;
				anon_izyfb12.val = fputil_internal_FPStorage_fputil_FPType_2_sign_const.Invoke(&fputil_FPBits_wjhbrm4);
				llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb13);
				*(sbyte*)(&anon_izyfb13) = -86;
				anon_izyfb14.val = fputil_internal_FPStorage_fputil_FPType_2_sign_const.Invoke(&fputil_FPBits_wjhbrm2);
				anon_izyfb15.val = fputil_internal_FPStorage_fputil_FPType_2_sign_const.Invoke(&fputil_FPBits_wjhbrm3);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb13, (!operator_Sign_Sign_fy8fvt.Invoke(anon_izyfb14.val, anon_izyfb15.val)) ? Sign_NEG.Pointer : Sign_POS.Pointer, 1L, isVolatile: false);
				int num21 = (ushort)fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_biased_exponent_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2));
				num7 = checked(num7 + num21);
				int num22 = (ushort)fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_biased_exponent_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm3));
				num8 = checked(num8 + num22);
				int num23 = (ushort)fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_biased_exponent_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm4));
				num9 = checked(num9 + num23);
				if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((num7 == 2047) ? true : ((num8 != 2047) ? (num9 == 2047) : true), expected: false))
				{
					result = cpp_enable_if_cpp_is_floating_point_v_float_cpp_is_floating_point_v_double_float_type_fputil_cast_float_double_double.Invoke(llvm_fmuladd_f64.Invoke(num15, num16, num17));
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(8L, &v);
					v = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_get_explicit_mantissa_const.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2));
					llvm_lifetime_start_p0.Invoke(8L, &v2);
					v2 = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_get_explicit_mantissa_const.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm3));
					llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh);
					sbyte* ptr = (sbyte*)(&bigInt_qdkjbh);
					*(long*)ptr = -6148914691236517206L;
					((long*)ptr)[1] = -6148914691236517206L;
					BigInt_128ul_false_unsigned_long_BigInt_unsigned_long_void_unsigned_long.Invoke((anon_izyfb7*)(&bigInt_qdkjbh), fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_get_explicit_mantissa_const.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm4)));
					llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh2);
					sbyte* ptr2 = (sbyte*)(&bigInt_qdkjbh2);
					*(long*)ptr2 = -6148914691236517206L;
					((long*)ptr2)[1] = -6148914691236517206L;
					llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh3);
					BigInt_128ul_false_unsigned_long_BigInt_unsigned_long_void_unsigned_long.Invoke((anon_izyfb7*)(&bigInt_qdkjbh3), v);
					llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh4);
					BigInt_128ul_false_unsigned_long_BigInt_unsigned_long_void_unsigned_long.Invoke((anon_izyfb7*)(&bigInt_qdkjbh4), v2);
					Struct_fiz2nb struct_fiz2nb = BigInt_128ul_false_unsigned_long_operator_BigInt_128ul_false_unsigned_long_const_const_sxvpyc.Invoke((anon_izyfb7*)(&bigInt_qdkjbh3), (anon_izyfb7*)(&bigInt_qdkjbh4));
					InlineArray2_Int64* ptr3 = &bigInt_qdkjbh2.val.Data;
					Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
					((Struct_fiz2nb*)ptr3)->field_0 = struct_fiz2nb2.field_0;
					Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
					((Struct_fiz2nb*)ptr3)->field_1 = struct_fiz2nb3.field_1;
					llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh4);
					llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh3);
					llvm_lifetime_start_p0.Invoke(4L, &num12);
					num12 = checked(num7 + num8 - 1127);
					llvm_lifetime_start_p0.Invoke(4L, &num13);
					num13 = 54;
					BigInt_128ul_false_unsigned_long_operator_unsigned_long_89tuvz.Invoke((anon_izyfb7*)(&bigInt_qdkjbh), 54L);
					llvm_lifetime_start_p0.Invoke(4L, &num14);
					num14 = checked(num9 - 106);
					llvm_lifetime_start_p0.Invoke(1L, &b);
					b = 0;
					llvm_lifetime_start_p0.Invoke(1L, &b2);
					b2 = 0;
					if (num12 < num14)
					{
						b = (cpp_enable_if_is_unsigned_integral_or_big_int_v_BigInt_128ul_false_unsigned_long_bool_type_fputil_generic_internal_shift_mantissa_BigInt_128ul_false_unsigned_long_int_BigInt_128ul_false_unsigned_long.Invoke(checked(num14 - num12), (anon_izyfb7*)(&bigInt_qdkjbh2)) ? ((sbyte)1) : ((sbyte)0));
						num12 = num14;
					}
					else if (num14 < num12)
					{
						b2 = 1;
						b = (cpp_enable_if_is_unsigned_integral_or_big_int_v_BigInt_128ul_false_unsigned_long_bool_type_fputil_generic_internal_shift_mantissa_BigInt_128ul_false_unsigned_long_int_BigInt_128ul_false_unsigned_long.Invoke(checked(num12 - num14), (anon_izyfb7*)(&bigInt_qdkjbh)) ? ((sbyte)1) : ((sbyte)0));
					}
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb16, &anon_izyfb13, 1L, isVolatile: false);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb17, &anon_izyfb12, 1L, isVolatile: false);
					if (operator_Sign_Sign_fy8fvt.Invoke(anon_izyfb16.val, anon_izyfb17.val))
					{
						BigInt_128ul_false_unsigned_long_operator_BigInt_128ul_false_unsigned_long_const_2yyncw.Invoke((anon_izyfb7*)(&bigInt_qdkjbh2), (anon_izyfb7*)(&bigInt_qdkjbh));
					}
					else if (operator_BigInt_128ul_false_unsigned_long_const_BigInt_128ul_false_unsigned_long_const_8dmq5f.Invoke((anon_izyfb7*)(&bigInt_qdkjbh2), (anon_izyfb7*)(&bigInt_qdkjbh)))
					{
						if ((b2 & 1) == 1 && (b & 1) == 1)
						{
							BigInt_128ul_false_unsigned_long_operator.Invoke((anon_izyfb7*)(&bigInt_qdkjbh));
						}
						BigInt_128ul_false_unsigned_long_operator_BigInt_128ul_false_unsigned_long_const_kgy9bi.Invoke((anon_izyfb7*)(&bigInt_qdkjbh2), (anon_izyfb7*)(&bigInt_qdkjbh));
					}
					else
					{
						if ((b2 & 1) != 1 && (b & 1) == 1)
						{
							BigInt_128ul_false_unsigned_long_operator.Invoke((anon_izyfb7*)(&bigInt_qdkjbh2));
						}
						llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh5);
						Struct_fiz2nb struct_fiz2nb4 = BigInt_128ul_false_unsigned_long_operator_BigInt_128ul_false_unsigned_long_const_const_bswzzf.Invoke((anon_izyfb7*)(&bigInt_qdkjbh), (anon_izyfb7*)(&bigInt_qdkjbh2));
						InlineArray2_Int64* ptr4 = &bigInt_qdkjbh5.val.Data;
						Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
						((Struct_fiz2nb*)ptr4)->field_0 = struct_fiz2nb5.field_0;
						Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
						((Struct_fiz2nb*)ptr4)->field_1 = struct_fiz2nb6.field_1;
						llvm_memcpy_p0_p0_i64.Invoke(&bigInt_qdkjbh2, &bigInt_qdkjbh5, 16L, isVolatile: false);
						llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh5);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb13, &anon_izyfb12, 1L, isVolatile: false);
					}
					llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh6);
					BigInt_128ul_false_unsigned_long_BigInt_int_void_int.Invoke((anon_izyfb7*)(&bigInt_qdkjbh6), 0);
					bool num24 = operator_BigInt_128ul_false_unsigned_long_const_BigInt_128ul_false_unsigned_long_const_u7vb72.Invoke((anon_izyfb7*)(&bigInt_qdkjbh2), (anon_izyfb7*)(&bigInt_qdkjbh6));
					llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh6);
					if (num24)
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
					llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd5);
					*(sbyte*)(&fputil_DyadicFloat_kt2kd5) = -86;
					sbyte* ptr5 = (sbyte*)(&fputil_DyadicFloat_kt2kd5) + 1;
					*ptr5 = -86;
					ptr5[1] = -86;
					ptr5[2] = -86;
					((int*)(&fputil_DyadicFloat_kt2kd5))[1] = -1431655766;
					sbyte* ptr6 = (sbyte*)(&fputil_DyadicFloat_kt2kd5) + 8;
					*(long*)ptr6 = -6148914691236517206L;
					((long*)ptr6)[1] = -6148914691236517206L;
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb18, &anon_izyfb13, 1L, isVolatile: false);
					int e = checked(num12 - 1023);
					llvm_memcpy_p0_p0_i64.Invoke(&bigInt_qdkjbh7, &bigInt_qdkjbh2, 16L, isVolatile: false);
					fputil_DyadicFloat_128ul_DyadicFloat_Sign_int_BigInt_128ul_false_unsigned_long.Invoke(&fputil_DyadicFloat_kt2kd5, anon_izyfb18.val, e, *(long*)(&bigInt_qdkjbh7), ((long*)(&bigInt_qdkjbh7))[1]);
					llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh8);
					BigInt_128ul_false_unsigned_long_BigInt_unsigned_int_void_unsigned_int.Invoke((anon_izyfb7*)(&bigInt_qdkjbh8), ((b & 1) == 1) ? 1 : 0);
					Struct_fiz2nb struct_fiz2nb7 = operator_BigInt_128ul_false_unsigned_long_BigInt_128ul_false_unsigned_long_const_wgy84t.Invoke((anon_izyfb7*)(&fputil_DyadicFloat_kt2kd5.mantissa), (anon_izyfb7*)(&bigInt_qdkjbh8));
					InlineArray2_Int64* ptr7 = &bigInt_qdkjbh9.val.Data;
					Struct_fiz2nb struct_fiz2nb8 = struct_fiz2nb7;
					((Struct_fiz2nb*)ptr7)->field_0 = struct_fiz2nb8.field_0;
					Struct_fiz2nb struct_fiz2nb9 = struct_fiz2nb7;
					((Struct_fiz2nb*)ptr7)->field_1 = struct_fiz2nb9.field_1;
					llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh8);
					result = float_fputil_DyadicFloat_128ul_as_float_true_void_const.Invoke(&fputil_DyadicFloat_kt2kd5);
					llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd5);
					llvm_lifetime_end_p0.Invoke(1L, &b2);
					llvm_lifetime_end_p0.Invoke(1L, &b);
					llvm_lifetime_end_p0.Invoke(4L, &num14);
					llvm_lifetime_end_p0.Invoke(4L, &num13);
					llvm_lifetime_end_p0.Invoke(4L, &num12);
					llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh2);
					llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh);
					llvm_lifetime_end_p0.Invoke(8L, &v2);
					llvm_lifetime_end_p0.Invoke(8L, &v);
				}
				llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb13);
				llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb12);
				llvm_lifetime_end_p0.Invoke(8L, &num11);
				llvm_lifetime_end_p0.Invoke(8L, &num10);
				llvm_lifetime_end_p0.Invoke(4L, &num9);
				llvm_lifetime_end_p0.Invoke(4L, &num8);
				llvm_lifetime_end_p0.Invoke(4L, &num7);
			}
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			llvm_lifetime_end_p0.Invoke(8L, &num3);
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}
