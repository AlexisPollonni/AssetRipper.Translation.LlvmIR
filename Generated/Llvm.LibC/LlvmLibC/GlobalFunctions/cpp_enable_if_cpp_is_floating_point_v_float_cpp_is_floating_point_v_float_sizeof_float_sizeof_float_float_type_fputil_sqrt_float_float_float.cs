using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil4sqrtIffEENS_3cpp9enable_ifIXaaaasr3cppE19is_floating_point_vIT_Esr3cppE19is_floating_point_vIT0_ElestS4_stS5_ES4_E4typeES5_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<float> && cpp::is_floating_point_v<float> && sizeof (float) <= sizeof (float), float>::type __llvm_libc_20_1_2_::fputil::sqrt<float, float>(float)")]
internal static partial class cpp_enable_if_cpp_is_floating_point_v_float_cpp_is_floating_point_v_float_sizeof_float_sizeof_float_float_type_fputil_sqrt_float_float_float
{
	public unsafe static float Invoke(float x)
	{
		float num = 0f;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = float.NaN;
		num = IntrinsicFunctions.AsmSqrtss(x);
		float result = num;
		llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
