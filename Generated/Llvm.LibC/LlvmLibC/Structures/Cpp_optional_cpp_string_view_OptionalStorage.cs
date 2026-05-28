using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 24)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_3cpp8optionalINS_8internal13ExpandedFloatIdEEE15OptionalStorageIS4_Lb0EEE")]
[MangledName("struct.__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::cpp::string_view>::OptionalStorage")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::cpp::string_view>::OptionalStorage")]
public partial struct Cpp_optional_cpp_string_view_OptionalStorage
{
	[FieldOffset(0)]
	public Anon_hnnzgy field;

	[FieldOffset(16)]
	public sbyte In_use;

	[FieldOffset(17)]
	public InlineArray7_SByte field_2;
}
