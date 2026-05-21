using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FloatWriter_init
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core11FloatWriter4initEmm")]
	[DemangledName("__llvm_libc_20_1_2_::printf_core::FloatWriter::init(unsigned long, unsigned long)")]
	public unsafe static void Invoke([MangledName("this")] Llvm_libc_20_1_2_printf_core_FloatWriter* This, [MangledName("init_total_digits")][NativeType("unsigned long")] long Init_total_digits, [MangledName("init_digits_before_decimal")][NativeType("unsigned long")] long Init_digits_before_decimal)
	{
		This->Total_digits = Init_total_digits;
		This->Digits_before_decimal = Init_digits_before_decimal;
	}
}
