using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 32)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_8TLSImageE")]
[MangledName("struct.__llvm_libc_20_1_2_::TLSImage")]
[DemangledName("__llvm_libc_20_1_2_::TLSImage")]
public partial struct TLSImage
{
	[FieldOffset(0)]
	public long address;

	[FieldOffset(8)]
	public long size;

	[FieldOffset(16)]
	public long init_size;

	[FieldOffset(24)]
	public long align;
}
