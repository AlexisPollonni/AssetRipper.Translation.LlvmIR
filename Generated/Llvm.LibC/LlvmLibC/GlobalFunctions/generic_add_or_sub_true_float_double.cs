using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class generic_add_or_sub_true_float_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic10add_or_subILb1EfdEENS_3cpp9enable_ifIXaaaasr3cppE19is_floating_point_vIT0_Esr3cppE19is_floating_point_vIT1_ElestS5_stS6_ES5_E4typeES6_S6_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<float> && cpp::is_floating_point_v<double> && sizeof (float) <= sizeof (double), float>::type __llvm_libc_20_1_2_::fputil::generic::add_or_sub<true, float, double>(double, double)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<float> && cpp::is_floating_point_v<double> && sizeof (float) <= sizeof (double), float>::type")]
	public unsafe static float Invoke([NativeType("double")] double x, [NativeType("double")] double y)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		sbyte b = 0;
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		long num4 = 0L;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		long num5 = 0L;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb11 = default(anon_izyfb7);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs4 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb12 = default(anon_izyfb7);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs5 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb13 = default(anon_izyfb7);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs6 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb14 = default(anon_izyfb7);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs7 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb15 = default(anon_izyfb7);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs8 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb16 = default(anon_izyfb7);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs9 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb17 = default(anon_izyfb7);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs10 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb18 = default(anon_izyfb7);
		double num6 = 0.0;
		double num7 = 0.0;
		double num8 = 0.0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm4 = default(fputil_FPBits_wjhbrm);
		double num9 = 0.0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm5 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs11 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb19 = default(anon_izyfb7);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs12 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb20 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb21 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb22 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb23 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb24 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm6 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm7 = default(fputil_FPBits_wjhbrm);
		long num10 = 0L;
		long num11 = 0L;
		long num12 = 0L;
		int num13 = 0;
		long num14 = 0L;
		sbyte b2 = 0;
		long num15 = 0L;
		int num16 = 0;
		fputil_DyadicFloat_syracv fputil_DyadicFloat_syracv2 = default(fputil_DyadicFloat_syracv);
		anon_izyfb7 anon_izyfb25 = default(anon_izyfb7);
		BigInt_555ggs bigInt_555ggs = default(BigInt_555ggs);
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = 3;
		llvm_lifetime_start_p0.Invoke(4L, &num2);
		num2 = 55;
		llvm_lifetime_start_p0.Invoke(4L, &num3);
		num3 = 56;
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		float result;
		unchecked
		{
			*(long*)(&fputil_FPBits_wjhbrm2) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm2, x);
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
			*(long*)(&fputil_FPBits_wjhbrm3) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm3, y);
			llvm_lifetime_start_p0.Invoke(1L, &b);
			anon_izyfb8.val = FPStorage_fputil_FPType_2_sign.Invoke(&fputil_FPBits_wjhbrm2);
			anon_izyfb9.val = FPStorage_fputil_FPType_2_sign.Invoke(&fputil_FPBits_wjhbrm3);
			b = ((!Equals_fy8fvt.Invoke(anon_izyfb8.val, anon_izyfb9.val)) ? ((sbyte)1) : ((sbyte)0));
			if (!details_expects_bool_condition_bool.Invoke(FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_inf_or_nan.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2)) ? true : (FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_inf_or_nan.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm3)) ? true : ((!FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2))) ? FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm3)) : true)), expected: false))
			{
				goto IL_07f2;
			}
			if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_nan.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2)) || FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_nan.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm3)))
			{
				if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_signaling_nan.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2)) || FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_signaling_nan.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm3)))
				{
					fputil_raise_except_if_required.Invoke(1);
				}
				if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_quiet_nan.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2)))
				{
					llvm_lifetime_start_p0.Invoke(8L, &num4);
					num4 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2));
					num4 >>>= 29;
					llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
					anon_izyfb10.val = FPStorage_fputil_FPType_2_sign.Invoke(&fputil_FPBits_wjhbrm2);
					int field_ = FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan.Invoke(v: (int)num4, sign: anon_izyfb10.val);
					fputil_FPBits_5nkvcs2.FPRepImpl.FPRepSem.field_0.field_0 = field_;
					result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs2);
					llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
					llvm_lifetime_end_p0.Invoke(8L, &num4);
				}
				else if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_quiet_nan.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm3)))
				{
					llvm_lifetime_start_p0.Invoke(8L, &num5);
					num5 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm3));
					num5 >>>= 29;
					llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
					anon_izyfb11.val = FPStorage_fputil_FPType_2_sign.Invoke(&fputil_FPBits_wjhbrm3);
					int field_2 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan.Invoke(v: (int)num5, sign: anon_izyfb11.val);
					fputil_FPBits_5nkvcs3.FPRepImpl.FPRepSem.field_0.field_0 = field_2;
					result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs3);
					llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
					llvm_lifetime_end_p0.Invoke(8L, &num5);
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb12, Sign_POS.Pointer, 1L, isVolatile: false);
					int field_3 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan.Invoke(anon_izyfb12.val, 0);
					fputil_FPBits_5nkvcs4.FPRepImpl.FPRepSem.field_0.field_0 = field_3;
					result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs4);
					llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
				}
			}
			else if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_inf.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2)))
			{
				if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_inf.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm3)))
				{
					if ((b & 1) != 1)
					{
						fputil_raise_except_if_required.Invoke(1);
						llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs5);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb13, Sign_POS.Pointer, 1L, isVolatile: false);
						int field_4 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan.Invoke(anon_izyfb13.val, 0);
						fputil_FPBits_5nkvcs5.FPRepImpl.FPRepSem.field_0.field_0 = field_4;
						result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs5);
						llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs5);
					}
					else
					{
						llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs6);
						anon_izyfb14.val = FPStorage_fputil_FPType_2_sign.Invoke(&fputil_FPBits_wjhbrm2);
						int field_5 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_inf.Invoke(anon_izyfb14.val);
						fputil_FPBits_5nkvcs6.FPRepImpl.FPRepSem.field_0.field_0 = field_5;
						result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs6);
						llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs6);
					}
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs7);
					anon_izyfb15.val = FPStorage_fputil_FPType_2_sign.Invoke(&fputil_FPBits_wjhbrm2);
					int field_6 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_inf.Invoke(anon_izyfb15.val);
					fputil_FPBits_5nkvcs7.FPRepImpl.FPRepSem.field_0.field_0 = field_6;
					result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs7);
					llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs7);
				}
			}
			else if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_inf.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm3)))
			{
				llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs8);
				anon_izyfb16.val = FPStorage_fputil_FPType_2_sign.Invoke(&fputil_FPBits_wjhbrm3);
				int field_7 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_inf.Invoke(anon_izyfb16.val);
				fputil_FPBits_5nkvcs8.FPRepImpl.FPRepSem.field_0.field_0 = field_7;
				result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs8);
				llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs8);
			}
			else if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2)))
			{
				if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm3)))
				{
					if (fputil_quick_get_round.Invoke() == 1024)
					{
						llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs9);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb17, Sign_NEG.Pointer, 1L, isVolatile: false);
						int field_8 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_zero.Invoke(anon_izyfb17.val);
						fputil_FPBits_5nkvcs9.FPRepImpl.FPRepSem.field_0.field_0 = field_8;
						result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs9);
						llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs9);
					}
					else
					{
						llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs10);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb18, Sign_POS.Pointer, 1L, isVolatile: false);
						int field_9 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_zero.Invoke(anon_izyfb18.val);
						fputil_FPBits_5nkvcs10.FPRepImpl.FPRepSem.field_0.field_0 = field_9;
						result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs10);
						llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs10);
					}
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(8L, &num6);
					num6 = y;
					num6 = 0.0 - num6;
					result = fputil_cast_float_double.Invoke(num6);
					llvm_lifetime_end_p0.Invoke(8L, &num6);
				}
			}
			else
			{
				if (!FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm3)))
				{
					goto IL_07f2;
				}
				llvm_lifetime_start_p0.Invoke(8L, &num7);
				num7 = y;
				num7 = 0.0 - num7;
				result = fputil_cast_float_double.Invoke(num7);
				llvm_lifetime_end_p0.Invoke(8L, &num7);
			}
			goto IL_0e94;
		}
		IL_0e94:
		llvm_lifetime_end_p0.Invoke(1L, &b);
		llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
		llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		llvm_lifetime_end_p0.Invoke(4L, &num3);
		llvm_lifetime_end_p0.Invoke(4L, &num2);
		llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
		IL_07f2:
		llvm_lifetime_start_p0.Invoke(8L, &num8);
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
		unchecked
		{
			long val = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_abs.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2));
			fputil_FPBits_wjhbrm4.FPRepImpl.FPRepSem.FPStorage.val = val;
			double num17 = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm4);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
			num8 = num17;
			llvm_lifetime_start_p0.Invoke(8L, &num9);
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
			long val2 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_abs.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm3));
			fputil_FPBits_wjhbrm5.FPRepImpl.FPRepSem.FPStorage.val = val2;
			double num18 = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm5);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
			num9 = num18;
			if (num8 == num9 && (b & 1) != 1)
			{
				if (fputil_quick_get_round.Invoke() == 1024)
				{
					llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs11);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb19, Sign_NEG.Pointer, 1L, isVolatile: false);
					int field_10 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_zero.Invoke(anon_izyfb19.val);
					fputil_FPBits_5nkvcs11.FPRepImpl.FPRepSem.field_0.field_0 = field_10;
					result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs11);
					llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs11);
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs12);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb20, Sign_POS.Pointer, 1L, isVolatile: false);
					int field_11 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_zero.Invoke(anon_izyfb20.val);
					fputil_FPBits_5nkvcs12.FPRepImpl.FPRepSem.field_0.field_0 = field_11;
					result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs12);
					llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs12);
				}
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb21);
				*(sbyte*)(&anon_izyfb21) = -86;
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb21, Sign_POS.Pointer, 1L, isVolatile: false);
				if (num8 > num9)
				{
					llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb22);
					anon_izyfb22.val = FPStorage_fputil_FPType_2_sign.Invoke(&fputil_FPBits_wjhbrm2);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb21, &anon_izyfb22, 1L, isVolatile: false);
					llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb22);
				}
				else if (num8 < num9)
				{
					if ((b & 1) == 1)
					{
						llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb23);
						anon_izyfb23.val = FPStorage_fputil_FPType_2_sign.Invoke(&fputil_FPBits_wjhbrm3);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb21, &anon_izyfb23, 1L, isVolatile: false);
						llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb23);
					}
					else if (FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_pos.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm3)))
					{
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb21, Sign_NEG.Pointer, 1L, isVolatile: false);
					}
				}
				else if ((b & 1) == 1)
				{
					llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb24);
					anon_izyfb24.val = FPStorage_fputil_FPType_2_sign.Invoke(&fputil_FPBits_wjhbrm2);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb21, &anon_izyfb24, 1L, isVolatile: false);
					llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb24);
				}
				llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm6);
				*(long*)(&fputil_FPBits_wjhbrm6) = -6148914691236517206L;
				FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm6, *(double*)cpp_max_double.Invoke(&num8, &num9));
				llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm7);
				*(long*)(&fputil_FPBits_wjhbrm7) = -6148914691236517206L;
				FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm7, *(double*)cpp_min_double.Invoke(&num8, &num9));
				llvm_lifetime_start_p0.Invoke(8L, &num10);
				num10 = -6148914691236517206L;
				if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_subnormal.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm6)))
				{
					num10 = (((b & 1) != 1) ? (FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm6)) - FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm7))) : (FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm6)) + FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm7))));
					num10 <<= 3;
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(8L, &num11);
					num11 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_get_explicit_mantissa.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm6)) << 3;
					llvm_lifetime_start_p0.Invoke(8L, &num12);
					num12 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_get_explicit_mantissa.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm7)) << 3;
					llvm_lifetime_start_p0.Invoke(4L, &num13);
					checked
					{
						num13 = unchecked((ushort)FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_biased_exponent.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm6))) - unchecked((ushort)FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_biased_exponent.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm7)));
						llvm_lifetime_start_p0.Invoke(8L, &num14);
					}
					num14 = num12 >>> (int)(uint)(*(int*)cpp_min_int.Invoke(&num13, &num3));
					llvm_lifetime_start_p0.Invoke(1L, &b2);
					b2 = -86;
					b2 = ((num13 > 3 && (num13 > 55 || num12 << (int)(uint)checked(64 - num13) != 0L)) ? ((sbyte)1) : ((sbyte)0));
					llvm_lifetime_start_p0.Invoke(8L, &num15);
					num15 = (((b2 & 1) == 1) ? 1 : 0);
					num10 = (((b & 1) != 1) ? (num11 - (num14 | num15)) : (num11 + (num14 | num15)));
					llvm_lifetime_end_p0.Invoke(8L, &num15);
					llvm_lifetime_end_p0.Invoke(1L, &b2);
					llvm_lifetime_end_p0.Invoke(8L, &num14);
					llvm_lifetime_end_p0.Invoke(4L, &num13);
					llvm_lifetime_end_p0.Invoke(8L, &num12);
					llvm_lifetime_end_p0.Invoke(8L, &num11);
				}
				llvm_lifetime_start_p0.Invoke(4L, &num16);
				checked
				{
					num16 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_exponent.Invoke(unchecked((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm6))) - 55;
					llvm_lifetime_start_p0.Invoke(16L, &fputil_DyadicFloat_syracv2);
				}
				*(sbyte*)(&fputil_DyadicFloat_syracv2) = -86;
				sbyte* ptr = (sbyte*)(&fputil_DyadicFloat_syracv2) + 1;
				*ptr = -86;
				ptr[1] = -86;
				ptr[2] = -86;
				((int*)(&fputil_DyadicFloat_syracv2))[1] = -1431655766;
				((long*)(&fputil_DyadicFloat_syracv2))[1] = -6148914691236517206L;
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb25, &anon_izyfb21, 1L, isVolatile: false);
				int e = num16;
				BigInt_64ul_false_unsigned_long_BigInt_unsigned_long_void.Invoke(&bigInt_555ggs, num10);
				DyadicFloat_64ul_Constructor.Invoke(&fputil_DyadicFloat_syracv2, anon_izyfb25.val, e, *(long*)(&bigInt_555ggs.val.Data));
				result = DyadicFloat_64ul_as_float_true_void.Invoke(&fputil_DyadicFloat_syracv2);
				llvm_lifetime_end_p0.Invoke(16L, &fputil_DyadicFloat_syracv2);
				llvm_lifetime_end_p0.Invoke(4L, &num16);
				llvm_lifetime_end_p0.Invoke(8L, &num10);
				llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm7);
				llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm6);
				llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb21);
			}
			llvm_lifetime_end_p0.Invoke(8L, &num9);
			llvm_lifetime_end_p0.Invoke(8L, &num8);
			goto IL_0e94;
		}
	}
}
