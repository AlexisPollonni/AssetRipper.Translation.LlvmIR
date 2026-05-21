using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class HighPrecisionDecimal_get_num_digits
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal20HighPrecisionDecimal14get_num_digitsEv")]
	[DemangledName("__llvm_libc_20_1_2_::internal::HighPrecisionDecimal::get_num_digits()")]
	public unsafe static int Invoke([MangledName("this")] Llvm_libc_20_1_2_internal_HighPrecisionDecimal* This)
	{
		return This->Num_digits;
	}
}
