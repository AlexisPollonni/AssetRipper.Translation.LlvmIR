using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil11DyadicFloatILm128EE2asIfLb1EvEET_v")]
[DemangledName("float __llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>::as<float, true, void>() const")]
internal static partial class float_fputil_DyadicFloat_128ul_as_float_true_void_const
{
	public unsafe static float Invoke(fputil_DyadicFloat_kt2kd4* @this)
	{
		return float_fputil_DyadicFloat_128ul_fast_as_float_true_void_const.Invoke(@this);
	}
}
