using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8copysignIfTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_S4_")]
[DemangledName("float __llvm_libc_20_1_2_::fputil::copysign<float, 0>(float, float)")]
internal static partial class float_fputil_copysign_float_0_float_float
{
	public unsafe static float Invoke(float x, float y)
	{
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(fputil_FPBits_5nkvcs);
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		*unchecked((int*)(&fputil_FPBits_5nkvcs2)) = -1431655766;
		fputil_FPBits_float_FPBits_float_float.Invoke(&fputil_FPBits_5nkvcs2, x);
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
		fputil_FPBits_float_FPBits_float_float.Invoke(&fputil_FPBits_5nkvcs3, y);
		anon_izyfb8.val = fputil_internal_FPStorage_fputil_FPType_1_sign_const.Invoke(&fputil_FPBits_5nkvcs3);
		fputil_internal_FPStorage_fputil_FPType_1_set_sign_Sign.Invoke(&fputil_FPBits_5nkvcs2, anon_izyfb8.val);
		llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
		float result = fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs2);
		llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		return result;
	}
}
