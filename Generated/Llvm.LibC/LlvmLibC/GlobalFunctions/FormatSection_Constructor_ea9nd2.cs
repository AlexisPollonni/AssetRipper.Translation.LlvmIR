using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FormatSection_Constructor_ea9nd2
{
	[MangledName("_ZN19__llvm_libc_20_1_2_10scanf_core13FormatSectionC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::scanf_core::FormatSection::FormatSection()")]
	[CleanName("FormatSection_Constructor")]
	public unsafe static void Invoke([MangledName("this")] Llvm_libc_20_1_2_scanf_core_FormatSection* This)
	{
		String_view_Constructor.Invoke(&This->Raw_string);
		This->Flags = FormatFlags_96pze4.NONE;
		This->Length_modifier = LengthModifier_3739tr.NONE;
		This->Max_width = -1;
		This->Output_ptr = null;
		Bitset_256ul_Constructor.Invoke(&This->Scan_set);
	}
}
