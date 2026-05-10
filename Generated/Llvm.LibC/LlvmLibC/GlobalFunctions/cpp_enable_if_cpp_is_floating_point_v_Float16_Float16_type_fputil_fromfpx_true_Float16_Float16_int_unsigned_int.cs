using System;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7fromfpxILb1EDF16_EENS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT0_EES4_E4typeES4_ij")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16>, _Float16>::type __llvm_libc_20_1_2_::fputil::fromfpx<true, _Float16>(_Float16, int, unsigned int)")]
internal static partial class cpp_enable_if_cpp_is_floating_point_v_Float16_Float16_type_fputil_fromfpx_true_Float16_Float16_int_unsigned_int
{
	public unsafe static Half Invoke(Half x, int rnd, int width)
	{
		Half half = default(Half);
		fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(fputil_FPBits_2fahva);
		llvm_lifetime_start_p0.Invoke(2L, &half);
		half = cpp_enable_if_cpp_is_floating_point_v_Float16_Float16_type_fputil_fromfp_true_Float16_Float16_int_unsigned_int.Invoke(x, rnd, width);
		llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
		*unchecked((short*)(&fputil_FPBits_2fahva2)) = -21846;
		fputil_FPBits_Float16_FPBits_Float16_Float16.Invoke(&fputil_FPBits_2fahva2, half);
		if (!fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_nan_const.Invoke(&fputil_FPBits_2fahva2) && NumericHelper.IsUnorderedOrNotEquals(half, x))
		{
			fputil_raise_except_if_required_int.Invoke(32);
		}
		Half result = half;
		llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
		llvm_lifetime_end_p0.Invoke(2L, &half);
		return result;
	}
}
