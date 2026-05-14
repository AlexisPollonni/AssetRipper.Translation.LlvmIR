using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 3652)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_13MessageMapperILm134ELm3113EEE")]
[MangledName("class.__llvm_libc_20_1_2_::MessageMapper.6586")]
[DemangledName("__llvm_libc_20_1_2_::MessageMapper")]
[CleanName("MessageMapper")]
public partial struct MessageMapper_8a2hs7
{
	[FieldOffset(0)]
	public InlineArray134_Int32 msg_offsets;

	[FieldOffset(536)]
	public InlineArray3113_SByte string_array;

	[FieldOffset(3649)]
	public InlineArray3_SByte field_2;
}
