using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class HighPrecisionDecimal_get_decimal_point
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal20HighPrecisionDecimal17get_decimal_pointEv")]
	[DemangledName("__llvm_libc_20_1_2_::internal::HighPrecisionDecimal::get_decimal_point()")]
	public unsafe static int Invoke([MangledName("this")] Llvm_libc_20_1_2_internal_HighPrecisionDecimal* This)
	{
		return This->Decimal_point;
	}
}
