using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core13FormatSectionC2Ev")]
[DemangledName("__llvm_libc_20_1_2_::printf_core::FormatSection::FormatSection()")]
internal static partial class printf_core_FormatSection_FormatSection
{
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			cpp_string_view_string_view.Invoke(&((printf_core_FormatSection*)@this)->raw_string);
			((printf_core_FormatSection*)@this)->flags = 0;
			((printf_core_FormatSection*)@this)->length_modifier = 10;
			((printf_core_FormatSection*)@this)->bit_width = 0L;
			((printf_core_FormatSection*)@this)->min_width = 0;
			((printf_core_FormatSection*)@this)->precision = -1;
		}
	}
}
