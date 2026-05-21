using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_copysign_double_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8copysignIdTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_S4_")]
	[DemangledName("double __llvm_libc_20_1_2_::fputil::copysign<double, 0>(double, double)")]
	[return: NativeType("double")]
	public unsafe static double Invoke([NativeType("double")] double x, [NativeType("double")] double y)
	{
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		*unchecked((long*)(&fputil_FPBits_wjhbrm2)) = -6148914691236517206L;
		FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm2, x);
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
		FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm3, y);
		anon_izyfb8.val = FPStorage_fputil_FPType_2_sign.Invoke(&fputil_FPBits_wjhbrm3);
		FPStorage_fputil_FPType_2_set_sign.Invoke(&fputil_FPBits_wjhbrm2, anon_izyfb8.val);
		llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
		double result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm2);
		llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		return result;
	}
}
