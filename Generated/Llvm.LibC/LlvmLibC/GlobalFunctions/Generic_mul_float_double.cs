using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Generic_mul_float_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic3mulIfdEENS_3cpp9enable_ifIXaaaasr3cppE19is_floating_point_vIT_Esr3cppE19is_floating_point_vIT0_ElestS5_stS6_ES5_E4typeES6_S6_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<float> && cpp::is_floating_point_v<double> && sizeof (float) <= sizeof (double), float>::type __llvm_libc_20_1_2_::fputil::generic::mul<float, double>(double, double)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<float> && cpp::is_floating_point_v<double> && sizeof (float) <= sizeof (double), float>::type")]
	public unsafe static float Invoke([MangledName("x")][NativeType("double")] double X, [MangledName("y")][NativeType("double")] double Y)
	{
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm = default(Fputil_FPBits_wjhbrm);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(Fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		long num = 0L;
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs = default(Fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb4 = default(Anon_izyfb7);
		long num2 = 0L;
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
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd = default(Fputil_DyadicFloat_kt2kd4);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd2 = default(Fputil_DyadicFloat_kt2kd4);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd3 = default(Fputil_DyadicFloat_kt2kd4);
		Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
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
			float result;
			if (Details_expects_bool_condition_bool.Invoke(FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_inf_or_nan.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm)) || FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_inf_or_nan.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2)) || FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm)) || FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2)), Expected: false))
			{
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
						num >>>= 29;
						Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs);
						anon_izyfb4.Val = FPStorage_fputil_FPType_2_sign.Invoke(&fputil_FPBits_wjhbrm);
						int field_ = FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan.Invoke(V: (int)num, Sign: anon_izyfb4.Val);
						fputil_FPBits_5nkvcs.FPRepImpl.FPRepSem.field_0.field_0 = field_;
						result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs);
						Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs);
						Llvm_lifetime_end_p0.Invoke(8L, &num);
					}
					else if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_quiet_nan.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2)))
					{
						Llvm_lifetime_start_p0.Invoke(8L, &num2);
						num2 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2));
						num2 >>>= 29;
						Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
						anon_izyfb5.Val = FPStorage_fputil_FPType_2_sign.Invoke(&fputil_FPBits_wjhbrm2);
						int field_2 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan.Invoke(V: (int)num2, Sign: anon_izyfb5.Val);
						fputil_FPBits_5nkvcs2.FPRepImpl.FPRepSem.field_0.field_0 = field_2;
						result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs2);
						Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
						Llvm_lifetime_end_p0.Invoke(8L, &num2);
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
				else if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_inf.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm)))
				{
					if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2)))
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
				else if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_inf.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2)))
				{
					if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm)))
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
				DyadicFloat_128ul_DyadicFloat_double_0.Invoke(&fputil_DyadicFloat_kt2kd, X);
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
				DyadicFloat_128ul_DyadicFloat_double_0.Invoke(&fputil_DyadicFloat_kt2kd2, Y);
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
				result = DyadicFloat_128ul_as_float_true_void.Invoke(&fputil_DyadicFloat_kt2kd3);
				Llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd3);
				Llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd2);
				Llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd);
			}
			Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb);
			Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
			return result;
		}
	}
}
