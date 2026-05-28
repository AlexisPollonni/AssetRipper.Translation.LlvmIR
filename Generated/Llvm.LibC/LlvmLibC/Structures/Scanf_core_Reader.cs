using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 40)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_10scanf_core6ReaderE")]
[MangledName("class.__llvm_libc_20_1_2_::scanf_core::Reader")]
[DemangledName("__llvm_libc_20_1_2_::scanf_core::Reader")]
public partial struct Scanf_core_Reader
{
	[FieldOffset(0)]
	public unsafe Scanf_core_ReadBuffer* Rb;

	[FieldOffset(8)]
	public unsafe void* Input_stream;

	[FieldOffset(16)]
	public unsafe void* Stream_getc;

	[FieldOffset(24)]
	public unsafe void* Stream_ungetc;

	[FieldOffset(32)]
	public long Cur_chars_read;
}
