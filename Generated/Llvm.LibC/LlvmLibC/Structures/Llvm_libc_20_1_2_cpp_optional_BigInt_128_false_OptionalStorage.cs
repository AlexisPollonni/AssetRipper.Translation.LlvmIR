using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 24)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_3cpp8optionalINS_8internal13ExpandedFloatIdEEE15OptionalStorageIS4_Lb0EEE")]
[MangledName("struct.__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::BigInt<128, false>>::OptionalStorage")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::BigInt<128, false>>::OptionalStorage")]
public partial struct Llvm_libc_20_1_2_cpp_optional_BigInt_128_false_OptionalStorage
{
	[FieldOffset(0)]
	public Anon_2zhidv field;

	[FieldOffset(16)]
	public sbyte In_use;

	[FieldOffset(17)]
	public InlineArray7_SByte field_2;
}
