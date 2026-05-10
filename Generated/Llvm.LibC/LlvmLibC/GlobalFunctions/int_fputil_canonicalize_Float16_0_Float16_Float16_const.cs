using System;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil12canonicalizeIDF16_TnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEEiRS4_RKS4_")]
[DemangledName("int __llvm_libc_20_1_2_::fputil::canonicalize<_Float16, 0>(_Float16&, _Float16 const&)")]
internal static partial class int_fputil_canonicalize_Float16_0_Float16_Float16_const
{
	public unsafe static int Invoke(void* cx, void* x)
	{
		fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(fputil_FPBits_2fahva);
		fputil_FPBits_2fahva fputil_FPBits_2fahva3 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
		unchecked
		{
			*(short*)(&fputil_FPBits_2fahva2) = -21846;
			fputil_FPBits_Float16_FPBits_Float16_Float16.Invoke(&fputil_FPBits_2fahva2, *(Half*)x);
			int result;
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_signaling_nan_const.Invoke(&fputil_FPBits_2fahva2), expected: false))
			{
				llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva3);
				anon_izyfb8.val = fputil_internal_FPStorage_fputil_FPType_0_sign_const.Invoke(&fputil_FPBits_2fahva2);
				short field_ = fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan_Sign_unsigned_short.Invoke(v: fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_get_explicit_mantissa_const.Invoke(&fputil_FPBits_2fahva2), sign: anon_izyfb8.val);
				fputil_FPBits_2fahva3.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
				*(Half*)cx = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva3);
				llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva3);
				fputil_raise_except_if_required_int.Invoke(1);
				result = 1;
			}
			else
			{
				*(Half*)cx = *(Half*)x;
				result = 0;
			}
			llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
			return result;
		}
	}
}
