using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_round_using_current_rounding_mode_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil33round_using_current_rounding_modeIdEENS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EES4_E4typeES4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<double>, double>::type __llvm_libc_20_1_2_::fputil::round_using_current_rounding_mode<double>(double)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<double>, double>::type")]
	public unsafe static double Invoke([MangledName("x")][NativeType("double")] double X)
	{
		int num = 0;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = Fputil_quick_get_round.Invoke();
		double result = num switch
		{
			1024 => Fputil_round_using_specific_rounding_mode_double.Invoke(X, 1), 
			2048 => Fputil_round_using_specific_rounding_mode_double.Invoke(X, 0), 
			3072 => Fputil_round_using_specific_rounding_mode_double.Invoke(X, 2), 
			0 => Fputil_round_using_specific_rounding_mode_double.Invoke(X, 4), 
			_ => throw new NotImplementedException("Reached LLVM unreachable instruction."), 
		};
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
