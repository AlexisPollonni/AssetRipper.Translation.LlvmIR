using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class PaddingWriter_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core13PaddingWriterC2ERKNS0_13FormatSectionEc")]
	[DemangledName("__llvm_libc_20_1_2_::printf_core::PaddingWriter::PaddingWriter(__llvm_libc_20_1_2_::printf_core::FormatSection const&, char)")]
	public unsafe static void Invoke(printf_core_PaddingWriter* @this, [NativeType("__llvm_libc_20_1_2_::printf_core::FormatSection const&")] printf_core_FormatSection* to_conv, [NativeType("char")] sbyte init_sign_char)
	{
		sbyte sign_char = init_sign_char;
		unchecked
		{
			@this->left_justified = ((((byte)to_conv->flags & 1) > 0) ? ((sbyte)1) : ((sbyte)0));
			@this->leading_zeroes = ((((byte)to_conv->flags & 0x10) > 0) ? ((sbyte)1) : ((sbyte)0));
			@this->sign_char = sign_char;
			long* min_width = &@this->min_width;
			*min_width = ((to_conv->min_width > 0) ? to_conv->min_width : 0);
		}
	}
}
