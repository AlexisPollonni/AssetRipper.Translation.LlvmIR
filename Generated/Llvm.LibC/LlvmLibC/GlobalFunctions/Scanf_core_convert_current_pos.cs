using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Scanf_core_convert_current_pos
{
	[MangledName("_ZN19__llvm_libc_20_1_2_10scanf_core19convert_current_posEPNS0_6ReaderERKNS0_13FormatSectionE")]
	[DemangledName("__llvm_libc_20_1_2_::scanf_core::convert_current_pos(__llvm_libc_20_1_2_::scanf_core::Reader*, __llvm_libc_20_1_2_::scanf_core::FormatSection const&)")]
	public unsafe static int Invoke([MangledName("reader")][NativeType("__llvm_libc_20_1_2_::scanf_core::Reader*")] Llvm_libc_20_1_2_scanf_core_Reader* Reader, [MangledName("to_conv")][NativeType("__llvm_libc_20_1_2_::scanf_core::FormatSection const&")] Llvm_libc_20_1_2_scanf_core_FormatSection* To_conv)
	{
		Scanf_core_write_int_with_length.Invoke(Reader_chars_read.Invoke(Reader), To_conv);
		return 0;
	}
}
