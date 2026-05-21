using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_floor_float_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil5floorIfTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_")]
	[DemangledName("float __llvm_libc_20_1_2_::fputil::floor<float, 0>(float)")]
	[return: NativeType("float")]
	public unsafe static float Invoke([NativeType("float")] float x)
	{
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs2) = -1431655766;
			FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs2, x);
			float result = ((!FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_neg.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2))) ? fputil_trunc_float_0.Invoke(x) : (0f - fputil_ceil_float_0.Invoke(0f - x)));
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
			return result;
		}
	}
}
