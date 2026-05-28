using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Generic_div_Float16_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic3divIDF16_dEENS_3cpp9enable_ifIXaaaasr3cppE19is_floating_point_vIT_Esr3cppE19is_floating_point_vIT0_ElestS5_stS6_ES5_E4typeES6_S6_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16> && cpp::is_floating_point_v<double> && sizeof (_Float16) <= sizeof (double), _Float16>::type __llvm_libc_20_1_2_::fputil::generic::div<_Float16, double>(double, double)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16> && cpp::is_floating_point_v<double> && sizeof (_Float16) <= sizeof (double), _Float16>::type")]
	public unsafe static Half Invoke([MangledName("x")][NativeType("double")] double X, [MangledName("y")][NativeType("double")] double Y)
	{
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm = default(Fputil_FPBits_wjhbrm);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(Fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		long num = 0L;
		Fputil_FPBits_2fahva fputil_FPBits_2fahva = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb4 = default(Anon_izyfb7);
		long num2 = 0L;
		Fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb5 = default(Anon_izyfb7);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva3 = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb6 = default(Anon_izyfb7);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva4 = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb7 = default(Anon_izyfb7);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva5 = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb8 = default(Anon_izyfb7);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva6 = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb9 = default(Anon_izyfb7);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva7 = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb10 = default(Anon_izyfb7);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva8 = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb11 = default(Anon_izyfb7);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva9 = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb12 = default(Anon_izyfb7);
		Fputil_DyadicFloat_syracv fputil_DyadicFloat_syracv = default(Fputil_DyadicFloat_syracv);
		Fputil_DyadicFloat_syracv fputil_DyadicFloat_syracv2 = default(Fputil_DyadicFloat_syracv);
		int num3 = 0;
		int num4 = 0;
		long num5 = 0L;
		long num6 = 0L;
		BigInt_555ggs bigInt_555ggs = default(BigInt_555ggs);
		long num7 = 0L;
		BigInt_555ggs bigInt_555ggs2 = default(BigInt_555ggs);
		int i = 0;
		Fputil_DyadicFloat_syracv fputil_DyadicFloat_syracv3 = default(Fputil_DyadicFloat_syracv);
		Anon_izyfb7 anon_izyfb13 = default(Anon_izyfb7);
		BigInt_555ggs bigInt_555ggs3 = default(BigInt_555ggs);
		BigInt_555ggs bigInt_555ggs4 = default(BigInt_555ggs);
		BigInt_555ggs bigInt_555ggs5 = default(BigInt_555ggs);
		Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
		Half result;
		unchecked
		{
			*(long*)(&fputil_FPBits_wjhbrm) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm, X);
			Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			*(long*)(&fputil_FPBits_wjhbrm2) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm2, Y);
			Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb);
			*(sbyte*)(&anon_izyfb) = -86;
			anon_izyfb2.Val = FPStorage_fputil_FPType_2_sign.Invoke(&fputil_FPBits_wjhbrm);
			anon_izyfb3.Val = FPStorage_fputil_FPType_2_sign.Invoke(&fputil_FPBits_wjhbrm2);
			Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, (!Equals_fy8fvt.Invoke(anon_izyfb2.Val, anon_izyfb3.Val)) ? Sign_NEG.Pointer : Sign_POS.Pointer, 1L, isVolatile: false);
			if (!Details_expects_bool_condition_bool.Invoke(FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_inf_or_nan.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm)) || FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_inf_or_nan.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2)) || FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm)) || FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2)), Expected: false))
			{
				goto IL_0703;
			}
			if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_nan.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm)) || FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_nan.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2)))
			{
				if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_signaling_nan.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm)) || FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_signaling_nan.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2)))
				{
					Fputil_raise_except_if_required.Invoke(1);
				}
				if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_quiet_nan.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm)))
				{
					Llvm_lifetime_start_p0.Invoke(8L, &num);
					num = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm));
					num >>>= 42;
					Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva);
					anon_izyfb4.Val = FPStorage_fputil_FPType_2_sign.Invoke(&fputil_FPBits_wjhbrm);
					short field_ = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan.Invoke(V: (short)num, Sign: anon_izyfb4.Val);
					fputil_FPBits_2fahva.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
					result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva);
					Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva);
					Llvm_lifetime_end_p0.Invoke(8L, &num);
				}
				else if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_quiet_nan.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2)))
				{
					Llvm_lifetime_start_p0.Invoke(8L, &num2);
					num2 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2));
					num2 >>>= 42;
					Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
					anon_izyfb5.Val = FPStorage_fputil_FPType_2_sign.Invoke(&fputil_FPBits_wjhbrm2);
					short field_2 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan.Invoke(V: (short)num2, Sign: anon_izyfb5.Val);
					fputil_FPBits_2fahva2.FPRepImpl.FPRepSem.FPStorage.field_0 = field_2;
					result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva2);
					Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
					Llvm_lifetime_end_p0.Invoke(8L, &num2);
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva3);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb6, Sign_POS.Pointer, 1L, isVolatile: false);
					short field_3 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan.Invoke(anon_izyfb6.Val, 0);
					fputil_FPBits_2fahva3.FPRepImpl.FPRepSem.FPStorage.field_0 = field_3;
					result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva3);
					Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva3);
				}
			}
			else if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_inf.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm)))
			{
				if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_inf.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2)))
				{
					Fputil_set_errno_if_required.Invoke(33);
					Fputil_raise_except_if_required.Invoke(1);
					Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva4);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb7, Sign_POS.Pointer, 1L, isVolatile: false);
					short field_4 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan.Invoke(anon_izyfb7.Val, 0);
					fputil_FPBits_2fahva4.FPRepImpl.FPRepSem.FPStorage.field_0 = field_4;
					result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva4);
					Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva4);
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva5);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, &anon_izyfb, 1L, isVolatile: false);
					short field_5 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_inf.Invoke(anon_izyfb8.Val);
					fputil_FPBits_2fahva5.FPRepImpl.FPRepSem.FPStorage.field_0 = field_5;
					result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva5);
					Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva5);
				}
			}
			else if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_inf.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2)))
			{
				Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva6);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, &anon_izyfb, 1L, isVolatile: false);
				short field_6 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_inf.Invoke(anon_izyfb9.Val);
				fputil_FPBits_2fahva6.FPRepImpl.FPRepSem.FPStorage.field_0 = field_6;
				result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva6);
				Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva6);
			}
			else if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2)))
			{
				if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm)))
				{
					Fputil_raise_except_if_required.Invoke(1);
					Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva7);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb10, Sign_POS.Pointer, 1L, isVolatile: false);
					short field_7 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan.Invoke(anon_izyfb10.Val, 0);
					fputil_FPBits_2fahva7.FPRepImpl.FPRepSem.FPStorage.field_0 = field_7;
					result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva7);
					Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva7);
				}
				else
				{
					Fputil_raise_except_if_required.Invoke(4);
					Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva8);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb11, &anon_izyfb, 1L, isVolatile: false);
					short field_8 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_inf.Invoke(anon_izyfb11.Val);
					fputil_FPBits_2fahva8.FPRepImpl.FPRepSem.FPStorage.field_0 = field_8;
					result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva8);
					Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva8);
				}
			}
			else
			{
				if (!FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm)))
				{
					goto IL_0703;
				}
				Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva9);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb12, &anon_izyfb, 1L, isVolatile: false);
				short field_9 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_zero.Invoke(anon_izyfb12.Val);
				fputil_FPBits_2fahva9.FPRepImpl.FPRepSem.FPStorage.field_0 = field_9;
				result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva9);
				Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva9);
			}
			goto IL_0ac2;
		}
		IL_0ac2:
		Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb);
		Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
		return result;
		IL_0703:
		Llvm_lifetime_start_p0.Invoke(16L, &fputil_DyadicFloat_syracv);
		unchecked
		{
			*(sbyte*)(&fputil_DyadicFloat_syracv) = -86;
			sbyte* ptr = (sbyte*)(&fputil_DyadicFloat_syracv) + 1;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			((int*)(&fputil_DyadicFloat_syracv))[1] = -1431655766;
			((long*)(&fputil_DyadicFloat_syracv))[1] = -6148914691236517206L;
			DyadicFloat_64ul_DyadicFloat_double_0.Invoke(&fputil_DyadicFloat_syracv, X);
			Llvm_lifetime_start_p0.Invoke(16L, &fputil_DyadicFloat_syracv2);
			*(sbyte*)(&fputil_DyadicFloat_syracv2) = -86;
			sbyte* ptr2 = (sbyte*)(&fputil_DyadicFloat_syracv2) + 1;
			*ptr2 = -86;
			ptr2[1] = -86;
			ptr2[2] = -86;
			((int*)(&fputil_DyadicFloat_syracv2))[1] = -1431655766;
			((long*)(&fputil_DyadicFloat_syracv2))[1] = -6148914691236517206L;
			DyadicFloat_64ul_DyadicFloat_double_0.Invoke(&fputil_DyadicFloat_syracv2, Y);
			Llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = 13;
			Llvm_lifetime_start_p0.Invoke(4L, &num4);
			num4 = checked(fputil_DyadicFloat_syracv.Exponent - fputil_DyadicFloat_syracv2.Exponent - 12);
			Llvm_lifetime_start_p0.Invoke(8L, &num5);
			num5 = 0L;
			Llvm_lifetime_start_p0.Invoke(8L, &num6);
			Llvm_lifetime_start_p0.Invoke(8L, &bigInt_555ggs);
			long data = BigInt_64ul_false_unsigned_long_RightShift.Invoke(&fputil_DyadicFloat_syracv.Mantissa, 2L);
			*(long*)(&bigInt_555ggs.Val.Data) = data;
			long num8 = BigInt_64ul_false_unsigned_long_Unsigned_long_unsigned_long.Invoke(&bigInt_555ggs);
			Llvm_lifetime_end_p0.Invoke(8L, &bigInt_555ggs);
			num6 = num8;
			Llvm_lifetime_start_p0.Invoke(8L, &num7);
			Llvm_lifetime_start_p0.Invoke(8L, &bigInt_555ggs2);
			long data2 = BigInt_64ul_false_unsigned_long_RightShift.Invoke(&fputil_DyadicFloat_syracv2.Mantissa, 1L);
			*(long*)(&bigInt_555ggs2.Val.Data) = data2;
			long num9 = BigInt_64ul_false_unsigned_long_Unsigned_long_unsigned_long.Invoke(&bigInt_555ggs2);
			Llvm_lifetime_end_p0.Invoke(8L, &bigInt_555ggs2);
			num7 = num9;
			Llvm_lifetime_start_p0.Invoke(4L, &i);
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
			Llvm_lifetime_end_p0.Invoke(4L, &i);
			Llvm_lifetime_start_p0.Invoke(16L, &fputil_DyadicFloat_syracv3);
			*(sbyte*)(&fputil_DyadicFloat_syracv3) = -86;
			sbyte* ptr3 = (sbyte*)(&fputil_DyadicFloat_syracv3) + 1;
			*ptr3 = -86;
			ptr3[1] = -86;
			ptr3[2] = -86;
			((int*)(&fputil_DyadicFloat_syracv3))[1] = -1431655766;
			((long*)(&fputil_DyadicFloat_syracv3))[1] = -6148914691236517206L;
			Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb13, &anon_izyfb, 1L, isVolatile: false);
			int e = num4;
			BigInt_64ul_false_unsigned_long_BigInt_unsigned_long_void.Invoke(&bigInt_555ggs3, num5);
			DyadicFloat_64ul_Constructor.Invoke(&fputil_DyadicFloat_syracv3, anon_izyfb13.Val, e, *(long*)(&bigInt_555ggs3.Val.Data));
			Llvm_lifetime_start_p0.Invoke(8L, &bigInt_555ggs4);
			BigInt_64ul_false_unsigned_long_BigInt_unsigned_int_void.Invoke(&bigInt_555ggs4, (num6 != 0L) ? 1 : 0);
			long data3 = Operator_um4whe.Invoke(&fputil_DyadicFloat_syracv3.Mantissa, &bigInt_555ggs4);
			*(long*)(&bigInt_555ggs5.Val.Data) = data3;
			Llvm_lifetime_end_p0.Invoke(8L, &bigInt_555ggs4);
			result = DyadicFloat_64ul_as_Float16_true_void.Invoke(&fputil_DyadicFloat_syracv3);
			Llvm_lifetime_end_p0.Invoke(16L, &fputil_DyadicFloat_syracv3);
			Llvm_lifetime_end_p0.Invoke(8L, &num7);
			Llvm_lifetime_end_p0.Invoke(8L, &num6);
			Llvm_lifetime_end_p0.Invoke(8L, &num5);
			Llvm_lifetime_end_p0.Invoke(4L, &num4);
			Llvm_lifetime_end_p0.Invoke(4L, &num3);
			Llvm_lifetime_end_p0.Invoke(16L, &fputil_DyadicFloat_syracv2);
			Llvm_lifetime_end_p0.Invoke(16L, &fputil_DyadicFloat_syracv);
			goto IL_0ac2;
		}
	}
}
