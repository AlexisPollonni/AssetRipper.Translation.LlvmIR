using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 48)]
[MangledName("struct.__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::ExpandedFloat<long double>>::OptionalStorage")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::ExpandedFloat<long double>>::OptionalStorage")]
public partial struct cpp_optional_internal_ExpandedFloat_long_double_OptionalStorage
{
	[FieldOffset(0)]
	public anon_zfq63p field;

	[FieldOffset(32)]
	public sbyte in_use;

	[FieldOffset(33)]
	public InlineArray15_SByte field_2;
}
