using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic4FModIfmNS1_24FModDivisionSimpleHelperImEEE9pre_checkEffRf")]
[DemangledName("__llvm_libc_20_1_2_::fputil::generic::FMod<float, unsigned long, __llvm_libc_20_1_2_::fputil::generic::FModDivisionSimpleHelper<unsigned long>>::pre_check(float, float, float&)")]
internal static partial class fputil_generic_FMod_float_unsigned_long_fputil_generic_FModDivisionSimpleHelper_unsigned_long_pre_check_float_float_float
{
	public unsafe static bool Invoke(float x, float y, void* @out)
	{
		float num = 0f;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(fputil_FPBits_5nkvcs);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs4 = default(fputil_FPBits_5nkvcs);
		llvm_lifetime_start_p0.Invoke(4L, &num);
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
		int field_ = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan_Sign_unsigned_int.Invoke(anon_izyfb8.val, 0);
		fputil_FPBits_5nkvcs2.FPRepImpl.FPRepSem.field_0.field_0 = field_;
		float num2 = fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs2);
		llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		num = num2;
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs3) = -1431655766;
			fputil_FPBits_float_FPBits_float_float.Invoke(&fputil_FPBits_5nkvcs3, x);
			llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
			*(int*)(&fputil_FPBits_5nkvcs4) = -1431655766;
			fputil_FPBits_float_FPBits_float_float.Invoke(&fputil_FPBits_5nkvcs4, y);
			bool result;
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(!fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_zero_const.Invoke(&fputil_FPBits_5nkvcs4) && ((!fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_inf_or_nan_const.Invoke(&fputil_FPBits_5nkvcs4)) ? ((byte)((fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_inf_or_nan_const.Invoke(&fputil_FPBits_5nkvcs3) ? 1u : 0u) ^ 0xFFFFFFFFu) != 0) : false), expected: true))
			{
				result = false;
			}
			else if (fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan_const.Invoke(&fputil_FPBits_5nkvcs3) || fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan_const.Invoke(&fputil_FPBits_5nkvcs4))
			{
				if (fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_signaling_nan_const.Invoke(&fputil_FPBits_5nkvcs3) || fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_signaling_nan_const.Invoke(&fputil_FPBits_5nkvcs4))
				{
					fputil_raise_except_if_required_int.Invoke(1);
				}
				*(float*)@out = float.NaN;
				result = true;
			}
			else if (fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_inf_const.Invoke(&fputil_FPBits_5nkvcs3) || fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_zero_const.Invoke(&fputil_FPBits_5nkvcs4))
			{
				fputil_raise_except_if_required_int.Invoke(1);
				fputil_set_errno_if_required_int.Invoke(33);
				*(float*)@out = float.NaN;
				result = true;
			}
			else
			{
				*(float*)@out = x;
				result = true;
			}
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
			llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}
