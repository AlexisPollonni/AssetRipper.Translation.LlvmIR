using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 56)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_8internal11DigitBufferIoLi10EEE")]
[MangledName("struct.__llvm_libc_20_1_2_::internal::DigitBuffer.11")]
[DemangledName("__llvm_libc_20_1_2_::internal::DigitBuffer")]
[CleanName("internal_DigitBuffer")]
public partial struct internal_DigitBuffer_wha8ym
{
	[FieldOffset(0)]
	public InlineArray42_SByte digits;

	[FieldOffset(48)]
	public long size;
}
