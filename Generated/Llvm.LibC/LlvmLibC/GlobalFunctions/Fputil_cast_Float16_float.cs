using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_cast_Float16_float
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil4castIDF16_fEENS_3cpp9enable_ifIXaasr3cppE19is_floating_point_vIT_Esr3cppE19is_floating_point_vIT0_EES4_E4typeES5_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16> && cpp::is_floating_point_v<float>, _Float16>::type __llvm_libc_20_1_2_::fputil::cast<_Float16, float>(float)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16> && cpp::is_floating_point_v<float>, _Float16>::type")]
	public static Half Invoke([MangledName("x")][NativeType("float")] float X)
	{
		return unchecked((Half)X);
	}
}
