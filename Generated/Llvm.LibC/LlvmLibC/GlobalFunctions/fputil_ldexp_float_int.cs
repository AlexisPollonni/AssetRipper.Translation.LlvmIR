using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_ldexp_float_int
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil5ldexpIfiEENS_3cpp9enable_ifIXaasr3cppE19is_floating_point_vIT_Esr3cppE13is_integral_vIT0_EES4_E4typeES4_S5_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<float> && cpp::is_integral_v<int>, float>::type __llvm_libc_20_1_2_::fputil::ldexp<float, int>(float, int)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<float> && cpp::is_integral_v<int>, float>::type")]
	public unsafe static float Invoke([NativeType("float")] float x, [NativeType("int")] int exp)
	{
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		int num = 0;
		int num2 = 0;
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb11 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb12 = default(anon_izyfb7);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb13 = default(anon_izyfb7);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs4 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb14 = default(anon_izyfb7);
		int num3 = 0;
		anon_izyfb7 anon_izyfb15 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb16 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb17 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb18 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb19 = default(anon_izyfb7);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs5 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb20 = default(anon_izyfb7);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs6 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb21 = default(anon_izyfb7);
		fputil_DyadicFloat_cs3nhs fputil_DyadicFloat_cs3nhs2 = default(fputil_DyadicFloat_cs3nhs);
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		float result;
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs2) = -1431655766;
			FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs2, x);
			if (details_expects_bool_condition_bool.Invoke((exp == 0) ? true : ((!FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_zero.Invoke(&fputil_FPBits_5nkvcs2)) ? FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_inf_or_nan.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2)) : true), expected: false))
			{
				result = x;
				goto IL_059d;
			}
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = 279;
			if (details_expects_bool_condition_bool.Invoke(exp > 279, expected: false))
			{
				llvm_lifetime_start_p0.Invoke(4L, &num2);
				num2 = fputil_quick_get_round.Invoke();
				llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb8);
				*(sbyte*)(&anon_izyfb8) = -86;
				anon_izyfb8.val = FPStorage_fputil_FPType_1_sign.Invoke(&fputil_FPBits_5nkvcs2);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, &anon_izyfb8, 1L, isVolatile: false);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb10, Sign_POS.Pointer, 1L, isVolatile: false);
				if (!Equals_fy8fvt.Invoke(anon_izyfb9.val, anon_izyfb10.val) || num2 != 1024)
				{
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb11, &anon_izyfb8, 1L, isVolatile: false);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb12, Sign_NEG.Pointer, 1L, isVolatile: false);
					if ((!Equals_fy8fvt.Invoke(anon_izyfb11.val, anon_izyfb12.val) || num2 != 2048) && num2 != 3072)
					{
						fputil_set_errno_if_required.Invoke(34);
						fputil_raise_except_if_required.Invoke(8);
						llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb14, &anon_izyfb8, 1L, isVolatile: false);
						int field_ = FPRepSem_fputil_FPType_1_fputil_FPBits_float_inf.Invoke(anon_izyfb14.val);
						fputil_FPBits_5nkvcs4.FPRepImpl.FPRepSem.field_0.field_0 = field_;
						result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs4);
						llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
						goto IL_02ec;
					}
				}
				llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb13, &anon_izyfb8, 1L, isVolatile: false);
				int field_2 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_max_normal.Invoke(anon_izyfb13.val);
				fputil_FPBits_5nkvcs3.FPRepImpl.FPRepSem.field_0.field_0 = field_2;
				result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs3);
				llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
				goto IL_02ec;
			}
			if (details_expects_bool_condition_bool.Invoke(exp < -279, expected: false))
			{
				llvm_lifetime_start_p0.Invoke(4L, &num3);
				num3 = fputil_quick_get_round.Invoke();
				llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb15);
				*(sbyte*)(&anon_izyfb15) = -86;
				anon_izyfb15.val = FPStorage_fputil_FPType_1_sign.Invoke(&fputil_FPBits_5nkvcs2);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb16, &anon_izyfb15, 1L, isVolatile: false);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb17, Sign_POS.Pointer, 1L, isVolatile: false);
				if (!Equals_fy8fvt.Invoke(anon_izyfb16.val, anon_izyfb17.val) || num3 != 2048)
				{
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb18, &anon_izyfb15, 1L, isVolatile: false);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb19, Sign_NEG.Pointer, 1L, isVolatile: false);
					if (!Equals_fy8fvt.Invoke(anon_izyfb18.val, anon_izyfb19.val) || num3 != 1024)
					{
						fputil_set_errno_if_required.Invoke(34);
						fputil_raise_except_if_required.Invoke(16);
						llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs6);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb21, &anon_izyfb15, 1L, isVolatile: false);
						int field_3 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_zero.Invoke(anon_izyfb21.val);
						fputil_FPBits_5nkvcs6.FPRepImpl.FPRepSem.field_0.field_0 = field_3;
						result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs6);
						llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs6);
						goto IL_04d5;
					}
				}
				llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs5);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb20, &anon_izyfb15, 1L, isVolatile: false);
				int field_4 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_min_subnormal.Invoke(anon_izyfb20.val);
				fputil_FPBits_5nkvcs5.FPRepImpl.FPRepSem.field_0.field_0 = field_4;
				result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs5);
				llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs5);
				goto IL_04d5;
			}
			llvm_lifetime_start_p0.Invoke(12L, &fputil_DyadicFloat_cs3nhs2);
			*(sbyte*)(&fputil_DyadicFloat_cs3nhs2) = -86;
			sbyte* ptr = (sbyte*)(&fputil_DyadicFloat_cs3nhs2) + 1;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			((int*)(&fputil_DyadicFloat_cs3nhs2))[1] = -1431655766;
			((int*)(&fputil_DyadicFloat_cs3nhs2))[2] = -1431655766;
			DyadicFloat_32ul_DyadicFloat_float_0.Invoke(&fputil_DyadicFloat_cs3nhs2, FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs2));
		}
		fputil_DyadicFloat_cs3nhs2.exponent += exp;
		result = DyadicFloat_32ul_as_float_true_void.Invoke(&fputil_DyadicFloat_cs3nhs2);
		llvm_lifetime_end_p0.Invoke(12L, &fputil_DyadicFloat_cs3nhs2);
		goto IL_058b;
		IL_02ec:
		llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb8);
		llvm_lifetime_end_p0.Invoke(4L, &num2);
		goto IL_058b;
		IL_04d5:
		llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb15);
		llvm_lifetime_end_p0.Invoke(4L, &num3);
		goto IL_058b;
		IL_059d:
		llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		return result;
		IL_058b:
		llvm_lifetime_end_p0.Invoke(4L, &num);
		goto IL_059d;
	}
}
