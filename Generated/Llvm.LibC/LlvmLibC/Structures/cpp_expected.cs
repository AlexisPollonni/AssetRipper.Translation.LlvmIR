using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 16)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_3cpp8optionalIdE15OptionalStorageIdLb0EEE")]
[MangledName("class.__llvm_libc_20_1_2_::cpp::expected")]
[DemangledName("__llvm_libc_20_1_2_::cpp::expected")]
public partial struct cpp_expected
{
	[FieldOffset(0)]
	public fputil_internal_FPStorage_v3nexn field;

	[FieldOffset(8)]
	public sbyte in_use;

	[FieldOffset(9)]
	public InlineArray7_SByte field_2;
}
