using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 328)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_11printf_core6ParserINS_8internal7ArgListEEE")]
[MangledName("class.__llvm_libc_20_1_2_::printf_core::Parser")]
[DemangledName("__llvm_libc_20_1_2_::printf_core::Parser")]
public partial struct Llvm_libc_20_1_2_printf_core_Parser
{
	[FieldOffset(0)]
	public unsafe void* Str;

	[FieldOffset(8)]
	public long Cur_pos;

	[FieldOffset(16)]
	public Llvm_libc_20_1_2_internal_ArgList Args_cur;

	[FieldOffset(40)]
	public Llvm_libc_20_1_2_internal_ArgList Args_start;

	[FieldOffset(64)]
	public long Args_index;

	[FieldOffset(72)]
	public InlineArray128_Llvm_libc_20_1_2_printf_core_TypeDesc Desc_arr;
}
