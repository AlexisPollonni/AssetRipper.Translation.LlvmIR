using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil11DyadicFloatILm32EE2asIDF16_Lb1EvEET_v")]
[DemangledName("_Float16 __llvm_libc_20_1_2_::fputil::DyadicFloat<32ul>::as<_Float16, true, void>() const")]
internal static partial class Float16_fputil_DyadicFloat_32ul_as_Float16_true_void_const
{
	public unsafe static Half Invoke(void* @this)
	{
		return Float16_fputil_DyadicFloat_32ul_fast_as_Float16_true_void_const.Invoke(@this);
	}
}
