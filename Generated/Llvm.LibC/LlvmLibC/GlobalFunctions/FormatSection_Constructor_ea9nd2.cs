using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FormatSection_Constructor_ea9nd2
{
	[MangledName("_ZN19__llvm_libc_20_1_2_10scanf_core13FormatSectionC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::scanf_core::FormatSection::FormatSection()")]
	[CleanName("FormatSection_Constructor")]
	public unsafe static void Invoke(scanf_core_FormatSection* @this)
	{
		string_view_Constructor.Invoke(&@this->raw_string);
		@this->flags = FormatFlags_96pze4.NONE;
		@this->length_modifier = LengthModifier_3739tr.NONE;
		@this->max_width = -1;
		@this->output_ptr = null;
		bitset_256ul_Constructor.Invoke(&@this->scan_set);
	}
}
