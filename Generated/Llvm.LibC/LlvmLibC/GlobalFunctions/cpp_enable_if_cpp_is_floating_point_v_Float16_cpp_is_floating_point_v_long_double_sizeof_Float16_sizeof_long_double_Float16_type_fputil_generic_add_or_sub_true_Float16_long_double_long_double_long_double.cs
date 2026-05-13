using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic10add_or_subILb1EDF16_eEENS_3cpp9enable_ifIXaaaasr3cppE19is_floating_point_vIT0_Esr3cppE19is_floating_point_vIT1_ElestS5_stS6_ES5_E4typeES6_S6_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16> && cpp::is_floating_point_v<long double> && sizeof (_Float16) <= sizeof (long double), _Float16>::type __llvm_libc_20_1_2_::fputil::generic::add_or_sub<true, _Float16, long double>(long double, long double)")]
internal static partial class cpp_enable_if_cpp_is_floating_point_v_Float16_cpp_is_floating_point_v_long_double_sizeof_Float16_sizeof_long_double_Float16_type_fputil_generic_add_or_sub_true_Float16_long_double_long_double_long_double
{
	public unsafe static Half Invoke(double x, double y)
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
		fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		Int128 int3 = default(Int128);
		Int128 int4 = default(Int128);
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
		double num4 = 0.0;
		double num5 = 0.0;
		double num6 = 0.0;
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi5 = default(fputil_FPBits_ubgsi2);
		double num7 = 0.0;
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi6 = default(fputil_FPBits_ubgsi2);
		fputil_FPBits_2fahva fputil_FPBits_2fahva11 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb19 = default(anon_izyfb7);
		fputil_FPBits_2fahva fputil_FPBits_2fahva12 = default(fputil_FPBits_2fahva);
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
		Int128 x2 = default(Int128);
		Int128 x3 = default(Int128);
		Int128 x4 = default(Int128);
		Int128 x5 = default(Int128);
		int num8 = 0;
		Int128 x6 = default(Int128);
		sbyte b2 = 0;
		Int128 y4 = default(Int128);
		int num9 = 0;
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
		Half result;
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
			b = ((!operator_Sign_Sign_fy8fvt.Invoke(anon_izyfb8.val, anon_izyfb9.val)) ? ((sbyte)1) : ((sbyte)0));
			if (!bool_details_expects_bool_condition_bool_bool_bool.Invoke(fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_is_inf_or_nan_const.Invoke(&fputil_FPBits_ubgsi3) ? true : (fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_is_inf_or_nan_const.Invoke(&fputil_FPBits_ubgsi4) ? true : ((!fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_zero_const.Invoke(&fputil_FPBits_ubgsi3)) ? fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_zero_const.Invoke(&fputil_FPBits_ubgsi4) : true)), expected: false))
			{
				goto IL_08ce;
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
					Int128* num10 = &int2;
					Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
					*(long*)num10 = struct_fiz2nb2.field_0;
					byte* num11 = (byte*)(&int2) + 8u;
					Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
					*(long*)num11 = struct_fiz2nb3.field_1;
					@int = int2;
					@int = NumericHelper.ShiftRightLogical(@int, 53L);
					llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
					anon_izyfb10.val = fputil_internal_FPStorage_fputil_FPType_4_sign_const.Invoke(&fputil_FPBits_ubgsi3);
					short field_ = fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan_Sign_unsigned_short.Invoke(v: (short)@int, sign: anon_izyfb10.val);
					fputil_FPBits_2fahva2.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
					result = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva2);
					llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
					llvm_lifetime_end_p0.Invoke(16L, &@int);
				}
				else if (fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_quiet_nan_const.Invoke(&fputil_FPBits_ubgsi4))
				{
					llvm_lifetime_start_p0.Invoke(16L, &int3);
					Struct_fiz2nb struct_fiz2nb4 = fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_mantissa_const.Invoke(&fputil_FPBits_ubgsi4);
					Int128* num12 = &int4;
					Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
					*(long*)num12 = struct_fiz2nb5.field_0;
					byte* num13 = (byte*)(&int4) + 8u;
					Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
					*(long*)num13 = struct_fiz2nb6.field_1;
					int3 = int4;
					int3 = NumericHelper.ShiftRightLogical(int3, 53L);
					llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva3);
					anon_izyfb11.val = fputil_internal_FPStorage_fputil_FPType_4_sign_const.Invoke(&fputil_FPBits_ubgsi4);
					short field_2 = fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan_Sign_unsigned_short.Invoke(v: (short)int3, sign: anon_izyfb11.val);
					fputil_FPBits_2fahva3.FPRepImpl.FPRepSem.FPStorage.field_0 = field_2;
					result = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva3);
					llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva3);
					llvm_lifetime_end_p0.Invoke(16L, &int3);
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
			else if (fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_inf_const.Invoke(&fputil_FPBits_ubgsi3))
			{
				if (fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_inf_const.Invoke(&fputil_FPBits_ubgsi4))
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
						anon_izyfb14.val = fputil_internal_FPStorage_fputil_FPType_4_sign_const.Invoke(&fputil_FPBits_ubgsi3);
						short field_5 = fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_inf_Sign.Invoke(anon_izyfb14.val);
						fputil_FPBits_2fahva6.FPRepImpl.FPRepSem.FPStorage.field_0 = field_5;
						result = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva6);
						llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva6);
					}
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva7);
					anon_izyfb15.val = fputil_internal_FPStorage_fputil_FPType_4_sign_const.Invoke(&fputil_FPBits_ubgsi3);
					short field_6 = fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_inf_Sign.Invoke(anon_izyfb15.val);
					fputil_FPBits_2fahva7.FPRepImpl.FPRepSem.FPStorage.field_0 = field_6;
					result = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva7);
					llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva7);
				}
			}
			else if (fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_inf_const.Invoke(&fputil_FPBits_ubgsi4))
			{
				llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva8);
				anon_izyfb16.val = fputil_internal_FPStorage_fputil_FPType_4_sign_const.Invoke(&fputil_FPBits_ubgsi4);
				short field_7 = fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_inf_Sign.Invoke(anon_izyfb16.val);
				fputil_FPBits_2fahva8.FPRepImpl.FPRepSem.FPStorage.field_0 = field_7;
				result = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva8);
				llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva8);
			}
			else if (fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_zero_const.Invoke(&fputil_FPBits_ubgsi3))
			{
				if (fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_zero_const.Invoke(&fputil_FPBits_ubgsi4))
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
					llvm_lifetime_start_p0.Invoke(16L, &num4);
					num4 = y;
					num4 = 0.0 - num4;
					result = cpp_enable_if_cpp_is_floating_point_v_Float16_cpp_is_floating_point_v_long_double_Float16_type_fputil_cast_Float16_long_double_long_double.Invoke(num4);
					llvm_lifetime_end_p0.Invoke(16L, &num4);
				}
			}
			else
			{
				if (!fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_zero_const.Invoke(&fputil_FPBits_ubgsi4))
				{
					goto IL_08ce;
				}
				llvm_lifetime_start_p0.Invoke(16L, &num5);
				num5 = y;
				num5 = 0.0 - num5;
				result = cpp_enable_if_cpp_is_floating_point_v_Float16_cpp_is_floating_point_v_long_double_Float16_type_fputil_cast_Float16_long_double_long_double.Invoke(num5);
				llvm_lifetime_end_p0.Invoke(16L, &num5);
			}
			goto IL_112f;
		}
		IL_112f:
		llvm_lifetime_end_p0.Invoke(1L, &b);
		llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
		llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		llvm_lifetime_end_p0.Invoke(4L, &num3);
		llvm_lifetime_end_p0.Invoke(4L, &num2);
		llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
		IL_08ce:
		llvm_lifetime_start_p0.Invoke(16L, &num6);
		llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi5);
		Struct_fiz2nb struct_fiz2nb7 = fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_abs_const.Invoke(&fputil_FPBits_ubgsi3);
		Int128* ptr = &fputil_FPBits_ubgsi5.val.Data.FPStorage.field_0;
		Struct_fiz2nb struct_fiz2nb8 = struct_fiz2nb7;
		unchecked
		{
			((Struct_fiz2nb*)ptr)->field_0 = struct_fiz2nb8.field_0;
			Struct_fiz2nb struct_fiz2nb9 = struct_fiz2nb7;
			((Struct_fiz2nb*)ptr)->field_1 = struct_fiz2nb9.field_1;
			double num14 = fputil_FPBits_long_double_get_val_const.Invoke(&fputil_FPBits_ubgsi5);
			llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi5);
			num6 = num14;
			llvm_lifetime_start_p0.Invoke(16L, &num7);
			llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi6);
			Struct_fiz2nb struct_fiz2nb10 = fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_abs_const.Invoke(&fputil_FPBits_ubgsi4);
			Int128* ptr2 = &fputil_FPBits_ubgsi6.val.Data.FPStorage.field_0;
			Struct_fiz2nb struct_fiz2nb11 = struct_fiz2nb10;
			((Struct_fiz2nb*)ptr2)->field_0 = struct_fiz2nb11.field_0;
			Struct_fiz2nb struct_fiz2nb12 = struct_fiz2nb10;
			((Struct_fiz2nb*)ptr2)->field_1 = struct_fiz2nb12.field_1;
			double num15 = fputil_FPBits_long_double_get_val_const.Invoke(&fputil_FPBits_ubgsi6);
			llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi6);
			num7 = num15;
			if (num6 == num7 && (b & 1) != 1)
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
				if (num6 > num7)
				{
					llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb22);
					anon_izyfb22.val = fputil_internal_FPStorage_fputil_FPType_4_sign_const.Invoke(&fputil_FPBits_ubgsi3);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb21, &anon_izyfb22, 1L, isVolatile: false);
					llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb22);
				}
				else if (num6 < num7)
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
				fputil_FPBits_long_double_FPBits_long_double_long_double.Invoke(&fputil_FPBits_ubgsi7, *(double*)long_double_const_cpp_max_long_double_long_double_const_long_double_const.Invoke(&num6, &num7));
				llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi8);
				*(Int128*)(&fputil_FPBits_ubgsi8) = -6148914691236517206L;
				fputil_FPBits_long_double_FPBits_long_double_long_double.Invoke(&fputil_FPBits_ubgsi8, *(double*)long_double_const_cpp_min_long_double_long_double_const_long_double_const.Invoke(&num6, &num7));
				llvm_lifetime_start_p0.Invoke(16L, &int5);
				int5 = -6148914691236517206L;
				if (fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_subnormal_const.Invoke(&fputil_FPBits_ubgsi7))
				{
					if ((b & 1) == 1)
					{
						Struct_fiz2nb struct_fiz2nb13 = fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_mantissa_const.Invoke(&fputil_FPBits_ubgsi7);
						Int128* num16 = &int6;
						Struct_fiz2nb struct_fiz2nb14 = struct_fiz2nb13;
						*(long*)num16 = struct_fiz2nb14.field_0;
						byte* num17 = (byte*)(&int6) + 8u;
						Struct_fiz2nb struct_fiz2nb15 = struct_fiz2nb13;
						*(long*)num17 = struct_fiz2nb15.field_1;
						Int128 x7 = int6;
						Struct_fiz2nb struct_fiz2nb16 = fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_mantissa_const.Invoke(&fputil_FPBits_ubgsi8);
						Int128* num18 = &y2;
						Struct_fiz2nb struct_fiz2nb17 = struct_fiz2nb16;
						*(long*)num18 = struct_fiz2nb17.field_0;
						byte* num19 = (byte*)(&y2) + 8u;
						Struct_fiz2nb struct_fiz2nb18 = struct_fiz2nb16;
						*(long*)num19 = struct_fiz2nb18.field_1;
						int5 = NumericHelper.Add(x7, y2);
					}
					else
					{
						Struct_fiz2nb struct_fiz2nb19 = fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_mantissa_const.Invoke(&fputil_FPBits_ubgsi7);
						Int128* num20 = &int7;
						Struct_fiz2nb struct_fiz2nb20 = struct_fiz2nb19;
						*(long*)num20 = struct_fiz2nb20.field_0;
						byte* num21 = (byte*)(&int7) + 8u;
						Struct_fiz2nb struct_fiz2nb21 = struct_fiz2nb19;
						*(long*)num21 = struct_fiz2nb21.field_1;
						Int128 x8 = int7;
						Struct_fiz2nb struct_fiz2nb22 = fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_mantissa_const.Invoke(&fputil_FPBits_ubgsi8);
						Int128* num22 = &y3;
						Struct_fiz2nb struct_fiz2nb23 = struct_fiz2nb22;
						*(long*)num22 = struct_fiz2nb23.field_0;
						byte* num23 = (byte*)(&y3) + 8u;
						Struct_fiz2nb struct_fiz2nb24 = struct_fiz2nb22;
						*(long*)num23 = struct_fiz2nb24.field_1;
						int5 = NumericHelper.Subtract(x8, y3);
					}
					int5 = NumericHelper.ShiftLeft(int5, 3L);
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(16L, &x2);
					Struct_fiz2nb struct_fiz2nb25 = fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_get_explicit_mantissa_const.Invoke(&fputil_FPBits_ubgsi7);
					Int128* num24 = &x3;
					Struct_fiz2nb struct_fiz2nb26 = struct_fiz2nb25;
					*(long*)num24 = struct_fiz2nb26.field_0;
					byte* num25 = (byte*)(&x3) + 8u;
					Struct_fiz2nb struct_fiz2nb27 = struct_fiz2nb25;
					*(long*)num25 = struct_fiz2nb27.field_1;
					x2 = NumericHelper.ShiftLeft(x3, 3L);
					llvm_lifetime_start_p0.Invoke(16L, &x4);
					Struct_fiz2nb struct_fiz2nb28 = fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_get_explicit_mantissa_const.Invoke(&fputil_FPBits_ubgsi8);
					Int128* num26 = &x5;
					Struct_fiz2nb struct_fiz2nb29 = struct_fiz2nb28;
					*(long*)num26 = struct_fiz2nb29.field_0;
					byte* num27 = (byte*)(&x5) + 8u;
					Struct_fiz2nb struct_fiz2nb30 = struct_fiz2nb28;
					*(long*)num27 = struct_fiz2nb30.field_1;
					x4 = NumericHelper.ShiftLeft(x5, 3L);
					llvm_lifetime_start_p0.Invoke(4L, &num8);
					checked
					{
						num8 = unchecked((ushort)fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_biased_exponent_const.Invoke(&fputil_FPBits_ubgsi7)) - unchecked((ushort)fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_biased_exponent_const.Invoke(&fputil_FPBits_ubgsi8));
						llvm_lifetime_start_p0.Invoke(16L, &x6);
					}
					x6 = NumericHelper.ShiftRightLogical(x4, (Int128)(UInt128)(*(uint*)int_const_cpp_min_int_int_const_int_const.Invoke(&num8, &num3)));
					llvm_lifetime_start_p0.Invoke(1L, &b2);
					b2 = -86;
					b2 = ((num8 > 3 && (num8 > 66 || NumericHelper.IntCmpNe(NumericHelper.ShiftLeft(x4, (Int128)(UInt128)(uint)checked(128 - num8)), 0L))) ? ((sbyte)1) : ((sbyte)0));
					llvm_lifetime_start_p0.Invoke(16L, &y4);
					y4 = (((b2 & 1) == 1) ? 1 : 0);
					int5 = (((b & 1) != 1) ? NumericHelper.Subtract(x2, NumericHelper.BitwiseOr(x6, y4)) : NumericHelper.Add(x2, NumericHelper.BitwiseOr(x6, y4)));
					llvm_lifetime_end_p0.Invoke(16L, &y4);
					llvm_lifetime_end_p0.Invoke(1L, &b2);
					llvm_lifetime_end_p0.Invoke(16L, &x6);
					llvm_lifetime_end_p0.Invoke(4L, &num8);
					llvm_lifetime_end_p0.Invoke(16L, &x4);
					llvm_lifetime_end_p0.Invoke(16L, &x2);
				}
				llvm_lifetime_start_p0.Invoke(4L, &num9);
				num9 = checked(fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_exponent_const.Invoke(&fputil_FPBits_ubgsi7) - 66);
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
				int e = num9;
				int8 = int5;
				BigInt_128ul_false_unsigned_long_BigInt_unsigned_int128_void_unsigned_int128.Invoke((anon_izyfb7*)(&bigInt_qdkjbh), *(long*)(&int8), ((long*)(&int8))[1]);
				fputil_DyadicFloat_128ul_DyadicFloat_Sign_int_BigInt_128ul_false_unsigned_long.Invoke(&fputil_DyadicFloat_kt2kd5, anon_izyfb25.val, e, *(long*)(&bigInt_qdkjbh), ((long*)(&bigInt_qdkjbh))[1]);
				result = Float16_fputil_DyadicFloat_128ul_as_Float16_true_void_const.Invoke(&fputil_DyadicFloat_kt2kd5);
				llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd5);
				llvm_lifetime_end_p0.Invoke(4L, &num9);
				llvm_lifetime_end_p0.Invoke(16L, &int5);
				llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi8);
				llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi7);
				llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb21);
			}
			llvm_lifetime_end_p0.Invoke(16L, &num7);
			llvm_lifetime_end_p0.Invoke(16L, &num6);
			goto IL_112f;
		}
	}
}
