using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 24)]
[MangledName("struct.__llvm_libc_20_1_2_::scanf_core::ReadBuffer")]
[DemangledName("__llvm_libc_20_1_2_::scanf_core::ReadBuffer")]
public partial struct scanf_core_ReadBuffer
{
	[FieldOffset(0)]
	public unsafe void* buffer;

	[FieldOffset(8)]
	public long buff_len;

	[FieldOffset(16)]
	public long buff_cur;
}
