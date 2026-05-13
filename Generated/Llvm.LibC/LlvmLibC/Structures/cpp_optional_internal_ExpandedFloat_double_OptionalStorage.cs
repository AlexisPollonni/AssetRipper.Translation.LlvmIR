using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 24)]
[MangledName("struct.__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::ExpandedFloat<double>>::OptionalStorage")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::ExpandedFloat<double>>::OptionalStorage")]
public partial struct cpp_optional_internal_ExpandedFloat_double_OptionalStorage
{
	[FieldOffset(0)]
	public anon_54rhxc field;

	[FieldOffset(16)]
	public sbyte in_use;

	[FieldOffset(17)]
	public InlineArray7_SByte field_2;
}
