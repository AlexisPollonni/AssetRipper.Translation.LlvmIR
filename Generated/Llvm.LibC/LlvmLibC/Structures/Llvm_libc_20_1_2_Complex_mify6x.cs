using System;
using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 4)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_7ComplexIDF16_EE")]
[MangledName("struct.__llvm_libc_20_1_2_::Complex.2614")]
[DemangledName("__llvm_libc_20_1_2_::Complex")]
[CleanName("Llvm_libc_20_1_2_Complex")]
public partial struct Llvm_libc_20_1_2_Complex_mify6x
{
	[FieldOffset(0)]
	public Half Real;

	[FieldOffset(2)]
	public Half Imag;
}
