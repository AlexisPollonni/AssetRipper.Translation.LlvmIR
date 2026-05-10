using System;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic10add_or_subILb0EdeEENS_3cpp9enable_ifIXaaaasr3cppE19is_floating_point_vIT0_Esr3cppE19is_floating_point_vIT1_ElestS5_stS6_ES5_E4typeES6_S6_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<double> && cpp::is_floating_point_v<long double> && sizeof (double) <= sizeof (long double), double>::type __llvm_libc_20_1_2_::fputil::generic::add_or_sub<false, double, long double>(long double, long double)")]
internal static partial class cpp_enable_if_cpp_is_floating_point_v_double_cpp_is_floating_point_v_long_double_sizeof_double_sizeof_long_double_double_type_fputil_generic_add_or_sub_false_double_long_double_long_double_long_double
{
	public unsafe static double Invoke(double x, double y)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(fputil_FPBits_ubgsi2);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi4 = default(fputil_FPBits_ubgsi2);
		sbyte b = 0;
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		Int128 @int = default(Int128);
		Int128 int2 = default(Int128);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		Int128 int3 = default(Int128);
		Int128 int4 = default(Int128);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb11 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm4 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb12 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm5 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb13 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm6 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb14 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm7 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb15 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm8 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb16 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm9 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb17 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm10 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb18 = default(anon_izyfb7);
		double x2 = 0.0;
		double x3 = 0.0;
		double num4 = 0.0;
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi5 = default(fputil_FPBits_ubgsi2);
		double num5 = 0.0;
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi6 = default(fputil_FPBits_ubgsi2);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm11 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb19 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm12 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb20 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb21 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb22 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb23 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb24 = default(anon_izyfb7);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi7 = default(fputil_FPBits_ubgsi2);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi8 = default(fputil_FPBits_ubgsi2);
		Int128 int5 = default(Int128);
		Int128 int6 = default(Int128);
		Int128 y2 = default(Int128);
		Int128 int7 = default(Int128);
		Int128 y3 = default(Int128);
		Int128 x4 = default(Int128);
		Int128 x5 = default(Int128);
		Int128 x6 = default(Int128);
		Int128 x7 = default(Int128);
		int num6 = 0;
		Int128 x8 = default(Int128);
		sbyte b2 = 0;
		Int128 y4 = default(Int128);
		int num7 = 0;
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd5 = default(fputil_DyadicFloat_kt2kd4);
		anon_izyfb7 anon_izyfb25 = default(anon_izyfb7);
		BigInt_qdkjbh bigInt_qdkjbh = default(BigInt_qdkjbh);
		Int128 int8 = default(Int128);
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = 3;
		llvm_lifetime_start_p0.Invoke(4L, &num2);
		num2 = 66;
		llvm_lifetime_start_p0.Invoke(4L, &num3);
		num3 = 67;
		llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		double result;
		unchecked
		{
			*(Int128*)(&fputil_FPBits_ubgsi3) = -6148914691236517206L;
			fputil_FPBits_long_double_FPBits_long_double_long_double.Invoke(&fputil_FPBits_ubgsi3, x);
			llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
			*(Int128*)(&fputil_FPBits_ubgsi4) = -6148914691236517206L;
			fputil_FPBits_long_double_FPBits_long_double_long_double.Invoke(&fputil_FPBits_ubgsi4, y);
			llvm_lifetime_start_p0.Invoke(1L, &b);
			anon_izyfb8.val = fputil_internal_FPStorage_fputil_FPType_4_sign_const.Invoke(&fputil_FPBits_ubgsi3);
			anon_izyfb9.val = fputil_internal_FPStorage_fputil_FPType_4_sign_const.Invoke(&fputil_FPBits_ubgsi4);
			b = (operator_Sign_Sign_fy8fvt.Invoke(anon_izyfb8.val, anon_izyfb9.val) ? ((sbyte)1) : ((sbyte)0));
			if (!bool_details_expects_bool_condition_bool_bool_bool.Invoke(fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_is_inf_or_nan_const.Invoke(&fputil_FPBits_ubgsi3) ? true : (fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_is_inf_or_nan_const.Invoke(&fputil_FPBits_ubgsi4) ? true : ((!fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_zero_const.Invoke(&fputil_FPBits_ubgsi3)) ? fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_zero_const.Invoke(&fputil_FPBits_ubgsi4) : true)), expected: false))
			{
				goto IL_08d6;
			}
			if (fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_nan_const.Invoke(&fputil_FPBits_ubgsi3) || fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_nan_const.Invoke(&fputil_FPBits_ubgsi4))
			{
				if (fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_signaling_nan_const.Invoke(&fputil_FPBits_ubgsi3) || fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_signaling_nan_const.Invoke(&fputil_FPBits_ubgsi4))
				{
					fputil_raise_except_if_required_int.Invoke(1);
				}
				if (fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_quiet_nan_const.Invoke(&fputil_FPBits_ubgsi3))
				{
					llvm_lifetime_start_p0.Invoke(16L, &@int);
					Struct_fiz2nb struct_fiz2nb = fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_mantissa_const.Invoke(&fputil_FPBits_ubgsi3);
					Int128* num8 = &int2;
					Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
					*(long*)num8 = struct_fiz2nb2.field_0;
					byte* num9 = (byte*)(&int2) + 8u;
					Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
					*(long*)num9 = struct_fiz2nb3.field_1;
					@int = int2;
					@int = NumericHelper.ShiftRightLogical(@int, 11L);
					llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
					anon_izyfb10.val = fputil_internal_FPStorage_fputil_FPType_4_sign_const.Invoke(&fputil_FPBits_ubgsi3);
					long val = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan_Sign_unsigned_long.Invoke(v: (long)@int, sign: anon_izyfb10.val);
					fputil_FPBits_wjhbrm2.FPRepImpl.FPRepSem.FPStorage.val = val;
					result = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm2);
					llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
					llvm_lifetime_end_p0.Invoke(16L, &@int);
				}
				else if (fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_quiet_nan_const.Invoke(&fputil_FPBits_ubgsi4))
				{
					llvm_lifetime_start_p0.Invoke(16L, &int3);
					Struct_fiz2nb struct_fiz2nb4 = fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_mantissa_const.Invoke(&fputil_FPBits_ubgsi4);
					Int128* num10 = &int4;
					Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
					*(long*)num10 = struct_fiz2nb5.field_0;
					byte* num11 = (byte*)(&int4) + 8u;
					Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
					*(long*)num11 = struct_fiz2nb6.field_1;
					int3 = int4;
					int3 = NumericHelper.ShiftRightLogical(int3, 11L);
					llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
					anon_izyfb11.val = fputil_internal_FPStorage_fputil_FPType_4_sign_const.Invoke(&fputil_FPBits_ubgsi4);
					long val2 = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan_Sign_unsigned_long.Invoke(v: (long)int3, sign: anon_izyfb11.val);
					fputil_FPBits_wjhbrm3.FPRepImpl.FPRepSem.FPStorage.val = val2;
					result = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm3);
					llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
					llvm_lifetime_end_p0.Invoke(16L, &int3);
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb12, Sign_POS.Pointer, 1L, isVolatile: false);
					long val3 = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan_Sign_unsigned_long.Invoke(anon_izyfb12.val, 0L);
					fputil_FPBits_wjhbrm4.FPRepImpl.FPRepSem.FPStorage.val = val3;
					result = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm4);
					llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
				}
			}
			else if (fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_inf_const.Invoke(&fputil_FPBits_ubgsi3))
			{
				if (fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_inf_const.Invoke(&fputil_FPBits_ubgsi4))
				{
					if ((b & 1) != 1)
					{
						fputil_raise_except_if_required_int.Invoke(1);
						llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb13, Sign_POS.Pointer, 1L, isVolatile: false);
						long val4 = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan_Sign_unsigned_long.Invoke(anon_izyfb13.val, 0L);
						fputil_FPBits_wjhbrm5.FPRepImpl.FPRepSem.FPStorage.val = val4;
						result = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm5);
						llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
					}
					else
					{
						llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm6);
						anon_izyfb14.val = fputil_internal_FPStorage_fputil_FPType_4_sign_const.Invoke(&fputil_FPBits_ubgsi3);
						long val5 = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_inf_Sign.Invoke(anon_izyfb14.val);
						fputil_FPBits_wjhbrm6.FPRepImpl.FPRepSem.FPStorage.val = val5;
						result = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm6);
						llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm6);
					}
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm7);
					anon_izyfb15.val = fputil_internal_FPStorage_fputil_FPType_4_sign_const.Invoke(&fputil_FPBits_ubgsi3);
					long val6 = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_inf_Sign.Invoke(anon_izyfb15.val);
					fputil_FPBits_wjhbrm7.FPRepImpl.FPRepSem.FPStorage.val = val6;
					result = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm7);
					llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm7);
				}
			}
			else if (fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_inf_const.Invoke(&fputil_FPBits_ubgsi4))
			{
				llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm8);
				anon_izyfb16.val = fputil_internal_FPStorage_fputil_FPType_4_sign_const.Invoke(&fputil_FPBits_ubgsi4);
				long val7 = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_inf_Sign.Invoke(anon_izyfb16.val);
				fputil_FPBits_wjhbrm8.FPRepImpl.FPRepSem.FPStorage.val = val7;
				result = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm8);
				llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm8);
			}
			else if (fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_zero_const.Invoke(&fputil_FPBits_ubgsi3))
			{
				if (fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_zero_const.Invoke(&fputil_FPBits_ubgsi4))
				{
					if (fputil_quick_get_round.Invoke() == 1024)
					{
						llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm9);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb17, Sign_NEG.Pointer, 1L, isVolatile: false);
						long val8 = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_zero_Sign.Invoke(anon_izyfb17.val);
						fputil_FPBits_wjhbrm9.FPRepImpl.FPRepSem.FPStorage.val = val8;
						result = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm9);
						llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm9);
					}
					else
					{
						llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm10);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb18, Sign_POS.Pointer, 1L, isVolatile: false);
						long val9 = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_zero_Sign.Invoke(anon_izyfb18.val);
						fputil_FPBits_wjhbrm10.FPRepImpl.FPRepSem.FPStorage.val = val9;
						result = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm10);
						llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm10);
					}
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(16L, &x2);
					x2 = y;
					result = cpp_enable_if_cpp_is_floating_point_v_double_cpp_is_floating_point_v_long_double_double_type_fputil_cast_double_long_double_long_double.Invoke(x2);
					llvm_lifetime_end_p0.Invoke(16L, &x2);
				}
			}
			else
			{
				if (!fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_zero_const.Invoke(&fputil_FPBits_ubgsi4))
				{
					goto IL_08d6;
				}
				llvm_lifetime_start_p0.Invoke(16L, &x3);
				x3 = y;
				result = cpp_enable_if_cpp_is_floating_point_v_double_cpp_is_floating_point_v_long_double_double_type_fputil_cast_double_long_double_long_double.Invoke(x3);
				llvm_lifetime_end_p0.Invoke(16L, &x3);
			}
			goto IL_1137;
		}
		IL_1137:
		llvm_lifetime_end_p0.Invoke(1L, &b);
		llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
		llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		llvm_lifetime_end_p0.Invoke(4L, &num3);
		llvm_lifetime_end_p0.Invoke(4L, &num2);
		llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
		IL_08d6:
		llvm_lifetime_start_p0.Invoke(16L, &num4);
		llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi5);
		Struct_fiz2nb struct_fiz2nb7 = fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_abs_const.Invoke(&fputil_FPBits_ubgsi3);
		Int128* ptr = &fputil_FPBits_ubgsi5.val.Data.FPStorage.field_0;
		Struct_fiz2nb struct_fiz2nb8 = struct_fiz2nb7;
		unchecked
		{
			((Struct_fiz2nb*)ptr)->field_0 = struct_fiz2nb8.field_0;
			Struct_fiz2nb struct_fiz2nb9 = struct_fiz2nb7;
			((Struct_fiz2nb*)ptr)->field_1 = struct_fiz2nb9.field_1;
			double num12 = fputil_FPBits_long_double_get_val_const.Invoke(&fputil_FPBits_ubgsi5);
			llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi5);
			num4 = num12;
			llvm_lifetime_start_p0.Invoke(16L, &num5);
			llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi6);
			Struct_fiz2nb struct_fiz2nb10 = fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_abs_const.Invoke(&fputil_FPBits_ubgsi4);
			Int128* ptr2 = &fputil_FPBits_ubgsi6.val.Data.FPStorage.field_0;
			Struct_fiz2nb struct_fiz2nb11 = struct_fiz2nb10;
			((Struct_fiz2nb*)ptr2)->field_0 = struct_fiz2nb11.field_0;
			Struct_fiz2nb struct_fiz2nb12 = struct_fiz2nb10;
			((Struct_fiz2nb*)ptr2)->field_1 = struct_fiz2nb12.field_1;
			double num13 = fputil_FPBits_long_double_get_val_const.Invoke(&fputil_FPBits_ubgsi6);
			llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi6);
			num5 = num13;
			if (num4 == num5 && (b & 1) != 1)
			{
				if (fputil_quick_get_round.Invoke() == 1024)
				{
					llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm11);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb19, Sign_NEG.Pointer, 1L, isVolatile: false);
					long val10 = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_zero_Sign.Invoke(anon_izyfb19.val);
					fputil_FPBits_wjhbrm11.FPRepImpl.FPRepSem.FPStorage.val = val10;
					result = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm11);
					llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm11);
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm12);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb20, Sign_POS.Pointer, 1L, isVolatile: false);
					long val11 = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_zero_Sign.Invoke(anon_izyfb20.val);
					fputil_FPBits_wjhbrm12.FPRepImpl.FPRepSem.FPStorage.val = val11;
					result = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm12);
					llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm12);
				}
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb21);
				*(sbyte*)(&anon_izyfb21) = -86;
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb21, Sign_POS.Pointer, 1L, isVolatile: false);
				if (num4 > num5)
				{
					llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb22);
					anon_izyfb22.val = fputil_internal_FPStorage_fputil_FPType_4_sign_const.Invoke(&fputil_FPBits_ubgsi3);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb21, &anon_izyfb22, 1L, isVolatile: false);
					llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb22);
				}
				else if (num4 < num5)
				{
					if ((b & 1) == 1)
					{
						llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb23);
						anon_izyfb23.val = fputil_internal_FPStorage_fputil_FPType_4_sign_const.Invoke(&fputil_FPBits_ubgsi4);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb21, &anon_izyfb23, 1L, isVolatile: false);
						llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb23);
					}
					else if (fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_is_pos_const.Invoke(&fputil_FPBits_ubgsi4))
					{
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb21, Sign_NEG.Pointer, 1L, isVolatile: false);
					}
				}
				else if ((b & 1) == 1)
				{
					llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb24);
					anon_izyfb24.val = fputil_internal_FPStorage_fputil_FPType_4_sign_const.Invoke(&fputil_FPBits_ubgsi3);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb21, &anon_izyfb24, 1L, isVolatile: false);
					llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb24);
				}
				llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi7);
				*(Int128*)(&fputil_FPBits_ubgsi7) = -6148914691236517206L;
				fputil_FPBits_long_double_FPBits_long_double_long_double.Invoke(&fputil_FPBits_ubgsi7, *(double*)long_double_const_cpp_max_long_double_long_double_const_long_double_const.Invoke(&num4, &num5));
				llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi8);
				*(Int128*)(&fputil_FPBits_ubgsi8) = -6148914691236517206L;
				fputil_FPBits_long_double_FPBits_long_double_long_double.Invoke(&fputil_FPBits_ubgsi8, *(double*)long_double_const_cpp_min_long_double_long_double_const_long_double_const.Invoke(&num4, &num5));
				llvm_lifetime_start_p0.Invoke(16L, &int5);
				int5 = -6148914691236517206L;
				if (fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_subnormal_const.Invoke(&fputil_FPBits_ubgsi7))
				{
					if ((b & 1) == 1)
					{
						Struct_fiz2nb struct_fiz2nb13 = fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_mantissa_const.Invoke(&fputil_FPBits_ubgsi7);
						Int128* num14 = &int6;
						Struct_fiz2nb struct_fiz2nb14 = struct_fiz2nb13;
						*(long*)num14 = struct_fiz2nb14.field_0;
						byte* num15 = (byte*)(&int6) + 8u;
						Struct_fiz2nb struct_fiz2nb15 = struct_fiz2nb13;
						*(long*)num15 = struct_fiz2nb15.field_1;
						Int128 x9 = int6;
						Struct_fiz2nb struct_fiz2nb16 = fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_mantissa_const.Invoke(&fputil_FPBits_ubgsi8);
						Int128* num16 = &y2;
						Struct_fiz2nb struct_fiz2nb17 = struct_fiz2nb16;
						*(long*)num16 = struct_fiz2nb17.field_0;
						byte* num17 = (byte*)(&y2) + 8u;
						Struct_fiz2nb struct_fiz2nb18 = struct_fiz2nb16;
						*(long*)num17 = struct_fiz2nb18.field_1;
						int5 = NumericHelper.Add(x9, y2);
					}
					else
					{
						Struct_fiz2nb struct_fiz2nb19 = fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_mantissa_const.Invoke(&fputil_FPBits_ubgsi7);
						Int128* num18 = &int7;
						Struct_fiz2nb struct_fiz2nb20 = struct_fiz2nb19;
						*(long*)num18 = struct_fiz2nb20.field_0;
						byte* num19 = (byte*)(&int7) + 8u;
						Struct_fiz2nb struct_fiz2nb21 = struct_fiz2nb19;
						*(long*)num19 = struct_fiz2nb21.field_1;
						Int128 x10 = int7;
						Struct_fiz2nb struct_fiz2nb22 = fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_mantissa_const.Invoke(&fputil_FPBits_ubgsi8);
						Int128* num20 = &y3;
						Struct_fiz2nb struct_fiz2nb23 = struct_fiz2nb22;
						*(long*)num20 = struct_fiz2nb23.field_0;
						byte* num21 = (byte*)(&y3) + 8u;
						Struct_fiz2nb struct_fiz2nb24 = struct_fiz2nb22;
						*(long*)num21 = struct_fiz2nb24.field_1;
						int5 = NumericHelper.Subtract(x10, y3);
					}
					int5 = NumericHelper.ShiftLeft(int5, 3L);
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(16L, &x4);
					Struct_fiz2nb struct_fiz2nb25 = fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_get_explicit_mantissa_const.Invoke(&fputil_FPBits_ubgsi7);
					Int128* num22 = &x5;
					Struct_fiz2nb struct_fiz2nb26 = struct_fiz2nb25;
					*(long*)num22 = struct_fiz2nb26.field_0;
					byte* num23 = (byte*)(&x5) + 8u;
					Struct_fiz2nb struct_fiz2nb27 = struct_fiz2nb25;
					*(long*)num23 = struct_fiz2nb27.field_1;
					x4 = NumericHelper.ShiftLeft(x5, 3L);
					llvm_lifetime_start_p0.Invoke(16L, &x6);
					Struct_fiz2nb struct_fiz2nb28 = fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_get_explicit_mantissa_const.Invoke(&fputil_FPBits_ubgsi8);
					Int128* num24 = &x7;
					Struct_fiz2nb struct_fiz2nb29 = struct_fiz2nb28;
					*(long*)num24 = struct_fiz2nb29.field_0;
					byte* num25 = (byte*)(&x7) + 8u;
					Struct_fiz2nb struct_fiz2nb30 = struct_fiz2nb28;
					*(long*)num25 = struct_fiz2nb30.field_1;
					x6 = NumericHelper.ShiftLeft(x7, 3L);
					llvm_lifetime_start_p0.Invoke(4L, &num6);
					checked
					{
						num6 = unchecked((ushort)fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_biased_exponent_const.Invoke(&fputil_FPBits_ubgsi7)) - unchecked((ushort)fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_biased_exponent_const.Invoke(&fputil_FPBits_ubgsi8));
						llvm_lifetime_start_p0.Invoke(16L, &x8);
					}
					x8 = NumericHelper.ShiftRightLogical(x6, (Int128)(UInt128)(*(uint*)int_const_cpp_min_int_int_const_int_const.Invoke(&num6, &num3)));
					llvm_lifetime_start_p0.Invoke(1L, &b2);
					b2 = -86;
					b2 = ((num6 > 3 && (num6 > 66 || NumericHelper.IntCmpNe(NumericHelper.ShiftLeft(x6, (Int128)(UInt128)(uint)checked(128 - num6)), 0L))) ? ((sbyte)1) : ((sbyte)0));
					llvm_lifetime_start_p0.Invoke(16L, &y4);
					y4 = (((b2 & 1) == 1) ? 1 : 0);
					int5 = (((b & 1) != 1) ? NumericHelper.Subtract(x4, NumericHelper.BitwiseOr(x8, y4)) : NumericHelper.Add(x4, NumericHelper.BitwiseOr(x8, y4)));
					llvm_lifetime_end_p0.Invoke(16L, &y4);
					llvm_lifetime_end_p0.Invoke(1L, &b2);
					llvm_lifetime_end_p0.Invoke(16L, &x8);
					llvm_lifetime_end_p0.Invoke(4L, &num6);
					llvm_lifetime_end_p0.Invoke(16L, &x6);
					llvm_lifetime_end_p0.Invoke(16L, &x4);
				}
				llvm_lifetime_start_p0.Invoke(4L, &num7);
				num7 = checked(fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_exponent_const.Invoke(&fputil_FPBits_ubgsi7) - 66);
				llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd5);
				*(sbyte*)(&fputil_DyadicFloat_kt2kd5) = -86;
				sbyte* ptr3 = (sbyte*)(&fputil_DyadicFloat_kt2kd5) + 1;
				*ptr3 = -86;
				ptr3[1] = -86;
				ptr3[2] = -86;
				((int*)(&fputil_DyadicFloat_kt2kd5))[1] = -1431655766;
				sbyte* ptr4 = (sbyte*)(&fputil_DyadicFloat_kt2kd5) + 8;
				*(long*)ptr4 = -6148914691236517206L;
				((long*)ptr4)[1] = -6148914691236517206L;
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb25, &anon_izyfb21, 1L, isVolatile: false);
				int e = num7;
				int8 = int5;
				BigInt_128ul_false_unsigned_long_BigInt_unsigned_int128_void_unsigned_int128.Invoke(&bigInt_qdkjbh, *(long*)(&int8), ((long*)(&int8))[1]);
				fputil_DyadicFloat_128ul_DyadicFloat_Sign_int_BigInt_128ul_false_unsigned_long.Invoke(&fputil_DyadicFloat_kt2kd5, anon_izyfb25.val, e, *(long*)(&bigInt_qdkjbh), ((long*)(&bigInt_qdkjbh))[1]);
				result = double_fputil_DyadicFloat_128ul_as_double_true_void_const.Invoke(&fputil_DyadicFloat_kt2kd5);
				llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd5);
				llvm_lifetime_end_p0.Invoke(4L, &num7);
				llvm_lifetime_end_p0.Invoke(16L, &int5);
				llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi8);
				llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi7);
				llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb21);
			}
			llvm_lifetime_end_p0.Invoke(16L, &num5);
			llvm_lifetime_end_p0.Invoke(16L, &num4);
			goto IL_1137;
		}
	}
}
