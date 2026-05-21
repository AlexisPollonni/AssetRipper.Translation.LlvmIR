using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class cfsetispeed
{
	public unsafe static int Invoke(termios* t, int speed)
	{
		int num = 0;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = -4112;
		int result;
		if (t == null || (speed & -4112) != 0)
		{
			Errno_Assignment.Invoke(libc_errno.Pointer, 22);
			result = -1;
		}
		else
		{
			t->c_cflag = (t->c_cflag & -4112) | speed;
			t->c_ispeed = speed;
			result = 0;
		}
		llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
