using System;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Unimplemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal3minIDF16_EENS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EES5_E4typeES5_S5_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16>, _Float16>::type __llvm_libc_20_1_2_::fputil::internal::min<_Float16>(_Float16, _Float16)")]
internal static partial class cpp_enable_if_cpp_is_floating_point_v_Float16_Float16_type_fputil_internal_min_Float16_Float16_Float16
{
	public static Half Invoke(Half x, Half y)
	{
		return llvm_minnum_f16.Invoke(x, y);
	}
}
