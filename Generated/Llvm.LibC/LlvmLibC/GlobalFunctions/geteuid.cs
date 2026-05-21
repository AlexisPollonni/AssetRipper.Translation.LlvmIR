namespace LlvmLibC.GlobalFunctions;

internal static partial class geteuid
{
	public static int Invoke()
	{
		return syscall_impl_unsigned_int.Invoke(107L);
	}
}
