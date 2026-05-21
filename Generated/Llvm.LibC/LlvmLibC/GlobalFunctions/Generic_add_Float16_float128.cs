using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Generic_add_Float16_float128
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic3addIDF16_gEENS_3cpp9enable_ifIXaaaasr3cppE19is_floating_point_vIT_Esr3cppE19is_floating_point_vIT0_ElestS5_stS6_ES5_E4typeES6_S6_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16> && cpp::is_floating_point_v<__float128> && sizeof (_Float16) <= sizeof (__float128), _Float16>::type __llvm_libc_20_1_2_::fputil::generic::add<_Float16, __float128>(__float128, __float128)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16> && cpp::is_floating_point_v<__float128> && sizeof (_Float16) <= sizeof (__float128), _Float16>::type")]
	public static Half Invoke([MangledName("x")][NativeType("__float128")] double X, [MangledName("y")][NativeType("__float128")] double Y)
	{
		return Generic_add_or_sub_false_Float16_float128.Invoke(X, Y);
	}
}
