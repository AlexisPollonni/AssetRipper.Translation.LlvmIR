using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic3divIfdEENS_3cpp9enable_ifIXaaaasr3cppE19is_floating_point_vIT_Esr3cppE19is_floating_point_vIT0_ElestS5_stS6_ES5_E4typeES6_S6_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<float> && cpp::is_floating_point_v<double> && sizeof (float) <= sizeof (double), float>::type __llvm_libc_20_1_2_::fputil::generic::div<float, double>(double, double)")]
internal static partial class cpp_enable_if_cpp_is_floating_point_v_float_cpp_is_floating_point_v_double_sizeof_float_sizeof_double_float_type_fputil_generic_div_float_double_double_double
{
	public unsafe static float Invoke(double x, double y)
	{
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		long num = 0L;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb11 = default(anon_izyfb7);
		long num2 = 0L;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb12 = default(anon_izyfb7);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs4 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb13 = default(anon_izyfb7);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs5 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb14 = default(anon_izyfb7);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs6 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb15 = default(anon_izyfb7);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs7 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb16 = default(anon_izyfb7);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs8 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb17 = default(anon_izyfb7);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs9 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb18 = default(anon_izyfb7);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs10 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb19 = default(anon_izyfb7);
		fputil_DyadicFloat_374hpp fputil_DyadicFloat_374hpp2 = default(fputil_DyadicFloat_374hpp);
		fputil_DyadicFloat_374hpp fputil_DyadicFloat_374hpp3 = default(fputil_DyadicFloat_374hpp);
		int num3 = 0;
		int num4 = 0;
		long num5 = 0L;
		long num6 = 0L;
		BigInt_nx6qdt bigInt_nx6qdt = default(BigInt_nx6qdt);
		long num7 = 0L;
		BigInt_nx6qdt bigInt_nx6qdt2 = default(BigInt_nx6qdt);
		int i = 0;
		fputil_DyadicFloat_374hpp fputil_DyadicFloat_374hpp4 = default(fputil_DyadicFloat_374hpp);
		anon_izyfb7 anon_izyfb20 = default(anon_izyfb7);
		BigInt_nx6qdt bigInt_nx6qdt3 = default(BigInt_nx6qdt);
		BigInt_nx6qdt bigInt_nx6qdt4 = default(BigInt_nx6qdt);
		BigInt_nx6qdt bigInt_nx6qdt5 = default(BigInt_nx6qdt);
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		float result;
		unchecked
		{
			*(long*)(&fputil_FPBits_wjhbrm2) = -6148914691236517206L;
			fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm2, x);
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
			*(long*)(&fputil_FPBits_wjhbrm3) = -6148914691236517206L;
			fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm3, y);
			llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb8);
			*(sbyte*)(&anon_izyfb8) = -86;
			anon_izyfb9.val = fputil_internal_FPStorage_fputil_FPType_2_sign_const.Invoke(&fputil_FPBits_wjhbrm2);
			anon_izyfb10.val = fputil_internal_FPStorage_fputil_FPType_2_sign_const.Invoke(&fputil_FPBits_wjhbrm3);
			llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, (!operator_Sign_Sign_fy8fvt.Invoke(anon_izyfb9.val, anon_izyfb10.val)) ? Sign_NEG.Pointer : Sign_POS.Pointer, 1L, isVolatile: false);
			if (!bool_details_expects_bool_condition_bool_bool_bool.Invoke(fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_inf_or_nan_const.Invoke(&fputil_FPBits_wjhbrm2) ? true : (fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_inf_or_nan_const.Invoke(&fputil_FPBits_wjhbrm3) ? true : ((!fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero_const.Invoke(&fputil_FPBits_wjhbrm2)) ? fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero_const.Invoke(&fputil_FPBits_wjhbrm3) : true)), expected: false))
			{
				goto IL_0701;
			}
			if (fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_nan_const.Invoke(&fputil_FPBits_wjhbrm2) || fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_nan_const.Invoke(&fputil_FPBits_wjhbrm3))
			{
				if (fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_signaling_nan_const.Invoke(&fputil_FPBits_wjhbrm2) || fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_signaling_nan_const.Invoke(&fputil_FPBits_wjhbrm3))
				{
					fputil_raise_except_if_required_int.Invoke(1);
				}
				if (fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_quiet_nan_const.Invoke(&fputil_FPBits_wjhbrm2))
				{
					llvm_lifetime_start_p0.Invoke(8L, &num);
					num = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa_const.Invoke(&fputil_FPBits_wjhbrm2);
					num >>>= 29;
					llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
					anon_izyfb11.val = fputil_internal_FPStorage_fputil_FPType_2_sign_const.Invoke(&fputil_FPBits_wjhbrm2);
					int field_ = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan_Sign_unsigned_int.Invoke(v: (int)num, sign: anon_izyfb11.val);
					fputil_FPBits_5nkvcs2.FPRepImpl.FPRepSem.field_0.field_0 = field_;
					result = fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs2);
					llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
					llvm_lifetime_end_p0.Invoke(8L, &num);
				}
				else if (fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_quiet_nan_const.Invoke(&fputil_FPBits_wjhbrm3))
				{
					llvm_lifetime_start_p0.Invoke(8L, &num2);
					num2 = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa_const.Invoke(&fputil_FPBits_wjhbrm3);
					num2 >>>= 29;
					llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
					anon_izyfb12.val = fputil_internal_FPStorage_fputil_FPType_2_sign_const.Invoke(&fputil_FPBits_wjhbrm3);
					int field_2 = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan_Sign_unsigned_int.Invoke(v: (int)num2, sign: anon_izyfb12.val);
					fputil_FPBits_5nkvcs3.FPRepImpl.FPRepSem.field_0.field_0 = field_2;
					result = fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs3);
					llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
					llvm_lifetime_end_p0.Invoke(8L, &num2);
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb13, Sign_POS.Pointer, 1L, isVolatile: false);
					int field_3 = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan_Sign_unsigned_int.Invoke(anon_izyfb13.val, 0);
					fputil_FPBits_5nkvcs4.FPRepImpl.FPRepSem.field_0.field_0 = field_3;
					result = fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs4);
					llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
				}
			}
			else if (fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_inf_const.Invoke(&fputil_FPBits_wjhbrm2))
			{
				if (fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_inf_const.Invoke(&fputil_FPBits_wjhbrm3))
				{
					fputil_set_errno_if_required_int.Invoke(33);
					fputil_raise_except_if_required_int.Invoke(1);
					llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs5);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb14, Sign_POS.Pointer, 1L, isVolatile: false);
					int field_4 = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan_Sign_unsigned_int.Invoke(anon_izyfb14.val, 0);
					fputil_FPBits_5nkvcs5.FPRepImpl.FPRepSem.field_0.field_0 = field_4;
					result = fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs5);
					llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs5);
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs6);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb15, &anon_izyfb8, 1L, isVolatile: false);
					int field_5 = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_inf_Sign.Invoke(anon_izyfb15.val);
					fputil_FPBits_5nkvcs6.FPRepImpl.FPRepSem.field_0.field_0 = field_5;
					result = fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs6);
					llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs6);
				}
			}
			else if (fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_inf_const.Invoke(&fputil_FPBits_wjhbrm3))
			{
				llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs7);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb16, &anon_izyfb8, 1L, isVolatile: false);
				int field_6 = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_inf_Sign.Invoke(anon_izyfb16.val);
				fputil_FPBits_5nkvcs7.FPRepImpl.FPRepSem.field_0.field_0 = field_6;
				result = fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs7);
				llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs7);
			}
			else if (fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero_const.Invoke(&fputil_FPBits_wjhbrm3))
			{
				if (fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero_const.Invoke(&fputil_FPBits_wjhbrm2))
				{
					fputil_raise_except_if_required_int.Invoke(1);
					llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs8);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb17, Sign_POS.Pointer, 1L, isVolatile: false);
					int field_7 = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan_Sign_unsigned_int.Invoke(anon_izyfb17.val, 0);
					fputil_FPBits_5nkvcs8.FPRepImpl.FPRepSem.field_0.field_0 = field_7;
					result = fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs8);
					llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs8);
				}
				else
				{
					fputil_raise_except_if_required_int.Invoke(4);
					llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs9);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb18, &anon_izyfb8, 1L, isVolatile: false);
					int field_8 = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_inf_Sign.Invoke(anon_izyfb18.val);
					fputil_FPBits_5nkvcs9.FPRepImpl.FPRepSem.field_0.field_0 = field_8;
					result = fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs9);
					llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs9);
				}
			}
			else
			{
				if (!fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero_const.Invoke(&fputil_FPBits_wjhbrm2))
				{
					goto IL_0701;
				}
				llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs10);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb19, &anon_izyfb8, 1L, isVolatile: false);
				int field_9 = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_zero_Sign.Invoke(anon_izyfb19.val);
				fputil_FPBits_5nkvcs10.FPRepImpl.FPRepSem.field_0.field_0 = field_9;
				result = fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs10);
				llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs10);
			}
			goto IL_0ac0;
		}
		IL_0ac0:
		llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb8);
		llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
		llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		return result;
		IL_0701:
		llvm_lifetime_start_p0.Invoke(16L, &fputil_DyadicFloat_374hpp2);
		unchecked
		{
			*(sbyte*)(&fputil_DyadicFloat_374hpp2) = -86;
			sbyte* ptr = (sbyte*)(&fputil_DyadicFloat_374hpp2) + 1;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			((int*)(&fputil_DyadicFloat_374hpp2))[1] = -1431655766;
			((long*)(&fputil_DyadicFloat_374hpp2))[1] = -6148914691236517206L;
			fputil_DyadicFloat_64ul_DyadicFloat_double_0_double.Invoke(&fputil_DyadicFloat_374hpp2, x);
			llvm_lifetime_start_p0.Invoke(16L, &fputil_DyadicFloat_374hpp3);
			*(sbyte*)(&fputil_DyadicFloat_374hpp3) = -86;
			sbyte* ptr2 = (sbyte*)(&fputil_DyadicFloat_374hpp3) + 1;
			*ptr2 = -86;
			ptr2[1] = -86;
			ptr2[2] = -86;
			((int*)(&fputil_DyadicFloat_374hpp3))[1] = -1431655766;
			((long*)(&fputil_DyadicFloat_374hpp3))[1] = -6148914691236517206L;
			fputil_DyadicFloat_64ul_DyadicFloat_double_0_double.Invoke(&fputil_DyadicFloat_374hpp3, y);
			llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = 26;
			llvm_lifetime_start_p0.Invoke(4L, &num4);
			num4 = checked(fputil_DyadicFloat_374hpp2.exponent - fputil_DyadicFloat_374hpp3.exponent - 25);
			llvm_lifetime_start_p0.Invoke(8L, &num5);
			num5 = 0L;
			llvm_lifetime_start_p0.Invoke(8L, &num6);
			llvm_lifetime_start_p0.Invoke(8L, &bigInt_nx6qdt);
			long data = BigInt_64ul_false_unsigned_long_operator_unsigned_long_const_5vdftb.Invoke(&fputil_DyadicFloat_374hpp2.mantissa, 2L);
			*(long*)(&bigInt_nx6qdt.val.Data) = data;
			long num8 = BigInt_64ul_false_unsigned_long_operator_unsigned_long_unsigned_long_const.Invoke(&bigInt_nx6qdt);
			llvm_lifetime_end_p0.Invoke(8L, &bigInt_nx6qdt);
			num6 = num8;
			llvm_lifetime_start_p0.Invoke(8L, &num7);
			llvm_lifetime_start_p0.Invoke(8L, &bigInt_nx6qdt2);
			long data2 = BigInt_64ul_false_unsigned_long_operator_unsigned_long_const_5vdftb.Invoke(&fputil_DyadicFloat_374hpp3.mantissa, 1L);
			*(long*)(&bigInt_nx6qdt2.val.Data) = data2;
			long num9 = BigInt_64ul_false_unsigned_long_operator_unsigned_long_unsigned_long_const.Invoke(&bigInt_nx6qdt2);
			llvm_lifetime_end_p0.Invoke(8L, &bigInt_nx6qdt2);
			num7 = num9;
			llvm_lifetime_start_p0.Invoke(4L, &i);
			for (i = 0; i < 26; i = checked(i + 1))
			{
				num5 <<= 1;
				num6 <<= 1;
				if ((ulong)num6 >= (ulong)num7)
				{
					num5++;
					num6 -= num7;
				}
			}
			llvm_lifetime_end_p0.Invoke(4L, &i);
			llvm_lifetime_start_p0.Invoke(16L, &fputil_DyadicFloat_374hpp4);
			*(sbyte*)(&fputil_DyadicFloat_374hpp4) = -86;
			sbyte* ptr3 = (sbyte*)(&fputil_DyadicFloat_374hpp4) + 1;
			*ptr3 = -86;
			ptr3[1] = -86;
			ptr3[2] = -86;
			((int*)(&fputil_DyadicFloat_374hpp4))[1] = -1431655766;
			((long*)(&fputil_DyadicFloat_374hpp4))[1] = -6148914691236517206L;
			llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb20, &anon_izyfb8, 1L, isVolatile: false);
			int e = num4;
			BigInt_64ul_false_unsigned_long_BigInt_unsigned_long_void_unsigned_long.Invoke(&bigInt_nx6qdt3, num5);
			fputil_DyadicFloat_64ul_DyadicFloat_Sign_int_BigInt_64ul_false_unsigned_long.Invoke(&fputil_DyadicFloat_374hpp4, anon_izyfb20.val, e, *(long*)(&bigInt_nx6qdt3.val.Data));
			llvm_lifetime_start_p0.Invoke(8L, &bigInt_nx6qdt4);
			BigInt_64ul_false_unsigned_long_BigInt_unsigned_int_void_unsigned_int.Invoke(&bigInt_nx6qdt4, (num6 != 0L) ? 1 : 0);
			long data3 = operator_BigInt_64ul_false_unsigned_long_BigInt_64ul_false_unsigned_long_const.Invoke(&fputil_DyadicFloat_374hpp4.mantissa, &bigInt_nx6qdt4);
			*(long*)(&bigInt_nx6qdt5.val.Data) = data3;
			llvm_lifetime_end_p0.Invoke(8L, &bigInt_nx6qdt4);
			result = float_fputil_DyadicFloat_64ul_as_float_true_void_const.Invoke(&fputil_DyadicFloat_374hpp4);
			llvm_lifetime_end_p0.Invoke(16L, &fputil_DyadicFloat_374hpp4);
			llvm_lifetime_end_p0.Invoke(8L, &num7);
			llvm_lifetime_end_p0.Invoke(8L, &num6);
			llvm_lifetime_end_p0.Invoke(8L, &num5);
			llvm_lifetime_end_p0.Invoke(4L, &num4);
			llvm_lifetime_end_p0.Invoke(4L, &num3);
			llvm_lifetime_end_p0.Invoke(16L, &fputil_DyadicFloat_374hpp3);
			llvm_lifetime_end_p0.Invoke(16L, &fputil_DyadicFloat_374hpp2);
			goto IL_0ac0;
		}
	}
}
