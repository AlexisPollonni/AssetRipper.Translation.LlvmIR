using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_cast_Float16_float128
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil4castIDF16_gEENS_3cpp9enable_ifIXaasr3cppE19is_floating_point_vIT_Esr3cppE19is_floating_point_vIT0_EES4_E4typeES5_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16> && cpp::is_floating_point_v<__float128>, _Float16>::type __llvm_libc_20_1_2_::fputil::cast<_Float16, __float128>(__float128)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16> && cpp::is_floating_point_v<__float128>, _Float16>::type")]
	public static Half Invoke([MangledName("x")][NativeType("__float128")] double X)
	{
		return unchecked((Half)X);
	}
}
