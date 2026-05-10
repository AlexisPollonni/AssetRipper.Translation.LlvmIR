using System.Runtime.InteropServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 40)]
[MangledName("struct.__llvm_libc_20_1_2_::internal::DigitBuffer.10")]
[DemangledName("__llvm_libc_20_1_2_::internal::DigitBuffer")]
[CleanName("internal_DigitBuffer")]
public partial struct internal_DigitBuffer_cze9ca
{
	[FieldOffset(0)]
	public InlineArray32_SByte digits;

	[FieldOffset(32)]
	public long size;
}
