using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class HighPrecisionDecimal_get_digits
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal20HighPrecisionDecimal10get_digitsEv")]
	[DemangledName("__llvm_libc_20_1_2_::internal::HighPrecisionDecimal::get_digits()")]
	public unsafe static void* Invoke([MangledName("this")] Llvm_libc_20_1_2_internal_HighPrecisionDecimal* This)
	{
		return &This->Digits;
	}
}
