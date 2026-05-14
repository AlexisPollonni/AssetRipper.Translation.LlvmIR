using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 88)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_10CharVectorE")]
[MangledName("class.__llvm_libc_20_1_2_::CharVector")]
[DemangledName("__llvm_libc_20_1_2_::CharVector")]
public partial struct CharVector
{
	[FieldOffset(0)]
	public InlineArray64_SByte local_buffer;

	[FieldOffset(64)]
	public unsafe void* cur_str;

	[FieldOffset(72)]
	public long cur_buff_size;

	[FieldOffset(80)]
	public long index;
}
