using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 32)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_3cpp8optionalINS_8internal10AbsTimeoutEE15OptionalStorageIS3_Lb0EEE")]
[MangledName("struct.__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::AbsTimeout>::OptionalStorage")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::AbsTimeout>::OptionalStorage")]
public partial struct cpp_optional_internal_AbsTimeout_OptionalStorage
{
	[FieldOffset(0)]
	public anon_t8muxx field;

	[FieldOffset(24)]
	public sbyte in_use;

	[FieldOffset(25)]
	public InlineArray7_SByte field_2;
}
