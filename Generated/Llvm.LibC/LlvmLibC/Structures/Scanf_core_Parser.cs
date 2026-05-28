using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 72)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_10scanf_core6ParserINS_8internal7ArgListEEE")]
[MangledName("class.__llvm_libc_20_1_2_::scanf_core::Parser")]
[DemangledName("__llvm_libc_20_1_2_::scanf_core::Parser")]
public partial struct Scanf_core_Parser
{
	[FieldOffset(0)]
	public unsafe void* Str;

	[FieldOffset(8)]
	public long Cur_pos;

	[FieldOffset(16)]
	public Internal_ArgList Args_cur;

	[FieldOffset(40)]
	public Internal_ArgList Args_start;

	[FieldOffset(64)]
	public long Args_index;
}
