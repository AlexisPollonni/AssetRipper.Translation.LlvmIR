using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 60)]
[MangledName("_ZTS7termios")]
[MangledName("struct.termios")]
[DemangledName("termios")]
public partial struct Termios
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
	public InlineArray32_SByte C_cc;

	[FieldOffset(52)]
	public int C_ispeed;

	[FieldOffset(56)]
	public int C_ospeed;
}
