namespace LlvmLibC.GlobalFunctions;

internal static partial class getpid
{
	public static int Invoke()
	{
		return syscall_impl_int.Invoke(39L);
	}
}
