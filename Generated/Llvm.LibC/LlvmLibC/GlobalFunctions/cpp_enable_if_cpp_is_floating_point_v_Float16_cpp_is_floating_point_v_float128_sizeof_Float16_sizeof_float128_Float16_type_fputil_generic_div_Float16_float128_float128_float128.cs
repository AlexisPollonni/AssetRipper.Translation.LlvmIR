using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic3divIDF16_gEENS_3cpp9enable_ifIXaaaasr3cppE19is_floating_point_vIT_Esr3cppE19is_floating_point_vIT0_ElestS5_stS6_ES5_E4typeES6_S6_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16> && cpp::is_floating_point_v<__float128> && sizeof (_Float16) <= sizeof (__float128), _Float16>::type __llvm_libc_20_1_2_::fputil::generic::div<_Float16, __float128>(__float128, __float128)")]
internal static partial class cpp_enable_if_cpp_is_floating_point_v_Float16_cpp_is_floating_point_v_float128_sizeof_Float16_sizeof_float128_Float16_type_fputil_generic_div_Float16_float128_float128_float128
{
	public unsafe static Half Invoke(double x, double y)
	{
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(fputil_FPBits_ubgsi2);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi4 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		Int128 @int = default(Int128);
		Int128 int2 = default(Int128);
		fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb11 = default(anon_izyfb7);
		Int128 int3 = default(Int128);
		Int128 int4 = default(Int128);
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
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd5 = default(fputil_DyadicFloat_kt2kd4);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd6 = default(fputil_DyadicFloat_kt2kd4);
		int num = 0;
		int num2 = 0;
		Int128 int5 = default(Int128);
		Int128 x2 = default(Int128);
		BigInt_qdkjbh bigInt_qdkjbh = default(BigInt_qdkjbh);
		Int128 int6 = default(Int128);
		Int128 y2 = default(Int128);
		BigInt_qdkjbh bigInt_qdkjbh2 = default(BigInt_qdkjbh);
		Int128 int7 = default(Int128);
		int i = 0;
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd7 = default(fputil_DyadicFloat_kt2kd4);
		anon_izyfb7 anon_izyfb20 = default(anon_izyfb7);
		BigInt_qdkjbh bigInt_qdkjbh3 = default(BigInt_qdkjbh);
		Int128 int8 = default(Int128);
		BigInt_qdkjbh bigInt_qdkjbh4 = default(BigInt_qdkjbh);
		BigInt_qdkjbh bigInt_qdkjbh5 = default(BigInt_qdkjbh);
		llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		Half result;
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
			if (!bool_details_expects_bool_condition_bool_bool_bool.Invoke(fputil_internal_FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_is_inf_or_nan_const.Invoke(&fputil_FPBits_ubgsi3) ? true : (fputil_internal_FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_is_inf_or_nan_const.Invoke(&fputil_FPBits_ubgsi4) ? true : ((!fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_zero_const.Invoke((fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi3))) ? fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_zero_const.Invoke((fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi4)) : true)), expected: false))
			{
				goto IL_07b5;
			}
			if (fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_nan_const.Invoke((fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi3)) || fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_nan_const.Invoke((fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi4)))
			{
				if (fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_signaling_nan_const.Invoke((fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi3)) || fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_signaling_nan_const.Invoke((fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi4)))
				{
					fputil_raise_except_if_required_int.Invoke(1);
				}
				if (fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_quiet_nan_const.Invoke((fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi3)))
				{
					llvm_lifetime_start_p0.Invoke(16L, &@int);
					Struct_fiz2nb struct_fiz2nb = fputil_internal_FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_get_mantissa_const.Invoke(&fputil_FPBits_ubgsi3);
					Int128* num3 = &int2;
					Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
					*(long*)num3 = struct_fiz2nb2.field_0;
					byte* num4 = (byte*)(&int2) + 8u;
					Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
					*(long*)num4 = struct_fiz2nb3.field_1;
					@int = int2;
					@int = NumericHelper.ShiftRightLogical(@int, 102L);
					llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
					anon_izyfb11.val = fputil_internal_FPStorage_fputil_FPType_3_sign_const.Invoke(&fputil_FPBits_ubgsi3);
					short field_ = fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan_Sign_unsigned_short.Invoke(v: (short)@int, sign: anon_izyfb11.val);
					fputil_FPBits_2fahva2.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
					result = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva2);
					llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
					llvm_lifetime_end_p0.Invoke(16L, &@int);
				}
				else if (fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_quiet_nan_const.Invoke((fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi4)))
				{
					llvm_lifetime_start_p0.Invoke(16L, &int3);
					Struct_fiz2nb struct_fiz2nb4 = fputil_internal_FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_get_mantissa_const.Invoke(&fputil_FPBits_ubgsi4);
					Int128* num5 = &int4;
					Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
					*(long*)num5 = struct_fiz2nb5.field_0;
					byte* num6 = (byte*)(&int4) + 8u;
					Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
					*(long*)num6 = struct_fiz2nb6.field_1;
					int3 = int4;
					int3 = NumericHelper.ShiftRightLogical(int3, 102L);
					llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva3);
					anon_izyfb12.val = fputil_internal_FPStorage_fputil_FPType_3_sign_const.Invoke(&fputil_FPBits_ubgsi4);
					short field_2 = fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan_Sign_unsigned_short.Invoke(v: (short)int3, sign: anon_izyfb12.val);
					fputil_FPBits_2fahva3.FPRepImpl.FPRepSem.FPStorage.field_0 = field_2;
					result = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva3);
					llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva3);
					llvm_lifetime_end_p0.Invoke(16L, &int3);
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
			else if (fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_inf_const.Invoke((fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi3)))
			{
				if (fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_inf_const.Invoke((fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi4)))
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
			else if (fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_inf_const.Invoke((fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi4)))
			{
				llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva7);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb16, &anon_izyfb8, 1L, isVolatile: false);
				short field_6 = fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_inf_Sign.Invoke(anon_izyfb16.val);
				fputil_FPBits_2fahva7.FPRepImpl.FPRepSem.FPStorage.field_0 = field_6;
				result = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva7);
				llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva7);
			}
			else if (fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_zero_const.Invoke((fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi4)))
			{
				if (fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_zero_const.Invoke((fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi3)))
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
				if (!fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_zero_const.Invoke((fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi3)))
				{
					goto IL_07b5;
				}
				llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva10);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb19, &anon_izyfb8, 1L, isVolatile: false);
				short field_9 = fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_zero_Sign.Invoke(anon_izyfb19.val);
				fputil_FPBits_2fahva10.FPRepImpl.FPRepSem.FPStorage.field_0 = field_9;
				result = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva10);
				llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva10);
			}
			goto IL_0ca6;
		}
		IL_0ca6:
		llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb8);
		llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
		llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		return result;
		IL_07b5:
		llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd5);
		unchecked
		{
			*(sbyte*)(&fputil_DyadicFloat_kt2kd5) = -86;
			sbyte* ptr = (sbyte*)(&fputil_DyadicFloat_kt2kd5) + 1;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			((int*)(&fputil_DyadicFloat_kt2kd5))[1] = -1431655766;
			sbyte* ptr2 = (sbyte*)(&fputil_DyadicFloat_kt2kd5) + 8;
			*(long*)ptr2 = -6148914691236517206L;
			((long*)ptr2)[1] = -6148914691236517206L;
			fputil_DyadicFloat_128ul_DyadicFloat_float128_0_float128.Invoke(&fputil_DyadicFloat_kt2kd5, x);
			llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd6);
			*(sbyte*)(&fputil_DyadicFloat_kt2kd6) = -86;
			sbyte* ptr3 = (sbyte*)(&fputil_DyadicFloat_kt2kd6) + 1;
			*ptr3 = -86;
			ptr3[1] = -86;
			ptr3[2] = -86;
			((int*)(&fputil_DyadicFloat_kt2kd6))[1] = -1431655766;
			sbyte* ptr4 = (sbyte*)(&fputil_DyadicFloat_kt2kd6) + 8;
			*(long*)ptr4 = -6148914691236517206L;
			((long*)ptr4)[1] = -6148914691236517206L;
			fputil_DyadicFloat_128ul_DyadicFloat_float128_0_float128.Invoke(&fputil_DyadicFloat_kt2kd6, y);
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = 13;
			llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = checked(fputil_DyadicFloat_kt2kd5.exponent - fputil_DyadicFloat_kt2kd6.exponent - 12);
			llvm_lifetime_start_p0.Invoke(16L, &int5);
			int5 = 0L;
			llvm_lifetime_start_p0.Invoke(16L, &x2);
			llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh);
			Struct_fiz2nb struct_fiz2nb7 = BigInt_128ul_false_unsigned_long_operator_unsigned_long_const_99u38u.Invoke((anon_izyfb7*)(&fputil_DyadicFloat_kt2kd5.mantissa), 2L);
			InlineArray2_Int64* ptr5 = &bigInt_qdkjbh.val.Data;
			Struct_fiz2nb struct_fiz2nb8 = struct_fiz2nb7;
			((Struct_fiz2nb*)ptr5)->field_0 = struct_fiz2nb8.field_0;
			Struct_fiz2nb struct_fiz2nb9 = struct_fiz2nb7;
			((Struct_fiz2nb*)ptr5)->field_1 = struct_fiz2nb9.field_1;
			Struct_fiz2nb struct_fiz2nb10 = BigInt_128ul_false_unsigned_long_operator_unsigned_int128_unsigned_int128_const.Invoke((anon_izyfb7*)(&bigInt_qdkjbh));
			Int128* num7 = &int6;
			Struct_fiz2nb struct_fiz2nb11 = struct_fiz2nb10;
			*(long*)num7 = struct_fiz2nb11.field_0;
			byte* num8 = (byte*)(&int6) + 8u;
			Struct_fiz2nb struct_fiz2nb12 = struct_fiz2nb10;
			*(long*)num8 = struct_fiz2nb12.field_1;
			Int128 int9 = int6;
			llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh);
			x2 = int9;
			llvm_lifetime_start_p0.Invoke(16L, &y2);
			llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh2);
			Struct_fiz2nb struct_fiz2nb13 = BigInt_128ul_false_unsigned_long_operator_unsigned_long_const_99u38u.Invoke((anon_izyfb7*)(&fputil_DyadicFloat_kt2kd6.mantissa), 1L);
			InlineArray2_Int64* ptr6 = &bigInt_qdkjbh2.val.Data;
			Struct_fiz2nb struct_fiz2nb14 = struct_fiz2nb13;
			((Struct_fiz2nb*)ptr6)->field_0 = struct_fiz2nb14.field_0;
			Struct_fiz2nb struct_fiz2nb15 = struct_fiz2nb13;
			((Struct_fiz2nb*)ptr6)->field_1 = struct_fiz2nb15.field_1;
			Struct_fiz2nb struct_fiz2nb16 = BigInt_128ul_false_unsigned_long_operator_unsigned_int128_unsigned_int128_const.Invoke((anon_izyfb7*)(&bigInt_qdkjbh2));
			Int128* num9 = &int7;
			Struct_fiz2nb struct_fiz2nb17 = struct_fiz2nb16;
			*(long*)num9 = struct_fiz2nb17.field_0;
			byte* num10 = (byte*)(&int7) + 8u;
			Struct_fiz2nb struct_fiz2nb18 = struct_fiz2nb16;
			*(long*)num10 = struct_fiz2nb18.field_1;
			Int128 int10 = int7;
			llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh2);
			y2 = int10;
			llvm_lifetime_start_p0.Invoke(4L, &i);
			for (i = 0; i < 13; i = checked(i + 1))
			{
				int5 = NumericHelper.ShiftLeft(int5, 1L);
				x2 = NumericHelper.ShiftLeft(x2, 1L);
				if (NumericHelper.IntCmpUge(x2, y2))
				{
					int5 = NumericHelper.Add(int5, 1L);
					x2 = NumericHelper.Subtract(x2, y2);
				}
			}
			llvm_lifetime_end_p0.Invoke(4L, &i);
			llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd7);
			*(sbyte*)(&fputil_DyadicFloat_kt2kd7) = -86;
			sbyte* ptr7 = (sbyte*)(&fputil_DyadicFloat_kt2kd7) + 1;
			*ptr7 = -86;
			ptr7[1] = -86;
			ptr7[2] = -86;
			((int*)(&fputil_DyadicFloat_kt2kd7))[1] = -1431655766;
			sbyte* ptr8 = (sbyte*)(&fputil_DyadicFloat_kt2kd7) + 8;
			*(long*)ptr8 = -6148914691236517206L;
			((long*)ptr8)[1] = -6148914691236517206L;
			llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb20, &anon_izyfb8, 1L, isVolatile: false);
			int e = num2;
			int8 = int5;
			BigInt_128ul_false_unsigned_long_BigInt_unsigned_int128_void_unsigned_int128.Invoke((anon_izyfb7*)(&bigInt_qdkjbh3), *(long*)(&int8), ((long*)(&int8))[1]);
			fputil_DyadicFloat_128ul_DyadicFloat_Sign_int_BigInt_128ul_false_unsigned_long.Invoke(&fputil_DyadicFloat_kt2kd7, anon_izyfb20.val, e, *(long*)(&bigInt_qdkjbh3), ((long*)(&bigInt_qdkjbh3))[1]);
			llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh4);
			BigInt_128ul_false_unsigned_long_BigInt_unsigned_int_void_unsigned_int.Invoke((anon_izyfb7*)(&bigInt_qdkjbh4), NumericHelper.IntCmpNe(x2, 0L) ? 1 : 0);
			Struct_fiz2nb struct_fiz2nb19 = operator_BigInt_128ul_false_unsigned_long_BigInt_128ul_false_unsigned_long_const_wgy84t.Invoke((anon_izyfb7*)(&fputil_DyadicFloat_kt2kd7.mantissa), (anon_izyfb7*)(&bigInt_qdkjbh4));
			InlineArray2_Int64* ptr9 = &bigInt_qdkjbh5.val.Data;
			Struct_fiz2nb struct_fiz2nb20 = struct_fiz2nb19;
			((Struct_fiz2nb*)ptr9)->field_0 = struct_fiz2nb20.field_0;
			Struct_fiz2nb struct_fiz2nb21 = struct_fiz2nb19;
			((Struct_fiz2nb*)ptr9)->field_1 = struct_fiz2nb21.field_1;
			llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh4);
			result = Float16_fputil_DyadicFloat_128ul_as_Float16_true_void_const.Invoke(&fputil_DyadicFloat_kt2kd7);
			llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd7);
			llvm_lifetime_end_p0.Invoke(16L, &y2);
			llvm_lifetime_end_p0.Invoke(16L, &x2);
			llvm_lifetime_end_p0.Invoke(16L, &int5);
			llvm_lifetime_end_p0.Invoke(4L, &num2);
			llvm_lifetime_end_p0.Invoke(4L, &num);
			llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd6);
			llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd5);
			goto IL_0ca6;
		}
	}
}
