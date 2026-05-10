using System;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil5ldexpIDF16_iEENS_3cpp9enable_ifIXaasr3cppE19is_floating_point_vIT_Esr3cppE13is_integral_vIT0_EES4_E4typeES4_S5_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16> && cpp::is_integral_v<int>, _Float16>::type __llvm_libc_20_1_2_::fputil::ldexp<_Float16, int>(_Float16, int)")]
internal static partial class cpp_enable_if_cpp_is_floating_point_v_Float16_cpp_is_integral_v_int_Float16_type_fputil_ldexp_Float16_int_Float16_int
{
	public unsafe static Half Invoke(Half x, int exp)
	{
		fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(fputil_FPBits_2fahva);
		int num = 0;
		int num2 = 0;
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb11 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb12 = default(anon_izyfb7);
		fputil_FPBits_2fahva fputil_FPBits_2fahva3 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb13 = default(anon_izyfb7);
		fputil_FPBits_2fahva fputil_FPBits_2fahva4 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb14 = default(anon_izyfb7);
		int num3 = 0;
		anon_izyfb7 anon_izyfb15 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb16 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb17 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb18 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb19 = default(anon_izyfb7);
		fputil_FPBits_2fahva fputil_FPBits_2fahva5 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb20 = default(anon_izyfb7);
		fputil_FPBits_2fahva fputil_FPBits_2fahva6 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb21 = default(anon_izyfb7);
		fputil_DyadicFloat_jvghxm fputil_DyadicFloat_jvghxm2 = default(fputil_DyadicFloat_jvghxm);
		llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
		Half result;
		unchecked
		{
			*(short*)(&fputil_FPBits_2fahva2) = -21846;
			fputil_FPBits_Float16_FPBits_Float16_Float16.Invoke(&fputil_FPBits_2fahva2, x);
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((exp == 0) ? true : ((!fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_zero_const.Invoke(&fputil_FPBits_2fahva2)) ? fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_is_inf_or_nan_const.Invoke(&fputil_FPBits_2fahva2) : true), expected: false))
			{
				result = x;
				goto IL_05ac;
			}
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = 42;
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(exp > 42, expected: false))
			{
				llvm_lifetime_start_p0.Invoke(4L, &num2);
				num2 = fputil_quick_get_round.Invoke();
				llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb8);
				*(sbyte*)(&anon_izyfb8) = -86;
				anon_izyfb8.val = fputil_internal_FPStorage_fputil_FPType_0_sign_const.Invoke(&fputil_FPBits_2fahva2);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, &anon_izyfb8, 1L, isVolatile: false);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb10, Sign_POS.Pointer, 1L, isVolatile: false);
				if (!operator_Sign_Sign_fy8fvt.Invoke(anon_izyfb9.val, anon_izyfb10.val) || num2 != 1024)
				{
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb11, &anon_izyfb8, 1L, isVolatile: false);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb12, Sign_NEG.Pointer, 1L, isVolatile: false);
					if ((!operator_Sign_Sign_fy8fvt.Invoke(anon_izyfb11.val, anon_izyfb12.val) || num2 != 2048) && num2 != 3072)
					{
						fputil_set_errno_if_required_int.Invoke(34);
						fputil_raise_except_if_required_int.Invoke(8);
						llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva4);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb14, &anon_izyfb8, 1L, isVolatile: false);
						short field_ = fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_inf_Sign.Invoke(anon_izyfb14.val);
						fputil_FPBits_2fahva4.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
						result = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva4);
						llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva4);
						goto IL_02e8;
					}
				}
				llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva3);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb13, &anon_izyfb8, 1L, isVolatile: false);
				short field_2 = fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_max_normal_Sign.Invoke(anon_izyfb13.val);
				fputil_FPBits_2fahva3.FPRepImpl.FPRepSem.FPStorage.field_0 = field_2;
				result = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva3);
				llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva3);
				goto IL_02e8;
			}
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(exp < -42, expected: false))
			{
				llvm_lifetime_start_p0.Invoke(4L, &num3);
				num3 = fputil_quick_get_round.Invoke();
				llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb15);
				*(sbyte*)(&anon_izyfb15) = -86;
				anon_izyfb15.val = fputil_internal_FPStorage_fputil_FPType_0_sign_const.Invoke(&fputil_FPBits_2fahva2);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb16, &anon_izyfb15, 1L, isVolatile: false);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb17, Sign_POS.Pointer, 1L, isVolatile: false);
				if (!operator_Sign_Sign_fy8fvt.Invoke(anon_izyfb16.val, anon_izyfb17.val) || num3 != 2048)
				{
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb18, &anon_izyfb15, 1L, isVolatile: false);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb19, Sign_NEG.Pointer, 1L, isVolatile: false);
					if (!operator_Sign_Sign_fy8fvt.Invoke(anon_izyfb18.val, anon_izyfb19.val) || num3 != 1024)
					{
						fputil_set_errno_if_required_int.Invoke(34);
						fputil_raise_except_if_required_int.Invoke(16);
						llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva6);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb21, &anon_izyfb15, 1L, isVolatile: false);
						short field_3 = fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_zero_Sign.Invoke(anon_izyfb21.val);
						fputil_FPBits_2fahva6.FPRepImpl.FPRepSem.FPStorage.field_0 = field_3;
						result = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva6);
						llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva6);
						goto IL_04ce;
					}
				}
				llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva5);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb20, &anon_izyfb15, 1L, isVolatile: false);
				short field_4 = fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_min_subnormal_Sign.Invoke(anon_izyfb20.val);
				fputil_FPBits_2fahva5.FPRepImpl.FPRepSem.FPStorage.field_0 = field_4;
				result = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva5);
				llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva5);
				goto IL_04ce;
			}
			llvm_lifetime_start_p0.Invoke(12L, &fputil_DyadicFloat_jvghxm2);
			*(sbyte*)(&fputil_DyadicFloat_jvghxm2) = -86;
			sbyte* ptr = (sbyte*)(&fputil_DyadicFloat_jvghxm2) + 1;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			((int*)(&fputil_DyadicFloat_jvghxm2))[1] = -1431655766;
			((short*)(&fputil_DyadicFloat_jvghxm2))[4] = -21846;
			sbyte* ptr2 = (sbyte*)(&fputil_DyadicFloat_jvghxm2) + 10;
			*ptr2 = -86;
			ptr2[1] = -86;
			fputil_DyadicFloat_16ul_DyadicFloat_Float16_0_Float16.Invoke(&fputil_DyadicFloat_jvghxm2, fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva2));
		}
		fputil_DyadicFloat_jvghxm2.exponent += exp;
		result = Float16_fputil_DyadicFloat_16ul_as_Float16_true_void_const.Invoke(&fputil_DyadicFloat_jvghxm2);
		llvm_lifetime_end_p0.Invoke(12L, &fputil_DyadicFloat_jvghxm2);
		goto IL_059a;
		IL_02e8:
		llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb8);
		llvm_lifetime_end_p0.Invoke(4L, &num2);
		goto IL_059a;
		IL_04ce:
		llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb15);
		llvm_lifetime_end_p0.Invoke(4L, &num3);
		goto IL_059a;
		IL_05ac:
		llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
		return result;
		IL_059a:
		llvm_lifetime_end_p0.Invoke(4L, &num);
		goto IL_05ac;
	}
}
