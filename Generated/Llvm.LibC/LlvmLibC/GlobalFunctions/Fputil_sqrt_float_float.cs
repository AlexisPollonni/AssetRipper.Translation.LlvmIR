using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_sqrt_float_float
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil4sqrtIffEENS_3cpp9enable_ifIXaaaasr3cppE19is_floating_point_vIT_Esr3cppE19is_floating_point_vIT0_ElestS4_stS5_ES4_E4typeES5_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<float> && cpp::is_floating_point_v<float> && sizeof (float) <= sizeof (float), float>::type __llvm_libc_20_1_2_::fputil::sqrt<float, float>(float)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<float> && cpp::is_floating_point_v<float> && sizeof (float) <= sizeof (float), float>::type")]
	public unsafe static float Invoke([MangledName("x")][NativeType("float")] float X)
	{
		float num = 0f;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = float.NaN;
		num = IntrinsicFunctions.AsmSqrtss(X);
		float result = num;
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
