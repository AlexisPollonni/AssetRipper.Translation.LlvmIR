using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cfsetospeed
{
	[MangledName("cfsetospeed")]
	[DemangledName("cfsetospeed")]
	public unsafe static int Invoke([MangledName("t")] Termios* T, [MangledName("speed")] int Speed)
	{
		int num = 0;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = -4112;
		int result;
		if (T == null || (Speed & -4112) != 0)
		{
			Errno_Assignment.Invoke(Libc_errno.Pointer, 22);
			result = -1;
		}
		else
		{
			T->C_cflag = (T->C_cflag & -4112) | Speed;
			T->C_ospeed = Speed;
			result = 0;
		}
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
