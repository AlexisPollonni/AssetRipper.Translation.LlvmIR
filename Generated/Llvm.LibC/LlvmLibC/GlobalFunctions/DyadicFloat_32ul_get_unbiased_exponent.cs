using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class DyadicFloat_32ul_get_unbiased_exponent
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil11DyadicFloatILm32EE21get_unbiased_exponentEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::DyadicFloat<32ul>::get_unbiased_exponent() const")]
	public unsafe static int Invoke([MangledName("this")] void* This)
	{
		return unchecked((int)(((Llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs*)This)->Exponent + 31L));
	}
}
