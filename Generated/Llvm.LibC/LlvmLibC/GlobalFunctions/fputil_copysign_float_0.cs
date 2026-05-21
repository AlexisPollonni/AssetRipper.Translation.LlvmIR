using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_copysign_float_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8copysignIfTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_S4_")]
	[DemangledName("float __llvm_libc_20_1_2_::fputil::copysign<float, 0>(float, float)")]
	[return: NativeType("float")]
	public unsafe static float Invoke([NativeType("float")] float x, [NativeType("float")] float y)
	{
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(fputil_FPBits_5nkvcs);
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		*unchecked((int*)(&fputil_FPBits_5nkvcs2)) = -1431655766;
		FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs2, x);
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
		FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs3, y);
		anon_izyfb8.val = FPStorage_fputil_FPType_1_sign.Invoke(&fputil_FPBits_5nkvcs3);
		FPStorage_fputil_FPType_1_set_sign.Invoke(&fputil_FPBits_5nkvcs2, anon_izyfb8.val);
		llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
		float result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs2);
		llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		return result;
	}
}
