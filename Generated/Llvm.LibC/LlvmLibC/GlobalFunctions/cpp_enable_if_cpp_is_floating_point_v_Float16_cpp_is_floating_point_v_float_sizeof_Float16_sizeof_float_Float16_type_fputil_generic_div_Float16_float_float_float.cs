using System;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic3divIDF16_fEENS_3cpp9enable_ifIXaaaasr3cppE19is_floating_point_vIT_Esr3cppE19is_floating_point_vIT0_ElestS5_stS6_ES5_E4typeES6_S6_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16> && cpp::is_floating_point_v<float> && sizeof (_Float16) <= sizeof (float), _Float16>::type __llvm_libc_20_1_2_::fputil::generic::div<_Float16, float>(float, float)")]
internal static partial class cpp_enable_if_cpp_is_floating_point_v_Float16_cpp_is_floating_point_v_float_sizeof_Float16_sizeof_float_Float16_type_fputil_generic_div_Float16_float_float_float
{
	public unsafe static Half Invoke(float x, float y)
	{
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		int num = 0;
		fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb11 = default(anon_izyfb7);
		int num2 = 0;
		fputil_FPBits_2fahva fputil_FPBits_2fahva3 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb12 = default(anon_izyfb7);
		fputil_FPBits_2fahva fputil_FPBits_2fahva4 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb13 = default(anon_izyfb7);
		fputil_FPBits_2fahva fputil_FPBits_2fahva5 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb14 = default(anon_izyfb7);
		fputil_FPBits_2fahva fputil_FPBits_2fahva6 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb15 = default(anon_izyfb7);
		fputil_FPBits_2fahva fputil_FPBits_2fahva7 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb16 = default(anon_izyfb7);
		fputil_FPBits_2fahva fputil_FPBits_2fahva8 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb17 = default(anon_izyfb7);
		fputil_FPBits_2fahva fputil_FPBits_2fahva9 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb18 = default(anon_izyfb7);
		fputil_FPBits_2fahva fputil_FPBits_2fahva10 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb19 = default(anon_izyfb7);
		fputil_DyadicFloat_c8qpxg fputil_DyadicFloat_c8qpxg2 = default(fputil_DyadicFloat_c8qpxg);
		fputil_DyadicFloat_c8qpxg fputil_DyadicFloat_c8qpxg3 = default(fputil_DyadicFloat_c8qpxg);
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		BigInt_fzjdu3 bigInt_fzjdu = default(BigInt_fzjdu3);
		int num7 = 0;
		BigInt_fzjdu3 bigInt_fzjdu2 = default(BigInt_fzjdu3);
		int i = 0;
		fputil_DyadicFloat_c8qpxg fputil_DyadicFloat_c8qpxg4 = default(fputil_DyadicFloat_c8qpxg);
		anon_izyfb7 anon_izyfb20 = default(anon_izyfb7);
		BigInt_fzjdu3 bigInt_fzjdu3 = default(BigInt_fzjdu3);
		BigInt_fzjdu3 bigInt_fzjdu4 = default(BigInt_fzjdu3);
		BigInt_fzjdu3 bigInt_fzjdu5 = default(BigInt_fzjdu3);
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		Half result;
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs2) = -1431655766;
			fputil_FPBits_float_FPBits_float_float.Invoke(&fputil_FPBits_5nkvcs2, x);
			llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
			*(int*)(&fputil_FPBits_5nkvcs3) = -1431655766;
			fputil_FPBits_float_FPBits_float_float.Invoke(&fputil_FPBits_5nkvcs3, y);
			llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb8);
			*(sbyte*)(&anon_izyfb8) = -86;
			anon_izyfb9.val = fputil_internal_FPStorage_fputil_FPType_1_sign_const.Invoke(&fputil_FPBits_5nkvcs2);
			anon_izyfb10.val = fputil_internal_FPStorage_fputil_FPType_1_sign_const.Invoke(&fputil_FPBits_5nkvcs3);
			llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, (!operator_Sign_Sign_fy8fvt.Invoke(anon_izyfb9.val, anon_izyfb10.val)) ? Sign_NEG.Pointer : Sign_POS.Pointer, 1L, isVolatile: false);
			if (!bool_details_expects_bool_condition_bool_bool_bool.Invoke(fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_inf_or_nan_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2)) ? true : (fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_inf_or_nan_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs3)) ? true : ((!fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_zero_const.Invoke(&fputil_FPBits_5nkvcs2)) ? fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_zero_const.Invoke(&fputil_FPBits_5nkvcs3) : true)), expected: false))
			{
				goto IL_06e8;
			}
			if (fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan_const.Invoke(&fputil_FPBits_5nkvcs2) || fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan_const.Invoke(&fputil_FPBits_5nkvcs3))
			{
				if (fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_signaling_nan_const.Invoke(&fputil_FPBits_5nkvcs2) || fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_signaling_nan_const.Invoke(&fputil_FPBits_5nkvcs3))
				{
					fputil_raise_except_if_required_int.Invoke(1);
				}
				if (fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_quiet_nan_const.Invoke(&fputil_FPBits_5nkvcs2))
				{
					llvm_lifetime_start_p0.Invoke(4L, &num);
					num = fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_mantissa_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2));
					num >>>= 13;
					llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
					anon_izyfb11.val = fputil_internal_FPStorage_fputil_FPType_1_sign_const.Invoke(&fputil_FPBits_5nkvcs2);
					short field_ = fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan_Sign_unsigned_short.Invoke(v: (short)num, sign: anon_izyfb11.val);
					fputil_FPBits_2fahva2.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
					result = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva2);
					llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
					llvm_lifetime_end_p0.Invoke(4L, &num);
				}
				else if (fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_quiet_nan_const.Invoke(&fputil_FPBits_5nkvcs3))
				{
					llvm_lifetime_start_p0.Invoke(4L, &num2);
					num2 = fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_mantissa_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs3));
					num2 >>>= 13;
					llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva3);
					anon_izyfb12.val = fputil_internal_FPStorage_fputil_FPType_1_sign_const.Invoke(&fputil_FPBits_5nkvcs3);
					short field_2 = fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan_Sign_unsigned_short.Invoke(v: (short)num2, sign: anon_izyfb12.val);
					fputil_FPBits_2fahva3.FPRepImpl.FPRepSem.FPStorage.field_0 = field_2;
					result = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva3);
					llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva3);
					llvm_lifetime_end_p0.Invoke(4L, &num2);
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva4);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb13, Sign_POS.Pointer, 1L, isVolatile: false);
					short field_3 = fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan_Sign_unsigned_short.Invoke(anon_izyfb13.val, 0);
					fputil_FPBits_2fahva4.FPRepImpl.FPRepSem.FPStorage.field_0 = field_3;
					result = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva4);
					llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva4);
				}
			}
			else if (fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_inf_const.Invoke(&fputil_FPBits_5nkvcs2))
			{
				if (fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_inf_const.Invoke(&fputil_FPBits_5nkvcs3))
				{
					fputil_set_errno_if_required_int.Invoke(33);
					fputil_raise_except_if_required_int.Invoke(1);
					llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva5);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb14, Sign_POS.Pointer, 1L, isVolatile: false);
					short field_4 = fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan_Sign_unsigned_short.Invoke(anon_izyfb14.val, 0);
					fputil_FPBits_2fahva5.FPRepImpl.FPRepSem.FPStorage.field_0 = field_4;
					result = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva5);
					llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva5);
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva6);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb15, &anon_izyfb8, 1L, isVolatile: false);
					short field_5 = fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_inf_Sign.Invoke(anon_izyfb15.val);
					fputil_FPBits_2fahva6.FPRepImpl.FPRepSem.FPStorage.field_0 = field_5;
					result = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva6);
					llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva6);
				}
			}
			else if (fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_inf_const.Invoke(&fputil_FPBits_5nkvcs3))
			{
				llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva7);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb16, &anon_izyfb8, 1L, isVolatile: false);
				short field_6 = fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_inf_Sign.Invoke(anon_izyfb16.val);
				fputil_FPBits_2fahva7.FPRepImpl.FPRepSem.FPStorage.field_0 = field_6;
				result = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva7);
				llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva7);
			}
			else if (fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_zero_const.Invoke(&fputil_FPBits_5nkvcs3))
			{
				if (fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_zero_const.Invoke(&fputil_FPBits_5nkvcs2))
				{
					fputil_raise_except_if_required_int.Invoke(1);
					llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva8);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb17, Sign_POS.Pointer, 1L, isVolatile: false);
					short field_7 = fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan_Sign_unsigned_short.Invoke(anon_izyfb17.val, 0);
					fputil_FPBits_2fahva8.FPRepImpl.FPRepSem.FPStorage.field_0 = field_7;
					result = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva8);
					llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva8);
				}
				else
				{
					fputil_raise_except_if_required_int.Invoke(4);
					llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva9);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb18, &anon_izyfb8, 1L, isVolatile: false);
					short field_8 = fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_inf_Sign.Invoke(anon_izyfb18.val);
					fputil_FPBits_2fahva9.FPRepImpl.FPRepSem.FPStorage.field_0 = field_8;
					result = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva9);
					llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva9);
				}
			}
			else
			{
				if (!fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_zero_const.Invoke(&fputil_FPBits_5nkvcs2))
				{
					goto IL_06e8;
				}
				llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva10);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb19, &anon_izyfb8, 1L, isVolatile: false);
				short field_9 = fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_zero_Sign.Invoke(anon_izyfb19.val);
				fputil_FPBits_2fahva10.FPRepImpl.FPRepSem.FPStorage.field_0 = field_9;
				result = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva10);
				llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva10);
			}
			goto IL_0a7a;
		}
		IL_0a7a:
		llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb8);
		llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
		llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		return result;
		IL_06e8:
		llvm_lifetime_start_p0.Invoke(12L, &fputil_DyadicFloat_c8qpxg2);
		unchecked
		{
			*(sbyte*)(&fputil_DyadicFloat_c8qpxg2) = -86;
			sbyte* ptr = (sbyte*)(&fputil_DyadicFloat_c8qpxg2) + 1;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			((int*)(&fputil_DyadicFloat_c8qpxg2))[1] = -1431655766;
			((int*)(&fputil_DyadicFloat_c8qpxg2))[2] = -1431655766;
			fputil_DyadicFloat_32ul_DyadicFloat_float_0_float.Invoke(&fputil_DyadicFloat_c8qpxg2, x);
			llvm_lifetime_start_p0.Invoke(12L, &fputil_DyadicFloat_c8qpxg3);
			*(sbyte*)(&fputil_DyadicFloat_c8qpxg3) = -86;
			sbyte* ptr2 = (sbyte*)(&fputil_DyadicFloat_c8qpxg3) + 1;
			*ptr2 = -86;
			ptr2[1] = -86;
			ptr2[2] = -86;
			((int*)(&fputil_DyadicFloat_c8qpxg3))[1] = -1431655766;
			((int*)(&fputil_DyadicFloat_c8qpxg3))[2] = -1431655766;
			fputil_DyadicFloat_32ul_DyadicFloat_float_0_float.Invoke(&fputil_DyadicFloat_c8qpxg3, y);
			llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = 13;
			llvm_lifetime_start_p0.Invoke(4L, &num4);
			num4 = checked(fputil_DyadicFloat_c8qpxg2.exponent - fputil_DyadicFloat_c8qpxg3.exponent - 12);
			llvm_lifetime_start_p0.Invoke(4L, &num5);
			num5 = 0;
			llvm_lifetime_start_p0.Invoke(4L, &num6);
			llvm_lifetime_start_p0.Invoke(4L, &bigInt_fzjdu);
			int data = BigInt_32ul_false_unsigned_int_operator_unsigned_long_const_mny5rw.Invoke(&fputil_DyadicFloat_c8qpxg2.mantissa, 2L);
			*(int*)(&bigInt_fzjdu.val.Data) = data;
			int num8 = BigInt_32ul_false_unsigned_int_operator_unsigned_int_unsigned_int_const.Invoke(&bigInt_fzjdu);
			llvm_lifetime_end_p0.Invoke(4L, &bigInt_fzjdu);
			num6 = num8;
			llvm_lifetime_start_p0.Invoke(4L, &num7);
			llvm_lifetime_start_p0.Invoke(4L, &bigInt_fzjdu2);
			int data2 = BigInt_32ul_false_unsigned_int_operator_unsigned_long_const_mny5rw.Invoke(&fputil_DyadicFloat_c8qpxg3.mantissa, 1L);
			*(int*)(&bigInt_fzjdu2.val.Data) = data2;
			int num9 = BigInt_32ul_false_unsigned_int_operator_unsigned_int_unsigned_int_const.Invoke(&bigInt_fzjdu2);
			llvm_lifetime_end_p0.Invoke(4L, &bigInt_fzjdu2);
			num7 = num9;
			llvm_lifetime_start_p0.Invoke(4L, &i);
			for (i = 0; i < 13; i = checked(i + 1))
			{
				num5 <<= 1;
				num6 <<= 1;
				if ((uint)num6 >= (uint)num7)
				{
					num5++;
					num6 -= num7;
				}
			}
			llvm_lifetime_end_p0.Invoke(4L, &i);
			llvm_lifetime_start_p0.Invoke(12L, &fputil_DyadicFloat_c8qpxg4);
			*(sbyte*)(&fputil_DyadicFloat_c8qpxg4) = -86;
			sbyte* ptr3 = (sbyte*)(&fputil_DyadicFloat_c8qpxg4) + 1;
			*ptr3 = -86;
			ptr3[1] = -86;
			ptr3[2] = -86;
			((int*)(&fputil_DyadicFloat_c8qpxg4))[1] = -1431655766;
			((int*)(&fputil_DyadicFloat_c8qpxg4))[2] = -1431655766;
			llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb20, &anon_izyfb8, 1L, isVolatile: false);
			int e = num4;
			BigInt_32ul_false_unsigned_int_BigInt_unsigned_int_void_unsigned_int.Invoke(&bigInt_fzjdu3, num5);
			fputil_DyadicFloat_32ul_DyadicFloat_Sign_int_BigInt_32ul_false_unsigned_int.Invoke(&fputil_DyadicFloat_c8qpxg4, anon_izyfb20.val, e, *(int*)(&bigInt_fzjdu3.val.Data));
			llvm_lifetime_start_p0.Invoke(4L, &bigInt_fzjdu4);
			BigInt_32ul_false_unsigned_int_BigInt_unsigned_int_void_unsigned_int.Invoke(&bigInt_fzjdu4, (num6 != 0) ? 1 : 0);
			int data3 = operator_BigInt_32ul_false_unsigned_int_BigInt_32ul_false_unsigned_int_const.Invoke(&fputil_DyadicFloat_c8qpxg4.mantissa, &bigInt_fzjdu4);
			*(int*)(&bigInt_fzjdu5.val.Data) = data3;
			llvm_lifetime_end_p0.Invoke(4L, &bigInt_fzjdu4);
			result = Float16_fputil_DyadicFloat_32ul_as_Float16_true_void_const.Invoke(&fputil_DyadicFloat_c8qpxg4);
			llvm_lifetime_end_p0.Invoke(12L, &fputil_DyadicFloat_c8qpxg4);
			llvm_lifetime_end_p0.Invoke(4L, &num7);
			llvm_lifetime_end_p0.Invoke(4L, &num6);
			llvm_lifetime_end_p0.Invoke(4L, &num5);
			llvm_lifetime_end_p0.Invoke(4L, &num4);
			llvm_lifetime_end_p0.Invoke(4L, &num3);
			llvm_lifetime_end_p0.Invoke(12L, &fputil_DyadicFloat_c8qpxg3);
			llvm_lifetime_end_p0.Invoke(12L, &fputil_DyadicFloat_c8qpxg2);
			goto IL_0a7a;
		}
	}
}
