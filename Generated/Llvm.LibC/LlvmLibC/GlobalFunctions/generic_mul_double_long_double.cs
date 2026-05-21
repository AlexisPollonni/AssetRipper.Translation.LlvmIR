using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class generic_mul_double_long_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic3mulIdeEENS_3cpp9enable_ifIXaaaasr3cppE19is_floating_point_vIT_Esr3cppE19is_floating_point_vIT0_ElestS5_stS6_ES5_E4typeES6_S6_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<double> && cpp::is_floating_point_v<long double> && sizeof (double) <= sizeof (long double), double>::type __llvm_libc_20_1_2_::fputil::generic::mul<double, long double>(long double, long double)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<double> && cpp::is_floating_point_v<long double> && sizeof (double) <= sizeof (long double), double>::type")]
	public unsafe static double Invoke([NativeType("long double")] double x, [NativeType("long double")] double y)
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
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd5 = default(fputil_DyadicFloat_kt2kd4);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd6 = default(fputil_DyadicFloat_kt2kd4);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd7 = default(fputil_DyadicFloat_kt2kd4);
		llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		unchecked
		{
			*(Int128*)(&fputil_FPBits_ubgsi3) = -6148914691236517206L;
			FPBits_long_double_Constructor.Invoke(&fputil_FPBits_ubgsi3, x);
			llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
			*(Int128*)(&fputil_FPBits_ubgsi4) = -6148914691236517206L;
			FPBits_long_double_Constructor.Invoke(&fputil_FPBits_ubgsi4, y);
			llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb8);
			*(sbyte*)(&anon_izyfb8) = -86;
			anon_izyfb9.val = FPStorage_fputil_FPType_4_sign.Invoke(&fputil_FPBits_ubgsi3);
			anon_izyfb10.val = FPStorage_fputil_FPType_4_sign.Invoke(&fputil_FPBits_ubgsi4);
			llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, (!Equals_fy8fvt.Invoke(anon_izyfb9.val, anon_izyfb10.val)) ? Sign_NEG.Pointer : Sign_POS.Pointer, 1L, isVolatile: false);
			double result;
			if (details_expects_bool_condition_bool.Invoke(FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_is_inf_or_nan.Invoke(&fputil_FPBits_ubgsi3) ? true : (FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_is_inf_or_nan.Invoke(&fputil_FPBits_ubgsi4) ? true : ((!FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_zero.Invoke(&fputil_FPBits_ubgsi3)) ? FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_zero.Invoke(&fputil_FPBits_ubgsi4) : true)), expected: false))
			{
				if (FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_nan.Invoke(&fputil_FPBits_ubgsi3) || FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_nan.Invoke(&fputil_FPBits_ubgsi4))
				{
					if (FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_signaling_nan.Invoke(&fputil_FPBits_ubgsi3) || FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_signaling_nan.Invoke(&fputil_FPBits_ubgsi4))
					{
						fputil_raise_except_if_required.Invoke(1);
					}
					if (FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_quiet_nan.Invoke(&fputil_FPBits_ubgsi3))
					{
						llvm_lifetime_start_p0.Invoke(16L, &@int);
						Struct_fiz2nb struct_fiz2nb = FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_mantissa.Invoke(&fputil_FPBits_ubgsi3);
						Int128* num = &int2;
						Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
						*(long*)num = struct_fiz2nb2.field_0;
						byte* num2 = (byte*)(&int2) + 8u;
						Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
						*(long*)num2 = struct_fiz2nb3.field_1;
						@int = int2;
						@int = NumericHelper.ShiftRightLogical(@int, 11L);
						llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
						anon_izyfb11.val = FPStorage_fputil_FPType_4_sign.Invoke(&fputil_FPBits_ubgsi3);
						long val = FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan.Invoke(v: (long)@int, sign: anon_izyfb11.val);
						fputil_FPBits_wjhbrm2.FPRepImpl.FPRepSem.FPStorage.val = val;
						result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm2);
						llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
						llvm_lifetime_end_p0.Invoke(16L, &@int);
					}
					else if (FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_quiet_nan.Invoke(&fputil_FPBits_ubgsi4))
					{
						llvm_lifetime_start_p0.Invoke(16L, &int3);
						Struct_fiz2nb struct_fiz2nb4 = FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_mantissa.Invoke(&fputil_FPBits_ubgsi4);
						Int128* num3 = &int4;
						Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
						*(long*)num3 = struct_fiz2nb5.field_0;
						byte* num4 = (byte*)(&int4) + 8u;
						Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
						*(long*)num4 = struct_fiz2nb6.field_1;
						int3 = int4;
						int3 = NumericHelper.ShiftRightLogical(int3, 11L);
						llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
						anon_izyfb12.val = FPStorage_fputil_FPType_4_sign.Invoke(&fputil_FPBits_ubgsi4);
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
				else if (FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_inf.Invoke(&fputil_FPBits_ubgsi3))
				{
					if (FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_zero.Invoke(&fputil_FPBits_ubgsi4))
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
				else if (FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_inf.Invoke(&fputil_FPBits_ubgsi4))
				{
					if (FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_zero.Invoke(&fputil_FPBits_ubgsi3))
					{
						fputil_set_errno_if_required.Invoke(33);
						fputil_raise_except_if_required.Invoke(1);
						llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm7);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb16, Sign_POS.Pointer, 1L, isVolatile: false);
						long val6 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan.Invoke(anon_izyfb16.val, 0L);
						fputil_FPBits_wjhbrm7.FPRepImpl.FPRepSem.FPStorage.val = val6;
						result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm7);
						llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm7);
					}
					else
					{
						llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm8);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb17, &anon_izyfb8, 1L, isVolatile: false);
						long val7 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_inf.Invoke(anon_izyfb17.val);
						fputil_FPBits_wjhbrm8.FPRepImpl.FPRepSem.FPStorage.val = val7;
						result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm8);
						llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm8);
					}
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm9);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb18, &anon_izyfb8, 1L, isVolatile: false);
					long val8 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_zero.Invoke(anon_izyfb18.val);
					fputil_FPBits_wjhbrm9.FPRepImpl.FPRepSem.FPStorage.val = val8;
					result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm9);
					llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm9);
				}
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd5);
				*(sbyte*)(&fputil_DyadicFloat_kt2kd5) = -86;
				sbyte* ptr = (sbyte*)(&fputil_DyadicFloat_kt2kd5) + 1;
				*ptr = -86;
				ptr[1] = -86;
				ptr[2] = -86;
				((int*)(&fputil_DyadicFloat_kt2kd5))[1] = -1431655766;
				sbyte* ptr2 = (sbyte*)(&fputil_DyadicFloat_kt2kd5) + 8;
				*(long*)ptr2 = -6148914691236517206L;
				((long*)ptr2)[1] = -6148914691236517206L;
				DyadicFloat_128ul_DyadicFloat_long_double_0.Invoke(&fputil_DyadicFloat_kt2kd5, x);
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
				DyadicFloat_128ul_DyadicFloat_long_double_0.Invoke(&fputil_DyadicFloat_kt2kd6, y);
				llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd7);
				*(sbyte*)(&fputil_DyadicFloat_kt2kd7) = -86;
				sbyte* ptr5 = (sbyte*)(&fputil_DyadicFloat_kt2kd7) + 1;
				*ptr5 = -86;
				ptr5[1] = -86;
				ptr5[2] = -86;
				((int*)(&fputil_DyadicFloat_kt2kd7))[1] = -1431655766;
				sbyte* ptr6 = (sbyte*)(&fputil_DyadicFloat_kt2kd7) + 8;
				*(long*)ptr6 = -6148914691236517206L;
				((long*)ptr6)[1] = -6148914691236517206L;
				fputil_quick_mul_128ul.Invoke(&fputil_DyadicFloat_kt2kd7, &fputil_DyadicFloat_kt2kd5, &fputil_DyadicFloat_kt2kd6);
				result = DyadicFloat_128ul_as_double_true_void.Invoke(&fputil_DyadicFloat_kt2kd7);
				llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd7);
				llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd6);
				llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd5);
			}
			llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb8);
			llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
			llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
			return result;
		}
	}
}
