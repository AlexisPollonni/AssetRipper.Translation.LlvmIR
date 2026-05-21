using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class scanf_core_convert_current_pos
{
	[MangledName("_ZN19__llvm_libc_20_1_2_10scanf_core19convert_current_posEPNS0_6ReaderERKNS0_13FormatSectionE")]
	[DemangledName("__llvm_libc_20_1_2_::scanf_core::convert_current_pos(__llvm_libc_20_1_2_::scanf_core::Reader*, __llvm_libc_20_1_2_::scanf_core::FormatSection const&)")]
	public unsafe static int Invoke([NativeType("__llvm_libc_20_1_2_::scanf_core::Reader*")] scanf_core_Reader* reader, [NativeType("__llvm_libc_20_1_2_::scanf_core::FormatSection const&")] scanf_core_FormatSection* to_conv)
	{
		scanf_core_write_int_with_length.Invoke(Reader_chars_read.Invoke(reader), to_conv);
		return 0;
	}
}
