namespace LlvmLibC.GlobalFunctions;

internal static partial class fesetenv
{
	public unsafe static int Invoke(void* envp)
	{
		return fputil_set_env_fenv_t_const.Invoke(envp);
	}
}
