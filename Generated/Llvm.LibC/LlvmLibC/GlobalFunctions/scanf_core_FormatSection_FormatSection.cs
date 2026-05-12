using LlvmLibC.Enumerations;
using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_10scanf_core13FormatSectionC2Ev")]
[DemangledName("__llvm_libc_20_1_2_::scanf_core::FormatSection::FormatSection()")]
internal static partial class scanf_core_FormatSection_FormatSection
{
	public unsafe static void Invoke(scanf_core_FormatSection* @this)
	{
		cpp_string_view_string_view.Invoke(&@this->raw_string);
		@this->flags = FormatFlags_96pze4.NONE;
		@this->length_modifier = LengthModifier_3739tr.NONE;
		@this->max_width = -1;
		@this->output_ptr = null;
		cpp_bitset_256ul_bitset.Invoke(&@this->scan_set);
	}
}
