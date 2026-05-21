using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FloatWriter_right_pad
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core11FloatWriter9right_padEv")]
	[DemangledName("__llvm_libc_20_1_2_::printf_core::FloatWriter::right_pad()")]
	public unsafe static int Invoke([MangledName("this")] Llvm_libc_20_1_2_printf_core_FloatWriter* This)
	{
		return PaddingWriter_write_right_padding.Invoke(&This->Padding_writer, This->Writer, This->Total_digits);
	}
}
