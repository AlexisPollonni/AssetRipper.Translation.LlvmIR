using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class generic_div_double_float128
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic3divIdgEENS_3cpp9enable_ifIXaaaasr3cppE19is_floating_point_vIT_Esr3cppE19is_floating_point_vIT0_ElestS5_stS6_ES5_E4typeES6_S6_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<double> && cpp::is_floating_point_v<__float128> && sizeof (double) <= sizeof (__float128), double>::type __llvm_libc_20_1_2_::fputil::generic::div<double, __float128>(__float128, __float128)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<double> && cpp::is_floating_point_v<__float128> && sizeof (double) <= sizeof (__float128), double>::type")]
	public unsafe static double Invoke([NativeType("__float128")] double x, [NativeType("__float128")] double y)
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
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm10 = default(fputil_FPBits_wjhbrm);
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
		double result;
		unchecked
		{
			*(Int128*)(&fputil_FPBits_ubgsi3) = -6148914691236517206L;
			FPBits_float128_Constructor.Invoke(&fputil_FPBits_ubgsi3, x);
			llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
			*(Int128*)(&fputil_FPBits_ubgsi4) = -6148914691236517206L;
			FPBits_float128_Constructor.Invoke(&fputil_FPBits_ubgsi4, y);
			llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb8);
			*(sbyte*)(&anon_izyfb8) = -86;
			anon_izyfb9.val = FPStorage_fputil_FPType_3_sign.Invoke(&fputil_FPBits_ubgsi3);
			anon_izyfb10.val = FPStorage_fputil_FPType_3_sign.Invoke(&fputil_FPBits_ubgsi4);
			llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, (!Equals_fy8fvt.Invoke(anon_izyfb9.val, anon_izyfb10.val)) ? Sign_NEG.Pointer : Sign_POS.Pointer, 1L, isVolatile: false);
			if (!details_expects_bool_condition_bool.Invoke(FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_is_inf_or_nan.Invoke(&fputil_FPBits_ubgsi3) ? true : (FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_is_inf_or_nan.Invoke(&fputil_FPBits_ubgsi4) ? true : ((!FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_zero.Invoke((fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi3))) ? FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_zero.Invoke((fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi4)) : true)), expected: false))
			{
				goto IL_07d2;
			}
			if (FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_nan.Invoke((fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi3)) || FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_nan.Invoke((fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi4)))
			{
				if (FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_signaling_nan.Invoke((fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi3)) || FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_signaling_nan.Invoke((fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi4)))
				{
					fputil_raise_except_if_required.Invoke(1);
				}
				if (FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_quiet_nan.Invoke((fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi3)))
				{
					llvm_lifetime_start_p0.Invoke(16L, &@int);
					Struct_fiz2nb struct_fiz2nb = FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_get_mantissa.Invoke(&fputil_FPBits_ubgsi3);
					Int128* num3 = &int2;
					Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
					*(long*)num3 = struct_fiz2nb2.field_0;
					byte* num4 = (byte*)(&int2) + 8u;
					Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
					*(long*)num4 = struct_fiz2nb3.field_1;
					@int = int2;
					@int = NumericHelper.ShiftRightLogical(@int, 60L);
					llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
					anon_izyfb11.val = FPStorage_fputil_FPType_3_sign.Invoke(&fputil_FPBits_ubgsi3);
					long val = FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan.Invoke(v: (long)@int, sign: anon_izyfb11.val);
					fputil_FPBits_wjhbrm2.FPRepImpl.FPRepSem.FPStorage.val = val;
					result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm2);
					llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
					llvm_lifetime_end_p0.Invoke(16L, &@int);
				}
				else if (FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_quiet_nan.Invoke((fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi4)))
				{
					llvm_lifetime_start_p0.Invoke(16L, &int3);
					Struct_fiz2nb struct_fiz2nb4 = FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_get_mantissa.Invoke(&fputil_FPBits_ubgsi4);
					Int128* num5 = &int4;
					Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
					*(long*)num5 = struct_fiz2nb5.field_0;
					byte* num6 = (byte*)(&int4) + 8u;
					Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
					*(long*)num6 = struct_fiz2nb6.field_1;
					int3 = int4;
					int3 = NumericHelper.ShiftRightLogical(int3, 60L);
					llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
					anon_izyfb12.val = FPStorage_fputil_FPType_3_sign.Invoke(&fputil_FPBits_ubgsi4);
					long val2 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan.Invoke(v: (long)int3, sign: anon_izyfb12.val);
					fputil_FPBits_wjhbrm3.FPRepImpl.FPRepSem.FPStorage.val = val2;
					result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm3);
					llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
					llvm_lifetime_end_p0.Invoke(16L, &int3);
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb13, Sign_POS.Pointer, 1L, isVolatile: false);
					long val3 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan.Invoke(anon_izyfb13.val, 0L);
					fputil_FPBits_wjhbrm4.FPRepImpl.FPRepSem.FPStorage.val = val3;
					result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm4);
					llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
				}
			}
			else if (FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_inf.Invoke((fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi3)))
			{
				if (FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_inf.Invoke((fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi4)))
				{
					fputil_set_errno_if_required.Invoke(33);
					fputil_raise_except_if_required.Invoke(1);
					llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb14, Sign_POS.Pointer, 1L, isVolatile: false);
					long val4 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan.Invoke(anon_izyfb14.val, 0L);
					fputil_FPBits_wjhbrm5.FPRepImpl.FPRepSem.FPStorage.val = val4;
					result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm5);
					llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm6);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb15, &anon_izyfb8, 1L, isVolatile: false);
					long val5 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_inf.Invoke(anon_izyfb15.val);
					fputil_FPBits_wjhbrm6.FPRepImpl.FPRepSem.FPStorage.val = val5;
					result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm6);
					llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm6);
				}
			}
			else if (FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_inf.Invoke((fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi4)))
			{
				llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm7);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb16, &anon_izyfb8, 1L, isVolatile: false);
				long val6 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_inf.Invoke(anon_izyfb16.val);
				fputil_FPBits_wjhbrm7.FPRepImpl.FPRepSem.FPStorage.val = val6;
				result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm7);
				llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm7);
			}
			else if (FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_zero.Invoke((fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi4)))
			{
				if (FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_zero.Invoke((fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi3)))
				{
					fputil_raise_except_if_required.Invoke(1);
					llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm8);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb17, Sign_POS.Pointer, 1L, isVolatile: false);
					long val7 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan.Invoke(anon_izyfb17.val, 0L);
					fputil_FPBits_wjhbrm8.FPRepImpl.FPRepSem.FPStorage.val = val7;
					result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm8);
					llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm8);
				}
				else
				{
					fputil_raise_except_if_required.Invoke(4);
					llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm9);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb18, &anon_izyfb8, 1L, isVolatile: false);
					long val8 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_inf.Invoke(anon_izyfb18.val);
					fputil_FPBits_wjhbrm9.FPRepImpl.FPRepSem.FPStorage.val = val8;
					result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm9);
					llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm9);
				}
			}
			else
			{
				if (!FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_zero.Invoke((fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi3)))
				{
					goto IL_07d2;
				}
				llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm10);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb19, &anon_izyfb8, 1L, isVolatile: false);
				long val9 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_zero.Invoke(anon_izyfb19.val);
				fputil_FPBits_wjhbrm10.FPRepImpl.FPRepSem.FPStorage.val = val9;
				result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm10);
				llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm10);
			}
			goto IL_0cc3;
		}
		IL_0cc3:
		llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb8);
		llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
		llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		return result;
		IL_07d2:
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
			DyadicFloat_128ul_DyadicFloat_float128_0.Invoke(&fputil_DyadicFloat_kt2kd5, x);
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
			DyadicFloat_128ul_DyadicFloat_float128_0.Invoke(&fputil_DyadicFloat_kt2kd6, y);
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = 55;
			llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = checked(fputil_DyadicFloat_kt2kd5.exponent - fputil_DyadicFloat_kt2kd6.exponent - 54);
			llvm_lifetime_start_p0.Invoke(16L, &int5);
			int5 = 0L;
			llvm_lifetime_start_p0.Invoke(16L, &x2);
			llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh);
			Struct_fiz2nb struct_fiz2nb7 = BigInt_128ul_false_unsigned_long_RightShift.Invoke((anon_izyfb7*)(&fputil_DyadicFloat_kt2kd5.mantissa), 2L);
			InlineArray2_Int64* ptr5 = &bigInt_qdkjbh.val.Data;
			Struct_fiz2nb struct_fiz2nb8 = struct_fiz2nb7;
			((Struct_fiz2nb*)ptr5)->field_0 = struct_fiz2nb8.field_0;
			Struct_fiz2nb struct_fiz2nb9 = struct_fiz2nb7;
			((Struct_fiz2nb*)ptr5)->field_1 = struct_fiz2nb9.field_1;
			Struct_fiz2nb struct_fiz2nb10 = BigInt_128ul_false_unsigned_long_unsigned_int128_unsigned_int128.Invoke((anon_izyfb7*)(&bigInt_qdkjbh));
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
			Struct_fiz2nb struct_fiz2nb13 = BigInt_128ul_false_unsigned_long_RightShift.Invoke((anon_izyfb7*)(&fputil_DyadicFloat_kt2kd6.mantissa), 1L);
			InlineArray2_Int64* ptr6 = &bigInt_qdkjbh2.val.Data;
			Struct_fiz2nb struct_fiz2nb14 = struct_fiz2nb13;
			((Struct_fiz2nb*)ptr6)->field_0 = struct_fiz2nb14.field_0;
			Struct_fiz2nb struct_fiz2nb15 = struct_fiz2nb13;
			((Struct_fiz2nb*)ptr6)->field_1 = struct_fiz2nb15.field_1;
			Struct_fiz2nb struct_fiz2nb16 = BigInt_128ul_false_unsigned_long_unsigned_int128_unsigned_int128.Invoke((anon_izyfb7*)(&bigInt_qdkjbh2));
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
			for (i = 0; i < 55; i = checked(i + 1))
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
			BigInt_128ul_false_unsigned_long_BigInt_unsigned_int128_void.Invoke((anon_izyfb7*)(&bigInt_qdkjbh3), *(long*)(&int8), ((long*)(&int8))[1]);
			DyadicFloat_128ul_Constructor.Invoke(&fputil_DyadicFloat_kt2kd7, anon_izyfb20.val, e, *(long*)(&bigInt_qdkjbh3), ((long*)(&bigInt_qdkjbh3))[1]);
			llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh4);
			BigInt_128ul_false_unsigned_long_BigInt_unsigned_int_void.Invoke((anon_izyfb7*)(&bigInt_qdkjbh4), NumericHelper.IntCmpNe(x2, 0L) ? 1 : 0);
			Struct_fiz2nb struct_fiz2nb19 = Operator_66fhg9.Invoke((anon_izyfb7*)(&fputil_DyadicFloat_kt2kd7.mantissa), (anon_izyfb7*)(&bigInt_qdkjbh4));
			InlineArray2_Int64* ptr9 = &bigInt_qdkjbh5.val.Data;
			Struct_fiz2nb struct_fiz2nb20 = struct_fiz2nb19;
			((Struct_fiz2nb*)ptr9)->field_0 = struct_fiz2nb20.field_0;
			Struct_fiz2nb struct_fiz2nb21 = struct_fiz2nb19;
			((Struct_fiz2nb*)ptr9)->field_1 = struct_fiz2nb21.field_1;
			llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh4);
			result = DyadicFloat_128ul_as_double_true_void.Invoke(&fputil_DyadicFloat_kt2kd7);
			llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd7);
			llvm_lifetime_end_p0.Invoke(16L, &y2);
			llvm_lifetime_end_p0.Invoke(16L, &x2);
			llvm_lifetime_end_p0.Invoke(16L, &int5);
			llvm_lifetime_end_p0.Invoke(4L, &num2);
			llvm_lifetime_end_p0.Invoke(4L, &num);
			llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd6);
			llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd5);
			goto IL_0cc3;
		}
	}
}
