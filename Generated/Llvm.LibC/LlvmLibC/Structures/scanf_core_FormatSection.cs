using System.Runtime.InteropServices;
using LlvmLibC.Enumerations;
using LlvmLibC.Helpers;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 88)]
[MangledName("struct.__llvm_libc_20_1_2_::scanf_core::FormatSection")]
[DemangledName("__llvm_libc_20_1_2_::scanf_core::FormatSection")]
public partial struct scanf_core_FormatSection
{
	[FieldOffset(0)]
	public sbyte has_conv;

	[FieldOffset(8)]
	public cpp_string_view raw_string;

	[FieldOffset(24)]
	public FormatFlags_96pze4 flags;

	[FieldOffset(28)]
	public LengthModifier_3739tr length_modifier;

	[FieldOffset(32)]
	public int max_width;

	[FieldOffset(40)]
	public unsafe void* output_ptr;

	[FieldOffset(48)]
	public sbyte conv_name;

	[FieldOffset(56)]
	public cpp_array_jgy3xh scan_set;
}
