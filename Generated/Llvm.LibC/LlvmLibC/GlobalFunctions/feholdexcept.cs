namespace LlvmLibC.GlobalFunctions;

internal static partial class feholdexcept
{
	public unsafe static int Invoke(void* envp)
	{
		if (fputil_get_env.Invoke(envp) != 0)
		{
			return -1;
		}
		fputil_clear_except.Invoke(61);
		fputil_disable_except.Invoke(61);
		return 0;
	}
}
