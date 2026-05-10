using System;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil5ldexpIelEENS_3cpp9enable_ifIXaasr3cppE19is_floating_point_vIT_Esr3cppE13is_integral_vIT0_EES4_E4typeES4_S5_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<long double> && cpp::is_integral_v<long>, long double>::type __llvm_libc_20_1_2_::fputil::ldexp<long double, long>(long double, long)")]
internal static partial class cpp_enable_if_cpp_is_floating_point_v_long_double_cpp_is_integral_v_long_long_double_type_fputil_ldexp_long_double_long_long_double_long
{
	public unsafe static double Invoke(double x, long exp)
	{
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(fputil_FPBits_ubgsi2);
		int num = 0;
		int num2 = 0;
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb11 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb12 = default(anon_izyfb7);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi4 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb13 = default(anon_izyfb7);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi5 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb14 = default(anon_izyfb7);
		int num3 = 0;
		anon_izyfb7 anon_izyfb15 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb16 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb17 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb18 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb19 = default(anon_izyfb7);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi6 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb20 = default(anon_izyfb7);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi7 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb21 = default(anon_izyfb7);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd5 = default(fputil_DyadicFloat_kt2kd4);
		llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		double result;
		unchecked
		{
			*(Int128*)(&fputil_FPBits_ubgsi3) = -6148914691236517206L;
			fputil_FPBits_long_double_FPBits_long_double_long_double.Invoke(&fputil_FPBits_ubgsi3, x);
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((exp == 0L) ? true : ((!fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_zero_const.Invoke(&fputil_FPBits_ubgsi3)) ? fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_is_inf_or_nan_const.Invoke(&fputil_FPBits_ubgsi3) : true), expected: false))
			{
				result = x;
				goto IL_0675;
			}
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = 32831;
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(exp > 32831L, expected: false))
			{
				llvm_lifetime_start_p0.Invoke(4L, &num2);
				num2 = fputil_quick_get_round.Invoke();
				llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb8);
				*(sbyte*)(&anon_izyfb8) = -86;
				anon_izyfb8.val = fputil_internal_FPStorage_fputil_FPType_4_sign_const.Invoke(&fputil_FPBits_ubgsi3);
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
						llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi5);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb14, &anon_izyfb8, 1L, isVolatile: false);
						Struct_fiz2nb struct_fiz2nb = fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_inf_Sign.Invoke(anon_izyfb14.val);
						Int128* ptr = &fputil_FPBits_ubgsi5.val.Data.FPStorage.field_0;
						Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
						((Struct_fiz2nb*)ptr)->field_0 = struct_fiz2nb2.field_0;
						Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
						((Struct_fiz2nb*)ptr)->field_1 = struct_fiz2nb3.field_1;
						result = fputil_FPBits_long_double_get_val_const.Invoke(&fputil_FPBits_ubgsi5);
						llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi5);
						goto IL_0357;
					}
				}
				llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb13, &anon_izyfb8, 1L, isVolatile: false);
				Struct_fiz2nb struct_fiz2nb4 = fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_max_normal_Sign.Invoke(anon_izyfb13.val);
				Int128* ptr2 = &fputil_FPBits_ubgsi4.val.Data.FPStorage.field_0;
				Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
				((Struct_fiz2nb*)ptr2)->field_0 = struct_fiz2nb5.field_0;
				Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
				((Struct_fiz2nb*)ptr2)->field_1 = struct_fiz2nb6.field_1;
				result = fputil_FPBits_long_double_get_val_const.Invoke(&fputil_FPBits_ubgsi4);
				llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
				goto IL_0357;
			}
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(exp < -32831L, expected: false))
			{
				llvm_lifetime_start_p0.Invoke(4L, &num3);
				num3 = fputil_quick_get_round.Invoke();
				llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb15);
				*(sbyte*)(&anon_izyfb15) = -86;
				anon_izyfb15.val = fputil_internal_FPStorage_fputil_FPType_4_sign_const.Invoke(&fputil_FPBits_ubgsi3);
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
						llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi7);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb21, &anon_izyfb15, 1L, isVolatile: false);
						Struct_fiz2nb struct_fiz2nb7 = fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_zero_Sign.Invoke(anon_izyfb21.val);
						Int128* ptr3 = &fputil_FPBits_ubgsi7.val.Data.FPStorage.field_0;
						Struct_fiz2nb struct_fiz2nb8 = struct_fiz2nb7;
						((Struct_fiz2nb*)ptr3)->field_0 = struct_fiz2nb8.field_0;
						Struct_fiz2nb struct_fiz2nb9 = struct_fiz2nb7;
						((Struct_fiz2nb*)ptr3)->field_1 = struct_fiz2nb9.field_1;
						result = fputil_FPBits_long_double_get_val_const.Invoke(&fputil_FPBits_ubgsi7);
						llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi7);
						goto IL_0595;
					}
				}
				llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi6);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb20, &anon_izyfb15, 1L, isVolatile: false);
				Struct_fiz2nb struct_fiz2nb10 = fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_min_subnormal_Sign.Invoke(anon_izyfb20.val);
				Int128* ptr4 = &fputil_FPBits_ubgsi6.val.Data.FPStorage.field_0;
				Struct_fiz2nb struct_fiz2nb11 = struct_fiz2nb10;
				((Struct_fiz2nb*)ptr4)->field_0 = struct_fiz2nb11.field_0;
				Struct_fiz2nb struct_fiz2nb12 = struct_fiz2nb10;
				((Struct_fiz2nb*)ptr4)->field_1 = struct_fiz2nb12.field_1;
				result = fputil_FPBits_long_double_get_val_const.Invoke(&fputil_FPBits_ubgsi6);
				llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi6);
				goto IL_0595;
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
			fputil_DyadicFloat_128ul_DyadicFloat_long_double_0_long_double.Invoke(&fputil_DyadicFloat_kt2kd5, fputil_FPBits_long_double_get_val_const.Invoke(&fputil_FPBits_ubgsi3));
		}
		fputil_DyadicFloat_kt2kd5.exponent += unchecked((int)exp);
		result = long_double_fputil_DyadicFloat_128ul_as_long_double_true_void_const.Invoke(&fputil_DyadicFloat_kt2kd5);
		llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd5);
		goto IL_0663;
		IL_0357:
		llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb8);
		llvm_lifetime_end_p0.Invoke(4L, &num2);
		goto IL_0663;
		IL_0595:
		llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb15);
		llvm_lifetime_end_p0.Invoke(4L, &num3);
		goto IL_0663;
		IL_0675:
		llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		return result;
		IL_0663:
		llvm_lifetime_end_p0.Invoke(4L, &num);
		goto IL_0675;
	}
}
