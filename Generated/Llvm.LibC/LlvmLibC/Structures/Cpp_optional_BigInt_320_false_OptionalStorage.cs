using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 48)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_3cpp8optionalINS_8internal13ExpandedFloatIeEEE15OptionalStorageIS4_Lb0EEE")]
[MangledName("struct.__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::BigInt<320, false>>::OptionalStorage")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::BigInt<320, false>>::OptionalStorage")]
public partial struct Cpp_optional_BigInt_320_false_OptionalStorage
{
	[FieldOffset(0)]
	public Anon_m9wkkk field;

	[FieldOffset(40)]
	public sbyte field_1;

	[FieldOffset(41)]
	public InlineArray7_SByte field_2;
}
