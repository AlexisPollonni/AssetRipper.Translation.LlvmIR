using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class PaddingWriter_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core13PaddingWriterC2ERKNS0_13FormatSectionEc")]
	[DemangledName("__llvm_libc_20_1_2_::printf_core::PaddingWriter::PaddingWriter(__llvm_libc_20_1_2_::printf_core::FormatSection const&, char)")]
	public unsafe static void Invoke([MangledName("this")] Llvm_libc_20_1_2_printf_core_PaddingWriter* This, [MangledName("to_conv")][NativeType("__llvm_libc_20_1_2_::printf_core::FormatSection const&")] Llvm_libc_20_1_2_printf_core_FormatSection* To_conv, [MangledName("init_sign_char")][NativeType("char")] sbyte Init_sign_char)
	{
		sbyte sign_char = Init_sign_char;
		unchecked
		{
			This->Left_justified = ((((byte)To_conv->Flags & 1) > 0) ? ((sbyte)1) : ((sbyte)0));
			This->Leading_zeroes = ((((byte)To_conv->Flags & 0x10) > 0) ? ((sbyte)1) : ((sbyte)0));
			This->Sign_char = sign_char;
			long* min_width = &This->Min_width;
			*min_width = ((To_conv->Min_width > 0) ? To_conv->Min_width : 0);
		}
	}
}
