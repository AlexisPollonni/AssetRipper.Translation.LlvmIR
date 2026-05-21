using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Generic_fma_Float16_float
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic3fmaIDF16_fEENS_3cpp9enable_ifIXaaaasr3cppE19is_floating_point_vIT_Esr3cppE19is_floating_point_vIT0_ElestS5_stS6_ES5_E4typeES6_S6_S6_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16> && cpp::is_floating_point_v<float> && sizeof (_Float16) <= sizeof (float), _Float16>::type __llvm_libc_20_1_2_::fputil::generic::fma<_Float16, float>(float, float, float)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16> && cpp::is_floating_point_v<float> && sizeof (_Float16) <= sizeof (float), _Float16>::type")]
	public unsafe static Half Invoke([MangledName("x")][NativeType("float")] float X, [MangledName("y")][NativeType("float")] float Y, [MangledName("z")][NativeType("float")] float Z)
	{
		int num = 0;
		long num2 = 0L;
		long num3 = 0L;
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs2 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs3 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		int num4 = 0;
		Llvm_libc_20_1_2_fputil_FPBits_2fahva llvm_libc_20_1_2_fputil_FPBits_2fahva = default(Llvm_libc_20_1_2_fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		int num5 = 0;
		Llvm_libc_20_1_2_fputil_FPBits_2fahva llvm_libc_20_1_2_fputil_FPBits_2fahva2 = default(Llvm_libc_20_1_2_fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		int num6 = 0;
		Llvm_libc_20_1_2_fputil_FPBits_2fahva llvm_libc_20_1_2_fputil_FPBits_2fahva3 = default(Llvm_libc_20_1_2_fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_2fahva llvm_libc_20_1_2_fputil_FPBits_2fahva4 = default(Llvm_libc_20_1_2_fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb4 = default(Anon_izyfb7);
		int num7 = 0;
		int num8 = 0;
		int num9 = 0;
		int num10 = 0;
		float num11 = 0f;
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs4 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs5 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs6 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs7 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs8 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs9 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb5 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb6 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb7 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb8 = default(Anon_izyfb7);
		int v = 0;
		int v2 = 0;
		Llvm_libc_20_1_2_BigInt_555ggs llvm_libc_20_1_2_BigInt_555ggs = default(Llvm_libc_20_1_2_BigInt_555ggs);
		Llvm_libc_20_1_2_BigInt_555ggs llvm_libc_20_1_2_BigInt_555ggs2 = default(Llvm_libc_20_1_2_BigInt_555ggs);
		Llvm_libc_20_1_2_BigInt_555ggs llvm_libc_20_1_2_BigInt_555ggs3 = default(Llvm_libc_20_1_2_BigInt_555ggs);
		Llvm_libc_20_1_2_BigInt_555ggs llvm_libc_20_1_2_BigInt_555ggs4 = default(Llvm_libc_20_1_2_BigInt_555ggs);
		int num12 = 0;
		int num13 = 0;
		int num14 = 0;
		sbyte b = 0;
		sbyte b2 = 0;
		Anon_izyfb7 anon_izyfb9 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb10 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_BigInt_555ggs llvm_libc_20_1_2_BigInt_555ggs5 = default(Llvm_libc_20_1_2_BigInt_555ggs);
		Llvm_libc_20_1_2_BigInt_555ggs llvm_libc_20_1_2_BigInt_555ggs6 = default(Llvm_libc_20_1_2_BigInt_555ggs);
		Llvm_libc_20_1_2_fputil_DyadicFloat_syracv llvm_libc_20_1_2_fputil_DyadicFloat_syracv = default(Llvm_libc_20_1_2_fputil_DyadicFloat_syracv);
		Anon_izyfb7 anon_izyfb11 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_BigInt_555ggs llvm_libc_20_1_2_BigInt_555ggs7 = default(Llvm_libc_20_1_2_BigInt_555ggs);
		Llvm_libc_20_1_2_BigInt_555ggs llvm_libc_20_1_2_BigInt_555ggs8 = default(Llvm_libc_20_1_2_BigInt_555ggs);
		Llvm_libc_20_1_2_BigInt_555ggs llvm_libc_20_1_2_BigInt_555ggs9 = default(Llvm_libc_20_1_2_BigInt_555ggs);
		float num15 = X;
		float num16 = Y;
		float num17 = Z;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = 24;
		Llvm_lifetime_start_p0.Invoke(8L, &num2);
		num2 = 48L;
		Llvm_lifetime_start_p0.Invoke(8L, &num3);
		num3 = 64L;
		Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		unchecked
		{
			*(int*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs) = -1431655766;
			FPBits_float_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs, num15);
			Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
			*(int*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2) = -1431655766;
			FPBits_float_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2, num16);
			Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs3);
			*(int*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs3) = -1431655766;
			FPBits_float_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs3, num17);
			Half result;
			if (Details_expects_bool_condition_bool.Invoke(FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs) ? true : ((!FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2)) ? FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs3) : true), Expected: false) && (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs) || FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2)))
			{
				if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_signaling_nan.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs) || FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_signaling_nan.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2) || FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_signaling_nan.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs3))
				{
					Fputil_raise_except_if_required.Invoke(1);
				}
				if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_quiet_nan.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs))
				{
					Llvm_lifetime_start_p0.Invoke(4L, &num4);
					num4 = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs));
					num4 >>>= 13;
					Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva);
					anon_izyfb.Val = FPStorage_fputil_FPType_1_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
					short field_ = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan.Invoke(V: (short)num4, Sign: anon_izyfb.Val);
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
					anon_izyfb2.Val = FPStorage_fputil_FPType_1_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
					short field_2 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan.Invoke(V: (short)num5, Sign: anon_izyfb2.Val);
					llvm_libc_20_1_2_fputil_FPBits_2fahva2.FPRepImpl.FPRepSem.FPStorage.field_0 = field_2;
					result = FPBits_Float16_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva2);
					Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva2);
					Llvm_lifetime_end_p0.Invoke(4L, &num5);
				}
				else if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_quiet_nan.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs3))
				{
					Llvm_lifetime_start_p0.Invoke(4L, &num6);
					num6 = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs3));
					num6 >>>= 13;
					Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva3);
					anon_izyfb3.Val = FPStorage_fputil_FPType_1_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs3);
					short field_3 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan.Invoke(V: (short)num6, Sign: anon_izyfb3.Val);
					llvm_libc_20_1_2_fputil_FPBits_2fahva3.FPRepImpl.FPRepSem.FPStorage.field_0 = field_3;
					result = FPBits_Float16_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva3);
					Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva3);
					Llvm_lifetime_end_p0.Invoke(4L, &num6);
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva4);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb4, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
					short field_4 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan.Invoke(anon_izyfb4.Val, 0);
					llvm_libc_20_1_2_fputil_FPBits_2fahva4.FPRepImpl.FPRepSem.FPStorage.field_0 = field_4;
					result = FPBits_Float16_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva4);
					Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva4);
				}
			}
			else if (Details_expects_bool_condition_bool.Invoke((num15 == 0f) ? true : ((num16 != 0f) ? (num17 == 0f) : true), Expected: false))
			{
				result = Fputil_cast_Float16_float.Invoke(Llvm_fmuladd_f32.Invoke(num15, num16, num17));
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num7);
				num7 = 0;
				Llvm_lifetime_start_p0.Invoke(4L, &num8);
				num8 = 0;
				Llvm_lifetime_start_p0.Invoke(4L, &num9);
				num9 = 0;
				Llvm_lifetime_start_p0.Invoke(4L, &num10);
				num10 = 0;
				Llvm_lifetime_start_p0.Invoke(4L, &num11);
				num11 = 8388608f;
				Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs4);
				FPBits_float_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs4, num15);
				bool num18 = Details_expects_bool_condition_bool.Invoke(FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_subnormal.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs4), Expected: false);
				Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs4);
				checked
				{
					if (num18)
					{
						num7 -= 23;
						num15 *= 8388608f;
					}
					Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs5);
					FPBits_float_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs5, num16);
					bool num19 = Details_expects_bool_condition_bool.Invoke(FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_subnormal.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs5), Expected: false);
					Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs5);
					if (num19)
					{
						num8 -= 23;
						num16 *= 8388608f;
					}
					Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs6);
					FPBits_float_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs6, num17);
					bool num20 = Details_expects_bool_condition_bool.Invoke(FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_subnormal.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs6), Expected: false);
					Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs6);
					if (num20)
					{
						num9 -= 23;
						num17 *= 8388608f;
					}
					Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs7);
					FPBits_float_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs7, num15);
					Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs7, 4L, isVolatile: false);
					Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs7);
					Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs8);
					FPBits_float_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs8, num16);
					Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs8, 4L, isVolatile: false);
					Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs8);
					Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs9);
					FPBits_float_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs9, num17);
					Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs3, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs9, 4L, isVolatile: false);
					Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs9);
					Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb5);
				}
				*(sbyte*)(&anon_izyfb5) = -86;
				anon_izyfb5.Val = FPStorage_fputil_FPType_1_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs3);
				Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb6);
				*(sbyte*)(&anon_izyfb6) = -86;
				anon_izyfb7.Val = FPStorage_fputil_FPType_1_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
				anon_izyfb8.Val = FPStorage_fputil_FPType_1_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb6, (!Llvm_libc_20_1_2_Equals_fy8fvt.Invoke(anon_izyfb7.Val, anon_izyfb8.Val)) ? Llvm_libc_20_1_2_Sign_NEG.Pointer : Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
				int num21 = (ushort)FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_biased_exponent.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs));
				num7 = checked(num7 + num21);
				int num22 = (ushort)FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_biased_exponent.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2));
				num8 = checked(num8 + num22);
				int num23 = (ushort)FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_biased_exponent.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs3));
				num9 = checked(num9 + num23);
				if (Details_expects_bool_condition_bool.Invoke((num7 == 255) ? true : ((num8 != 255) ? (num9 == 255) : true), Expected: false))
				{
					result = Fputil_cast_Float16_float.Invoke(Llvm_fmuladd_f32.Invoke(num15, num16, num17));
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(4L, &v);
					v = FPRepSem_fputil_FPType_1_fputil_FPBits_float_get_explicit_mantissa.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
					Llvm_lifetime_start_p0.Invoke(4L, &v2);
					v2 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_get_explicit_mantissa.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
					Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_BigInt_555ggs);
					*(long*)(&llvm_libc_20_1_2_BigInt_555ggs) = -6148914691236517206L;
					BigInt_64ul_false_unsigned_long_BigInt_unsigned_int_void.Invoke(&llvm_libc_20_1_2_BigInt_555ggs, FPRepSem_fputil_FPType_1_fputil_FPBits_float_get_explicit_mantissa.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs3));
					Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_BigInt_555ggs2);
					*(long*)(&llvm_libc_20_1_2_BigInt_555ggs2) = -6148914691236517206L;
					Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_BigInt_555ggs3);
					BigInt_64ul_false_unsigned_long_BigInt_unsigned_int_void.Invoke(&llvm_libc_20_1_2_BigInt_555ggs3, v);
					Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_BigInt_555ggs4);
					BigInt_64ul_false_unsigned_long_BigInt_unsigned_int_void.Invoke(&llvm_libc_20_1_2_BigInt_555ggs4, v2);
					long data = BigInt_64ul_false_unsigned_long_Multiply.Invoke(&llvm_libc_20_1_2_BigInt_555ggs3, &llvm_libc_20_1_2_BigInt_555ggs4);
					*(long*)(&llvm_libc_20_1_2_BigInt_555ggs2.Val.Data) = data;
					Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_BigInt_555ggs4);
					Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_BigInt_555ggs3);
					Llvm_lifetime_start_p0.Invoke(4L, &num12);
					checked
					{
						num12 = num7 + num8 - 173;
						Llvm_lifetime_start_p0.Invoke(4L, &num13);
						num13 = 25;
						BigInt_64ul_false_unsigned_long_Operator_pq2pm2.Invoke(&llvm_libc_20_1_2_BigInt_555ggs, 25L);
						Llvm_lifetime_start_p0.Invoke(4L, &num14);
						num14 = num9 - 48;
						Llvm_lifetime_start_p0.Invoke(1L, &b);
						b = 0;
						Llvm_lifetime_start_p0.Invoke(1L, &b2);
						b2 = 0;
						if (num12 < num14)
						{
							b = (Internal_shift_mantissa_BigInt_64ul_false_unsigned_long.Invoke(num14 - num12, &llvm_libc_20_1_2_BigInt_555ggs2) ? ((sbyte)1) : ((sbyte)0));
							num12 = num14;
						}
						else if (num14 < num12)
						{
							b2 = 1;
							b = (Internal_shift_mantissa_BigInt_64ul_false_unsigned_long.Invoke(num12 - num14, &llvm_libc_20_1_2_BigInt_555ggs) ? ((sbyte)1) : ((sbyte)0));
						}
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, &anon_izyfb6, 1L, isVolatile: false);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb10, &anon_izyfb5, 1L, isVolatile: false);
					}
					if (Llvm_libc_20_1_2_Equals_fy8fvt.Invoke(anon_izyfb9.Val, anon_izyfb10.Val))
					{
						BigInt_64ul_false_unsigned_long_Operator_qf3c8p.Invoke(&llvm_libc_20_1_2_BigInt_555ggs2, &llvm_libc_20_1_2_BigInt_555ggs);
					}
					else if (Llvm_libc_20_1_2_GreaterThanOrEquals_r32pss.Invoke(&llvm_libc_20_1_2_BigInt_555ggs2, &llvm_libc_20_1_2_BigInt_555ggs))
					{
						if ((b2 & 1) == 1 && (b & 1) == 1)
						{
							BigInt_64ul_false_unsigned_long_Increment.Invoke(&llvm_libc_20_1_2_BigInt_555ggs);
						}
						BigInt_64ul_false_unsigned_long_Operator_wnux5g.Invoke(&llvm_libc_20_1_2_BigInt_555ggs2, &llvm_libc_20_1_2_BigInt_555ggs);
					}
					else
					{
						if ((b2 & 1) != 1 && (b & 1) == 1)
						{
							BigInt_64ul_false_unsigned_long_Increment.Invoke(&llvm_libc_20_1_2_BigInt_555ggs2);
						}
						Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_BigInt_555ggs5);
						long data2 = BigInt_64ul_false_unsigned_long_Subtract_hpqj66.Invoke(&llvm_libc_20_1_2_BigInt_555ggs, &llvm_libc_20_1_2_BigInt_555ggs2);
						*(long*)(&llvm_libc_20_1_2_BigInt_555ggs5.Val.Data) = data2;
						Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_BigInt_555ggs2, &llvm_libc_20_1_2_BigInt_555ggs5, 8L, isVolatile: false);
						Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_BigInt_555ggs5);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb6, &anon_izyfb5, 1L, isVolatile: false);
					}
					Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_BigInt_555ggs6);
					BigInt_64ul_false_unsigned_long_BigInt_int_void.Invoke(&llvm_libc_20_1_2_BigInt_555ggs6, 0);
					bool num24 = Llvm_libc_20_1_2_Equals_tpd9hp.Invoke(&llvm_libc_20_1_2_BigInt_555ggs2, &llvm_libc_20_1_2_BigInt_555ggs6);
					Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_BigInt_555ggs6);
					if (num24)
					{
						if (Fputil_quick_get_round.Invoke() == 1024)
						{
							Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb6, Llvm_libc_20_1_2_Sign_NEG.Pointer, 1L, isVolatile: false);
						}
						else
						{
							Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb6, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
						}
					}
					Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_DyadicFloat_syracv);
					*(sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_syracv) = -86;
					sbyte* ptr = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_syracv) + 1;
					*ptr = -86;
					ptr[1] = -86;
					ptr[2] = -86;
					((int*)(&llvm_libc_20_1_2_fputil_DyadicFloat_syracv))[1] = -1431655766;
					((long*)(&llvm_libc_20_1_2_fputil_DyadicFloat_syracv))[1] = -6148914691236517206L;
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb11, &anon_izyfb6, 1L, isVolatile: false);
					int e = checked(num12 - 127);
					Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_BigInt_555ggs7, &llvm_libc_20_1_2_BigInt_555ggs2, 8L, isVolatile: false);
					DyadicFloat_64ul_Constructor.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_syracv, anon_izyfb11.Val, e, *(long*)(&llvm_libc_20_1_2_BigInt_555ggs7.Val.Data));
					Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_BigInt_555ggs8);
					BigInt_64ul_false_unsigned_long_BigInt_unsigned_int_void.Invoke(&llvm_libc_20_1_2_BigInt_555ggs8, ((b & 1) == 1) ? 1 : 0);
					long data3 = Llvm_libc_20_1_2_Operator_um4whe.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_syracv.Mantissa, &llvm_libc_20_1_2_BigInt_555ggs8);
					*(long*)(&llvm_libc_20_1_2_BigInt_555ggs9.Val.Data) = data3;
					Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_BigInt_555ggs8);
					result = DyadicFloat_64ul_as_Float16_true_void.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_syracv);
					Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_DyadicFloat_syracv);
					Llvm_lifetime_end_p0.Invoke(1L, &b2);
					Llvm_lifetime_end_p0.Invoke(1L, &b);
					Llvm_lifetime_end_p0.Invoke(4L, &num14);
					Llvm_lifetime_end_p0.Invoke(4L, &num13);
					Llvm_lifetime_end_p0.Invoke(4L, &num12);
					Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_BigInt_555ggs2);
					Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_BigInt_555ggs);
					Llvm_lifetime_end_p0.Invoke(4L, &v2);
					Llvm_lifetime_end_p0.Invoke(4L, &v);
				}
				Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb6);
				Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb5);
				Llvm_lifetime_end_p0.Invoke(4L, &num11);
				Llvm_lifetime_end_p0.Invoke(4L, &num10);
				Llvm_lifetime_end_p0.Invoke(4L, &num9);
				Llvm_lifetime_end_p0.Invoke(4L, &num8);
				Llvm_lifetime_end_p0.Invoke(4L, &num7);
			}
			Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs3);
			Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
			Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
			Llvm_lifetime_end_p0.Invoke(8L, &num3);
			Llvm_lifetime_end_p0.Invoke(8L, &num2);
			Llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}
