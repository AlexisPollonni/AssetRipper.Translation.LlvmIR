using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Generic_mul_double_long_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic3mulIdeEENS_3cpp9enable_ifIXaaaasr3cppE19is_floating_point_vIT_Esr3cppE19is_floating_point_vIT0_ElestS5_stS6_ES5_E4typeES6_S6_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<double> && cpp::is_floating_point_v<long double> && sizeof (double) <= sizeof (long double), double>::type __llvm_libc_20_1_2_::fputil::generic::mul<double, long double>(long double, long double)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<double> && cpp::is_floating_point_v<long double> && sizeof (double) <= sizeof (long double), double>::type")]
	public unsafe static double Invoke([MangledName("x")][NativeType("long double")] double X, [MangledName("y")][NativeType("long double")] double Y)
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
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd = default(Fputil_DyadicFloat_kt2kd4);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd2 = default(Fputil_DyadicFloat_kt2kd4);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd3 = default(Fputil_DyadicFloat_kt2kd4);
		Llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi);
		unchecked
		{
			*(Int128*)(&fputil_FPBits_ubgsi) = -6148914691236517206L;
			FPBits_long_double_Constructor.Invoke(&fputil_FPBits_ubgsi, X);
			Llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi2);
			*(Int128*)(&fputil_FPBits_ubgsi2) = -6148914691236517206L;
			FPBits_long_double_Constructor.Invoke(&fputil_FPBits_ubgsi2, Y);
			Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb);
			*(sbyte*)(&anon_izyfb) = -86;
			anon_izyfb2.Val = FPStorage_fputil_FPType_4_sign.Invoke(&fputil_FPBits_ubgsi);
			anon_izyfb3.Val = FPStorage_fputil_FPType_4_sign.Invoke(&fputil_FPBits_ubgsi2);
			Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, (!Equals_fy8fvt.Invoke(anon_izyfb2.Val, anon_izyfb3.Val)) ? Sign_NEG.Pointer : Sign_POS.Pointer, 1L, isVolatile: false);
			double result;
			if (Details_expects_bool_condition_bool.Invoke(FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_is_inf_or_nan.Invoke(&fputil_FPBits_ubgsi) || FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_is_inf_or_nan.Invoke(&fputil_FPBits_ubgsi2) || FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_zero.Invoke(&fputil_FPBits_ubgsi) || FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_zero.Invoke(&fputil_FPBits_ubgsi2), Expected: false))
			{
				if (FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_nan.Invoke(&fputil_FPBits_ubgsi) || FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_nan.Invoke(&fputil_FPBits_ubgsi2))
				{
					if (FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_signaling_nan.Invoke(&fputil_FPBits_ubgsi) || FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_signaling_nan.Invoke(&fputil_FPBits_ubgsi2))
					{
						Fputil_raise_except_if_required.Invoke(1);
					}
					if (FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_quiet_nan.Invoke(&fputil_FPBits_ubgsi))
					{
						Llvm_lifetime_start_p0.Invoke(16L, &@int);
						Struct_fiz2nb struct_fiz2nb = FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_mantissa.Invoke(&fputil_FPBits_ubgsi);
						Int128* num = &int2;
						Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
						*(long*)num = struct_fiz2nb2.field_0;
						byte* num2 = (byte*)(&int2) + 8u;
						Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
						*(long*)num2 = struct_fiz2nb3.field_1;
						@int = int2;
						@int = NumericHelper.ShiftRightLogical(@int, 11L);
						Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
						anon_izyfb4.Val = FPStorage_fputil_FPType_4_sign.Invoke(&fputil_FPBits_ubgsi);
						long val = FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan.Invoke(V: (long)@int, Sign: anon_izyfb4.Val);
						fputil_FPBits_wjhbrm.FPRepImpl.FPRepSem.FPStorage.Val = val;
						result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm);
						Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
						Llvm_lifetime_end_p0.Invoke(16L, &@int);
					}
					else if (FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_quiet_nan.Invoke(&fputil_FPBits_ubgsi2))
					{
						Llvm_lifetime_start_p0.Invoke(16L, &int3);
						Struct_fiz2nb struct_fiz2nb4 = FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_mantissa.Invoke(&fputil_FPBits_ubgsi2);
						Int128* num3 = &int4;
						Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
						*(long*)num3 = struct_fiz2nb5.field_0;
						byte* num4 = (byte*)(&int4) + 8u;
						Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
						*(long*)num4 = struct_fiz2nb6.field_1;
						int3 = int4;
						int3 = NumericHelper.ShiftRightLogical(int3, 11L);
						Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
						anon_izyfb5.Val = FPStorage_fputil_FPType_4_sign.Invoke(&fputil_FPBits_ubgsi2);
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
				else if (FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_inf.Invoke(&fputil_FPBits_ubgsi))
				{
					if (FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_zero.Invoke(&fputil_FPBits_ubgsi2))
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
				else if (FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_inf.Invoke(&fputil_FPBits_ubgsi2))
				{
					if (FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_zero.Invoke(&fputil_FPBits_ubgsi))
					{
						Fputil_set_errno_if_required.Invoke(33);
						Fputil_raise_except_if_required.Invoke(1);
						Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm6);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, Sign_POS.Pointer, 1L, isVolatile: false);
						long val6 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan.Invoke(anon_izyfb9.Val, 0L);
						fputil_FPBits_wjhbrm6.FPRepImpl.FPRepSem.FPStorage.Val = val6;
						result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm6);
						Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm6);
					}
					else
					{
						Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm7);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb10, &anon_izyfb, 1L, isVolatile: false);
						long val7 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_inf.Invoke(anon_izyfb10.Val);
						fputil_FPBits_wjhbrm7.FPRepImpl.FPRepSem.FPStorage.Val = val7;
						result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm7);
						Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm7);
					}
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm8);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb11, &anon_izyfb, 1L, isVolatile: false);
					long val8 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_zero.Invoke(anon_izyfb11.Val);
					fputil_FPBits_wjhbrm8.FPRepImpl.FPRepSem.FPStorage.Val = val8;
					result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm8);
					Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm8);
				}
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd);
				*(sbyte*)(&fputil_DyadicFloat_kt2kd) = -86;
				sbyte* ptr = (sbyte*)(&fputil_DyadicFloat_kt2kd) + 1;
				*ptr = -86;
				ptr[1] = -86;
				ptr[2] = -86;
				((int*)(&fputil_DyadicFloat_kt2kd))[1] = -1431655766;
				sbyte* ptr2 = (sbyte*)(&fputil_DyadicFloat_kt2kd) + 8;
				*(long*)ptr2 = -6148914691236517206L;
				((long*)ptr2)[1] = -6148914691236517206L;
				DyadicFloat_128ul_DyadicFloat_long_double_0.Invoke(&fputil_DyadicFloat_kt2kd, X);
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
				DyadicFloat_128ul_DyadicFloat_long_double_0.Invoke(&fputil_DyadicFloat_kt2kd2, Y);
				Llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd3);
				*(sbyte*)(&fputil_DyadicFloat_kt2kd3) = -86;
				sbyte* ptr5 = (sbyte*)(&fputil_DyadicFloat_kt2kd3) + 1;
				*ptr5 = -86;
				ptr5[1] = -86;
				ptr5[2] = -86;
				((int*)(&fputil_DyadicFloat_kt2kd3))[1] = -1431655766;
				sbyte* ptr6 = (sbyte*)(&fputil_DyadicFloat_kt2kd3) + 8;
				*(long*)ptr6 = -6148914691236517206L;
				((long*)ptr6)[1] = -6148914691236517206L;
				Fputil_quick_mul_128ul.Invoke(&fputil_DyadicFloat_kt2kd3, &fputil_DyadicFloat_kt2kd, &fputil_DyadicFloat_kt2kd2);
				result = DyadicFloat_128ul_as_double_true_void.Invoke(&fputil_DyadicFloat_kt2kd3);
				Llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd3);
				Llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd2);
				Llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd);
			}
			Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb);
			Llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi2);
			Llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi);
			return result;
		}
	}
}
