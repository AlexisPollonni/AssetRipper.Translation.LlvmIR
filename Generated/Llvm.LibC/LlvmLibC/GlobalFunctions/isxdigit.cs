using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class isxdigit
{
	public unsafe static int Invoke(int c)
	{
		int ch = 0;
		llvm_lifetime_start_p0.Invoke(4L, &ch);
		ch = c;
		bool result = internal_isalnum_59ka7f.Invoke(ch) && internal_b36_char_to_int_whaa9c.Invoke(ch) < 16;
		llvm_lifetime_end_p0.Invoke(4L, &ch);
		return result ? 1 : 0;
	}
}
