using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_multiply_add_Float16
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil12multiply_addIDF16_EENS_3cpp9enable_ifIXlestT_Lm8EES4_E4typeES4_S4_S4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (_Float16) <= 8ul, _Float16>::type __llvm_libc_20_1_2_::fputil::multiply_add<_Float16>(_Float16, _Float16, _Float16)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (_Float16) <= 8ul, _Float16>::type")]
	public static Half Invoke([NativeType("_Float16")] Half x, [NativeType("_Float16")] Half y, [NativeType("_Float16")] Half z)
	{
		return unchecked((Half)llvm_fmuladd_f32.Invoke((float)x, (float)y, (float)z));
	}
}
