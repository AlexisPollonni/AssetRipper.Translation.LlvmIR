using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class generic_mul_Float16_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic3mulIDF16_dEENS_3cpp9enable_ifIXaaaasr3cppE19is_floating_point_vIT_Esr3cppE19is_floating_point_vIT0_ElestS5_stS6_ES5_E4typeES6_S6_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16> && cpp::is_floating_point_v<double> && sizeof (_Float16) <= sizeof (double), _Float16>::type __llvm_libc_20_1_2_::fputil::generic::mul<_Float16, double>(double, double)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16> && cpp::is_floating_point_v<double> && sizeof (_Float16) <= sizeof (double), _Float16>::type")]
	public unsafe static Half Invoke([NativeType("double")] double x, [NativeType("double")] double y)
	{
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		long num = 0L;
		fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb11 = default(anon_izyfb7);
		long num2 = 0L;
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
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd5 = default(fputil_DyadicFloat_kt2kd4);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd6 = default(fputil_DyadicFloat_kt2kd4);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd7 = default(fputil_DyadicFloat_kt2kd4);
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		unchecked
		{
			*(long*)(&fputil_FPBits_wjhbrm2) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm2, x);
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
			*(long*)(&fputil_FPBits_wjhbrm3) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm3, y);
			llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb8);
			*(sbyte*)(&anon_izyfb8) = -86;
			anon_izyfb9.val = FPStorage_fputil_FPType_2_sign.Invoke(&fputil_FPBits_wjhbrm2);
			anon_izyfb10.val = FPStorage_fputil_FPType_2_sign.Invoke(&fputil_FPBits_wjhbrm3);
			llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, (!Equals_fy8fvt.Invoke(anon_izyfb9.val, anon_izyfb10.val)) ? Sign_NEG.Pointer : Sign_POS.Pointer, 1L, isVolatile: false);
			Half result;
			if (details_expects_bool_condition_bool.Invoke(FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_inf_or_nan.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2)) ? true : (FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_inf_or_nan.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm3)) ? true : ((!FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2))) ? FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm3)) : true)), expected: false))
			{
				if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_nan.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2)) || FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_nan.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm3)))
				{
					if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_signaling_nan.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2)) || FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_signaling_nan.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm3)))
					{
						fputil_raise_except_if_required.Invoke(1);
					}
					if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_quiet_nan.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2)))
					{
						llvm_lifetime_start_p0.Invoke(8L, &num);
						num = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2));
						num >>>= 42;
						llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
						anon_izyfb11.val = FPStorage_fputil_FPType_2_sign.Invoke(&fputil_FPBits_wjhbrm2);
						short field_ = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan.Invoke(v: (short)num, sign: anon_izyfb11.val);
						fputil_FPBits_2fahva2.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
						result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva2);
						llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
						llvm_lifetime_end_p0.Invoke(8L, &num);
					}
					else if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_quiet_nan.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm3)))
					{
						llvm_lifetime_start_p0.Invoke(8L, &num2);
						num2 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm3));
						num2 >>>= 42;
						llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva3);
						anon_izyfb12.val = FPStorage_fputil_FPType_2_sign.Invoke(&fputil_FPBits_wjhbrm3);
						short field_2 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan.Invoke(v: (short)num2, sign: anon_izyfb12.val);
						fputil_FPBits_2fahva3.FPRepImpl.FPRepSem.FPStorage.field_0 = field_2;
						result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva3);
						llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva3);
						llvm_lifetime_end_p0.Invoke(8L, &num2);
					}
					else
					{
						llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva4);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb13, Sign_POS.Pointer, 1L, isVolatile: false);
						short field_3 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan.Invoke(anon_izyfb13.val, 0);
						fputil_FPBits_2fahva4.FPRepImpl.FPRepSem.FPStorage.field_0 = field_3;
						result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva4);
						llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva4);
					}
				}
				else if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_inf.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2)))
				{
					if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm3)))
					{
						fputil_set_errno_if_required.Invoke(33);
						fputil_raise_except_if_required.Invoke(1);
						llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva5);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb14, Sign_POS.Pointer, 1L, isVolatile: false);
						short field_4 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan.Invoke(anon_izyfb14.val, 0);
						fputil_FPBits_2fahva5.FPRepImpl.FPRepSem.FPStorage.field_0 = field_4;
						result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva5);
						llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva5);
					}
					else
					{
						llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva6);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb15, &anon_izyfb8, 1L, isVolatile: false);
						short field_5 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_inf.Invoke(anon_izyfb15.val);
						fputil_FPBits_2fahva6.FPRepImpl.FPRepSem.FPStorage.field_0 = field_5;
						result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva6);
						llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva6);
					}
				}
				else if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_inf.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm3)))
				{
					if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2)))
					{
						fputil_set_errno_if_required.Invoke(33);
						fputil_raise_except_if_required.Invoke(1);
						llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva7);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb16, Sign_POS.Pointer, 1L, isVolatile: false);
						short field_6 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan.Invoke(anon_izyfb16.val, 0);
						fputil_FPBits_2fahva7.FPRepImpl.FPRepSem.FPStorage.field_0 = field_6;
						result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva7);
						llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva7);
					}
					else
					{
						llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva8);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb17, &anon_izyfb8, 1L, isVolatile: false);
						short field_7 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_inf.Invoke(anon_izyfb17.val);
						fputil_FPBits_2fahva8.FPRepImpl.FPRepSem.FPStorage.field_0 = field_7;
						result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva8);
						llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva8);
					}
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva9);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb18, &anon_izyfb8, 1L, isVolatile: false);
					short field_8 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_zero.Invoke(anon_izyfb18.val);
					fputil_FPBits_2fahva9.FPRepImpl.FPRepSem.FPStorage.field_0 = field_8;
					result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva9);
					llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva9);
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
				DyadicFloat_128ul_DyadicFloat_double_0.Invoke(&fputil_DyadicFloat_kt2kd5, x);
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
				DyadicFloat_128ul_DyadicFloat_double_0.Invoke(&fputil_DyadicFloat_kt2kd6, y);
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
				result = DyadicFloat_128ul_as_Float16_true_void.Invoke(&fputil_DyadicFloat_kt2kd7);
				llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd7);
				llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd6);
				llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd5);
			}
			llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb8);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			return result;
		}
	}
}
