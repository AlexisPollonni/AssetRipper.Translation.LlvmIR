using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_abs_double_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil3absIdTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_")]
	[DemangledName("double __llvm_libc_20_1_2_::fputil::abs<double, 0>(double)")]
	[return: NativeType("double")]
	public unsafe static double Invoke([MangledName("x")][NativeType("double")] double X)
	{
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm = default(Fputil_FPBits_wjhbrm);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(Fputil_FPBits_wjhbrm);
		Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
		Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm2, X);
		long val = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_abs.Invoke(unchecked((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2)));
		fputil_FPBits_wjhbrm.FPRepImpl.FPRepSem.FPStorage.Val = val;
		double result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm);
		Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
		return result;
	}
}
