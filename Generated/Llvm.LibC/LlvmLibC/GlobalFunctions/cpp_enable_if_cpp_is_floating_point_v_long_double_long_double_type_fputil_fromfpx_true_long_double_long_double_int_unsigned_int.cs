using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7fromfpxILb1EeEENS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT0_EES4_E4typeES4_ij")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<long double>, long double>::type __llvm_libc_20_1_2_::fputil::fromfpx<true, long double>(long double, int, unsigned int)")]
internal static partial class cpp_enable_if_cpp_is_floating_point_v_long_double_long_double_type_fputil_fromfpx_true_long_double_long_double_int_unsigned_int
{
	public unsafe static double Invoke(double x, int rnd, int width)
	{
		double num = 0.0;
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(fputil_FPBits_ubgsi2);
		llvm_lifetime_start_p0.Invoke(16L, &num);
		num = cpp_enable_if_cpp_is_floating_point_v_long_double_long_double_type_fputil_fromfp_true_long_double_long_double_int_unsigned_int.Invoke(x, rnd, width);
		llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		*unchecked((Int128*)(&fputil_FPBits_ubgsi3)) = -6148914691236517206L;
		fputil_FPBits_long_double_FPBits_long_double_long_double.Invoke(&fputil_FPBits_ubgsi3, num);
		if (!fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_nan_const.Invoke(&fputil_FPBits_ubgsi3) && NumericHelper.IsUnorderedOrNotEquals(num, x))
		{
			fputil_raise_except_if_required_int.Invoke(32);
		}
		double result = num;
		llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		llvm_lifetime_end_p0.Invoke(16L, &num);
		return result;
	}
}
