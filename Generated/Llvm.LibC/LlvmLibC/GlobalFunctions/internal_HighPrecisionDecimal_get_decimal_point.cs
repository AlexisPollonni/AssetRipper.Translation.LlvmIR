using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal20HighPrecisionDecimal17get_decimal_pointEv")]
[DemangledName("__llvm_libc_20_1_2_::internal::HighPrecisionDecimal::get_decimal_point()")]
internal static partial class internal_HighPrecisionDecimal_get_decimal_point
{
	public unsafe static int Invoke(void* @this)
	{
		return unchecked((internal_HighPrecisionDecimal*)@this)->decimal_point;
	}
}
