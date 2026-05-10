using System;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic4FModIDF16_jNS1_24FModDivisionSimpleHelperIjEEE9pre_checkEDF16_DF16_RDF16_")]
[DemangledName("__llvm_libc_20_1_2_::fputil::generic::FMod<_Float16, unsigned int, __llvm_libc_20_1_2_::fputil::generic::FModDivisionSimpleHelper<unsigned int>>::pre_check(_Float16, _Float16, _Float16&)")]
internal static partial class fputil_generic_FMod_Float16_unsigned_int_fputil_generic_FModDivisionSimpleHelper_unsigned_int_pre_check_Float16_Float16_Float16
{
	public unsafe static bool Invoke(Half x, Half y, void* @out)
	{
		Half half = default(Half);
		fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		fputil_FPBits_2fahva fputil_FPBits_2fahva3 = default(fputil_FPBits_2fahva);
		fputil_FPBits_2fahva fputil_FPBits_2fahva4 = default(fputil_FPBits_2fahva);
		llvm_lifetime_start_p0.Invoke(2L, &half);
		llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
		llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
		short field_ = fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan_Sign_unsigned_short.Invoke(anon_izyfb8.val, 0);
		fputil_FPBits_2fahva2.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
		Half half2 = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva2);
		llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
		half = half2;
		llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva3);
		unchecked
		{
			*(short*)(&fputil_FPBits_2fahva3) = -21846;
			fputil_FPBits_Float16_FPBits_Float16_Float16.Invoke(&fputil_FPBits_2fahva3, x);
			llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva4);
			*(short*)(&fputil_FPBits_2fahva4) = -21846;
			fputil_FPBits_Float16_FPBits_Float16_Float16.Invoke(&fputil_FPBits_2fahva4, y);
			bool result;
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(!fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_zero_const.Invoke(&fputil_FPBits_2fahva4) && ((!fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_is_inf_or_nan_const.Invoke(&fputil_FPBits_2fahva4)) ? ((byte)((fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_is_inf_or_nan_const.Invoke(&fputil_FPBits_2fahva3) ? 1u : 0u) ^ 0xFFFFFFFFu) != 0) : false), expected: true))
			{
				result = false;
			}
			else if (fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_nan_const.Invoke(&fputil_FPBits_2fahva3) || fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_nan_const.Invoke(&fputil_FPBits_2fahva4))
			{
				if (fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_signaling_nan_const.Invoke(&fputil_FPBits_2fahva3) || fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_signaling_nan_const.Invoke(&fputil_FPBits_2fahva4))
				{
					fputil_raise_except_if_required_int.Invoke(1);
				}
				*(Half*)@out = default(Half);
				result = true;
			}
			else if (fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_inf_const.Invoke(&fputil_FPBits_2fahva3) || fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_zero_const.Invoke(&fputil_FPBits_2fahva4))
			{
				fputil_raise_except_if_required_int.Invoke(1);
				fputil_set_errno_if_required_int.Invoke(33);
				*(Half*)@out = default(Half);
				result = true;
			}
			else
			{
				*(Half*)@out = x;
				result = true;
			}
			llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva4);
			llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva3);
			llvm_lifetime_end_p0.Invoke(2L, &half);
			return result;
		}
	}
}
