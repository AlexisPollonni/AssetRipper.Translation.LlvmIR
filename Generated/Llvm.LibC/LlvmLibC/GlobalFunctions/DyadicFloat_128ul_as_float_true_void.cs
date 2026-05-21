using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class DyadicFloat_128ul_as_float_true_void
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil11DyadicFloatILm128EE2asIfLb1EvEET_v")]
	[DemangledName("float __llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>::as<float, true, void>() const")]
	[return: NativeType("float")]
	public unsafe static float Invoke([MangledName("this")] Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4* This)
	{
		return DyadicFloat_128ul_fast_as_float_true_void.Invoke(This);
	}
}
