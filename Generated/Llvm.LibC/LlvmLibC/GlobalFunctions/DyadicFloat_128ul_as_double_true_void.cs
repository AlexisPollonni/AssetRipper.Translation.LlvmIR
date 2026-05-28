using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class DyadicFloat_128ul_as_double_true_void
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil11DyadicFloatILm128EE2asIdLb1EvEET_v")]
	[DemangledName("double __llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>::as<double, true, void>() const")]
	[return: NativeType("double")]
	public unsafe static double Invoke([MangledName("this")] Fputil_DyadicFloat_kt2kd4* This)
	{
		return DyadicFloat_128ul_fast_as_double_true_void.Invoke(This);
	}
}
