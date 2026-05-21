using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class DyadicFloat_64ul_get_unbiased_exponent
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil11DyadicFloatILm64EE21get_unbiased_exponentEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::DyadicFloat<64ul>::get_unbiased_exponent() const")]
	public unsafe static int Invoke([MangledName("this")] Llvm_libc_20_1_2_fputil_DyadicFloat_syracv* This)
	{
		return unchecked((int)(This->Exponent + 63L));
	}
}
