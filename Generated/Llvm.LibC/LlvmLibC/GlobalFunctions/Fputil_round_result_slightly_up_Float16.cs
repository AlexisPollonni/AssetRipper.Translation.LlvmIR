using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_round_result_slightly_up_Float16
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil24round_result_slightly_upIDF16_EET_S2_")]
	[DemangledName("_Float16 __llvm_libc_20_1_2_::fputil::round_result_slightly_up<_Float16>(_Float16)")]
	[return: NativeType("_Float16")]
	public unsafe static Half Invoke([MangledName("value_rn")][NativeType("_Float16")] Half Value_rn)
	{
		float num = 0f;
		Fputil_FPBits_2fahva fputil_FPBits_2fahva = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		unchecked
		{
			num = (float)Value_rn;
			Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva);
			Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Sign_POS.Pointer, 1L, isVolatile: false);
			short field_ = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_min_normal.Invoke(anon_izyfb.Val);
			fputil_FPBits_2fahva.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
			float num2 = (float)FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva);
			num += num2;
			Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva);
			Half result = Fputil_cast_Float16_float.Invoke(num);
			Llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}
