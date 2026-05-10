using System.Runtime.InteropServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 136)]
[MangledName("struct.__llvm_libc_20_1_2_::internal::DigitBuffer")]
[DemangledName("__llvm_libc_20_1_2_::internal::DigitBuffer")]
[CleanName("internal_DigitBuffer")]
public partial struct internal_DigitBuffer_wtdk7c
{
	[FieldOffset(0)]
	public InlineArray128_SByte digits;

	[FieldOffset(128)]
	public long size;
}
