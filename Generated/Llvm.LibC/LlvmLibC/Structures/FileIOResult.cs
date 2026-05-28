using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 16)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_12FileIOResultE")]
[MangledName("struct.__llvm_libc_20_1_2_::FileIOResult")]
[DemangledName("__llvm_libc_20_1_2_::FileIOResult")]
public partial struct FileIOResult
{
	[FieldOffset(0)]
	public long Value;

	[FieldOffset(8)]
	public int Error;

	[FieldOffset(12)]
	public InlineArray4_SByte field_2;
}
