using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class iscntrl
{
	public unsafe static int Invoke(int c)
	{
		int num = 0;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = c;
		byte result = unchecked((byte)(((uint)num >= 32u) ? ((num == 127) ? 1 : 0) : (-1)));
		llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
