using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 266)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_3cpp8optionalINS0_5arrayIcLm265EEEE15OptionalStorageIS3_Lb0EEE")]
[MangledName("struct.__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::cpp::array<char, 265>>::OptionalStorage")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::cpp::array<char, 265>>::OptionalStorage")]
public partial struct Llvm_libc_20_1_2_cpp_optional_cpp_array_char_265_OptionalStorage
{
	[FieldOffset(0)]
	public Anon_d2djam field;

	[FieldOffset(265)]
	public sbyte In_use;
}
