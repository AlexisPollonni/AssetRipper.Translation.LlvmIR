using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_10scanf_core13FormatSectionC2Ev")]
[DemangledName("__llvm_libc_20_1_2_::scanf_core::FormatSection::FormatSection()")]
internal static partial class scanf_core_FormatSection_FormatSection
{
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			cpp_string_view_string_view.Invoke(&((scanf_core_FormatSection*)@this)->raw_string);
			((scanf_core_FormatSection*)@this)->flags = 0;
			((scanf_core_FormatSection*)@this)->length_modifier = 8;
			((scanf_core_FormatSection*)@this)->max_width = -1;
			((scanf_core_FormatSection*)@this)->output_ptr = null;
			cpp_bitset_256ul_bitset.Invoke(&((scanf_core_FormatSection*)@this)->scan_set);
		}
	}
}
