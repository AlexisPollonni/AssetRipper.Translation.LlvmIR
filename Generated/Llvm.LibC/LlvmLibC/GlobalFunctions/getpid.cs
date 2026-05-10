namespace LlvmLibC.GlobalFunctions;

internal static partial class getpid
{
	public static int Invoke()
	{
		return int_syscall_impl_int_long.Invoke(39L);
	}
}
