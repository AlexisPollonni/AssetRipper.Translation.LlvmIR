using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class generic_div_Float16_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic3divIDF16_dEENS_3cpp9enable_ifIXaaaasr3cppE19is_floating_point_vIT_Esr3cppE19is_floating_point_vIT0_ElestS5_stS6_ES5_E4typeES6_S6_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16> && cpp::is_floating_point_v<double> && sizeof (_Float16) <= sizeof (double), _Float16>::type __llvm_libc_20_1_2_::fputil::generic::div<_Float16, double>(double, double)")]
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
		fputil_FPBits_2fahva fputil_FPBits_2fahva10 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb19 = default(anon_izyfb7);
		fputil_DyadicFloat_syracv fputil_DyadicFloat_syracv2 = default(fputil_DyadicFloat_syracv);
		fputil_DyadicFloat_syracv fputil_DyadicFloat_syracv3 = default(fputil_DyadicFloat_syracv);
		int num3 = 0;
		int num4 = 0;
		long num5 = 0L;
		long num6 = 0L;
		BigInt_555ggs bigInt_555ggs = default(BigInt_555ggs);
		long num7 = 0L;
		BigInt_555ggs bigInt_555ggs2 = default(BigInt_555ggs);
		int i = 0;
		fputil_DyadicFloat_syracv fputil_DyadicFloat_syracv4 = default(fputil_DyadicFloat_syracv);
		anon_izyfb7 anon_izyfb20 = default(anon_izyfb7);
		BigInt_555ggs bigInt_555ggs3 = default(BigInt_555ggs);
		BigInt_555ggs bigInt_555ggs4 = default(BigInt_555ggs);
		BigInt_555ggs bigInt_555ggs5 = default(BigInt_555ggs);
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		Half result;
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
			if (!details_expects_bool_condition_bool.Invoke(FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_inf_or_nan.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2)) ? true : (FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_inf_or_nan.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm3)) ? true : ((!FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2))) ? FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm3)) : true)), expected: false))
			{
				goto IL_0703;
			}
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
				if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_inf.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm3)))
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
				llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva7);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb16, &anon_izyfb8, 1L, isVolatile: false);
				short field_6 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_inf.Invoke(anon_izyfb16.val);
				fputil_FPBits_2fahva7.FPRepImpl.FPRepSem.FPStorage.field_0 = field_6;
				result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva7);
				llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva7);
			}
			else if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm3)))
			{
				if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2)))
				{
					fputil_raise_except_if_required.Invoke(1);
					llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva8);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb17, Sign_POS.Pointer, 1L, isVolatile: false);
					short field_7 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan.Invoke(anon_izyfb17.val, 0);
					fputil_FPBits_2fahva8.FPRepImpl.FPRepSem.FPStorage.field_0 = field_7;
					result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva8);
					llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva8);
				}
				else
				{
					fputil_raise_except_if_required.Invoke(4);
					llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva9);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb18, &anon_izyfb8, 1L, isVolatile: false);
					short field_8 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_inf.Invoke(anon_izyfb18.val);
					fputil_FPBits_2fahva9.FPRepImpl.FPRepSem.FPStorage.field_0 = field_8;
					result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva9);
					llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva9);
				}
			}
			else
			{
				if (!FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2)))
				{
					goto IL_0703;
				}
				llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva10);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb19, &anon_izyfb8, 1L, isVolatile: false);
				short field_9 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_zero.Invoke(anon_izyfb19.val);
				fputil_FPBits_2fahva10.FPRepImpl.FPRepSem.FPStorage.field_0 = field_9;
				result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva10);
				llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva10);
			}
			goto IL_0ac2;
		}
		IL_0ac2:
		llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb8);
		llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
		llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		return result;
		IL_0703:
		llvm_lifetime_start_p0.Invoke(16L, &fputil_DyadicFloat_syracv2);
		unchecked
		{
			*(sbyte*)(&fputil_DyadicFloat_syracv2) = -86;
			sbyte* ptr = (sbyte*)(&fputil_DyadicFloat_syracv2) + 1;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			((int*)(&fputil_DyadicFloat_syracv2))[1] = -1431655766;
			((long*)(&fputil_DyadicFloat_syracv2))[1] = -6148914691236517206L;
			DyadicFloat_64ul_DyadicFloat_double_0.Invoke(&fputil_DyadicFloat_syracv2, x);
			llvm_lifetime_start_p0.Invoke(16L, &fputil_DyadicFloat_syracv3);
			*(sbyte*)(&fputil_DyadicFloat_syracv3) = -86;
			sbyte* ptr2 = (sbyte*)(&fputil_DyadicFloat_syracv3) + 1;
			*ptr2 = -86;
			ptr2[1] = -86;
			ptr2[2] = -86;
			((int*)(&fputil_DyadicFloat_syracv3))[1] = -1431655766;
			((long*)(&fputil_DyadicFloat_syracv3))[1] = -6148914691236517206L;
			DyadicFloat_64ul_DyadicFloat_double_0.Invoke(&fputil_DyadicFloat_syracv3, y);
			llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = 13;
			llvm_lifetime_start_p0.Invoke(4L, &num4);
			num4 = checked(fputil_DyadicFloat_syracv2.exponent - fputil_DyadicFloat_syracv3.exponent - 12);
			llvm_lifetime_start_p0.Invoke(8L, &num5);
			num5 = 0L;
			llvm_lifetime_start_p0.Invoke(8L, &num6);
			llvm_lifetime_start_p0.Invoke(8L, &bigInt_555ggs);
			long data = BigInt_64ul_false_unsigned_long_RightShift.Invoke(&fputil_DyadicFloat_syracv2.mantissa, 2L);
			*(long*)(&bigInt_555ggs.val.Data) = data;
			long num8 = BigInt_64ul_false_unsigned_long_unsigned_long_unsigned_long.Invoke(&bigInt_555ggs);
			llvm_lifetime_end_p0.Invoke(8L, &bigInt_555ggs);
			num6 = num8;
			llvm_lifetime_start_p0.Invoke(8L, &num7);
			llvm_lifetime_start_p0.Invoke(8L, &bigInt_555ggs2);
			long data2 = BigInt_64ul_false_unsigned_long_RightShift.Invoke(&fputil_DyadicFloat_syracv3.mantissa, 1L);
			*(long*)(&bigInt_555ggs2.val.Data) = data2;
			long num9 = BigInt_64ul_false_unsigned_long_unsigned_long_unsigned_long.Invoke(&bigInt_555ggs2);
			llvm_lifetime_end_p0.Invoke(8L, &bigInt_555ggs2);
			num7 = num9;
			llvm_lifetime_start_p0.Invoke(4L, &i);
			for (i = 0; i < 13; i = checked(i + 1))
			{
				num5 <<= 1;
				num6 <<= 1;
				if ((ulong)num6 >= (ulong)num7)
				{
					num5++;
					num6 -= num7;
				}
			}
			llvm_lifetime_end_p0.Invoke(4L, &i);
			llvm_lifetime_start_p0.Invoke(16L, &fputil_DyadicFloat_syracv4);
			*(sbyte*)(&fputil_DyadicFloat_syracv4) = -86;
			sbyte* ptr3 = (sbyte*)(&fputil_DyadicFloat_syracv4) + 1;
			*ptr3 = -86;
			ptr3[1] = -86;
			ptr3[2] = -86;
			((int*)(&fputil_DyadicFloat_syracv4))[1] = -1431655766;
			((long*)(&fputil_DyadicFloat_syracv4))[1] = -6148914691236517206L;
			llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb20, &anon_izyfb8, 1L, isVolatile: false);
			int e = num4;
			BigInt_64ul_false_unsigned_long_BigInt_unsigned_long_void.Invoke(&bigInt_555ggs3, num5);
			DyadicFloat_64ul_Constructor.Invoke(&fputil_DyadicFloat_syracv4, anon_izyfb20.val, e, *(long*)(&bigInt_555ggs3.val.Data));
			llvm_lifetime_start_p0.Invoke(8L, &bigInt_555ggs4);
			BigInt_64ul_false_unsigned_long_BigInt_unsigned_int_void.Invoke(&bigInt_555ggs4, (num6 != 0L) ? 1 : 0);
			long data3 = Operator_um4whe.Invoke(&fputil_DyadicFloat_syracv4.mantissa, &bigInt_555ggs4);
			*(long*)(&bigInt_555ggs5.val.Data) = data3;
			llvm_lifetime_end_p0.Invoke(8L, &bigInt_555ggs4);
			result = DyadicFloat_64ul_as_Float16_true_void.Invoke(&fputil_DyadicFloat_syracv4);
			llvm_lifetime_end_p0.Invoke(16L, &fputil_DyadicFloat_syracv4);
			llvm_lifetime_end_p0.Invoke(8L, &num7);
			llvm_lifetime_end_p0.Invoke(8L, &num6);
			llvm_lifetime_end_p0.Invoke(8L, &num5);
			llvm_lifetime_end_p0.Invoke(4L, &num4);
			llvm_lifetime_end_p0.Invoke(4L, &num3);
			llvm_lifetime_end_p0.Invoke(16L, &fputil_DyadicFloat_syracv3);
			llvm_lifetime_end_p0.Invoke(16L, &fputil_DyadicFloat_syracv2);
			goto IL_0ac2;
		}
	}
}
