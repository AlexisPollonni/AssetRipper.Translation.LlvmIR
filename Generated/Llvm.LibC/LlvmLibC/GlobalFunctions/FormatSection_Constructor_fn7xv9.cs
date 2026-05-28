using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FormatSection_Constructor_fn7xv9
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core13FormatSectionC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::printf_core::FormatSection::FormatSection()")]
	[CleanName("FormatSection_Constructor")]
	public unsafe static void Invoke([MangledName("this")] Printf_core_FormatSection* This)
	{
		String_view_Constructor.Invoke(&This->Raw_string);
		This->Flags = (FormatFlags_hin2uh)0;
		This->Length_modifier = LengthModifier_mnvaa2.none;
		This->Bit_width = 0L;
		This->Min_width = 0;
		This->Precision = -1;
	}
}
