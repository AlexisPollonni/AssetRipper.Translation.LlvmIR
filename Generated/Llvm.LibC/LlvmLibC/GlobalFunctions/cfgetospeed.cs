using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class cfgetospeed
{
	public unsafe static int Invoke(void* t)
	{
		return unchecked((termios*)t)->c_cflag & 0x100F;
	}
}
