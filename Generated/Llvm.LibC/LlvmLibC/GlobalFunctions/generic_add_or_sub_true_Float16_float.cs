using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class generic_add_or_sub_true_Float16_float
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic10add_or_subILb1EDF16_fEENS_3cpp9enable_ifIXaaaasr3cppE19is_floating_point_vIT0_Esr3cppE19is_floating_point_vIT1_ElestS5_stS6_ES5_E4typeES6_S6_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16> && cpp::is_floating_point_v<float> && sizeof (_Float16) <= sizeof (float), _Float16>::type __llvm_libc_20_1_2_::fputil::generic::add_or_sub<true, _Float16, float>(float, float)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16> && cpp::is_floating_point_v<float> && sizeof (_Float16) <= sizeof (float), _Float16>::type")]
	public unsafe static Half Invoke([NativeType("float")] float x, [NativeType("float")] float y)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(fputil_FPBits_5nkvcs);
		sbyte b = 0;
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		int num4 = 0;
		fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		int num5 = 0;
		fputil_FPBits_2fahva fputil_FPBits_2fahva3 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb11 = default(anon_izyfb7);
		fputil_FPBits_2fahva fputil_FPBits_2fahva4 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb12 = default(anon_izyfb7);
		fputil_FPBits_2fahva fputil_FPBits_2fahva5 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb13 = default(anon_izyfb7);
		fputil_FPBits_2fahva fputil_FPBits_2fahva6 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb14 = default(anon_izyfb7);
		fputil_FPBits_2fahva fputil_FPBits_2fahva7 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb15 = default(anon_izyfb7);
		fputil_FPBits_2fahva fputil_FPBits_2fahva8 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb16 = default(anon_izyfb7);
		fputil_FPBits_2fahva fputil_FPBits_2fahva9 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb17 = default(anon_izyfb7);
		fputil_FPBits_2fahva fputil_FPBits_2fahva10 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb18 = default(anon_izyfb7);
		float num6 = 0f;
		float num7 = 0f;
		float num8 = 0f;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs4 = default(fputil_FPBits_5nkvcs);
		float num9 = 0f;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs5 = default(fputil_FPBits_5nkvcs);
		fputil_FPBits_2fahva fputil_FPBits_2fahva11 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb19 = default(anon_izyfb7);
		fputil_FPBits_2fahva fputil_FPBits_2fahva12 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb20 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb21 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb22 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb23 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb24 = default(anon_izyfb7);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs6 = default(fputil_FPBits_5nkvcs);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs7 = default(fputil_FPBits_5nkvcs);
		int num10 = 0;
		int num11 = 0;
		int num12 = 0;
		int num13 = 0;
		int num14 = 0;
		sbyte b2 = 0;
		int num15 = 0;
		int num16 = 0;
		fputil_DyadicFloat_cs3nhs fputil_DyadicFloat_cs3nhs2 = default(fputil_DyadicFloat_cs3nhs);
		anon_izyfb7 anon_izyfb25 = default(anon_izyfb7);
		BigInt_vtm4cw bigInt_vtm4cw = default(BigInt_vtm4cw);
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = 3;
		llvm_lifetime_start_p0.Invoke(4L, &num2);
		num2 = 26;
		llvm_lifetime_start_p0.Invoke(4L, &num3);
		num3 = 27;
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		Half result;
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs2) = -1431655766;
			FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs2, x);
			llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
			*(int*)(&fputil_FPBits_5nkvcs3) = -1431655766;
			FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs3, y);
			llvm_lifetime_start_p0.Invoke(1L, &b);
			anon_izyfb8.val = FPStorage_fputil_FPType_1_sign.Invoke(&fputil_FPBits_5nkvcs2);
			anon_izyfb9.val = FPStorage_fputil_FPType_1_sign.Invoke(&fputil_FPBits_5nkvcs3);
			b = ((!Equals_fy8fvt.Invoke(anon_izyfb8.val, anon_izyfb9.val)) ? ((sbyte)1) : ((sbyte)0));
			if (!details_expects_bool_condition_bool.Invoke(FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_inf_or_nan.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2)) ? true : (FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_inf_or_nan.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs3)) ? true : ((!FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_zero.Invoke(&fputil_FPBits_5nkvcs2)) ? FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_zero.Invoke(&fputil_FPBits_5nkvcs3) : true)), expected: false))
			{
				goto IL_07c7;
			}
			if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan.Invoke(&fputil_FPBits_5nkvcs2) || FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan.Invoke(&fputil_FPBits_5nkvcs3))
			{
				if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_signaling_nan.Invoke(&fputil_FPBits_5nkvcs2) || FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_signaling_nan.Invoke(&fputil_FPBits_5nkvcs3))
				{
					fputil_raise_except_if_required.Invoke(1);
				}
				if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_quiet_nan.Invoke(&fputil_FPBits_5nkvcs2))
				{
					llvm_lifetime_start_p0.Invoke(4L, &num4);
					num4 = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_mantissa.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2));
					num4 >>>= 13;
					llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
					anon_izyfb10.val = FPStorage_fputil_FPType_1_sign.Invoke(&fputil_FPBits_5nkvcs2);
					short field_ = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan.Invoke(v: (short)num4, sign: anon_izyfb10.val);
					fputil_FPBits_2fahva2.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
					result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva2);
					llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
					llvm_lifetime_end_p0.Invoke(4L, &num4);
				}
				else if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_quiet_nan.Invoke(&fputil_FPBits_5nkvcs3))
				{
					llvm_lifetime_start_p0.Invoke(4L, &num5);
					num5 = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_mantissa.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs3));
					num5 >>>= 13;
					llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva3);
					anon_izyfb11.val = FPStorage_fputil_FPType_1_sign.Invoke(&fputil_FPBits_5nkvcs3);
					short field_2 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan.Invoke(v: (short)num5, sign: anon_izyfb11.val);
					fputil_FPBits_2fahva3.FPRepImpl.FPRepSem.FPStorage.field_0 = field_2;
					result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva3);
					llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva3);
					llvm_lifetime_end_p0.Invoke(4L, &num5);
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva4);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb12, Sign_POS.Pointer, 1L, isVolatile: false);
					short field_3 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan.Invoke(anon_izyfb12.val, 0);
					fputil_FPBits_2fahva4.FPRepImpl.FPRepSem.FPStorage.field_0 = field_3;
					result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva4);
					llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva4);
				}
			}
			else if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_inf.Invoke(&fputil_FPBits_5nkvcs2))
			{
				if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_inf.Invoke(&fputil_FPBits_5nkvcs3))
				{
					if ((b & 1) != 1)
					{
						fputil_raise_except_if_required.Invoke(1);
						llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva5);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb13, Sign_POS.Pointer, 1L, isVolatile: false);
						short field_4 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan.Invoke(anon_izyfb13.val, 0);
						fputil_FPBits_2fahva5.FPRepImpl.FPRepSem.FPStorage.field_0 = field_4;
						result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva5);
						llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva5);
					}
					else
					{
						llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva6);
						anon_izyfb14.val = FPStorage_fputil_FPType_1_sign.Invoke(&fputil_FPBits_5nkvcs2);
						short field_5 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_inf.Invoke(anon_izyfb14.val);
						fputil_FPBits_2fahva6.FPRepImpl.FPRepSem.FPStorage.field_0 = field_5;
						result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva6);
						llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva6);
					}
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva7);
					anon_izyfb15.val = FPStorage_fputil_FPType_1_sign.Invoke(&fputil_FPBits_5nkvcs2);
					short field_6 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_inf.Invoke(anon_izyfb15.val);
					fputil_FPBits_2fahva7.FPRepImpl.FPRepSem.FPStorage.field_0 = field_6;
					result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva7);
					llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva7);
				}
			}
			else if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_inf.Invoke(&fputil_FPBits_5nkvcs3))
			{
				llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva8);
				anon_izyfb16.val = FPStorage_fputil_FPType_1_sign.Invoke(&fputil_FPBits_5nkvcs3);
				short field_7 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_inf.Invoke(anon_izyfb16.val);
				fputil_FPBits_2fahva8.FPRepImpl.FPRepSem.FPStorage.field_0 = field_7;
				result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva8);
				llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva8);
			}
			else if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_zero.Invoke(&fputil_FPBits_5nkvcs2))
			{
				if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_zero.Invoke(&fputil_FPBits_5nkvcs3))
				{
					if (fputil_quick_get_round.Invoke() == 1024)
					{
						llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva9);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb17, Sign_NEG.Pointer, 1L, isVolatile: false);
						short field_8 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_zero.Invoke(anon_izyfb17.val);
						fputil_FPBits_2fahva9.FPRepImpl.FPRepSem.FPStorage.field_0 = field_8;
						result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva9);
						llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva9);
					}
					else
					{
						llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva10);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb18, Sign_POS.Pointer, 1L, isVolatile: false);
						short field_9 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_zero.Invoke(anon_izyfb18.val);
						fputil_FPBits_2fahva10.FPRepImpl.FPRepSem.FPStorage.field_0 = field_9;
						result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva10);
						llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva10);
					}
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(4L, &num6);
					num6 = y;
					num6 = 0f - num6;
					result = fputil_cast_Float16_float.Invoke(num6);
					llvm_lifetime_end_p0.Invoke(4L, &num6);
				}
			}
			else
			{
				if (!FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_zero.Invoke(&fputil_FPBits_5nkvcs3))
				{
					goto IL_07c7;
				}
				llvm_lifetime_start_p0.Invoke(4L, &num7);
				num7 = y;
				num7 = 0f - num7;
				result = fputil_cast_Float16_float.Invoke(num7);
				llvm_lifetime_end_p0.Invoke(4L, &num7);
			}
			goto IL_0e34;
		}
		IL_0e34:
		llvm_lifetime_end_p0.Invoke(1L, &b);
		llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
		llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		llvm_lifetime_end_p0.Invoke(4L, &num3);
		llvm_lifetime_end_p0.Invoke(4L, &num2);
		llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
		IL_07c7:
		llvm_lifetime_start_p0.Invoke(4L, &num8);
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
		unchecked
		{
			int field_10 = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_abs.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2));
			fputil_FPBits_5nkvcs4.FPRepImpl.FPRepSem.field_0.field_0 = field_10;
			float num17 = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs4);
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
			num8 = num17;
			llvm_lifetime_start_p0.Invoke(4L, &num9);
			llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs5);
			int field_11 = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_abs.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs3));
			fputil_FPBits_5nkvcs5.FPRepImpl.FPRepSem.field_0.field_0 = field_11;
			float num18 = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs5);
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs5);
			num9 = num18;
			if (num8 == num9 && (b & 1) != 1)
			{
				if (fputil_quick_get_round.Invoke() == 1024)
				{
					llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva11);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb19, Sign_NEG.Pointer, 1L, isVolatile: false);
					short field_12 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_zero.Invoke(anon_izyfb19.val);
					fputil_FPBits_2fahva11.FPRepImpl.FPRepSem.FPStorage.field_0 = field_12;
					result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva11);
					llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva11);
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva12);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb20, Sign_POS.Pointer, 1L, isVolatile: false);
					short field_13 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_zero.Invoke(anon_izyfb20.val);
					fputil_FPBits_2fahva12.FPRepImpl.FPRepSem.FPStorage.field_0 = field_13;
					result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva12);
					llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva12);
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
					anon_izyfb22.val = FPStorage_fputil_FPType_1_sign.Invoke(&fputil_FPBits_5nkvcs2);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb21, &anon_izyfb22, 1L, isVolatile: false);
					llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb22);
				}
				else if (num8 < num9)
				{
					if ((b & 1) == 1)
					{
						llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb23);
						anon_izyfb23.val = FPStorage_fputil_FPType_1_sign.Invoke(&fputil_FPBits_5nkvcs3);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb21, &anon_izyfb23, 1L, isVolatile: false);
						llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb23);
					}
					else if (FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_pos.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs3)))
					{
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb21, Sign_NEG.Pointer, 1L, isVolatile: false);
					}
				}
				else if ((b & 1) == 1)
				{
					llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb24);
					anon_izyfb24.val = FPStorage_fputil_FPType_1_sign.Invoke(&fputil_FPBits_5nkvcs2);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb21, &anon_izyfb24, 1L, isVolatile: false);
					llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb24);
				}
				llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs6);
				*(int*)(&fputil_FPBits_5nkvcs6) = -1431655766;
				FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs6, *(float*)cpp_max_float.Invoke(&num8, &num9));
				llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs7);
				*(int*)(&fputil_FPBits_5nkvcs7) = -1431655766;
				FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs7, *(float*)cpp_min_float.Invoke(&num8, &num9));
				llvm_lifetime_start_p0.Invoke(4L, &num10);
				num10 = -1431655766;
				if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_subnormal.Invoke(&fputil_FPBits_5nkvcs6))
				{
					num10 = (((b & 1) != 1) ? (FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_mantissa.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs6)) - FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_mantissa.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs7))) : (FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_mantissa.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs6)) + FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_mantissa.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs7))));
					num10 <<= 3;
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(4L, &num11);
					num11 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_get_explicit_mantissa.Invoke(&fputil_FPBits_5nkvcs6) << 3;
					llvm_lifetime_start_p0.Invoke(4L, &num12);
					num12 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_get_explicit_mantissa.Invoke(&fputil_FPBits_5nkvcs7) << 3;
					llvm_lifetime_start_p0.Invoke(4L, &num13);
					checked
					{
						num13 = unchecked((ushort)FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_biased_exponent.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs6))) - unchecked((ushort)FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_biased_exponent.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs7)));
						llvm_lifetime_start_p0.Invoke(4L, &num14);
						num14 = num12 >>> *unchecked((int*)cpp_min_int.Invoke(&num13, &num3));
						llvm_lifetime_start_p0.Invoke(1L, &b2);
						b2 = -86;
						b2 = ((num13 > 3 && (num13 > 26 || num12 << 32 - num13 != 0)) ? ((sbyte)1) : ((sbyte)0));
						llvm_lifetime_start_p0.Invoke(4L, &num15);
						num15 = (((b2 & 1) == 1) ? 1 : 0);
					}
					num10 = (((b & 1) != 1) ? (num11 - (num14 | num15)) : (num11 + (num14 | num15)));
					llvm_lifetime_end_p0.Invoke(4L, &num15);
					llvm_lifetime_end_p0.Invoke(1L, &b2);
					llvm_lifetime_end_p0.Invoke(4L, &num14);
					llvm_lifetime_end_p0.Invoke(4L, &num13);
					llvm_lifetime_end_p0.Invoke(4L, &num12);
					llvm_lifetime_end_p0.Invoke(4L, &num11);
				}
				llvm_lifetime_start_p0.Invoke(4L, &num16);
				checked
				{
					num16 = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_exponent.Invoke(unchecked((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs6))) - 26;
					llvm_lifetime_start_p0.Invoke(12L, &fputil_DyadicFloat_cs3nhs2);
				}
				*(sbyte*)(&fputil_DyadicFloat_cs3nhs2) = -86;
				sbyte* ptr = (sbyte*)(&fputil_DyadicFloat_cs3nhs2) + 1;
				*ptr = -86;
				ptr[1] = -86;
				ptr[2] = -86;
				((int*)(&fputil_DyadicFloat_cs3nhs2))[1] = -1431655766;
				((int*)(&fputil_DyadicFloat_cs3nhs2))[2] = -1431655766;
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb25, &anon_izyfb21, 1L, isVolatile: false);
				int e = num16;
				BigInt_32ul_false_unsigned_int_BigInt_unsigned_int_void.Invoke(&bigInt_vtm4cw, num10);
				DyadicFloat_32ul_Constructor.Invoke(&fputil_DyadicFloat_cs3nhs2, anon_izyfb25.val, e, *(int*)(&bigInt_vtm4cw.val.Data));
				result = DyadicFloat_32ul_as_Float16_true_void.Invoke(&fputil_DyadicFloat_cs3nhs2);
				llvm_lifetime_end_p0.Invoke(12L, &fputil_DyadicFloat_cs3nhs2);
				llvm_lifetime_end_p0.Invoke(4L, &num16);
				llvm_lifetime_end_p0.Invoke(4L, &num10);
				llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs7);
				llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs6);
				llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb21);
			}
			llvm_lifetime_end_p0.Invoke(4L, &num9);
			llvm_lifetime_end_p0.Invoke(4L, &num8);
			goto IL_0e34;
		}
	}
}
