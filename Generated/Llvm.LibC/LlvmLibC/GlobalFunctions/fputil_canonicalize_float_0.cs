using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_canonicalize_float_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil12canonicalizeIfTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEEiRS4_RKS4_")]
	[DemangledName("int __llvm_libc_20_1_2_::fputil::canonicalize<float, 0>(float&, float const&)")]
	[return: NativeType("int")]
	public unsafe static int Invoke([NativeType("float&")] void* cx, [NativeType("float const&")] void* x)
	{
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs2) = -1431655766;
			FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs2, *(float*)x);
			int result;
			if (details_expects_bool_condition_bool.Invoke(FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_signaling_nan.Invoke(&fputil_FPBits_5nkvcs2), expected: false))
			{
				llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
				anon_izyfb8.val = FPStorage_fputil_FPType_1_sign.Invoke(&fputil_FPBits_5nkvcs2);
				int field_ = FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan.Invoke(v: FPRepSem_fputil_FPType_1_fputil_FPBits_float_get_explicit_mantissa.Invoke(&fputil_FPBits_5nkvcs2), sign: anon_izyfb8.val);
				fputil_FPBits_5nkvcs3.FPRepImpl.FPRepSem.field_0.field_0 = field_;
				*(float*)cx = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs3);
				llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
				fputil_raise_except_if_required.Invoke(1);
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
