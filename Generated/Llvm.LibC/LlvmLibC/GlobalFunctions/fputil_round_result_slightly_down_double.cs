using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_round_result_slightly_down_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil26round_result_slightly_downIdEET_S2_")]
	[DemangledName("double __llvm_libc_20_1_2_::fputil::round_result_slightly_down<double>(double)")]
	[return: NativeType("double")]
	public unsafe static double Invoke([NativeType("double")] double value_rn)
	{
		double num = 0.0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = value_rn;
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
		long val = FPRepSem_fputil_FPType_2_fputil_FPBits_double_min_normal.Invoke(anon_izyfb8.val);
		fputil_FPBits_wjhbrm2.FPRepImpl.FPRepSem.FPStorage.val = val;
		double num2 = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm2);
		num -= num2;
		llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		double result = num;
		llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}
}
