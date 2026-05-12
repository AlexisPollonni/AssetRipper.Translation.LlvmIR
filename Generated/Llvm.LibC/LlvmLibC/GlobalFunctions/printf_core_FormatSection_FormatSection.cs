using LlvmLibC.Enumerations;
using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core13FormatSectionC2Ev")]
[DemangledName("__llvm_libc_20_1_2_::printf_core::FormatSection::FormatSection()")]
internal static partial class printf_core_FormatSection_FormatSection
{
	public unsafe static void Invoke(printf_core_FormatSection* @this)
	{
		cpp_string_view_string_view.Invoke(&@this->raw_string);
		@this->flags = (FormatFlags_hin2uh)0;
		@this->length_modifier = LengthModifier_mnvaa2.none;
		@this->bit_width = 0L;
		@this->min_width = 0;
		@this->precision = -1;
	}
}
