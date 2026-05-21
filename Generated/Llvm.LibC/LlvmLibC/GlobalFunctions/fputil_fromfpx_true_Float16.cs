using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_fromfpx_true_Float16
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7fromfpxILb1EDF16_EENS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT0_EES4_E4typeES4_ij")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16>, _Float16>::type __llvm_libc_20_1_2_::fputil::fromfpx<true, _Float16>(_Float16, int, unsigned int)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16>, _Float16>::type")]
	public unsafe static Half Invoke([NativeType("_Float16")] Half x, [NativeType("int")] int rnd, [NativeType("unsigned int")] int width)
	{
		Half half = default(Half);
		fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(fputil_FPBits_2fahva);
		llvm_lifetime_start_p0.Invoke(2L, &half);
		half = fputil_fromfp_true_Float16.Invoke(x, rnd, width);
		llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
		unchecked
		{
			*(short*)(&fputil_FPBits_2fahva2) = -21846;
			FPBits_Float16_Constructor.Invoke(&fputil_FPBits_2fahva2, half);
			if (!FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_nan.Invoke((fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva2)) && NumericHelper.IsUnorderedOrNotEquals(half, x))
			{
				fputil_raise_except_if_required.Invoke(32);
			}
			Half result = half;
			llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
			llvm_lifetime_end_p0.Invoke(2L, &half);
			return result;
		}
	}
}
