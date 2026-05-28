using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Generic_div_double_float128
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic3divIdgEENS_3cpp9enable_ifIXaaaasr3cppE19is_floating_point_vIT_Esr3cppE19is_floating_point_vIT0_ElestS5_stS6_ES5_E4typeES6_S6_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<double> && cpp::is_floating_point_v<__float128> && sizeof (double) <= sizeof (__float128), double>::type __llvm_libc_20_1_2_::fputil::generic::div<double, __float128>(__float128, __float128)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<double> && cpp::is_floating_point_v<__float128> && sizeof (double) <= sizeof (__float128), double>::type")]
	public unsafe static double Invoke([MangledName("x")][NativeType("__float128")] double X, [MangledName("y")][NativeType("__float128")] double Y)
	{
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi = default(Fputil_FPBits_ubgsi2);
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi2 = default(Fputil_FPBits_ubgsi2);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		Int128 @int = default(Int128);
		Int128 int2 = default(Int128);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm = default(Fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb4 = default(Anon_izyfb7);
		Int128 int3 = default(Int128);
		Int128 int4 = default(Int128);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(Fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb5 = default(Anon_izyfb7);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(Fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb6 = default(Anon_izyfb7);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm4 = default(Fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb7 = default(Anon_izyfb7);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm5 = default(Fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb8 = default(Anon_izyfb7);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm6 = default(Fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb9 = default(Anon_izyfb7);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm7 = default(Fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb10 = default(Anon_izyfb7);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm8 = default(Fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb11 = default(Anon_izyfb7);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm9 = default(Fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb12 = default(Anon_izyfb7);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd = default(Fputil_DyadicFloat_kt2kd4);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd2 = default(Fputil_DyadicFloat_kt2kd4);
		int num = 0;
		int num2 = 0;
		Int128 int5 = default(Int128);
		Int128 x = default(Int128);
		BigInt_qdkjbh bigInt_qdkjbh = default(BigInt_qdkjbh);
		Int128 int6 = default(Int128);
		Int128 y = default(Int128);
		BigInt_qdkjbh bigInt_qdkjbh2 = default(BigInt_qdkjbh);
		Int128 int7 = default(Int128);
		int i = 0;
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd3 = default(Fputil_DyadicFloat_kt2kd4);
		Anon_izyfb7 anon_izyfb13 = default(Anon_izyfb7);
		BigInt_qdkjbh bigInt_qdkjbh3 = default(BigInt_qdkjbh);
		Int128 int8 = default(Int128);
		BigInt_qdkjbh bigInt_qdkjbh4 = default(BigInt_qdkjbh);
		BigInt_qdkjbh bigInt_qdkjbh5 = default(BigInt_qdkjbh);
		Llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi);
		double result;
		unchecked
		{
			*(Int128*)(&fputil_FPBits_ubgsi) = -6148914691236517206L;
			FPBits_float128_Constructor.Invoke(&fputil_FPBits_ubgsi, X);
			Llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi2);
			*(Int128*)(&fputil_FPBits_ubgsi2) = -6148914691236517206L;
			FPBits_float128_Constructor.Invoke(&fputil_FPBits_ubgsi2, Y);
			Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb);
			*(sbyte*)(&anon_izyfb) = -86;
			anon_izyfb2.Val = FPStorage_fputil_FPType_3_sign.Invoke(&fputil_FPBits_ubgsi);
			anon_izyfb3.Val = FPStorage_fputil_FPType_3_sign.Invoke(&fputil_FPBits_ubgsi2);
			Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, (!Equals_fy8fvt.Invoke(anon_izyfb2.Val, anon_izyfb3.Val)) ? Sign_NEG.Pointer : Sign_POS.Pointer, 1L, isVolatile: false);
			if (!Details_expects_bool_condition_bool.Invoke(FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_is_inf_or_nan.Invoke(&fputil_FPBits_ubgsi) || FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_is_inf_or_nan.Invoke(&fputil_FPBits_ubgsi2) || FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_zero.Invoke((Fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi)) || FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_zero.Invoke((Fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi2)), Expected: false))
			{
				goto IL_07d2;
			}
			if (FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_nan.Invoke((Fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi)) || FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_nan.Invoke((Fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi2)))
			{
				if (FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_signaling_nan.Invoke((Fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi)) || FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_signaling_nan.Invoke((Fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi2)))
				{
					Fputil_raise_except_if_required.Invoke(1);
				}
				if (FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_quiet_nan.Invoke((Fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi)))
				{
					Llvm_lifetime_start_p0.Invoke(16L, &@int);
					Struct_fiz2nb struct_fiz2nb = FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_get_mantissa.Invoke(&fputil_FPBits_ubgsi);
					Int128* num3 = &int2;
					Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
					*(long*)num3 = struct_fiz2nb2.field_0;
					byte* num4 = (byte*)(&int2) + 8u;
					Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
					*(long*)num4 = struct_fiz2nb3.field_1;
					@int = int2;
					@int = NumericHelper.ShiftRightLogical(@int, 60L);
					Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
					anon_izyfb4.Val = FPStorage_fputil_FPType_3_sign.Invoke(&fputil_FPBits_ubgsi);
					long val = FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan.Invoke(V: (long)@int, Sign: anon_izyfb4.Val);
					fputil_FPBits_wjhbrm.FPRepImpl.FPRepSem.FPStorage.Val = val;
					result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm);
					Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
					Llvm_lifetime_end_p0.Invoke(16L, &@int);
				}
				else if (FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_quiet_nan.Invoke((Fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi2)))
				{
					Llvm_lifetime_start_p0.Invoke(16L, &int3);
					Struct_fiz2nb struct_fiz2nb4 = FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_get_mantissa.Invoke(&fputil_FPBits_ubgsi2);
					Int128* num5 = &int4;
					Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
					*(long*)num5 = struct_fiz2nb5.field_0;
					byte* num6 = (byte*)(&int4) + 8u;
					Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
					*(long*)num6 = struct_fiz2nb6.field_1;
					int3 = int4;
					int3 = NumericHelper.ShiftRightLogical(int3, 60L);
					Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
					anon_izyfb5.Val = FPStorage_fputil_FPType_3_sign.Invoke(&fputil_FPBits_ubgsi2);
					long val2 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan.Invoke(V: (long)int3, Sign: anon_izyfb5.Val);
					fputil_FPBits_wjhbrm2.FPRepImpl.FPRepSem.FPStorage.Val = val2;
					result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm2);
					Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
					Llvm_lifetime_end_p0.Invoke(16L, &int3);
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb6, Sign_POS.Pointer, 1L, isVolatile: false);
					long val3 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan.Invoke(anon_izyfb6.Val, 0L);
					fputil_FPBits_wjhbrm3.FPRepImpl.FPRepSem.FPStorage.Val = val3;
					result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm3);
					Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
				}
			}
			else if (FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_inf.Invoke((Fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi)))
			{
				if (FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_inf.Invoke((Fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi2)))
				{
					Fputil_set_errno_if_required.Invoke(33);
					Fputil_raise_except_if_required.Invoke(1);
					Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb7, Sign_POS.Pointer, 1L, isVolatile: false);
					long val4 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan.Invoke(anon_izyfb7.Val, 0L);
					fputil_FPBits_wjhbrm4.FPRepImpl.FPRepSem.FPStorage.Val = val4;
					result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm4);
					Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, &anon_izyfb, 1L, isVolatile: false);
					long val5 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_inf.Invoke(anon_izyfb8.Val);
					fputil_FPBits_wjhbrm5.FPRepImpl.FPRepSem.FPStorage.Val = val5;
					result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm5);
					Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
				}
			}
			else if (FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_inf.Invoke((Fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi2)))
			{
				Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm6);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, &anon_izyfb, 1L, isVolatile: false);
				long val6 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_inf.Invoke(anon_izyfb9.Val);
				fputil_FPBits_wjhbrm6.FPRepImpl.FPRepSem.FPStorage.Val = val6;
				result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm6);
				Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm6);
			}
			else if (FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_zero.Invoke((Fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi2)))
			{
				if (FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_zero.Invoke((Fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi)))
				{
					Fputil_raise_except_if_required.Invoke(1);
					Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm7);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb10, Sign_POS.Pointer, 1L, isVolatile: false);
					long val7 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan.Invoke(anon_izyfb10.Val, 0L);
					fputil_FPBits_wjhbrm7.FPRepImpl.FPRepSem.FPStorage.Val = val7;
					result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm7);
					Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm7);
				}
				else
				{
					Fputil_raise_except_if_required.Invoke(4);
					Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm8);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb11, &anon_izyfb, 1L, isVolatile: false);
					long val8 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_inf.Invoke(anon_izyfb11.Val);
					fputil_FPBits_wjhbrm8.FPRepImpl.FPRepSem.FPStorage.Val = val8;
					result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm8);
					Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm8);
				}
			}
			else
			{
				if (!FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_zero.Invoke((Fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi)))
				{
					goto IL_07d2;
				}
				Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm9);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb12, &anon_izyfb, 1L, isVolatile: false);
				long val9 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_zero.Invoke(anon_izyfb12.Val);
				fputil_FPBits_wjhbrm9.FPRepImpl.FPRepSem.FPStorage.Val = val9;
				result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm9);
				Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm9);
			}
			goto IL_0cc3;
		}
		IL_0cc3:
		Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb);
		Llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi2);
		Llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi);
		return result;
		IL_07d2:
		Llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd);
		unchecked
		{
			*(sbyte*)(&fputil_DyadicFloat_kt2kd) = -86;
			sbyte* ptr = (sbyte*)(&fputil_DyadicFloat_kt2kd) + 1;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			((int*)(&fputil_DyadicFloat_kt2kd))[1] = -1431655766;
			sbyte* ptr2 = (sbyte*)(&fputil_DyadicFloat_kt2kd) + 8;
			*(long*)ptr2 = -6148914691236517206L;
			((long*)ptr2)[1] = -6148914691236517206L;
			DyadicFloat_128ul_DyadicFloat_float128_0.Invoke(&fputil_DyadicFloat_kt2kd, X);
			Llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd2);
			*(sbyte*)(&fputil_DyadicFloat_kt2kd2) = -86;
			sbyte* ptr3 = (sbyte*)(&fputil_DyadicFloat_kt2kd2) + 1;
			*ptr3 = -86;
			ptr3[1] = -86;
			ptr3[2] = -86;
			((int*)(&fputil_DyadicFloat_kt2kd2))[1] = -1431655766;
			sbyte* ptr4 = (sbyte*)(&fputil_DyadicFloat_kt2kd2) + 8;
			*(long*)ptr4 = -6148914691236517206L;
			((long*)ptr4)[1] = -6148914691236517206L;
			DyadicFloat_128ul_DyadicFloat_float128_0.Invoke(&fputil_DyadicFloat_kt2kd2, Y);
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = 55;
			Llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = checked(fputil_DyadicFloat_kt2kd.Exponent - fputil_DyadicFloat_kt2kd2.Exponent - 54);
			Llvm_lifetime_start_p0.Invoke(16L, &int5);
			int5 = 0L;
			Llvm_lifetime_start_p0.Invoke(16L, &x);
			Llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh);
			Struct_fiz2nb struct_fiz2nb7 = BigInt_128ul_false_unsigned_long_RightShift.Invoke((Anon_izyfb7*)(&fputil_DyadicFloat_kt2kd.Mantissa), 2L);
			InlineArray2_Int64* ptr5 = &bigInt_qdkjbh.Val.Data;
			Struct_fiz2nb struct_fiz2nb8 = struct_fiz2nb7;
			((Struct_fiz2nb*)ptr5)->field_0 = struct_fiz2nb8.field_0;
			Struct_fiz2nb struct_fiz2nb9 = struct_fiz2nb7;
			((Struct_fiz2nb*)ptr5)->field_1 = struct_fiz2nb9.field_1;
			Struct_fiz2nb struct_fiz2nb10 = BigInt_128ul_false_unsigned_long_Unsigned_int128_unsigned_int128.Invoke((Anon_izyfb7*)(&bigInt_qdkjbh));
			Int128* num7 = &int6;
			Struct_fiz2nb struct_fiz2nb11 = struct_fiz2nb10;
			*(long*)num7 = struct_fiz2nb11.field_0;
			byte* num8 = (byte*)(&int6) + 8u;
			Struct_fiz2nb struct_fiz2nb12 = struct_fiz2nb10;
			*(long*)num8 = struct_fiz2nb12.field_1;
			Int128 int9 = int6;
			Llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh);
			x = int9;
			Llvm_lifetime_start_p0.Invoke(16L, &y);
			Llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh2);
			Struct_fiz2nb struct_fiz2nb13 = BigInt_128ul_false_unsigned_long_RightShift.Invoke((Anon_izyfb7*)(&fputil_DyadicFloat_kt2kd2.Mantissa), 1L);
			InlineArray2_Int64* ptr6 = &bigInt_qdkjbh2.Val.Data;
			Struct_fiz2nb struct_fiz2nb14 = struct_fiz2nb13;
			((Struct_fiz2nb*)ptr6)->field_0 = struct_fiz2nb14.field_0;
			Struct_fiz2nb struct_fiz2nb15 = struct_fiz2nb13;
			((Struct_fiz2nb*)ptr6)->field_1 = struct_fiz2nb15.field_1;
			Struct_fiz2nb struct_fiz2nb16 = BigInt_128ul_false_unsigned_long_Unsigned_int128_unsigned_int128.Invoke((Anon_izyfb7*)(&bigInt_qdkjbh2));
			Int128* num9 = &int7;
			Struct_fiz2nb struct_fiz2nb17 = struct_fiz2nb16;
			*(long*)num9 = struct_fiz2nb17.field_0;
			byte* num10 = (byte*)(&int7) + 8u;
			Struct_fiz2nb struct_fiz2nb18 = struct_fiz2nb16;
			*(long*)num10 = struct_fiz2nb18.field_1;
			Int128 int10 = int7;
			Llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh2);
			y = int10;
			Llvm_lifetime_start_p0.Invoke(4L, &i);
			for (i = 0; i < 55; i = checked(i + 1))
			{
				int5 = NumericHelper.ShiftLeft(int5, 1L);
				x = NumericHelper.ShiftLeft(x, 1L);
				if (NumericHelper.IntCmpUge(x, y))
				{
					int5 = NumericHelper.Add(int5, 1L);
					x = NumericHelper.Subtract(x, y);
				}
			}
			Llvm_lifetime_end_p0.Invoke(4L, &i);
			Llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd3);
			*(sbyte*)(&fputil_DyadicFloat_kt2kd3) = -86;
			sbyte* ptr7 = (sbyte*)(&fputil_DyadicFloat_kt2kd3) + 1;
			*ptr7 = -86;
			ptr7[1] = -86;
			ptr7[2] = -86;
			((int*)(&fputil_DyadicFloat_kt2kd3))[1] = -1431655766;
			sbyte* ptr8 = (sbyte*)(&fputil_DyadicFloat_kt2kd3) + 8;
			*(long*)ptr8 = -6148914691236517206L;
			((long*)ptr8)[1] = -6148914691236517206L;
			Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb13, &anon_izyfb, 1L, isVolatile: false);
			int e = num2;
			int8 = int5;
			BigInt_128ul_false_unsigned_long_BigInt_unsigned_int128_void.Invoke((Anon_izyfb7*)(&bigInt_qdkjbh3), *(long*)(&int8), ((long*)(&int8))[1]);
			DyadicFloat_128ul_Constructor.Invoke(&fputil_DyadicFloat_kt2kd3, anon_izyfb13.Val, e, *(long*)(&bigInt_qdkjbh3), ((long*)(&bigInt_qdkjbh3))[1]);
			Llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh4);
			BigInt_128ul_false_unsigned_long_BigInt_unsigned_int_void.Invoke((Anon_izyfb7*)(&bigInt_qdkjbh4), NumericHelper.IntCmpNe(x, 0L) ? 1 : 0);
			Struct_fiz2nb struct_fiz2nb19 = Operator_66fhg9.Invoke((Anon_izyfb7*)(&fputil_DyadicFloat_kt2kd3.Mantissa), (Anon_izyfb7*)(&bigInt_qdkjbh4));
			InlineArray2_Int64* ptr9 = &bigInt_qdkjbh5.Val.Data;
			Struct_fiz2nb struct_fiz2nb20 = struct_fiz2nb19;
			((Struct_fiz2nb*)ptr9)->field_0 = struct_fiz2nb20.field_0;
			Struct_fiz2nb struct_fiz2nb21 = struct_fiz2nb19;
			((Struct_fiz2nb*)ptr9)->field_1 = struct_fiz2nb21.field_1;
			Llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh4);
			result = DyadicFloat_128ul_as_double_true_void.Invoke(&fputil_DyadicFloat_kt2kd3);
			Llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd3);
			Llvm_lifetime_end_p0.Invoke(16L, &y);
			Llvm_lifetime_end_p0.Invoke(16L, &x);
			Llvm_lifetime_end_p0.Invoke(16L, &int5);
			Llvm_lifetime_end_p0.Invoke(4L, &num2);
			Llvm_lifetime_end_p0.Invoke(4L, &num);
			Llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd2);
			Llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd);
			goto IL_0cc3;
		}
	}
}
