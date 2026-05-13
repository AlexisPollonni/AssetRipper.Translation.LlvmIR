using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil11DyadicFloatILm64EE2asIDF16_Lb1EvEET_v")]
[DemangledName("_Float16 __llvm_libc_20_1_2_::fputil::DyadicFloat<64ul>::as<_Float16, true, void>() const")]
internal static partial class Float16_fputil_DyadicFloat_64ul_as_Float16_true_void_const
{
	public unsafe static Half Invoke(fputil_DyadicFloat_374hpp* @this)
	{
		return Float16_fputil_DyadicFloat_64ul_fast_as_Float16_true_void_const.Invoke(@this);
	}
}
