using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 72)]
[MangledName("class.__llvm_libc_20_1_2_::scanf_core::Parser")]
[DemangledName("__llvm_libc_20_1_2_::scanf_core::Parser")]
public partial struct scanf_core_Parser
{
	[FieldOffset(0)]
	public unsafe void* str;

	[FieldOffset(8)]
	public long cur_pos;

	[FieldOffset(16)]
	public internal_ArgList args_cur;

	[FieldOffset(40)]
	public internal_ArgList args_start;

	[FieldOffset(64)]
	public long args_index;
}
