using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class isprint
{
	public unsafe static int Invoke(int c)
	{
		int num = 0;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = c;
		bool result = unchecked((uint)(num - 32)) < 95u;
		llvm_lifetime_end_p0.Invoke(4L, &num);
		return result ? 1 : 0;
	}
}
