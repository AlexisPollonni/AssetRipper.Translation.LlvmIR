using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cfgetospeed
{
	[MangledName("cfgetospeed")]
	[DemangledName("cfgetospeed")]
	public unsafe static int Invoke([MangledName("t")] Termios* T)
	{
		return T->C_cflag & 0x100F;
	}
}
