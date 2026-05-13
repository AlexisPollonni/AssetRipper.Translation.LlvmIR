using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic10add_or_subILb1EDF16_dEENS_3cpp9enable_ifIXaaaasr3cppE19is_floating_point_vIT0_Esr3cppE19is_floating_point_vIT1_ElestS5_stS6_ES5_E4typeES6_S6_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16> && cpp::is_floating_point_v<double> && sizeof (_Float16) <= sizeof (double), _Float16>::type __llvm_libc_20_1_2_::fputil::generic::add_or_sub<true, _Float16, double>(double, double)")]
internal static partial class cpp_enable_if_cpp_is_floating_point_v_Float16_cpp_is_floating_point_v_double_sizeof_Float16_sizeof_double_Float16_type_fputil_generic_add_or_sub_true_Float16_double_double_double
{
	public unsafe static Half Invoke(double x, double y)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		sbyte b = 0;
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		long num4 = 0L;
		fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		long num5 = 0L;
		fputil_FPBits_2fahva fputil_FPBits_2fahva3 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb11 = default(anon_izyfb7);
		fputil_FPBits_2fahva fputil_FPBits_2fahva4 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb12 = default(anon_izyfb7);
		fputil_FPBits_2fahva fputil_FPBits_2fahva5 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb13 = default(anon_izyfb7);
		fputil_FPBits_2fahva fputil_FPBits_2fahva6 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb14 = default(anon_izyfb7);
		fputil_FPBits_2fahva fputil_FPBits_2fahva7 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb15 = default(anon_izyfb7);
		fputil_FPBits_2fahva fputil_FPBits_2fahva8 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb16 = default(anon_izyfb7);
		fputil_FPBits_2fahva fputil_FPBits_2fahva9 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb17 = default(anon_izyfb7);
		fputil_FPBits_2fahva fputil_FPBits_2fahva10 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb18 = default(anon_izyfb7);
		double num6 = 0.0;
		double num7 = 0.0;
		double num8 = 0.0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm4 = default(fputil_FPBits_wjhbrm);
		double num9 = 0.0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm5 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_2fahva fputil_FPBits_2fahva11 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb19 = default(anon_izyfb7);
		fputil_FPBits_2fahva fputil_FPBits_2fahva12 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb20 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb21 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb22 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb23 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb24 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm6 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm7 = default(fputil_FPBits_wjhbrm);
		long num10 = 0L;
		long num11 = 0L;
		long num12 = 0L;
		int num13 = 0;
		long num14 = 0L;
		sbyte b2 = 0;
		long num15 = 0L;
		int num16 = 0;
		fputil_DyadicFloat_374hpp fputil_DyadicFloat_374hpp2 = default(fputil_DyadicFloat_374hpp);
		anon_izyfb7 anon_izyfb25 = default(anon_izyfb7);
		BigInt_nx6qdt bigInt_nx6qdt = default(BigInt_nx6qdt);
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = 3;
		llvm_lifetime_start_p0.Invoke(4L, &num2);
		num2 = 55;
		llvm_lifetime_start_p0.Invoke(4L, &num3);
		num3 = 56;
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		Half result;
		unchecked
		{
			*(long*)(&fputil_FPBits_wjhbrm2) = -6148914691236517206L;
			fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm2, x);
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
			*(long*)(&fputil_FPBits_wjhbrm3) = -6148914691236517206L;
			fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm3, y);
			llvm_lifetime_start_p0.Invoke(1L, &b);
			anon_izyfb8.val = fputil_internal_FPStorage_fputil_FPType_2_sign_const.Invoke(&fputil_FPBits_wjhbrm2);
			anon_izyfb9.val = fputil_internal_FPStorage_fputil_FPType_2_sign_const.Invoke(&fputil_FPBits_wjhbrm3);
			b = ((!operator_Sign_Sign_fy8fvt.Invoke(anon_izyfb8.val, anon_izyfb9.val)) ? ((sbyte)1) : ((sbyte)0));
			if (!bool_details_expects_bool_condition_bool_bool_bool.Invoke(fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_inf_or_nan_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2)) ? true : (fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_inf_or_nan_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm3)) ? true : ((!fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero_const.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2))) ? fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero_const.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm3)) : true)), expected: false))
			{
				goto IL_07f4;
			}
			if (fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_nan_const.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2)) || fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_nan_const.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm3)))
			{
				if (fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_signaling_nan_const.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2)) || fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_signaling_nan_const.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm3)))
				{
					fputil_raise_except_if_required_int.Invoke(1);
				}
				if (fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_quiet_nan_const.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2)))
				{
					llvm_lifetime_start_p0.Invoke(8L, &num4);
					num4 = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2));
					num4 >>>= 42;
					llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
					anon_izyfb10.val = fputil_internal_FPStorage_fputil_FPType_2_sign_const.Invoke(&fputil_FPBits_wjhbrm2);
					short field_ = fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan_Sign_unsigned_short.Invoke(v: (short)num4, sign: anon_izyfb10.val);
					fputil_FPBits_2fahva2.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
					result = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva2);
					llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
					llvm_lifetime_end_p0.Invoke(8L, &num4);
				}
				else if (fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_quiet_nan_const.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm3)))
				{
					llvm_lifetime_start_p0.Invoke(8L, &num5);
					num5 = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm3));
					num5 >>>= 42;
					llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva3);
					anon_izyfb11.val = fputil_internal_FPStorage_fputil_FPType_2_sign_const.Invoke(&fputil_FPBits_wjhbrm3);
					short field_2 = fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan_Sign_unsigned_short.Invoke(v: (short)num5, sign: anon_izyfb11.val);
					fputil_FPBits_2fahva3.FPRepImpl.FPRepSem.FPStorage.field_0 = field_2;
					result = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva3);
					llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva3);
					llvm_lifetime_end_p0.Invoke(8L, &num5);
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva4);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb12, Sign_POS.Pointer, 1L, isVolatile: false);
					short field_3 = fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan_Sign_unsigned_short.Invoke(anon_izyfb12.val, 0);
					fputil_FPBits_2fahva4.FPRepImpl.FPRepSem.FPStorage.field_0 = field_3;
					result = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva4);
					llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva4);
				}
			}
			else if (fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_inf_const.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2)))
			{
				if (fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_inf_const.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm3)))
				{
					if ((b & 1) != 1)
					{
						fputil_raise_except_if_required_int.Invoke(1);
						llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva5);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb13, Sign_POS.Pointer, 1L, isVolatile: false);
						short field_4 = fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan_Sign_unsigned_short.Invoke(anon_izyfb13.val, 0);
						fputil_FPBits_2fahva5.FPRepImpl.FPRepSem.FPStorage.field_0 = field_4;
						result = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva5);
						llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva5);
					}
					else
					{
						llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva6);
						anon_izyfb14.val = fputil_internal_FPStorage_fputil_FPType_2_sign_const.Invoke(&fputil_FPBits_wjhbrm2);
						short field_5 = fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_inf_Sign.Invoke(anon_izyfb14.val);
						fputil_FPBits_2fahva6.FPRepImpl.FPRepSem.FPStorage.field_0 = field_5;
						result = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva6);
						llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva6);
					}
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva7);
					anon_izyfb15.val = fputil_internal_FPStorage_fputil_FPType_2_sign_const.Invoke(&fputil_FPBits_wjhbrm2);
					short field_6 = fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_inf_Sign.Invoke(anon_izyfb15.val);
					fputil_FPBits_2fahva7.FPRepImpl.FPRepSem.FPStorage.field_0 = field_6;
					result = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva7);
					llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva7);
				}
			}
			else if (fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_inf_const.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm3)))
			{
				llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva8);
				anon_izyfb16.val = fputil_internal_FPStorage_fputil_FPType_2_sign_const.Invoke(&fputil_FPBits_wjhbrm3);
				short field_7 = fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_inf_Sign.Invoke(anon_izyfb16.val);
				fputil_FPBits_2fahva8.FPRepImpl.FPRepSem.FPStorage.field_0 = field_7;
				result = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva8);
				llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva8);
			}
			else if (fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero_const.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2)))
			{
				if (fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero_const.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm3)))
				{
					if (fputil_quick_get_round.Invoke() == 1024)
					{
						llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva9);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb17, Sign_NEG.Pointer, 1L, isVolatile: false);
						short field_8 = fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_zero_Sign.Invoke(anon_izyfb17.val);
						fputil_FPBits_2fahva9.FPRepImpl.FPRepSem.FPStorage.field_0 = field_8;
						result = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva9);
						llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva9);
					}
					else
					{
						llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva10);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb18, Sign_POS.Pointer, 1L, isVolatile: false);
						short field_9 = fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_zero_Sign.Invoke(anon_izyfb18.val);
						fputil_FPBits_2fahva10.FPRepImpl.FPRepSem.FPStorage.field_0 = field_9;
						result = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva10);
						llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva10);
					}
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(8L, &num6);
					num6 = y;
					num6 = 0.0 - num6;
					result = cpp_enable_if_cpp_is_floating_point_v_Float16_cpp_is_floating_point_v_double_Float16_type_fputil_cast_Float16_double_double.Invoke(num6);
					llvm_lifetime_end_p0.Invoke(8L, &num6);
				}
			}
			else
			{
				if (!fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero_const.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm3)))
				{
					goto IL_07f4;
				}
				llvm_lifetime_start_p0.Invoke(8L, &num7);
				num7 = y;
				num7 = 0.0 - num7;
				result = cpp_enable_if_cpp_is_floating_point_v_Float16_cpp_is_floating_point_v_double_Float16_type_fputil_cast_Float16_double_double.Invoke(num7);
				llvm_lifetime_end_p0.Invoke(8L, &num7);
			}
			goto IL_0e96;
		}
		IL_0e96:
		llvm_lifetime_end_p0.Invoke(1L, &b);
		llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
		llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		llvm_lifetime_end_p0.Invoke(4L, &num3);
		llvm_lifetime_end_p0.Invoke(4L, &num2);
		llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
		IL_07f4:
		llvm_lifetime_start_p0.Invoke(8L, &num8);
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
		unchecked
		{
			long val = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_abs_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2));
			fputil_FPBits_wjhbrm4.FPRepImpl.FPRepSem.FPStorage.val = val;
			double num17 = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm4);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
			num8 = num17;
			llvm_lifetime_start_p0.Invoke(8L, &num9);
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
			long val2 = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_abs_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm3));
			fputil_FPBits_wjhbrm5.FPRepImpl.FPRepSem.FPStorage.val = val2;
			double num18 = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm5);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
			num9 = num18;
			if (num8 == num9 && (b & 1) != 1)
			{
				if (fputil_quick_get_round.Invoke() == 1024)
				{
					llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva11);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb19, Sign_NEG.Pointer, 1L, isVolatile: false);
					short field_10 = fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_zero_Sign.Invoke(anon_izyfb19.val);
					fputil_FPBits_2fahva11.FPRepImpl.FPRepSem.FPStorage.field_0 = field_10;
					result = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva11);
					llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva11);
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva12);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb20, Sign_POS.Pointer, 1L, isVolatile: false);
					short field_11 = fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_zero_Sign.Invoke(anon_izyfb20.val);
					fputil_FPBits_2fahva12.FPRepImpl.FPRepSem.FPStorage.field_0 = field_11;
					result = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva12);
					llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva12);
				}
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb21);
				*(sbyte*)(&anon_izyfb21) = -86;
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb21, Sign_POS.Pointer, 1L, isVolatile: false);
				if (num8 > num9)
				{
					llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb22);
					anon_izyfb22.val = fputil_internal_FPStorage_fputil_FPType_2_sign_const.Invoke(&fputil_FPBits_wjhbrm2);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb21, &anon_izyfb22, 1L, isVolatile: false);
					llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb22);
				}
				else if (num8 < num9)
				{
					if ((b & 1) == 1)
					{
						llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb23);
						anon_izyfb23.val = fputil_internal_FPStorage_fputil_FPType_2_sign_const.Invoke(&fputil_FPBits_wjhbrm3);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb21, &anon_izyfb23, 1L, isVolatile: false);
						llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb23);
					}
					else if (fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_pos_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm3)))
					{
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb21, Sign_NEG.Pointer, 1L, isVolatile: false);
					}
				}
				else if ((b & 1) == 1)
				{
					llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb24);
					anon_izyfb24.val = fputil_internal_FPStorage_fputil_FPType_2_sign_const.Invoke(&fputil_FPBits_wjhbrm2);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb21, &anon_izyfb24, 1L, isVolatile: false);
					llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb24);
				}
				llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm6);
				*(long*)(&fputil_FPBits_wjhbrm6) = -6148914691236517206L;
				fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm6, *(double*)double_const_cpp_max_double_double_const_double_const.Invoke(&num8, &num9));
				llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm7);
				*(long*)(&fputil_FPBits_wjhbrm7) = -6148914691236517206L;
				fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm7, *(double*)double_const_cpp_min_double_double_const_double_const.Invoke(&num8, &num9));
				llvm_lifetime_start_p0.Invoke(8L, &num10);
				num10 = -6148914691236517206L;
				if (fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_subnormal_const.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm6)))
				{
					num10 = (((b & 1) != 1) ? (fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm6)) - fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm7))) : (fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm6)) + fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm7))));
					num10 <<= 3;
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(8L, &num11);
					num11 = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_get_explicit_mantissa_const.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm6)) << 3;
					llvm_lifetime_start_p0.Invoke(8L, &num12);
					num12 = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_get_explicit_mantissa_const.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm7)) << 3;
					llvm_lifetime_start_p0.Invoke(4L, &num13);
					checked
					{
						num13 = unchecked((ushort)fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_biased_exponent_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm6))) - unchecked((ushort)fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_biased_exponent_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm7)));
						llvm_lifetime_start_p0.Invoke(8L, &num14);
					}
					num14 = num12 >>> (int)(uint)(*(int*)int_const_cpp_min_int_int_const_int_const.Invoke(&num13, &num3));
					llvm_lifetime_start_p0.Invoke(1L, &b2);
					b2 = -86;
					b2 = ((num13 > 3 && (num13 > 55 || num12 << (int)(uint)checked(64 - num13) != 0L)) ? ((sbyte)1) : ((sbyte)0));
					llvm_lifetime_start_p0.Invoke(8L, &num15);
					num15 = (((b2 & 1) == 1) ? 1 : 0);
					num10 = (((b & 1) != 1) ? (num11 - (num14 | num15)) : (num11 + (num14 | num15)));
					llvm_lifetime_end_p0.Invoke(8L, &num15);
					llvm_lifetime_end_p0.Invoke(1L, &b2);
					llvm_lifetime_end_p0.Invoke(8L, &num14);
					llvm_lifetime_end_p0.Invoke(4L, &num13);
					llvm_lifetime_end_p0.Invoke(8L, &num12);
					llvm_lifetime_end_p0.Invoke(8L, &num11);
				}
				llvm_lifetime_start_p0.Invoke(4L, &num16);
				checked
				{
					num16 = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_exponent_const.Invoke(unchecked((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm6))) - 55;
					llvm_lifetime_start_p0.Invoke(16L, &fputil_DyadicFloat_374hpp2);
				}
				*(sbyte*)(&fputil_DyadicFloat_374hpp2) = -86;
				sbyte* ptr = (sbyte*)(&fputil_DyadicFloat_374hpp2) + 1;
				*ptr = -86;
				ptr[1] = -86;
				ptr[2] = -86;
				((int*)(&fputil_DyadicFloat_374hpp2))[1] = -1431655766;
				((long*)(&fputil_DyadicFloat_374hpp2))[1] = -6148914691236517206L;
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb25, &anon_izyfb21, 1L, isVolatile: false);
				int e = num16;
				BigInt_64ul_false_unsigned_long_BigInt_unsigned_long_void_unsigned_long.Invoke(&bigInt_nx6qdt, num10);
				fputil_DyadicFloat_64ul_DyadicFloat_Sign_int_BigInt_64ul_false_unsigned_long.Invoke(&fputil_DyadicFloat_374hpp2, anon_izyfb25.val, e, *(long*)(&bigInt_nx6qdt.val.Data));
				result = Float16_fputil_DyadicFloat_64ul_as_Float16_true_void_const.Invoke(&fputil_DyadicFloat_374hpp2);
				llvm_lifetime_end_p0.Invoke(16L, &fputil_DyadicFloat_374hpp2);
				llvm_lifetime_end_p0.Invoke(4L, &num16);
				llvm_lifetime_end_p0.Invoke(8L, &num10);
				llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm7);
				llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm6);
				llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb21);
			}
			llvm_lifetime_end_p0.Invoke(8L, &num9);
			llvm_lifetime_end_p0.Invoke(8L, &num8);
			goto IL_0e96;
		}
	}
}
