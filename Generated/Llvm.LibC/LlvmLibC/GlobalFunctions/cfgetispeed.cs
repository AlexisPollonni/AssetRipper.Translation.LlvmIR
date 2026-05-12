using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class cfgetispeed
{
	public unsafe static int Invoke(termios* t)
	{
		return t->c_cflag & 0x100F;
	}
}
