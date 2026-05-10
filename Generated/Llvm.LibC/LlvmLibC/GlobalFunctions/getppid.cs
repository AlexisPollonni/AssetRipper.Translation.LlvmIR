namespace LlvmLibC.GlobalFunctions;

internal static partial class getppid
{
	public static int Invoke()
	{
		return int_syscall_impl_int_long.Invoke(110L);
	}
}
