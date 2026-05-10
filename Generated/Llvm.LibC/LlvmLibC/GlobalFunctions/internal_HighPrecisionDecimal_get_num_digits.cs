using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal20HighPrecisionDecimal14get_num_digitsEv")]
[DemangledName("__llvm_libc_20_1_2_::internal::HighPrecisionDecimal::get_num_digits()")]
internal static partial class internal_HighPrecisionDecimal_get_num_digits
{
	public unsafe static int Invoke(void* @this)
	{
		return unchecked((internal_HighPrecisionDecimal*)@this)->num_digits;
	}
}
