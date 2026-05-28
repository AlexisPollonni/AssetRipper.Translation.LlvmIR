using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class DyadicFloat_128ul_as_float128_true_void
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil11DyadicFloatILm128EE2asIgLb1EvEET_v")]
	[DemangledName("__float128 __llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>::as<__float128, true, void>() const")]
	[return: NativeType("__float128")]
	public unsafe static double Invoke([MangledName("this")] Fputil_DyadicFloat_kt2kd4* This)
	{
		return DyadicFloat_128ul_fast_as_float128_true_void.Invoke(This);
	}
}
