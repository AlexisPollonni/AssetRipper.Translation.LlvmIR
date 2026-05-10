namespace LlvmLibC.GlobalFunctions;

internal static partial class fetestexceptflag
{
	public unsafe static int Invoke(void* flagp, int excepts)
	{
		return unchecked((ushort)(*(short*)flagp)) | fputil_test_except_int.Invoke(excepts);
	}
}
