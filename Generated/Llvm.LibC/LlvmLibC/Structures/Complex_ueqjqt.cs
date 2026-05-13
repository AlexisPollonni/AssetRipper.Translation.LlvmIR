using System;
using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 4)]
[MangledName("struct.__llvm_libc_20_1_2_::Complex.2615")]
[DemangledName("__llvm_libc_20_1_2_::Complex")]
[CleanName("Complex")]
public partial struct Complex_ueqjqt
{
	[FieldOffset(0)]
	public Half real;

	[FieldOffset(2)]
	public Half imag;
}
