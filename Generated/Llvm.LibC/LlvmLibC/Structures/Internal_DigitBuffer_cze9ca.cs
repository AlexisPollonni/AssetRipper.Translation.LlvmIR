using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 40)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_8internal11DigitBufferIoLi16EEE")]
[MangledName("struct.__llvm_libc_20_1_2_::internal::DigitBuffer.10")]
[DemangledName("__llvm_libc_20_1_2_::internal::DigitBuffer")]
[CleanName("Internal_DigitBuffer")]
public partial struct Internal_DigitBuffer_cze9ca
{
	[FieldOffset(0)]
	public InlineArray32_SByte Digits;

	[FieldOffset(32)]
	public long Size;
}
