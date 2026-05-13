using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 36)]
[MangledName("struct.__llvm_libc_20_1_2_::kernel_termios")]
[DemangledName("__llvm_libc_20_1_2_::kernel_termios")]
public partial struct kernel_termios
{
	[FieldOffset(0)]
	public int c_iflag;

	[FieldOffset(4)]
	public int c_oflag;

	[FieldOffset(8)]
	public int c_cflag;

	[FieldOffset(12)]
	public int c_lflag;

	[FieldOffset(16)]
	public sbyte c_line;

	[FieldOffset(17)]
	public InlineArray19_SByte c_cc;
}
