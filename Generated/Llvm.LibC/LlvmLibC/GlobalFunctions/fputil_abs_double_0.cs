using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_abs_double_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil3absIdTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_")]
	[DemangledName("double __llvm_libc_20_1_2_::fputil::abs<double, 0>(double)")]
	[return: NativeType("double")]
	public unsafe static double Invoke([NativeType("double")] double x)
	{
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
		FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm3, x);
		long val = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_abs.Invoke(unchecked((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm3)));
		fputil_FPBits_wjhbrm2.FPRepImpl.FPRepSem.FPStorage.val = val;
		double result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm2);
		llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
		llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		return result;
	}
}
