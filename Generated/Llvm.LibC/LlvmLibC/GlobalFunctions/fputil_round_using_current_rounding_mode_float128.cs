using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_round_using_current_rounding_mode_float128
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil33round_using_current_rounding_modeIgEENS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EES4_E4typeES4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<__float128>, __float128>::type __llvm_libc_20_1_2_::fputil::round_using_current_rounding_mode<__float128>(__float128)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<__float128>, __float128>::type")]
	public unsafe static double Invoke([NativeType("__float128")] double x)
	{
		int num = 0;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = fputil_quick_get_round.Invoke();
		double result = num switch
		{
			1024 => fputil_round_using_specific_rounding_mode_float128.Invoke(x, 1), 
			2048 => fputil_round_using_specific_rounding_mode_float128.Invoke(x, 0), 
			3072 => fputil_round_using_specific_rounding_mode_float128.Invoke(x, 2), 
			0 => fputil_round_using_specific_rounding_mode_float128.Invoke(x, 4), 
			_ => throw new NotImplementedException("Reached LLVM unreachable instruction."), 
		};
		llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
