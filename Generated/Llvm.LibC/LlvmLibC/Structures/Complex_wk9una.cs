using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 32)]
[MangledName("struct.__llvm_libc_20_1_2_::Complex.5833")]
[DemangledName("__llvm_libc_20_1_2_::Complex")]
[CleanName("Complex")]
public partial struct Complex_wk9una
{
	[FieldOffset(0)]
	public double real;

	[FieldOffset(16)]
	public double imag;
}
