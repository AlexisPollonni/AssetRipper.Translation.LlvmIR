using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 328)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_11printf_core6ParserINS_8internal7ArgListEEE")]
[MangledName("class.__llvm_libc_20_1_2_::printf_core::Parser")]
[DemangledName("__llvm_libc_20_1_2_::printf_core::Parser")]
public partial struct printf_core_Parser
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

	[FieldOffset(72)]
	public InlineArray128_printf_core_TypeDesc desc_arr;
}
