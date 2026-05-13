using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil24round_result_slightly_upIdEET_S2_")]
[DemangledName("double __llvm_libc_20_1_2_::fputil::round_result_slightly_up<double>(double)")]
internal static partial class double_fputil_round_result_slightly_up_double_double
{
	public unsafe static double Invoke(double value_rn)
	{
		double num = 0.0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = value_rn;
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
		long val = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_min_normal_Sign.Invoke(anon_izyfb8.val);
		fputil_FPBits_wjhbrm2.FPRepImpl.FPRepSem.FPStorage.val = val;
		double num2 = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm2);
		num += num2;
		llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		double result = num;
		llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}
}
