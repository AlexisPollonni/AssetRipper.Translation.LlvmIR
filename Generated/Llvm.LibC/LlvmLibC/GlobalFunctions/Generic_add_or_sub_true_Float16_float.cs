using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Generic_add_or_sub_true_Float16_float
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic10add_or_subILb1EDF16_fEENS_3cpp9enable_ifIXaaaasr3cppE19is_floating_point_vIT0_Esr3cppE19is_floating_point_vIT1_ElestS5_stS6_ES5_E4typeES6_S6_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16> && cpp::is_floating_point_v<float> && sizeof (_Float16) <= sizeof (float), _Float16>::type __llvm_libc_20_1_2_::fputil::generic::add_or_sub<true, _Float16, float>(float, float)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16> && cpp::is_floating_point_v<float> && sizeof (_Float16) <= sizeof (float), _Float16>::type")]
	public unsafe static Half Invoke([MangledName("x")][NativeType("float")] float X, [MangledName("y")][NativeType("float")] float Y)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs2 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		sbyte b = 0;
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		int num4 = 0;
		Llvm_libc_20_1_2_fputil_FPBits_2fahva llvm_libc_20_1_2_fputil_FPBits_2fahva = default(Llvm_libc_20_1_2_fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		int num5 = 0;
		Llvm_libc_20_1_2_fputil_FPBits_2fahva llvm_libc_20_1_2_fputil_FPBits_2fahva2 = default(Llvm_libc_20_1_2_fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb4 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_2fahva llvm_libc_20_1_2_fputil_FPBits_2fahva3 = default(Llvm_libc_20_1_2_fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb5 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_2fahva llvm_libc_20_1_2_fputil_FPBits_2fahva4 = default(Llvm_libc_20_1_2_fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb6 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_2fahva llvm_libc_20_1_2_fputil_FPBits_2fahva5 = default(Llvm_libc_20_1_2_fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb7 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_2fahva llvm_libc_20_1_2_fputil_FPBits_2fahva6 = default(Llvm_libc_20_1_2_fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb8 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_2fahva llvm_libc_20_1_2_fputil_FPBits_2fahva7 = default(Llvm_libc_20_1_2_fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb9 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_2fahva llvm_libc_20_1_2_fputil_FPBits_2fahva8 = default(Llvm_libc_20_1_2_fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb10 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_2fahva llvm_libc_20_1_2_fputil_FPBits_2fahva9 = default(Llvm_libc_20_1_2_fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb11 = default(Anon_izyfb7);
		float num6 = 0f;
		float num7 = 0f;
		float num8 = 0f;
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs3 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		float num9 = 0f;
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs4 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Llvm_libc_20_1_2_fputil_FPBits_2fahva llvm_libc_20_1_2_fputil_FPBits_2fahva10 = default(Llvm_libc_20_1_2_fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb12 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_2fahva llvm_libc_20_1_2_fputil_FPBits_2fahva11 = default(Llvm_libc_20_1_2_fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb13 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb14 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb15 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb16 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb17 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs5 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs6 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		int num10 = 0;
		int num11 = 0;
		int num12 = 0;
		int num13 = 0;
		int num14 = 0;
		sbyte b2 = 0;
		int num15 = 0;
		int num16 = 0;
		Llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs = default(Llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs);
		Anon_izyfb7 anon_izyfb18 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_BigInt_vtm4cw llvm_libc_20_1_2_BigInt_vtm4cw = default(Llvm_libc_20_1_2_BigInt_vtm4cw);
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = 3;
		Llvm_lifetime_start_p0.Invoke(4L, &num2);
		num2 = 26;
		Llvm_lifetime_start_p0.Invoke(4L, &num3);
		num3 = 27;
		Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Half result;
		unchecked
		{
			*(int*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs) = -1431655766;
			FPBits_float_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs, X);
			Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
			*(int*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2) = -1431655766;
			FPBits_float_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2, Y);
			Llvm_lifetime_start_p0.Invoke(1L, &b);
			anon_izyfb.Val = FPStorage_fputil_FPType_1_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
			anon_izyfb2.Val = FPStorage_fputil_FPType_1_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
			b = ((!Llvm_libc_20_1_2_Equals_fy8fvt.Invoke(anon_izyfb.Val, anon_izyfb2.Val)) ? ((sbyte)1) : ((sbyte)0));
			if (!Details_expects_bool_condition_bool.Invoke(FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_inf_or_nan.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs)) ? true : (FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_inf_or_nan.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2)) ? true : ((!FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_zero.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs)) ? FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_zero.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2) : true)), Expected: false))
			{
				goto IL_07c7;
			}
			if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs) || FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2))
			{
				if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_signaling_nan.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs) || FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_signaling_nan.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2))
				{
					Fputil_raise_except_if_required.Invoke(1);
				}
				if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_quiet_nan.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs))
				{
					Llvm_lifetime_start_p0.Invoke(4L, &num4);
					num4 = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs));
					num4 >>>= 13;
					Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva);
					anon_izyfb3.Val = FPStorage_fputil_FPType_1_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
					short field_ = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan.Invoke(V: (short)num4, Sign: anon_izyfb3.Val);
					llvm_libc_20_1_2_fputil_FPBits_2fahva.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
					result = FPBits_Float16_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva);
					Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva);
					Llvm_lifetime_end_p0.Invoke(4L, &num4);
				}
				else if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_quiet_nan.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2))
				{
					Llvm_lifetime_start_p0.Invoke(4L, &num5);
					num5 = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2));
					num5 >>>= 13;
					Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva2);
					anon_izyfb4.Val = FPStorage_fputil_FPType_1_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
					short field_2 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan.Invoke(V: (short)num5, Sign: anon_izyfb4.Val);
					llvm_libc_20_1_2_fputil_FPBits_2fahva2.FPRepImpl.FPRepSem.FPStorage.field_0 = field_2;
					result = FPBits_Float16_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva2);
					Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva2);
					Llvm_lifetime_end_p0.Invoke(4L, &num5);
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva3);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb5, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
					short field_3 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan.Invoke(anon_izyfb5.Val, 0);
					llvm_libc_20_1_2_fputil_FPBits_2fahva3.FPRepImpl.FPRepSem.FPStorage.field_0 = field_3;
					result = FPBits_Float16_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva3);
					Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva3);
				}
			}
			else if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_inf.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs))
			{
				if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_inf.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2))
				{
					if ((b & 1) != 1)
					{
						Fputil_raise_except_if_required.Invoke(1);
						Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva4);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb6, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
						short field_4 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan.Invoke(anon_izyfb6.Val, 0);
						llvm_libc_20_1_2_fputil_FPBits_2fahva4.FPRepImpl.FPRepSem.FPStorage.field_0 = field_4;
						result = FPBits_Float16_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva4);
						Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva4);
					}
					else
					{
						Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva5);
						anon_izyfb7.Val = FPStorage_fputil_FPType_1_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
						short field_5 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_inf.Invoke(anon_izyfb7.Val);
						llvm_libc_20_1_2_fputil_FPBits_2fahva5.FPRepImpl.FPRepSem.FPStorage.field_0 = field_5;
						result = FPBits_Float16_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva5);
						Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva5);
					}
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva6);
					anon_izyfb8.Val = FPStorage_fputil_FPType_1_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
					short field_6 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_inf.Invoke(anon_izyfb8.Val);
					llvm_libc_20_1_2_fputil_FPBits_2fahva6.FPRepImpl.FPRepSem.FPStorage.field_0 = field_6;
					result = FPBits_Float16_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva6);
					Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva6);
				}
			}
			else if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_inf.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2))
			{
				Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva7);
				anon_izyfb9.Val = FPStorage_fputil_FPType_1_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
				short field_7 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_inf.Invoke(anon_izyfb9.Val);
				llvm_libc_20_1_2_fputil_FPBits_2fahva7.FPRepImpl.FPRepSem.FPStorage.field_0 = field_7;
				result = FPBits_Float16_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva7);
				Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva7);
			}
			else if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_zero.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs))
			{
				if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_zero.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2))
				{
					if (Fputil_quick_get_round.Invoke() == 1024)
					{
						Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva8);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb10, Llvm_libc_20_1_2_Sign_NEG.Pointer, 1L, isVolatile: false);
						short field_8 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_zero.Invoke(anon_izyfb10.Val);
						llvm_libc_20_1_2_fputil_FPBits_2fahva8.FPRepImpl.FPRepSem.FPStorage.field_0 = field_8;
						result = FPBits_Float16_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva8);
						Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva8);
					}
					else
					{
						Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva9);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb11, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
						short field_9 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_zero.Invoke(anon_izyfb11.Val);
						llvm_libc_20_1_2_fputil_FPBits_2fahva9.FPRepImpl.FPRepSem.FPStorage.field_0 = field_9;
						result = FPBits_Float16_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva9);
						Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva9);
					}
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(4L, &num6);
					num6 = Y;
					num6 = 0f - num6;
					result = Fputil_cast_Float16_float.Invoke(num6);
					Llvm_lifetime_end_p0.Invoke(4L, &num6);
				}
			}
			else
			{
				if (!FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_zero.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2))
				{
					goto IL_07c7;
				}
				Llvm_lifetime_start_p0.Invoke(4L, &num7);
				num7 = Y;
				num7 = 0f - num7;
				result = Fputil_cast_Float16_float.Invoke(num7);
				Llvm_lifetime_end_p0.Invoke(4L, &num7);
			}
			goto IL_0e34;
		}
		IL_0e34:
		Llvm_lifetime_end_p0.Invoke(1L, &b);
		Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
		Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Llvm_lifetime_end_p0.Invoke(4L, &num3);
		Llvm_lifetime_end_p0.Invoke(4L, &num2);
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
		IL_07c7:
		Llvm_lifetime_start_p0.Invoke(4L, &num8);
		Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs3);
		unchecked
		{
			int field_10 = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_abs.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs));
			llvm_libc_20_1_2_fputil_FPBits_5nkvcs3.FPRepImpl.FPRepSem.field_0.field_0 = field_10;
			float num17 = FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs3);
			Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs3);
			num8 = num17;
			Llvm_lifetime_start_p0.Invoke(4L, &num9);
			Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs4);
			int field_11 = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_abs.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2));
			llvm_libc_20_1_2_fputil_FPBits_5nkvcs4.FPRepImpl.FPRepSem.field_0.field_0 = field_11;
			float num18 = FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs4);
			Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs4);
			num9 = num18;
			if (num8 == num9 && (b & 1) != 1)
			{
				if (Fputil_quick_get_round.Invoke() == 1024)
				{
					Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva10);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb12, Llvm_libc_20_1_2_Sign_NEG.Pointer, 1L, isVolatile: false);
					short field_12 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_zero.Invoke(anon_izyfb12.Val);
					llvm_libc_20_1_2_fputil_FPBits_2fahva10.FPRepImpl.FPRepSem.FPStorage.field_0 = field_12;
					result = FPBits_Float16_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva10);
					Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva10);
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva11);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb13, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
					short field_13 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_zero.Invoke(anon_izyfb13.Val);
					llvm_libc_20_1_2_fputil_FPBits_2fahva11.FPRepImpl.FPRepSem.FPStorage.field_0 = field_13;
					result = FPBits_Float16_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva11);
					Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva11);
				}
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb14);
				*(sbyte*)(&anon_izyfb14) = -86;
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb14, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
				if (num8 > num9)
				{
					Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb15);
					anon_izyfb15.Val = FPStorage_fputil_FPType_1_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb14, &anon_izyfb15, 1L, isVolatile: false);
					Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb15);
				}
				else if (num8 < num9)
				{
					if ((b & 1) == 1)
					{
						Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb16);
						anon_izyfb16.Val = FPStorage_fputil_FPType_1_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb14, &anon_izyfb16, 1L, isVolatile: false);
						Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb16);
					}
					else if (FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_pos.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2)))
					{
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb14, Llvm_libc_20_1_2_Sign_NEG.Pointer, 1L, isVolatile: false);
					}
				}
				else if ((b & 1) == 1)
				{
					Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb17);
					anon_izyfb17.Val = FPStorage_fputil_FPType_1_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb14, &anon_izyfb17, 1L, isVolatile: false);
					Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb17);
				}
				Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs5);
				*(int*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs5) = -1431655766;
				FPBits_float_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs5, *(float*)Cpp_max_float.Invoke(&num8, &num9));
				Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs6);
				*(int*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs6) = -1431655766;
				FPBits_float_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs6, *(float*)Cpp_min_float.Invoke(&num8, &num9));
				Llvm_lifetime_start_p0.Invoke(4L, &num10);
				num10 = -1431655766;
				if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_subnormal.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs5))
				{
					num10 = (((b & 1) != 1) ? (FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs5)) - FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs6))) : (FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs5)) + FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs6))));
					num10 <<= 3;
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(4L, &num11);
					num11 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_get_explicit_mantissa.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs5) << 3;
					Llvm_lifetime_start_p0.Invoke(4L, &num12);
					num12 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_get_explicit_mantissa.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs6) << 3;
					Llvm_lifetime_start_p0.Invoke(4L, &num13);
					checked
					{
						num13 = unchecked((ushort)FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_biased_exponent.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs5))) - unchecked((ushort)FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_biased_exponent.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs6)));
						Llvm_lifetime_start_p0.Invoke(4L, &num14);
						num14 = num12 >>> *unchecked((int*)Cpp_min_int.Invoke(&num13, &num3));
						Llvm_lifetime_start_p0.Invoke(1L, &b2);
						b2 = -86;
						b2 = ((num13 > 3 && (num13 > 26 || num12 << 32 - num13 != 0)) ? ((sbyte)1) : ((sbyte)0));
						Llvm_lifetime_start_p0.Invoke(4L, &num15);
						num15 = (((b2 & 1) == 1) ? 1 : 0);
					}
					num10 = (((b & 1) != 1) ? (num11 - (num14 | num15)) : (num11 + (num14 | num15)));
					Llvm_lifetime_end_p0.Invoke(4L, &num15);
					Llvm_lifetime_end_p0.Invoke(1L, &b2);
					Llvm_lifetime_end_p0.Invoke(4L, &num14);
					Llvm_lifetime_end_p0.Invoke(4L, &num13);
					Llvm_lifetime_end_p0.Invoke(4L, &num12);
					Llvm_lifetime_end_p0.Invoke(4L, &num11);
				}
				Llvm_lifetime_start_p0.Invoke(4L, &num16);
				checked
				{
					num16 = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_exponent.Invoke(unchecked((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs5))) - 26;
					Llvm_lifetime_start_p0.Invoke(12L, &llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs);
				}
				*(sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs) = -86;
				sbyte* ptr = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs) + 1;
				*ptr = -86;
				ptr[1] = -86;
				ptr[2] = -86;
				((int*)(&llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs))[1] = -1431655766;
				((int*)(&llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs))[2] = -1431655766;
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb18, &anon_izyfb14, 1L, isVolatile: false);
				int e = num16;
				BigInt_32ul_false_unsigned_int_BigInt_unsigned_int_void.Invoke(&llvm_libc_20_1_2_BigInt_vtm4cw, num10);
				DyadicFloat_32ul_Constructor.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs, anon_izyfb18.Val, e, *(int*)(&llvm_libc_20_1_2_BigInt_vtm4cw.Val.Data));
				result = DyadicFloat_32ul_as_Float16_true_void.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs);
				Llvm_lifetime_end_p0.Invoke(12L, &llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs);
				Llvm_lifetime_end_p0.Invoke(4L, &num16);
				Llvm_lifetime_end_p0.Invoke(4L, &num10);
				Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs6);
				Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs5);
				Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb14);
			}
			Llvm_lifetime_end_p0.Invoke(4L, &num9);
			Llvm_lifetime_end_p0.Invoke(4L, &num8);
			goto IL_0e34;
		}
	}
}
