using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_10scanf_core19convert_current_posEPNS0_6ReaderERKNS0_13FormatSectionE")]
[DemangledName("__llvm_libc_20_1_2_::scanf_core::convert_current_pos(__llvm_libc_20_1_2_::scanf_core::Reader*, __llvm_libc_20_1_2_::scanf_core::FormatSection const&)")]
internal static partial class scanf_core_convert_current_pos_scanf_core_Reader_scanf_core_FormatSection_const
{
	public unsafe static int Invoke(scanf_core_Reader* reader, scanf_core_FormatSection* to_conv)
	{
		scanf_core_write_int_with_length_unsigned_long_scanf_core_FormatSection_const.Invoke(scanf_core_Reader_chars_read.Invoke(reader), to_conv);
		return 0;
	}
}
