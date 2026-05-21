using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Generic_div_Float16_float
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic3divIDF16_fEENS_3cpp9enable_ifIXaaaasr3cppE19is_floating_point_vIT_Esr3cppE19is_floating_point_vIT0_ElestS5_stS6_ES5_E4typeES6_S6_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16> && cpp::is_floating_point_v<float> && sizeof (_Float16) <= sizeof (float), _Float16>::type __llvm_libc_20_1_2_::fputil::generic::div<_Float16, float>(float, float)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16> && cpp::is_floating_point_v<float> && sizeof (_Float16) <= sizeof (float), _Float16>::type")]
	public unsafe static Half Invoke([MangledName("x")][NativeType("float")] float X, [MangledName("y")][NativeType("float")] float Y)
	{
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs2 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		int num = 0;
		Llvm_libc_20_1_2_fputil_FPBits_2fahva llvm_libc_20_1_2_fputil_FPBits_2fahva = default(Llvm_libc_20_1_2_fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb4 = default(Anon_izyfb7);
		int num2 = 0;
		Llvm_libc_20_1_2_fputil_FPBits_2fahva llvm_libc_20_1_2_fputil_FPBits_2fahva2 = default(Llvm_libc_20_1_2_fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb5 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_2fahva llvm_libc_20_1_2_fputil_FPBits_2fahva3 = default(Llvm_libc_20_1_2_fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb6 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_2fahva llvm_libc_20_1_2_fputil_FPBits_2fahva4 = default(Llvm_libc_20_1_2_fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb7 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_2fahva llvm_libc_20_1_2_fputil_FPBits_2fahva5 = default(Llvm_libc_20_1_2_fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb8 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_2fahva llvm_libc_20_1_2_fputil_FPBits_2fahva6 = default(Llvm_libc_20_1_2_fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb9 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_2fahva llvm_libc_20_1_2_fputil_FPBits_2fahva7 = default(Llvm_libc_20_1_2_fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb10 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_2fahva llvm_libc_20_1_2_fputil_FPBits_2fahva8 = default(Llvm_libc_20_1_2_fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb11 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_2fahva llvm_libc_20_1_2_fputil_FPBits_2fahva9 = default(Llvm_libc_20_1_2_fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb12 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs = default(Llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs);
		Llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs2 = default(Llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs);
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		Llvm_libc_20_1_2_BigInt_vtm4cw llvm_libc_20_1_2_BigInt_vtm4cw = default(Llvm_libc_20_1_2_BigInt_vtm4cw);
		int num7 = 0;
		Llvm_libc_20_1_2_BigInt_vtm4cw llvm_libc_20_1_2_BigInt_vtm4cw2 = default(Llvm_libc_20_1_2_BigInt_vtm4cw);
		int i = 0;
		Llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs3 = default(Llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs);
		Anon_izyfb7 anon_izyfb13 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_BigInt_vtm4cw llvm_libc_20_1_2_BigInt_vtm4cw3 = default(Llvm_libc_20_1_2_BigInt_vtm4cw);
		Llvm_libc_20_1_2_BigInt_vtm4cw llvm_libc_20_1_2_BigInt_vtm4cw4 = default(Llvm_libc_20_1_2_BigInt_vtm4cw);
		Llvm_libc_20_1_2_BigInt_vtm4cw llvm_libc_20_1_2_BigInt_vtm4cw5 = default(Llvm_libc_20_1_2_BigInt_vtm4cw);
		Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Half result;
		unchecked
		{
			*(int*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs) = -1431655766;
			FPBits_float_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs, X);
			Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
			*(int*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2) = -1431655766;
			FPBits_float_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2, Y);
			Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb);
			*(sbyte*)(&anon_izyfb) = -86;
			anon_izyfb2.Val = FPStorage_fputil_FPType_1_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
			anon_izyfb3.Val = FPStorage_fputil_FPType_1_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
			Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, (!Llvm_libc_20_1_2_Equals_fy8fvt.Invoke(anon_izyfb2.Val, anon_izyfb3.Val)) ? Llvm_libc_20_1_2_Sign_NEG.Pointer : Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
			if (!Details_expects_bool_condition_bool.Invoke(FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_inf_or_nan.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs)) ? true : (FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_inf_or_nan.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2)) ? true : ((!FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_zero.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs)) ? FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_zero.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2) : true)), Expected: false))
			{
				goto IL_06e8;
			}
			if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs) || FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2))
			{
				if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_signaling_nan.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs) || FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_signaling_nan.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2))
				{
					Fputil_raise_except_if_required.Invoke(1);
				}
				if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_quiet_nan.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs))
				{
					Llvm_lifetime_start_p0.Invoke(4L, &num);
					num = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs));
					num >>>= 13;
					Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva);
					anon_izyfb4.Val = FPStorage_fputil_FPType_1_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
					short field_ = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan.Invoke(V: (short)num, Sign: anon_izyfb4.Val);
					llvm_libc_20_1_2_fputil_FPBits_2fahva.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
					result = FPBits_Float16_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva);
					Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva);
					Llvm_lifetime_end_p0.Invoke(4L, &num);
				}
				else if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_quiet_nan.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2))
				{
					Llvm_lifetime_start_p0.Invoke(4L, &num2);
					num2 = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2));
					num2 >>>= 13;
					Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva2);
					anon_izyfb5.Val = FPStorage_fputil_FPType_1_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
					short field_2 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan.Invoke(V: (short)num2, Sign: anon_izyfb5.Val);
					llvm_libc_20_1_2_fputil_FPBits_2fahva2.FPRepImpl.FPRepSem.FPStorage.field_0 = field_2;
					result = FPBits_Float16_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva2);
					Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva2);
					Llvm_lifetime_end_p0.Invoke(4L, &num2);
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva3);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb6, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
					short field_3 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan.Invoke(anon_izyfb6.Val, 0);
					llvm_libc_20_1_2_fputil_FPBits_2fahva3.FPRepImpl.FPRepSem.FPStorage.field_0 = field_3;
					result = FPBits_Float16_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva3);
					Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva3);
				}
			}
			else if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_inf.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs))
			{
				if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_inf.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2))
				{
					Fputil_set_errno_if_required.Invoke(33);
					Fputil_raise_except_if_required.Invoke(1);
					Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva4);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb7, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
					short field_4 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan.Invoke(anon_izyfb7.Val, 0);
					llvm_libc_20_1_2_fputil_FPBits_2fahva4.FPRepImpl.FPRepSem.FPStorage.field_0 = field_4;
					result = FPBits_Float16_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva4);
					Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva4);
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva5);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, &anon_izyfb, 1L, isVolatile: false);
					short field_5 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_inf.Invoke(anon_izyfb8.Val);
					llvm_libc_20_1_2_fputil_FPBits_2fahva5.FPRepImpl.FPRepSem.FPStorage.field_0 = field_5;
					result = FPBits_Float16_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva5);
					Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva5);
				}
			}
			else if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_inf.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2))
			{
				Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva6);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, &anon_izyfb, 1L, isVolatile: false);
				short field_6 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_inf.Invoke(anon_izyfb9.Val);
				llvm_libc_20_1_2_fputil_FPBits_2fahva6.FPRepImpl.FPRepSem.FPStorage.field_0 = field_6;
				result = FPBits_Float16_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva6);
				Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva6);
			}
			else if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_zero.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2))
			{
				if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_zero.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs))
				{
					Fputil_raise_except_if_required.Invoke(1);
					Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva7);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb10, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
					short field_7 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan.Invoke(anon_izyfb10.Val, 0);
					llvm_libc_20_1_2_fputil_FPBits_2fahva7.FPRepImpl.FPRepSem.FPStorage.field_0 = field_7;
					result = FPBits_Float16_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva7);
					Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva7);
				}
				else
				{
					Fputil_raise_except_if_required.Invoke(4);
					Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva8);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb11, &anon_izyfb, 1L, isVolatile: false);
					short field_8 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_inf.Invoke(anon_izyfb11.Val);
					llvm_libc_20_1_2_fputil_FPBits_2fahva8.FPRepImpl.FPRepSem.FPStorage.field_0 = field_8;
					result = FPBits_Float16_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva8);
					Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva8);
				}
			}
			else
			{
				if (!FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_zero.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs))
				{
					goto IL_06e8;
				}
				Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva9);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb12, &anon_izyfb, 1L, isVolatile: false);
				short field_9 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_zero.Invoke(anon_izyfb12.Val);
				llvm_libc_20_1_2_fputil_FPBits_2fahva9.FPRepImpl.FPRepSem.FPStorage.field_0 = field_9;
				result = FPBits_Float16_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva9);
				Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva9);
			}
			goto IL_0a7a;
		}
		IL_0a7a:
		Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb);
		Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
		Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		return result;
		IL_06e8:
		Llvm_lifetime_start_p0.Invoke(12L, &llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs);
		unchecked
		{
			*(sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs) = -86;
			sbyte* ptr = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs) + 1;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			((int*)(&llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs))[1] = -1431655766;
			((int*)(&llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs))[2] = -1431655766;
			DyadicFloat_32ul_DyadicFloat_float_0.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs, X);
			Llvm_lifetime_start_p0.Invoke(12L, &llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs2);
			*(sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs2) = -86;
			sbyte* ptr2 = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs2) + 1;
			*ptr2 = -86;
			ptr2[1] = -86;
			ptr2[2] = -86;
			((int*)(&llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs2))[1] = -1431655766;
			((int*)(&llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs2))[2] = -1431655766;
			DyadicFloat_32ul_DyadicFloat_float_0.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs2, Y);
			Llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = 13;
			Llvm_lifetime_start_p0.Invoke(4L, &num4);
			num4 = checked(llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs.Exponent - llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs2.Exponent - 12);
			Llvm_lifetime_start_p0.Invoke(4L, &num5);
			num5 = 0;
			Llvm_lifetime_start_p0.Invoke(4L, &num6);
			Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_BigInt_vtm4cw);
			int data = BigInt_32ul_false_unsigned_int_RightShift.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs.Mantissa, 2L);
			*(int*)(&llvm_libc_20_1_2_BigInt_vtm4cw.Val.Data) = data;
			int num8 = BigInt_32ul_false_unsigned_int_Unsigned_int_unsigned_int.Invoke(&llvm_libc_20_1_2_BigInt_vtm4cw);
			Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_BigInt_vtm4cw);
			num6 = num8;
			Llvm_lifetime_start_p0.Invoke(4L, &num7);
			Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_BigInt_vtm4cw2);
			int data2 = BigInt_32ul_false_unsigned_int_RightShift.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs2.Mantissa, 1L);
			*(int*)(&llvm_libc_20_1_2_BigInt_vtm4cw2.Val.Data) = data2;
			int num9 = BigInt_32ul_false_unsigned_int_Unsigned_int_unsigned_int.Invoke(&llvm_libc_20_1_2_BigInt_vtm4cw2);
			Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_BigInt_vtm4cw2);
			num7 = num9;
			Llvm_lifetime_start_p0.Invoke(4L, &i);
			for (i = 0; i < 13; i = checked(i + 1))
			{
				num5 <<= 1;
				num6 <<= 1;
				if ((uint)num6 >= (uint)num7)
				{
					num5++;
					num6 -= num7;
				}
			}
			Llvm_lifetime_end_p0.Invoke(4L, &i);
			Llvm_lifetime_start_p0.Invoke(12L, &llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs3);
			*(sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs3) = -86;
			sbyte* ptr3 = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs3) + 1;
			*ptr3 = -86;
			ptr3[1] = -86;
			ptr3[2] = -86;
			((int*)(&llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs3))[1] = -1431655766;
			((int*)(&llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs3))[2] = -1431655766;
			Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb13, &anon_izyfb, 1L, isVolatile: false);
			int e = num4;
			BigInt_32ul_false_unsigned_int_BigInt_unsigned_int_void.Invoke(&llvm_libc_20_1_2_BigInt_vtm4cw3, num5);
			DyadicFloat_32ul_Constructor.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs3, anon_izyfb13.Val, e, *(int*)(&llvm_libc_20_1_2_BigInt_vtm4cw3.Val.Data));
			Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_BigInt_vtm4cw4);
			BigInt_32ul_false_unsigned_int_BigInt_unsigned_int_void.Invoke(&llvm_libc_20_1_2_BigInt_vtm4cw4, (num6 != 0) ? 1 : 0);
			int data3 = Llvm_libc_20_1_2_Operator_qdjidv.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs3.Mantissa, &llvm_libc_20_1_2_BigInt_vtm4cw4);
			*(int*)(&llvm_libc_20_1_2_BigInt_vtm4cw5.Val.Data) = data3;
			Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_BigInt_vtm4cw4);
			result = DyadicFloat_32ul_as_Float16_true_void.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs3);
			Llvm_lifetime_end_p0.Invoke(12L, &llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs3);
			Llvm_lifetime_end_p0.Invoke(4L, &num7);
			Llvm_lifetime_end_p0.Invoke(4L, &num6);
			Llvm_lifetime_end_p0.Invoke(4L, &num5);
			Llvm_lifetime_end_p0.Invoke(4L, &num4);
			Llvm_lifetime_end_p0.Invoke(4L, &num3);
			Llvm_lifetime_end_p0.Invoke(12L, &llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs2);
			Llvm_lifetime_end_p0.Invoke(12L, &llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs);
			goto IL_0a7a;
		}
	}
}
