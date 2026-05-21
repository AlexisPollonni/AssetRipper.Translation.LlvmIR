namespace LlvmLibC.GlobalFunctions;

internal static partial class getppid
{
	public static int Invoke()
	{
		return syscall_impl_int.Invoke(110L);
	}
}
