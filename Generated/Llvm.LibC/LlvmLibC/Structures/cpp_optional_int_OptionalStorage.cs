using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 8)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_3cpp8optionalIfE15OptionalStorageIfLb0EEE")]
[MangledName("struct.__llvm_libc_20_1_2_::cpp::optional<int>::OptionalStorage")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<int>::OptionalStorage")]
public partial struct cpp_optional_int_OptionalStorage
{
	[FieldOffset(0)]
	public fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt field;

	[FieldOffset(4)]
	public sbyte in_use;

	[FieldOffset(5)]
	public InlineArray3_SByte field_2;
}
