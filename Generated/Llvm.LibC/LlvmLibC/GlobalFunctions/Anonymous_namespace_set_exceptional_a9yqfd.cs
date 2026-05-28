using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Anonymous_namespace_set_exceptional_a9yqfd
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_115set_exceptionalEd.44")]
	[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::set_exceptional(double) (.44)")]
	[CleanName("Anonymous_namespace_set_exceptional")]
	public unsafe static double Invoke([MangledName("x")][NativeType("double")] double X)
	{
		double result = 0.0;
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm = default(Fputil_FPBits_wjhbrm);
		long num = 0L;
		long num2 = 0L;
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(Fputil_FPBits_wjhbrm);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(Fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		int num3 = 0;
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm4 = default(Fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm5 = default(Fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
		unchecked
		{
			*(long*)(&fputil_FPBits_wjhbrm) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm, X);
			Llvm_lifetime_start_p0.Invoke(8L, &num);
			num = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm));
			Llvm_lifetime_start_p0.Invoke(8L, &num2);
			Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			long val = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_abs.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm));
			fputil_FPBits_wjhbrm2.FPRepImpl.FPRepSem.FPStorage.Val = val;
			long num4 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2));
			Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			num2 = num4;
			if ((ulong)num2 <= 4362804393534743822uL)
			{
				result = Fputil_multiply_add_double.Invoke(X, 0.5, 1.0);
			}
			else if ((ulong)num >= 13867491935800207938uL)
			{
				if ((ulong)num > 13867772611911707474uL)
				{
					if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_inf.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm)))
					{
						result = 0.0;
					}
					else if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_nan.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm)))
					{
						result = X;
					}
					else if (Fputil_quick_get_round.Invoke() == 2048)
					{
						Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Sign_POS.Pointer, 1L, isVolatile: false);
						long val2 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_min_subnormal.Invoke(anon_izyfb.Val);
						fputil_FPBits_wjhbrm3.FPRepImpl.FPRepSem.FPStorage.Val = val2;
						result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm3);
						Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
					}
					else
					{
						Fputil_set_errno_if_required.Invoke(34);
						Fputil_raise_except_if_required.Invoke(16);
						result = 0.0;
					}
				}
				else
				{
					result = Anonymous_namespace_exp10_denorm.Invoke(X);
				}
			}
			else
			{
				if ((ulong)num < 9218868437227405312uL)
				{
					Llvm_lifetime_start_p0.Invoke(4L, &num3);
					num3 = Fputil_quick_get_round.Invoke();
					int num5;
					if (num3 == 1024 || num3 == 3072)
					{
						Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, Sign_POS.Pointer, 1L, isVolatile: false);
						long val3 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_max_normal.Invoke(anon_izyfb2.Val);
						fputil_FPBits_wjhbrm4.FPRepImpl.FPRepSem.FPStorage.Val = val3;
						result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm4);
						Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
						num5 = 1;
					}
					else
					{
						Fputil_set_errno_if_required.Invoke(34);
						Fputil_raise_except_if_required.Invoke(8);
						num5 = 0;
					}
					Llvm_lifetime_end_p0.Invoke(4L, &num3);
					switch (num5)
					{
					case 0:
						break;
					default:
						goto IL_037d;
					}
				}
				Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb3, Sign_POS.Pointer, 1L, isVolatile: false);
				long val4 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_inf.Invoke(anon_izyfb3.Val);
				fputil_FPBits_wjhbrm5.FPRepImpl.FPRepSem.FPStorage.Val = val4;
				result = X + FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm5);
				Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
			}
			goto IL_037d;
		}
		IL_037d:
		Llvm_lifetime_end_p0.Invoke(8L, &num2);
		Llvm_lifetime_end_p0.Invoke(8L, &num);
		Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
		return result;
	}
}
