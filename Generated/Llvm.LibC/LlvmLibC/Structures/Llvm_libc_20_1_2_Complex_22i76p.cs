using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 32)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_7ComplexIgEE")]
[MangledName("struct.__llvm_libc_20_1_2_::Complex")]
[DemangledName("__llvm_libc_20_1_2_::Complex")]
[CleanName("Llvm_libc_20_1_2_Complex")]
public partial struct Llvm_libc_20_1_2_Complex_22i76p
{
	[FieldOffset(0)]
	public double Real;

	[FieldOffset(16)]
	public double Imag;
}
