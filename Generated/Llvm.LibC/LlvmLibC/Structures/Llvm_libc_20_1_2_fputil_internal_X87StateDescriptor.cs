using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 28)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_6fputil8internal18X87StateDescriptorE")]
[MangledName("struct.__llvm_libc_20_1_2_::fputil::internal::X87StateDescriptor")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::X87StateDescriptor")]
public partial struct Llvm_libc_20_1_2_fputil_internal_X87StateDescriptor
{
	[FieldOffset(0)]
	public short Control_word;

	[FieldOffset(2)]
	public short Unused1;

	[FieldOffset(4)]
	public short Status_word;

	[FieldOffset(6)]
	public short Unused2;

	[FieldOffset(8)]
	public InlineArray5_Int32 field;
}
