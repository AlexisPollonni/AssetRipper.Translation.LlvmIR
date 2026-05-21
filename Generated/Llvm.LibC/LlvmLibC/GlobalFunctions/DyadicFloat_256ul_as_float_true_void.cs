using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class DyadicFloat_256ul_as_float_true_void
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil11DyadicFloatILm256EE2asIfLb1EvEET_v")]
	[DemangledName("float __llvm_libc_20_1_2_::fputil::DyadicFloat<256ul>::as<float, true, void>() const")]
	[return: NativeType("float")]
	public unsafe static float Invoke([MangledName("this")] Llvm_libc_20_1_2_fputil_DyadicFloat_jhcpjj* This)
	{
		return DyadicFloat_256ul_fast_as_float_true_void.Invoke(This);
	}
}
