using System;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7fromfpxILb1EgEENS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT0_EES4_E4typeES4_ij")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<__float128>, __float128>::type __llvm_libc_20_1_2_::fputil::fromfpx<true, __float128>(__float128, int, unsigned int)")]
internal static partial class cpp_enable_if_cpp_is_floating_point_v_float128_float128_type_fputil_fromfpx_true_float128_float128_int_unsigned_int
{
	public unsafe static double Invoke(double x, int rnd, int width)
	{
		double num = 0.0;
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(fputil_FPBits_ubgsi2);
		llvm_lifetime_start_p0.Invoke(16L, &num);
		num = cpp_enable_if_cpp_is_floating_point_v_float128_float128_type_fputil_fromfp_true_float128_float128_int_unsigned_int.Invoke(x, rnd, width);
		llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		*unchecked((Int128*)(&fputil_FPBits_ubgsi3)) = -6148914691236517206L;
		fputil_FPBits_float128_FPBits_float128_float128.Invoke(&fputil_FPBits_ubgsi3, num);
		if (!fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_nan_const.Invoke(&fputil_FPBits_ubgsi3) && NumericHelper.IsUnorderedOrNotEquals(num, x))
		{
			fputil_raise_except_if_required_int.Invoke(32);
		}
		double result = num;
		llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		llvm_lifetime_end_p0.Invoke(16L, &num);
		return result;
	}
}
