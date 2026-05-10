using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fesetexceptflag
{
	public unsafe static int Invoke(void* flagp, int excepts)
	{
		int excepts2 = 0;
		llvm_lifetime_start_p0.Invoke(4L, &excepts2);
		excepts2 = unchecked((ushort)(*(short*)flagp)) & excepts;
		fputil_clear_except_int.Invoke(61);
		int result = fputil_set_except_int.Invoke(excepts2);
		llvm_lifetime_end_p0.Invoke(4L, &excepts2);
		return result;
	}
}
