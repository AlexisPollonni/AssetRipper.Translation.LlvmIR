using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class generic_sub_Float16_long_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic3subIDF16_eEENS_3cpp9enable_ifIXaaaasr3cppE19is_floating_point_vIT_Esr3cppE19is_floating_point_vIT0_ElestS5_stS6_ES5_E4typeES6_S6_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16> && cpp::is_floating_point_v<long double> && sizeof (_Float16) <= sizeof (long double), _Float16>::type __llvm_libc_20_1_2_::fputil::generic::sub<_Float16, long double>(long double, long double)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16> && cpp::is_floating_point_v<long double> && sizeof (_Float16) <= sizeof (long double), _Float16>::type")]
	public static Half Invoke([NativeType("long double")] double x, [NativeType("long double")] double y)
	{
		return generic_add_or_sub_true_Float16_long_double.Invoke(x, y);
	}
}
