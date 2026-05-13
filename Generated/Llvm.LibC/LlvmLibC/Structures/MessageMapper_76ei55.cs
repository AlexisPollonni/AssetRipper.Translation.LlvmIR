using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 3652)]
[MangledName("class.__llvm_libc_20_1_2_::MessageMapper.6451")]
[DemangledName("__llvm_libc_20_1_2_::MessageMapper")]
[CleanName("MessageMapper")]
public partial struct MessageMapper_76ei55
{
	[FieldOffset(0)]
	public InlineArray134_Int32 msg_offsets;

	[FieldOffset(536)]
	public InlineArray3113_SByte string_array;

	[FieldOffset(3649)]
	public InlineArray3_SByte field_2;
}
