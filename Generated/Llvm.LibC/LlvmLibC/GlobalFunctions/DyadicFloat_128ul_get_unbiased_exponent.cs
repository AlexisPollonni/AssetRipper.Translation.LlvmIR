using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class DyadicFloat_128ul_get_unbiased_exponent
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil11DyadicFloatILm128EE21get_unbiased_exponentEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>::get_unbiased_exponent() const")]
	public unsafe static int Invoke([MangledName("this")] Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4* This)
	{
		return unchecked((int)(This->Exponent + 127L));
	}
}
