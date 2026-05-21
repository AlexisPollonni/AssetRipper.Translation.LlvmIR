using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class DyadicFloat_32ul_as_float_true_void
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil11DyadicFloatILm32EE2asIfLb1EvEET_v")]
	[DemangledName("float __llvm_libc_20_1_2_::fputil::DyadicFloat<32ul>::as<float, true, void>() const")]
	[return: NativeType("float")]
	public unsafe static float Invoke([MangledName("this")] void* This)
	{
		return DyadicFloat_32ul_fast_as_float_true_void.Invoke(This);
	}
}
