using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic4FModIdmNS1_24FModDivisionSimpleHelperImEEE9pre_checkEddRd")]
[DemangledName("__llvm_libc_20_1_2_::fputil::generic::FMod<double, unsigned long, __llvm_libc_20_1_2_::fputil::generic::FModDivisionSimpleHelper<unsigned long>>::pre_check(double, double, double&)")]
internal static partial class fputil_generic_FMod_double_unsigned_long_fputil_generic_FModDivisionSimpleHelper_unsigned_long_pre_check_double_double_double
{
	public unsafe static bool Invoke(double x, double y, void* @out)
	{
		double num = 0.0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm4 = default(fputil_FPBits_wjhbrm);
		llvm_lifetime_start_p0.Invoke(8L, &num);
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
		long val = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan_Sign_unsigned_long.Invoke(anon_izyfb8.val, 0L);
		fputil_FPBits_wjhbrm2.FPRepImpl.FPRepSem.FPStorage.val = val;
		double num2 = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm2);
		llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		num = num2;
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
		unchecked
		{
			*(long*)(&fputil_FPBits_wjhbrm3) = -6148914691236517206L;
			fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm3, x);
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
			*(long*)(&fputil_FPBits_wjhbrm4) = -6148914691236517206L;
			fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm4, y);
			bool result;
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(!fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero_const.Invoke(&fputil_FPBits_wjhbrm4) && ((!fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_inf_or_nan_const.Invoke(&fputil_FPBits_wjhbrm4)) ? ((byte)((fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_inf_or_nan_const.Invoke(&fputil_FPBits_wjhbrm3) ? 1u : 0u) ^ 0xFFFFFFFFu) != 0) : false), expected: true))
			{
				result = false;
			}
			else if (fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_nan_const.Invoke(&fputil_FPBits_wjhbrm3) || fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_nan_const.Invoke(&fputil_FPBits_wjhbrm4))
			{
				if (fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_signaling_nan_const.Invoke(&fputil_FPBits_wjhbrm3) || fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_signaling_nan_const.Invoke(&fputil_FPBits_wjhbrm4))
				{
					fputil_raise_except_if_required_int.Invoke(1);
				}
				*(double*)@out = double.NaN;
				result = true;
			}
			else if (fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_inf_const.Invoke(&fputil_FPBits_wjhbrm3) || fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero_const.Invoke(&fputil_FPBits_wjhbrm4))
			{
				fputil_raise_except_if_required_int.Invoke(1);
				fputil_set_errno_if_required_int.Invoke(33);
				*(double*)@out = double.NaN;
				result = true;
			}
			else
			{
				*(double*)@out = x;
				result = true;
			}
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
