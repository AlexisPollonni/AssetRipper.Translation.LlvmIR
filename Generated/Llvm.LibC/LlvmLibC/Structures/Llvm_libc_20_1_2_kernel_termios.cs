using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 36)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_14kernel_termiosE")]
[MangledName("struct.__llvm_libc_20_1_2_::kernel_termios")]
[DemangledName("__llvm_libc_20_1_2_::kernel_termios")]
public partial struct Llvm_libc_20_1_2_kernel_termios
{
	[FieldOffset(0)]
	public int C_iflag;

	[FieldOffset(4)]
	public int C_oflag;

	[FieldOffset(8)]
	public int C_cflag;

	[FieldOffset(12)]
	public int C_lflag;

	[FieldOffset(16)]
	public sbyte C_line;

	[FieldOffset(17)]
	public InlineArray19_SByte C_cc;
}
