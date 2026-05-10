using System;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic3mulIdgEENS_3cpp9enable_ifIXaaaasr3cppE19is_floating_point_vIT_Esr3cppE19is_floating_point_vIT0_ElestS5_stS6_ES5_E4typeES6_S6_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<double> && cpp::is_floating_point_v<__float128> && sizeof (double) <= sizeof (__float128), double>::type __llvm_libc_20_1_2_::fputil::generic::mul<double, __float128>(__float128, __float128)")]
internal static partial class cpp_enable_if_cpp_is_floating_point_v_double_cpp_is_floating_point_v_float128_sizeof_double_sizeof_float128_double_type_fputil_generic_mul_double_float128_float128_float128
{
	public unsafe static double Invoke(double x, double y)
	{
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(fputil_FPBits_ubgsi2);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi4 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		Int128 @int = default(Int128);
		Int128 int2 = default(Int128);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb11 = default(anon_izyfb7);
		Int128 int3 = default(Int128);
		Int128 int4 = default(Int128);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb12 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm4 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb13 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm5 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb14 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm6 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb15 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm7 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb16 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm8 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb17 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm9 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb18 = default(anon_izyfb7);
		fputil_DyadicFloat_jhcpjj fputil_DyadicFloat_jhcpjj2 = default(fputil_DyadicFloat_jhcpjj);
		fputil_DyadicFloat_jhcpjj fputil_DyadicFloat_jhcpjj3 = default(fputil_DyadicFloat_jhcpjj);
		fputil_DyadicFloat_jhcpjj fputil_DyadicFloat_jhcpjj4 = default(fputil_DyadicFloat_jhcpjj);
		llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		unchecked
		{
			*(Int128*)(&fputil_FPBits_ubgsi3) = -6148914691236517206L;
			fputil_FPBits_float128_FPBits_float128_float128.Invoke(&fputil_FPBits_ubgsi3, x);
			llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
			*(Int128*)(&fputil_FPBits_ubgsi4) = -6148914691236517206L;
			fputil_FPBits_float128_FPBits_float128_float128.Invoke(&fputil_FPBits_ubgsi4, y);
			llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb8);
			*(sbyte*)(&anon_izyfb8) = -86;
			anon_izyfb9.val = fputil_internal_FPStorage_fputil_FPType_3_sign_const.Invoke(&fputil_FPBits_ubgsi3);
			anon_izyfb10.val = fputil_internal_FPStorage_fputil_FPType_3_sign_const.Invoke(&fputil_FPBits_ubgsi4);
			llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, (!operator_Sign_Sign_fy8fvt.Invoke(anon_izyfb9.val, anon_izyfb10.val)) ? Sign_NEG.Pointer : Sign_POS.Pointer, 1L, isVolatile: false);
			double result;
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(fputil_internal_FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_is_inf_or_nan_const.Invoke(&fputil_FPBits_ubgsi3) ? true : (fputil_internal_FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_is_inf_or_nan_const.Invoke(&fputil_FPBits_ubgsi4) ? true : ((!fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_zero_const.Invoke(&fputil_FPBits_ubgsi3)) ? fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_zero_const.Invoke(&fputil_FPBits_ubgsi4) : true)), expected: false))
			{
				if (fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_nan_const.Invoke(&fputil_FPBits_ubgsi3) || fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_nan_const.Invoke(&fputil_FPBits_ubgsi4))
				{
					if (fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_signaling_nan_const.Invoke(&fputil_FPBits_ubgsi3) || fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_signaling_nan_const.Invoke(&fputil_FPBits_ubgsi4))
					{
						fputil_raise_except_if_required_int.Invoke(1);
					}
					if (fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_quiet_nan_const.Invoke(&fputil_FPBits_ubgsi3))
					{
						llvm_lifetime_start_p0.Invoke(16L, &@int);
						Struct_fiz2nb struct_fiz2nb = fputil_internal_FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_get_mantissa_const.Invoke(&fputil_FPBits_ubgsi3);
						Int128* num = &int2;
						Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
						*(long*)num = struct_fiz2nb2.field_0;
						byte* num2 = (byte*)(&int2) + 8u;
						Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
						*(long*)num2 = struct_fiz2nb3.field_1;
						@int = int2;
						@int = NumericHelper.ShiftRightLogical(@int, 60L);
						llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
						anon_izyfb11.val = fputil_internal_FPStorage_fputil_FPType_3_sign_const.Invoke(&fputil_FPBits_ubgsi3);
						long val = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan_Sign_unsigned_long.Invoke(v: (long)@int, sign: anon_izyfb11.val);
						fputil_FPBits_wjhbrm2.FPRepImpl.FPRepSem.FPStorage.val = val;
						result = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm2);
						llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
						llvm_lifetime_end_p0.Invoke(16L, &@int);
					}
					else if (fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_quiet_nan_const.Invoke(&fputil_FPBits_ubgsi4))
					{
						llvm_lifetime_start_p0.Invoke(16L, &int3);
						Struct_fiz2nb struct_fiz2nb4 = fputil_internal_FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_get_mantissa_const.Invoke(&fputil_FPBits_ubgsi4);
						Int128* num3 = &int4;
						Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
						*(long*)num3 = struct_fiz2nb5.field_0;
						byte* num4 = (byte*)(&int4) + 8u;
						Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
						*(long*)num4 = struct_fiz2nb6.field_1;
						int3 = int4;
						int3 = NumericHelper.ShiftRightLogical(int3, 60L);
						llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
						anon_izyfb12.val = fputil_internal_FPStorage_fputil_FPType_3_sign_const.Invoke(&fputil_FPBits_ubgsi4);
						long val2 = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan_Sign_unsigned_long.Invoke(v: (long)int3, sign: anon_izyfb12.val);
						fputil_FPBits_wjhbrm3.FPRepImpl.FPRepSem.FPStorage.val = val2;
						result = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm3);
						llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
						llvm_lifetime_end_p0.Invoke(16L, &int3);
					}
					else
					{
						llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb13, Sign_POS.Pointer, 1L, isVolatile: false);
						long val3 = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan_Sign_unsigned_long.Invoke(anon_izyfb13.val, 0L);
						fputil_FPBits_wjhbrm4.FPRepImpl.FPRepSem.FPStorage.val = val3;
						result = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm4);
						llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
					}
				}
				else if (fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_inf_const.Invoke(&fputil_FPBits_ubgsi3))
				{
					if (fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_zero_const.Invoke(&fputil_FPBits_ubgsi4))
					{
						fputil_set_errno_if_required_int.Invoke(33);
						fputil_raise_except_if_required_int.Invoke(1);
						llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb14, Sign_POS.Pointer, 1L, isVolatile: false);
						long val4 = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan_Sign_unsigned_long.Invoke(anon_izyfb14.val, 0L);
						fputil_FPBits_wjhbrm5.FPRepImpl.FPRepSem.FPStorage.val = val4;
						result = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm5);
						llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
					}
					else
					{
						llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm6);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb15, &anon_izyfb8, 1L, isVolatile: false);
						long val5 = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_inf_Sign.Invoke(anon_izyfb15.val);
						fputil_FPBits_wjhbrm6.FPRepImpl.FPRepSem.FPStorage.val = val5;
						result = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm6);
						llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm6);
					}
				}
				else if (fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_inf_const.Invoke(&fputil_FPBits_ubgsi4))
				{
					if (fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_zero_const.Invoke(&fputil_FPBits_ubgsi3))
					{
						fputil_set_errno_if_required_int.Invoke(33);
						fputil_raise_except_if_required_int.Invoke(1);
						llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm7);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb16, Sign_POS.Pointer, 1L, isVolatile: false);
						long val6 = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan_Sign_unsigned_long.Invoke(anon_izyfb16.val, 0L);
						fputil_FPBits_wjhbrm7.FPRepImpl.FPRepSem.FPStorage.val = val6;
						result = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm7);
						llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm7);
					}
					else
					{
						llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm8);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb17, &anon_izyfb8, 1L, isVolatile: false);
						long val7 = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_inf_Sign.Invoke(anon_izyfb17.val);
						fputil_FPBits_wjhbrm8.FPRepImpl.FPRepSem.FPStorage.val = val7;
						result = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm8);
						llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm8);
					}
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm9);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb18, &anon_izyfb8, 1L, isVolatile: false);
					long val8 = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_zero_Sign.Invoke(anon_izyfb18.val);
					fputil_FPBits_wjhbrm9.FPRepImpl.FPRepSem.FPStorage.val = val8;
					result = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm9);
					llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm9);
				}
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(40L, &fputil_DyadicFloat_jhcpjj2);
				llvm_memset_p0_i64.Invoke(&fputil_DyadicFloat_jhcpjj2, -86, 40L, isVolatile: false);
				fputil_DyadicFloat_256ul_DyadicFloat_float128_0_float128.Invoke(&fputil_DyadicFloat_jhcpjj2, x);
				llvm_lifetime_start_p0.Invoke(40L, &fputil_DyadicFloat_jhcpjj3);
				llvm_memset_p0_i64.Invoke(&fputil_DyadicFloat_jhcpjj3, -86, 40L, isVolatile: false);
				fputil_DyadicFloat_256ul_DyadicFloat_float128_0_float128.Invoke(&fputil_DyadicFloat_jhcpjj3, y);
				llvm_lifetime_start_p0.Invoke(40L, &fputil_DyadicFloat_jhcpjj4);
				llvm_memset_p0_i64.Invoke(&fputil_DyadicFloat_jhcpjj4, -86, 40L, isVolatile: false);
				fputil_DyadicFloat_256ul_fputil_quick_mul_256ul_fputil_DyadicFloat_256ul_const_fputil_DyadicFloat_256ul_const.Invoke(&fputil_DyadicFloat_jhcpjj4, &fputil_DyadicFloat_jhcpjj2, &fputil_DyadicFloat_jhcpjj3);
				result = double_fputil_DyadicFloat_256ul_as_double_true_void_const.Invoke(&fputil_DyadicFloat_jhcpjj4);
				llvm_lifetime_end_p0.Invoke(40L, &fputil_DyadicFloat_jhcpjj4);
				llvm_lifetime_end_p0.Invoke(40L, &fputil_DyadicFloat_jhcpjj3);
				llvm_lifetime_end_p0.Invoke(40L, &fputil_DyadicFloat_jhcpjj2);
			}
			llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb8);
			llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
			llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
			return result;
		}
	}
}
