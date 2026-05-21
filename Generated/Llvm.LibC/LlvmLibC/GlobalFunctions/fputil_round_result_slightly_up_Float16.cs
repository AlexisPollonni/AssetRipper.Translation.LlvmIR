using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_round_result_slightly_up_Float16
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil24round_result_slightly_upIDF16_EET_S2_")]
	[DemangledName("_Float16 __llvm_libc_20_1_2_::fputil::round_result_slightly_up<_Float16>(_Float16)")]
	[return: NativeType("_Float16")]
	public unsafe static Half Invoke([NativeType("_Float16")] Half value_rn)
	{
		float num = 0f;
		fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		llvm_lifetime_start_p0.Invoke(4L, &num);
		unchecked
		{
			num = (float)value_rn;
			llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
			llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
			short field_ = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_min_normal.Invoke(anon_izyfb8.val);
			fputil_FPBits_2fahva2.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
			float num2 = (float)FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva2);
			num += num2;
			llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
			Half result = fputil_cast_Float16_float.Invoke(num);
			llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}
