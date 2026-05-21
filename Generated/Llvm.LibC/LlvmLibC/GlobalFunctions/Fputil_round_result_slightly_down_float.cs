using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_round_result_slightly_down_float
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil26round_result_slightly_downIfEET_S2_")]
	[DemangledName("float __llvm_libc_20_1_2_::fputil::round_result_slightly_down<float>(float)")]
	[return: NativeType("float")]
	public unsafe static float Invoke([MangledName("value_rn")][NativeType("float")] float Value_rn)
	{
		float num = 0f;
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = Value_rn;
		Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
		int field_ = FPRepSem_fputil_FPType_1_fputil_FPBits_float_min_normal.Invoke(anon_izyfb.Val);
		llvm_libc_20_1_2_fputil_FPBits_5nkvcs.FPRepImpl.FPRepSem.field_0.field_0 = field_;
		float num2 = FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		num -= num2;
		Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		float result = num;
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
