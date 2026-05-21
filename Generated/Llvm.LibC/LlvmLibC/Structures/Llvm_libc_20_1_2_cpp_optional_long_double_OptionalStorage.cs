using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 32)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_3cpp8optionalINS_8internal10AbsTimeoutEE15OptionalStorageIS3_Lb0EEE")]
[MangledName("struct.__llvm_libc_20_1_2_::cpp::optional<long double>::OptionalStorage")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<long double>::OptionalStorage")]
public partial struct Llvm_libc_20_1_2_cpp_optional_long_double_OptionalStorage
{
	[FieldOffset(0)]
	public Anon_mbc8w5 field;

	[FieldOffset(16)]
	public sbyte field_1;

	[FieldOffset(17)]
	public InlineArray15_SByte field_2;
}
