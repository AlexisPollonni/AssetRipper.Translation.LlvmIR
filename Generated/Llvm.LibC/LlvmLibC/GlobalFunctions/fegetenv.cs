namespace LlvmLibC.GlobalFunctions;

internal static partial class fegetenv
{
	public unsafe static int Invoke(void* envp)
	{
		return fputil_get_env_fenv_t.Invoke(envp);
	}
}
