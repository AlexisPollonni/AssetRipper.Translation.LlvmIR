namespace LlvmLibC.GlobalFunctions;

internal static partial class geteuid
{
	public static int Invoke()
	{
		return unsigned_int_syscall_impl_unsigned_int_long.Invoke(107L);
	}
}
