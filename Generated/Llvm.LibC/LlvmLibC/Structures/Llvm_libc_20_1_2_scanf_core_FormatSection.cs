using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 88)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_10scanf_core13FormatSectionE")]
[MangledName("struct.__llvm_libc_20_1_2_::scanf_core::FormatSection")]
[DemangledName("__llvm_libc_20_1_2_::scanf_core::FormatSection")]
public partial struct Llvm_libc_20_1_2_scanf_core_FormatSection
{
	[FieldOffset(0)]
	public sbyte Has_conv;

	[FieldOffset(8)]
	public Llvm_libc_20_1_2_cpp_string_view Raw_string;

	[FieldOffset(24)]
	public FormatFlags_96pze4 Flags;

	[FieldOffset(28)]
	public LengthModifier_3739tr Length_modifier;

	[FieldOffset(32)]
	public int Max_width;

	[FieldOffset(40)]
	public unsafe void* Output_ptr;

	[FieldOffset(48)]
	public sbyte Conv_name;

	[FieldOffset(56)]
	public Llvm_libc_20_1_2_cpp_array_jgy3xh Scan_set;
}
