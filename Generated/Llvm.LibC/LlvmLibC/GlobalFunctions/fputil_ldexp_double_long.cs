using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_ldexp_double_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil5ldexpIdlEENS_3cpp9enable_ifIXaasr3cppE19is_floating_point_vIT_Esr3cppE13is_integral_vIT0_EES4_E4typeES4_S5_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<double> && cpp::is_integral_v<long>, double>::type __llvm_libc_20_1_2_::fputil::ldexp<double, long>(double, long)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<double> && cpp::is_integral_v<long>, double>::type")]
	public unsafe static double Invoke([NativeType("double")] double x, [NativeType("long")] long exp)
	{
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		int num = 0;
		int num2 = 0;
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb11 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb12 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb13 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm4 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb14 = default(anon_izyfb7);
		int num3 = 0;
		anon_izyfb7 anon_izyfb15 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb16 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb17 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb18 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb19 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm5 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb20 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm6 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb21 = default(anon_izyfb7);
		fputil_DyadicFloat_syracv fputil_DyadicFloat_syracv2 = default(fputil_DyadicFloat_syracv);
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		double result;
		unchecked
		{
			*(long*)(&fputil_FPBits_wjhbrm2) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm2, x);
			if (details_expects_bool_condition_bool.Invoke((exp == 0L) ? true : ((!FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2))) ? FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_inf_or_nan.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2)) : true), expected: false))
			{
				result = x;
				goto IL_05ba;
			}
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = 2100;
			if (details_expects_bool_condition_bool.Invoke(exp > 2100L, expected: false))
			{
				llvm_lifetime_start_p0.Invoke(4L, &num2);
				num2 = fputil_quick_get_round.Invoke();
				llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb8);
				*(sbyte*)(&anon_izyfb8) = -86;
				anon_izyfb8.val = FPStorage_fputil_FPType_2_sign.Invoke(&fputil_FPBits_wjhbrm2);
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
						llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb14, &anon_izyfb8, 1L, isVolatile: false);
						long val = FPRepSem_fputil_FPType_2_fputil_FPBits_double_inf.Invoke(anon_izyfb14.val);
						fputil_FPBits_wjhbrm4.FPRepImpl.FPRepSem.FPStorage.val = val;
						result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm4);
						llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
						goto IL_0300;
					}
				}
				llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb13, &anon_izyfb8, 1L, isVolatile: false);
				long val2 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_max_normal.Invoke(anon_izyfb13.val);
				fputil_FPBits_wjhbrm3.FPRepImpl.FPRepSem.FPStorage.val = val2;
				result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm3);
				llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
				goto IL_0300;
			}
			if (details_expects_bool_condition_bool.Invoke(exp < -2100L, expected: false))
			{
				llvm_lifetime_start_p0.Invoke(4L, &num3);
				num3 = fputil_quick_get_round.Invoke();
				llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb15);
				*(sbyte*)(&anon_izyfb15) = -86;
				anon_izyfb15.val = FPStorage_fputil_FPType_2_sign.Invoke(&fputil_FPBits_wjhbrm2);
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
						llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm6);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb21, &anon_izyfb15, 1L, isVolatile: false);
						long val3 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_zero.Invoke(anon_izyfb21.val);
						fputil_FPBits_wjhbrm6.FPRepImpl.FPRepSem.FPStorage.val = val3;
						result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm6);
						llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm6);
						goto IL_04ed;
					}
				}
				llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb20, &anon_izyfb15, 1L, isVolatile: false);
				long val4 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_min_subnormal.Invoke(anon_izyfb20.val);
				fputil_FPBits_wjhbrm5.FPRepImpl.FPRepSem.FPStorage.val = val4;
				result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm5);
				llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
				goto IL_04ed;
			}
			llvm_lifetime_start_p0.Invoke(16L, &fputil_DyadicFloat_syracv2);
			*(sbyte*)(&fputil_DyadicFloat_syracv2) = -86;
			sbyte* ptr = (sbyte*)(&fputil_DyadicFloat_syracv2) + 1;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			((int*)(&fputil_DyadicFloat_syracv2))[1] = -1431655766;
			((long*)(&fputil_DyadicFloat_syracv2))[1] = -6148914691236517206L;
			DyadicFloat_64ul_DyadicFloat_double_0.Invoke(&fputil_DyadicFloat_syracv2, FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm2));
		}
		fputil_DyadicFloat_syracv2.exponent += unchecked((int)exp);
		result = DyadicFloat_64ul_as_double_true_void.Invoke(&fputil_DyadicFloat_syracv2);
		llvm_lifetime_end_p0.Invoke(16L, &fputil_DyadicFloat_syracv2);
		goto IL_05a8;
		IL_0300:
		llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb8);
		llvm_lifetime_end_p0.Invoke(4L, &num2);
		goto IL_05a8;
		IL_04ed:
		llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb15);
		llvm_lifetime_end_p0.Invoke(4L, &num3);
		goto IL_05a8;
		IL_05ba:
		llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		return result;
		IL_05a8:
		llvm_lifetime_end_p0.Invoke(4L, &num);
		goto IL_05ba;
	}
}
