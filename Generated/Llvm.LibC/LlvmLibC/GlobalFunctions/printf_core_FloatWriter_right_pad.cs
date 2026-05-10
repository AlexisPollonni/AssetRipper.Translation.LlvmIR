using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core11FloatWriter9right_padEv")]
[DemangledName("__llvm_libc_20_1_2_::printf_core::FloatWriter::right_pad()")]
internal static partial class printf_core_FloatWriter_right_pad
{
	public unsafe static int Invoke(void* @this)
	{
		return unchecked(printf_core_PaddingWriter_write_right_padding_printf_core_Writer_unsigned_long.Invoke(&((printf_core_FloatWriter*)@this)->padding_writer, ((printf_core_FloatWriter*)@this)->writer, ((printf_core_FloatWriter*)@this)->total_digits));
	}
}
