using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8copysignIdTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_S4_")]
[DemangledName("double __llvm_libc_20_1_2_::fputil::copysign<double, 0>(double, double)")]
internal static partial class double_fputil_copysign_double_0_double_double
{
	public unsafe static double Invoke(double x, double y)
	{
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		*unchecked((long*)(&fputil_FPBits_wjhbrm2)) = -6148914691236517206L;
		fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm2, x);
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
		fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm3, y);
		anon_izyfb8.val = fputil_internal_FPStorage_fputil_FPType_2_sign_const.Invoke(&fputil_FPBits_wjhbrm3);
		fputil_internal_FPStorage_fputil_FPType_2_set_sign_Sign.Invoke(&fputil_FPBits_wjhbrm2, anon_izyfb8.val);
		llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
		double result = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm2);
		llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		return result;
	}
}
