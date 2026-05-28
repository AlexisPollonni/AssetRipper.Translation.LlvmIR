using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Generic_mul_float_float128
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic3mulIfgEENS_3cpp9enable_ifIXaaaasr3cppE19is_floating_point_vIT_Esr3cppE19is_floating_point_vIT0_ElestS5_stS6_ES5_E4typeES6_S6_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<float> && cpp::is_floating_point_v<__float128> && sizeof (float) <= sizeof (__float128), float>::type __llvm_libc_20_1_2_::fputil::generic::mul<float, __float128>(__float128, __float128)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<float> && cpp::is_floating_point_v<__float128> && sizeof (float) <= sizeof (__float128), float>::type")]
	public unsafe static float Invoke([MangledName("x")][NativeType("__float128")] double X, [MangledName("y")][NativeType("__float128")] double Y)
	{
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi = default(Fputil_FPBits_ubgsi2);
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi2 = default(Fputil_FPBits_ubgsi2);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		Int128 @int = default(Int128);
		Int128 int2 = default(Int128);
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs = default(Fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb4 = default(Anon_izyfb7);
		Int128 int3 = default(Int128);
		Int128 int4 = default(Int128);
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(Fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb5 = default(Anon_izyfb7);
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(Fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb6 = default(Anon_izyfb7);
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs4 = default(Fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb7 = default(Anon_izyfb7);
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs5 = default(Fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb8 = default(Anon_izyfb7);
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs6 = default(Fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb9 = default(Anon_izyfb7);
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs7 = default(Fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb10 = default(Anon_izyfb7);
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs8 = default(Fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb11 = default(Anon_izyfb7);
		Fputil_DyadicFloat_jhcpjj fputil_DyadicFloat_jhcpjj = default(Fputil_DyadicFloat_jhcpjj);
		Fputil_DyadicFloat_jhcpjj fputil_DyadicFloat_jhcpjj2 = default(Fputil_DyadicFloat_jhcpjj);
		Fputil_DyadicFloat_jhcpjj fputil_DyadicFloat_jhcpjj3 = default(Fputil_DyadicFloat_jhcpjj);
		Llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi);
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
			float result;
			if (Details_expects_bool_condition_bool.Invoke(FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_is_inf_or_nan.Invoke(&fputil_FPBits_ubgsi) || FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_is_inf_or_nan.Invoke(&fputil_FPBits_ubgsi2) || FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_zero.Invoke((Fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi)) || FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_zero.Invoke((Fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi2)), Expected: false))
			{
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
						Int128* num = &int2;
						Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
						*(long*)num = struct_fiz2nb2.field_0;
						byte* num2 = (byte*)(&int2) + 8u;
						Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
						*(long*)num2 = struct_fiz2nb3.field_1;
						@int = int2;
						@int = NumericHelper.ShiftRightLogical(@int, 89L);
						Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs);
						anon_izyfb4.Val = FPStorage_fputil_FPType_3_sign.Invoke(&fputil_FPBits_ubgsi);
						int field_ = FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan.Invoke(V: (int)@int, Sign: anon_izyfb4.Val);
						fputil_FPBits_5nkvcs.FPRepImpl.FPRepSem.field_0.field_0 = field_;
						result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs);
						Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs);
						Llvm_lifetime_end_p0.Invoke(16L, &@int);
					}
					else if (FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_quiet_nan.Invoke((Fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi2)))
					{
						Llvm_lifetime_start_p0.Invoke(16L, &int3);
						Struct_fiz2nb struct_fiz2nb4 = FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_get_mantissa.Invoke(&fputil_FPBits_ubgsi2);
						Int128* num3 = &int4;
						Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
						*(long*)num3 = struct_fiz2nb5.field_0;
						byte* num4 = (byte*)(&int4) + 8u;
						Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
						*(long*)num4 = struct_fiz2nb6.field_1;
						int3 = int4;
						int3 = NumericHelper.ShiftRightLogical(int3, 89L);
						Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
						anon_izyfb5.Val = FPStorage_fputil_FPType_3_sign.Invoke(&fputil_FPBits_ubgsi2);
						int field_2 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan.Invoke(V: (int)int3, Sign: anon_izyfb5.Val);
						fputil_FPBits_5nkvcs2.FPRepImpl.FPRepSem.field_0.field_0 = field_2;
						result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs2);
						Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
						Llvm_lifetime_end_p0.Invoke(16L, &int3);
					}
					else
					{
						Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb6, Sign_POS.Pointer, 1L, isVolatile: false);
						int field_3 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan.Invoke(anon_izyfb6.Val, 0);
						fputil_FPBits_5nkvcs3.FPRepImpl.FPRepSem.field_0.field_0 = field_3;
						result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs3);
						Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
					}
				}
				else if (FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_inf.Invoke((Fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi)))
				{
					if (FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_zero.Invoke((Fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi2)))
					{
						Fputil_set_errno_if_required.Invoke(33);
						Fputil_raise_except_if_required.Invoke(1);
						Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb7, Sign_POS.Pointer, 1L, isVolatile: false);
						int field_4 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan.Invoke(anon_izyfb7.Val, 0);
						fputil_FPBits_5nkvcs4.FPRepImpl.FPRepSem.field_0.field_0 = field_4;
						result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs4);
						Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
					}
					else
					{
						Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs5);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, &anon_izyfb, 1L, isVolatile: false);
						int field_5 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_inf.Invoke(anon_izyfb8.Val);
						fputil_FPBits_5nkvcs5.FPRepImpl.FPRepSem.field_0.field_0 = field_5;
						result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs5);
						Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs5);
					}
				}
				else if (FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_inf.Invoke((Fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi2)))
				{
					if (FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_zero.Invoke((Fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi)))
					{
						Fputil_set_errno_if_required.Invoke(33);
						Fputil_raise_except_if_required.Invoke(1);
						Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs6);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, Sign_POS.Pointer, 1L, isVolatile: false);
						int field_6 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan.Invoke(anon_izyfb9.Val, 0);
						fputil_FPBits_5nkvcs6.FPRepImpl.FPRepSem.field_0.field_0 = field_6;
						result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs6);
						Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs6);
					}
					else
					{
						Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs7);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb10, &anon_izyfb, 1L, isVolatile: false);
						int field_7 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_inf.Invoke(anon_izyfb10.Val);
						fputil_FPBits_5nkvcs7.FPRepImpl.FPRepSem.field_0.field_0 = field_7;
						result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs7);
						Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs7);
					}
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs8);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb11, &anon_izyfb, 1L, isVolatile: false);
					int field_8 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_zero.Invoke(anon_izyfb11.Val);
					fputil_FPBits_5nkvcs8.FPRepImpl.FPRepSem.field_0.field_0 = field_8;
					result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs8);
					Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs8);
				}
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(40L, &fputil_DyadicFloat_jhcpjj);
				Llvm_memset_p0_i64.Invoke(&fputil_DyadicFloat_jhcpjj, -86, 40L, isVolatile: false);
				DyadicFloat_256ul_DyadicFloat_float128_0.Invoke(&fputil_DyadicFloat_jhcpjj, X);
				Llvm_lifetime_start_p0.Invoke(40L, &fputil_DyadicFloat_jhcpjj2);
				Llvm_memset_p0_i64.Invoke(&fputil_DyadicFloat_jhcpjj2, -86, 40L, isVolatile: false);
				DyadicFloat_256ul_DyadicFloat_float128_0.Invoke(&fputil_DyadicFloat_jhcpjj2, Y);
				Llvm_lifetime_start_p0.Invoke(40L, &fputil_DyadicFloat_jhcpjj3);
				Llvm_memset_p0_i64.Invoke(&fputil_DyadicFloat_jhcpjj3, -86, 40L, isVolatile: false);
				Fputil_quick_mul_256ul.Invoke(&fputil_DyadicFloat_jhcpjj3, &fputil_DyadicFloat_jhcpjj, &fputil_DyadicFloat_jhcpjj2);
				result = DyadicFloat_256ul_as_float_true_void.Invoke(&fputil_DyadicFloat_jhcpjj3);
				Llvm_lifetime_end_p0.Invoke(40L, &fputil_DyadicFloat_jhcpjj3);
				Llvm_lifetime_end_p0.Invoke(40L, &fputil_DyadicFloat_jhcpjj2);
				Llvm_lifetime_end_p0.Invoke(40L, &fputil_DyadicFloat_jhcpjj);
			}
			Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb);
			Llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi2);
			Llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi);
			return result;
		}
	}
}
