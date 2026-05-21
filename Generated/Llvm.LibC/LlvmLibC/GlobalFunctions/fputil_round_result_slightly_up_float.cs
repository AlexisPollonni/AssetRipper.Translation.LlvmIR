using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_round_result_slightly_up_float
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil24round_result_slightly_upIfEET_S2_")]
	[DemangledName("float __llvm_libc_20_1_2_::fputil::round_result_slightly_up<float>(float)")]
	[return: NativeType("float")]
	public unsafe static float Invoke([NativeType("float")] float value_rn)
	{
		float num = 0f;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = value_rn;
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
		int field_ = FPRepSem_fputil_FPType_1_fputil_FPBits_float_min_normal.Invoke(anon_izyfb8.val);
		fputil_FPBits_5nkvcs2.FPRepImpl.FPRepSem.field_0.field_0 = field_;
		float num2 = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs2);
		num += num2;
		llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		float result = num;
		llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
