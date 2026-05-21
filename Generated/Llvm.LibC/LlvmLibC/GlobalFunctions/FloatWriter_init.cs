using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FloatWriter_init
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core11FloatWriter4initEmm")]
	[DemangledName("__llvm_libc_20_1_2_::printf_core::FloatWriter::init(unsigned long, unsigned long)")]
	public unsafe static void Invoke(printf_core_FloatWriter* @this, [NativeType("unsigned long")] long init_total_digits, [NativeType("unsigned long")] long init_digits_before_decimal)
	{
		@this->total_digits = init_total_digits;
		@this->digits_before_decimal = init_digits_before_decimal;
	}
}
