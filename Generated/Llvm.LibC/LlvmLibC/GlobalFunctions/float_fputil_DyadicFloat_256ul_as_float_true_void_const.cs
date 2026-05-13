using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil11DyadicFloatILm256EE2asIfLb1EvEET_v")]
[DemangledName("float __llvm_libc_20_1_2_::fputil::DyadicFloat<256ul>::as<float, true, void>() const")]
internal static partial class float_fputil_DyadicFloat_256ul_as_float_true_void_const
{
	public unsafe static float Invoke(fputil_DyadicFloat_jhcpjj* @this)
	{
		return float_fputil_DyadicFloat_256ul_fast_as_float_true_void_const.Invoke(@this);
	}
}
