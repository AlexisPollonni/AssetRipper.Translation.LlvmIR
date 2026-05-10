using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class ispunct
{
	public unsafe static int Invoke(int c)
	{
		int ch = 0;
		llvm_lifetime_start_p0.Invoke(4L, &ch);
		ch = c;
		bool result = !internal_isalnum_int_225.Invoke(ch) && internal_isgraph_int.Invoke(ch);
		llvm_lifetime_end_p0.Invoke(4L, &ch);
		return result ? 1 : 0;
	}
}
