using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal20HighPrecisionDecimal17get_decimal_pointEv")]
[DemangledName("__llvm_libc_20_1_2_::internal::HighPrecisionDecimal::get_decimal_point()")]
internal static partial class internal_HighPrecisionDecimal_get_decimal_point
{
	public unsafe static int Invoke(internal_HighPrecisionDecimal* @this)
	{
		return @this->decimal_point;
	}
}
