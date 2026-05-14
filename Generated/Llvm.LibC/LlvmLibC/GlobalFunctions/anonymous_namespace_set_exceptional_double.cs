using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_115set_exceptionalEd")]
[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::set_exceptional(double)")]
internal static partial class anonymous_namespace_set_exceptional_double
{
	public unsafe static double Invoke(double x)
	{
		double result = 0.0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		long num = 0L;
		long num2 = 0L;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		int num3 = 0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm4 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm5 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		unchecked
		{
			*(long*)(&fputil_FPBits_wjhbrm2) = -6148914691236517206L;
			fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm2, x);
			llvm_lifetime_start_p0.Invoke(8L, &num);
			num = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2));
			llvm_lifetime_start_p0.Invoke(8L, &num2);
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
			long val = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_abs_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2));
			fputil_FPBits_wjhbrm3.FPRepImpl.FPRepSem.FPStorage.val = val;
			long num4 = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm3));
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
			num2 = num4;
			if ((ulong)num2 <= 4368491638549381120uL)
			{
				result = ((!bool_details_expects_bool_condition_bool_bool_bool.Invoke((ulong)num2 <= 247697979505377280uL, expected: false)) ? double_fputil_round_result_slightly_up_double_double.Invoke(x) : ((!bool_details_expects_bool_condition_bool_bool_bool.Invoke(num2 == 0L, expected: false)) ? (6.223015277861142E-61 * cpp_enable_if_sizeof_double_8ul_double_type_fputil_multiply_add_double_double_double_double.Invoke(x, 1.6069380442589903E+60, 2.2250738585072014E-308)) : x));
			}
			else if ((ulong)num >= 13853836650999914722uL)
			{
				result = ((!fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_inf_const.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2))) ? ((!fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_nan_const.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2))) ? double_fputil_round_result_slightly_up_double_double.Invoke(-1.0) : x) : (-1.0));
			}
			else
			{
				if ((ulong)num < 9218868437227405312uL)
				{
					llvm_lifetime_start_p0.Invoke(4L, &num3);
					num3 = fputil_quick_get_round.Invoke();
					int num5;
					if (num3 == 1024 || num3 == 3072)
					{
						llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
						long val2 = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_max_normal_Sign.Invoke(anon_izyfb8.val);
						fputil_FPBits_wjhbrm4.FPRepImpl.FPRepSem.FPStorage.val = val2;
						result = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm4);
						llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
						num5 = 1;
					}
					else
					{
						fputil_set_errno_if_required_int.Invoke(34);
						fputil_raise_except_if_required_int.Invoke(8);
						num5 = 0;
					}
					llvm_lifetime_end_p0.Invoke(4L, &num3);
					switch (num5)
					{
					case 0:
						break;
					default:
						goto IL_0319;
					}
				}
				llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, Sign_POS.Pointer, 1L, isVolatile: false);
				long val3 = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_inf_Sign.Invoke(anon_izyfb9.val);
				fputil_FPBits_wjhbrm5.FPRepImpl.FPRepSem.FPStorage.val = val3;
				result = x + fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm5);
				llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
			}
			goto IL_0319;
		}
		IL_0319:
		llvm_lifetime_end_p0.Invoke(8L, &num2);
		llvm_lifetime_end_p0.Invoke(8L, &num);
		llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		return result;
	}
}
