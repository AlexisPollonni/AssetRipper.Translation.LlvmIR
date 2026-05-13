using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil12canonicalizeIfTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEEiRS4_RKS4_")]
[DemangledName("int __llvm_libc_20_1_2_::fputil::canonicalize<float, 0>(float&, float const&)")]
internal static partial class int_fputil_canonicalize_float_0_float_float_const
{
	public unsafe static int Invoke(void* cx, void* x)
	{
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs2) = -1431655766;
			fputil_FPBits_float_FPBits_float_float.Invoke(&fputil_FPBits_5nkvcs2, *(float*)x);
			int result;
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_signaling_nan_const.Invoke(&fputil_FPBits_5nkvcs2), expected: false))
			{
				llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
				anon_izyfb8.val = fputil_internal_FPStorage_fputil_FPType_1_sign_const.Invoke(&fputil_FPBits_5nkvcs2);
				int field_ = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan_Sign_unsigned_int.Invoke(v: fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_get_explicit_mantissa_const.Invoke(&fputil_FPBits_5nkvcs2), sign: anon_izyfb8.val);
				fputil_FPBits_5nkvcs3.FPRepImpl.FPRepSem.field_0.field_0 = field_;
				*(float*)cx = fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs3);
				llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
				fputil_raise_except_if_required_int.Invoke(1);
				result = 1;
			}
			else
			{
				*(float*)cx = *(float*)x;
				result = 0;
			}
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
			return result;
		}
	}
}
