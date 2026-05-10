using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil26round_result_slightly_downIfEET_S2_")]
[DemangledName("float __llvm_libc_20_1_2_::fputil::round_result_slightly_down<float>(float)")]
internal static partial class float_fputil_round_result_slightly_down_float_float
{
	public unsafe static float Invoke(float value_rn)
	{
		float num = 0f;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = value_rn;
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
		int field_ = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_min_normal_Sign.Invoke(anon_izyfb8.val);
		fputil_FPBits_5nkvcs2.FPRepImpl.FPRepSem.field_0.field_0 = field_;
		float num2 = fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs2);
		num -= num2;
		llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		float result = num;
		llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
