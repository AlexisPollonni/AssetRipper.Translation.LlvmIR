using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class DyadicFloat_128ul_Double_double_void
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil11DyadicFloatILm128EEcvT_IdvEEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>::operator double<double, void>() const")]
	public unsafe static double Invoke([MangledName("this")] Fputil_DyadicFloat_kt2kd4* This)
	{
		return DyadicFloat_128ul_as_double_false_void.Invoke(This);
	}
}
