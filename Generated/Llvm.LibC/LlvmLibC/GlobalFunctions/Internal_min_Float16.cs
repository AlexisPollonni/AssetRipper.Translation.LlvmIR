using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_min_Float16
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal3minIDF16_EENS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EES5_E4typeES5_S5_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16>, _Float16>::type __llvm_libc_20_1_2_::fputil::internal::min<_Float16>(_Float16, _Float16)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16>, _Float16>::type")]
	public static Half Invoke([MangledName("x")][NativeType("_Float16")] Half X, [MangledName("y")][NativeType("_Float16")] Half Y)
	{
		return Llvm_minnum_f16.Invoke(X, Y);
	}
}
