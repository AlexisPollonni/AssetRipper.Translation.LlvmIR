using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic3addIDF16_fEENS_3cpp9enable_ifIXaaaasr3cppE19is_floating_point_vIT_Esr3cppE19is_floating_point_vIT0_ElestS5_stS6_ES5_E4typeES6_S6_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16> && cpp::is_floating_point_v<float> && sizeof (_Float16) <= sizeof (float), _Float16>::type __llvm_libc_20_1_2_::fputil::generic::add<_Float16, float>(float, float)")]
internal static partial class cpp_enable_if_cpp_is_floating_point_v_Float16_cpp_is_floating_point_v_float_sizeof_Float16_sizeof_float_Float16_type_fputil_generic_add_Float16_float_float_float
{
	public static Half Invoke(float x, float y)
	{
		return cpp_enable_if_cpp_is_floating_point_v_Float16_cpp_is_floating_point_v_float_sizeof_Float16_sizeof_float_Float16_type_fputil_generic_add_or_sub_false_Float16_float_float_float.Invoke(x, y);
	}
}
