using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class feupdateenv
{
	public unsafe static int Invoke(void* envp)
	{
		int excepts = 0;
		llvm_lifetime_start_p0.Invoke(4L, &excepts);
		excepts = fputil_test_except_int.Invoke(61);
		int result = ((fputil_set_env_fenv_t_const.Invoke(envp) == 0) ? fputil_raise_except_int.Invoke(excepts) : (-1));
		llvm_lifetime_end_p0.Invoke(4L, &excepts);
		return result;
	}
}
