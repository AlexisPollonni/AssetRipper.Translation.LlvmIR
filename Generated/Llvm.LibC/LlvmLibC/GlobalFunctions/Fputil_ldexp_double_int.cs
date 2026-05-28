using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_ldexp_double_int
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil5ldexpIdiEENS_3cpp9enable_ifIXaasr3cppE19is_floating_point_vIT_Esr3cppE13is_integral_vIT0_EES4_E4typeES4_S5_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<double> && cpp::is_integral_v<int>, double>::type __llvm_libc_20_1_2_::fputil::ldexp<double, int>(double, int)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<double> && cpp::is_integral_v<int>, double>::type")]
	public unsafe static double Invoke([MangledName("x")][NativeType("double")] double X, [MangledName("exp")][NativeType("int")] int Exp)
	{
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm = default(Fputil_FPBits_wjhbrm);
		int num = 0;
		int num2 = 0;
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb4 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb5 = default(Anon_izyfb7);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(Fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb6 = default(Anon_izyfb7);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(Fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb7 = default(Anon_izyfb7);
		int num3 = 0;
		Anon_izyfb7 anon_izyfb8 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb9 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb10 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb11 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb12 = default(Anon_izyfb7);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm4 = default(Fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb13 = default(Anon_izyfb7);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm5 = default(Fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb14 = default(Anon_izyfb7);
		Fputil_DyadicFloat_syracv fputil_DyadicFloat_syracv = default(Fputil_DyadicFloat_syracv);
		Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
		double result;
		unchecked
		{
			*(long*)(&fputil_FPBits_wjhbrm) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm, X);
			if (Details_expects_bool_condition_bool.Invoke(Exp == 0 || FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm)) || FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_inf_or_nan.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm)), Expected: false))
			{
				result = X;
				goto IL_05a9;
			}
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = 2100;
			if (Details_expects_bool_condition_bool.Invoke(Exp > 2100, Expected: false))
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num2);
				num2 = Fputil_quick_get_round.Invoke();
				Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb);
				*(sbyte*)(&anon_izyfb) = -86;
				anon_izyfb.Val = FPStorage_fputil_FPType_2_sign.Invoke(&fputil_FPBits_wjhbrm);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, &anon_izyfb, 1L, isVolatile: false);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb3, Sign_POS.Pointer, 1L, isVolatile: false);
				if (!Equals_fy8fvt.Invoke(anon_izyfb2.Val, anon_izyfb3.Val) || num2 != 1024)
				{
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb4, &anon_izyfb, 1L, isVolatile: false);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb5, Sign_NEG.Pointer, 1L, isVolatile: false);
					if ((!Equals_fy8fvt.Invoke(anon_izyfb4.Val, anon_izyfb5.Val) || num2 != 2048) && num2 != 3072)
					{
						Fputil_set_errno_if_required.Invoke(34);
						Fputil_raise_except_if_required.Invoke(8);
						Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb7, &anon_izyfb, 1L, isVolatile: false);
						long val = FPRepSem_fputil_FPType_2_fputil_FPBits_double_inf.Invoke(anon_izyfb7.Val);
						fputil_FPBits_wjhbrm3.FPRepImpl.FPRepSem.FPStorage.Val = val;
						result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm3);
						Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
						goto IL_02f4;
					}
				}
				Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb6, &anon_izyfb, 1L, isVolatile: false);
				long val2 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_max_normal.Invoke(anon_izyfb6.Val);
				fputil_FPBits_wjhbrm2.FPRepImpl.FPRepSem.FPStorage.Val = val2;
				result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm2);
				Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
				goto IL_02f4;
			}
			if (Details_expects_bool_condition_bool.Invoke(Exp < -2100, Expected: false))
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num3);
				num3 = Fputil_quick_get_round.Invoke();
				Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb8);
				*(sbyte*)(&anon_izyfb8) = -86;
				anon_izyfb8.Val = FPStorage_fputil_FPType_2_sign.Invoke(&fputil_FPBits_wjhbrm);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, &anon_izyfb8, 1L, isVolatile: false);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb10, Sign_POS.Pointer, 1L, isVolatile: false);
				if (!Equals_fy8fvt.Invoke(anon_izyfb9.Val, anon_izyfb10.Val) || num3 != 2048)
				{
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb11, &anon_izyfb8, 1L, isVolatile: false);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb12, Sign_NEG.Pointer, 1L, isVolatile: false);
					if (!Equals_fy8fvt.Invoke(anon_izyfb11.Val, anon_izyfb12.Val) || num3 != 1024)
					{
						Fputil_set_errno_if_required.Invoke(34);
						Fputil_raise_except_if_required.Invoke(16);
						Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb14, &anon_izyfb8, 1L, isVolatile: false);
						long val3 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_zero.Invoke(anon_izyfb14.Val);
						fputil_FPBits_wjhbrm5.FPRepImpl.FPRepSem.FPStorage.Val = val3;
						result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm5);
						Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
						goto IL_04dd;
					}
				}
				Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb13, &anon_izyfb8, 1L, isVolatile: false);
				long val4 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_min_subnormal.Invoke(anon_izyfb13.Val);
				fputil_FPBits_wjhbrm4.FPRepImpl.FPRepSem.FPStorage.Val = val4;
				result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm4);
				Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
				goto IL_04dd;
			}
			Llvm_lifetime_start_p0.Invoke(16L, &fputil_DyadicFloat_syracv);
			*(sbyte*)(&fputil_DyadicFloat_syracv) = -86;
			sbyte* ptr = (sbyte*)(&fputil_DyadicFloat_syracv) + 1;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			((int*)(&fputil_DyadicFloat_syracv))[1] = -1431655766;
			((long*)(&fputil_DyadicFloat_syracv))[1] = -6148914691236517206L;
			DyadicFloat_64ul_DyadicFloat_double_0.Invoke(&fputil_DyadicFloat_syracv, FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm));
		}
		fputil_DyadicFloat_syracv.Exponent += Exp;
		result = DyadicFloat_64ul_as_double_true_void.Invoke(&fputil_DyadicFloat_syracv);
		Llvm_lifetime_end_p0.Invoke(16L, &fputil_DyadicFloat_syracv);
		goto IL_0597;
		IL_02f4:
		Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb);
		Llvm_lifetime_end_p0.Invoke(4L, &num2);
		goto IL_0597;
		IL_04dd:
		Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb8);
		Llvm_lifetime_end_p0.Invoke(4L, &num3);
		goto IL_0597;
		IL_05a9:
		Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
		return result;
		IL_0597:
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		goto IL_05a9;
	}
}
