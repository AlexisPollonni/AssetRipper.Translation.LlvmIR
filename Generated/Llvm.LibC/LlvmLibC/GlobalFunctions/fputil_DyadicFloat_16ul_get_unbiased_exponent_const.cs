using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil11DyadicFloatILm16EE21get_unbiased_exponentEv")]
[DemangledName("__llvm_libc_20_1_2_::fputil::DyadicFloat<16ul>::get_unbiased_exponent() const")]
internal static partial class fputil_DyadicFloat_16ul_get_unbiased_exponent_const
{
	public unsafe static int Invoke(fputil_DyadicFloat_jvghxm* @this)
	{
		return unchecked((int)(@this->exponent + 15L));
	}
}
