using System;
using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil11DyadicFloatILm128EE2asIDF16_Lb1EvEET_v")]
[DemangledName("_Float16 __llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>::as<_Float16, true, void>() const")]
internal static partial class Float16_fputil_DyadicFloat_128ul_as_Float16_true_void_const
{
	public unsafe static Half Invoke(fputil_DyadicFloat_kt2kd4* @this)
	{
		return Float16_fputil_DyadicFloat_128ul_fast_as_Float16_true_void_const.Invoke(@this);
	}
}
