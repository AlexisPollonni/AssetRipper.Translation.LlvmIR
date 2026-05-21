using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cfgetispeed
{
	[MangledName("cfgetispeed")]
	[DemangledName("cfgetispeed")]
	public unsafe static int Invoke([MangledName("t")] Termios* T)
	{
		return T->C_cflag & 0x100F;
	}
}
