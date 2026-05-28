using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_round_result_slightly_up_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil24round_result_slightly_upIdEET_S2_")]
	[DemangledName("double __llvm_libc_20_1_2_::fputil::round_result_slightly_up<double>(double)")]
	[return: NativeType("double")]
	public unsafe static double Invoke([MangledName("value_rn")][NativeType("double")] double Value_rn)
	{
		double num = 0.0;
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm = default(Fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = Value_rn;
		Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
		Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Sign_POS.Pointer, 1L, isVolatile: false);
		long val = FPRepSem_fputil_FPType_2_fputil_FPBits_double_min_normal.Invoke(anon_izyfb.Val);
		fputil_FPBits_wjhbrm.FPRepImpl.FPRepSem.FPStorage.Val = val;
		double num2 = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm);
		num += num2;
		Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
		double result = num;
		Llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}
}
