using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 616)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_13MessageMapperILm32ELm487EEE")]
[MangledName("class.__llvm_libc_20_1_2_::MessageMapper")]
[DemangledName("__llvm_libc_20_1_2_::MessageMapper")]
[CleanName("MessageMapper")]
public partial struct MessageMapper_f6bdqy
{
	[FieldOffset(0)]
	public InlineArray32_Int32 Msg_offsets;

	[FieldOffset(128)]
	public InlineArray487_SByte String_array;

	[FieldOffset(615)]
	public sbyte field_2;
}
