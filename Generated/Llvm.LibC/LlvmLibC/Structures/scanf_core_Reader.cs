using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 40)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_10scanf_core6ReaderE")]
[MangledName("class.__llvm_libc_20_1_2_::scanf_core::Reader")]
[DemangledName("__llvm_libc_20_1_2_::scanf_core::Reader")]
public partial struct scanf_core_Reader
{
	[FieldOffset(0)]
	public unsafe scanf_core_ReadBuffer* rb;

	[FieldOffset(8)]
	public unsafe void* input_stream;

	[FieldOffset(16)]
	public unsafe void* stream_getc;

	[FieldOffset(24)]
	public unsafe void* stream_ungetc;

	[FieldOffset(32)]
	public long cur_chars_read;
}
