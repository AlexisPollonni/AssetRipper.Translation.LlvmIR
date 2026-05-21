using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FormatSection_Constructor_fn7xv9
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core13FormatSectionC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::printf_core::FormatSection::FormatSection()")]
	[CleanName("FormatSection_Constructor")]
	public unsafe static void Invoke(printf_core_FormatSection* @this)
	{
		string_view_Constructor.Invoke(&@this->raw_string);
		@this->flags = (FormatFlags_hin2uh)0;
		@this->length_modifier = LengthModifier_mnvaa2.none;
		@this->bit_width = 0L;
		@this->min_width = 0;
		@this->precision = -1;
	}
}
