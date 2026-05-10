using System.Runtime.InteropServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 32)]
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
