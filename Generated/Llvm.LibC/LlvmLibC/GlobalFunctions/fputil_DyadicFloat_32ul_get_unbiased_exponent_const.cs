using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil11DyadicFloatILm32EE21get_unbiased_exponentEv")]
[DemangledName("__llvm_libc_20_1_2_::fputil::DyadicFloat<32ul>::get_unbiased_exponent() const")]
internal static partial class fputil_DyadicFloat_32ul_get_unbiased_exponent_const
{
	public unsafe static int Invoke(void* @this)
	{
		return unchecked((int)(((fputil_DyadicFloat_c8qpxg*)@this)->exponent + 31L));
	}
}
