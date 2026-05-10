using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core13PaddingWriterC2ERKNS0_13FormatSectionEc")]
[DemangledName("__llvm_libc_20_1_2_::printf_core::PaddingWriter::PaddingWriter(__llvm_libc_20_1_2_::printf_core::FormatSection const&, char)")]
internal static partial class printf_core_PaddingWriter_PaddingWriter_printf_core_FormatSection_const_char
{
	public unsafe static void Invoke(void* @this, void* to_conv, sbyte init_sign_char)
	{
		sbyte sign_char = init_sign_char;
		unchecked
		{
			((printf_core_PaddingWriter*)@this)->left_justified = ((((byte)((printf_core_FormatSection*)to_conv)->flags & 1) > 0) ? ((sbyte)1) : ((sbyte)0));
			((printf_core_PaddingWriter*)@this)->leading_zeroes = ((((byte)((printf_core_FormatSection*)to_conv)->flags & 0x10) > 0) ? ((sbyte)1) : ((sbyte)0));
			((printf_core_PaddingWriter*)@this)->sign_char = sign_char;
			long* min_width = &((printf_core_PaddingWriter*)@this)->min_width;
			*min_width = ((((printf_core_FormatSection*)to_conv)->min_width > 0) ? ((printf_core_FormatSection*)to_conv)->min_width : 0);
		}
	}
}
