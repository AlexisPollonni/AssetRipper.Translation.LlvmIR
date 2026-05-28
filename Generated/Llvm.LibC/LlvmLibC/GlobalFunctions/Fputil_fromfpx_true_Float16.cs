using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_fromfpx_true_Float16
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7fromfpxILb1EDF16_EENS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT0_EES4_E4typeES4_ij")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16>, _Float16>::type __llvm_libc_20_1_2_::fputil::fromfpx<true, _Float16>(_Float16, int, unsigned int)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16>, _Float16>::type")]
	public unsafe static Half Invoke([MangledName("x")][NativeType("_Float16")] Half X, [MangledName("rnd")][NativeType("int")] int Rnd, [MangledName("width")][NativeType("unsigned int")] int Width)
	{
		Half half = default(Half);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva = default(Fputil_FPBits_2fahva);
		Llvm_lifetime_start_p0.Invoke(2L, &half);
		half = Fputil_fromfp_true_Float16.Invoke(X, Rnd, Width);
		Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva);
		unchecked
		{
			*(short*)(&fputil_FPBits_2fahva) = -21846;
			FPBits_Float16_Constructor.Invoke(&fputil_FPBits_2fahva, half);
			if (!FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_nan.Invoke((Fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva)) && NumericHelper.IsUnorderedOrNotEquals(half, X))
			{
				Fputil_raise_except_if_required.Invoke(32);
			}
			Half result = half;
			Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva);
			Llvm_lifetime_end_p0.Invoke(2L, &half);
			return result;
		}
	}
}
