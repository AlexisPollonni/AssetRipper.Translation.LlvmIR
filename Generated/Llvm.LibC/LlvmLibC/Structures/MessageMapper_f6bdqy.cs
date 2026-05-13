using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 616)]
[MangledName("class.__llvm_libc_20_1_2_::MessageMapper")]
[DemangledName("__llvm_libc_20_1_2_::MessageMapper")]
[CleanName("MessageMapper")]
public partial struct MessageMapper_f6bdqy
{
	[FieldOffset(0)]
	public InlineArray32_Int32 msg_offsets;

	[FieldOffset(128)]
	public InlineArray487_SByte string_array;

	[FieldOffset(615)]
	public sbyte field_2;
}
