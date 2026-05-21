using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 24)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_10scanf_core10ReadBufferE")]
[MangledName("struct.__llvm_libc_20_1_2_::scanf_core::ReadBuffer")]
[DemangledName("__llvm_libc_20_1_2_::scanf_core::ReadBuffer")]
public partial struct Llvm_libc_20_1_2_scanf_core_ReadBuffer
{
	[FieldOffset(0)]
	public unsafe void* Buffer;

	[FieldOffset(8)]
	public long Buff_len;

	[FieldOffset(16)]
	public long Buff_cur;
}
