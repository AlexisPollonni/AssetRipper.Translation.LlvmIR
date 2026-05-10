namespace LlvmLibC.GlobalFunctions;

internal static partial class getuid
{
	public static int Invoke()
	{
		return unsigned_int_syscall_impl_unsigned_int_long.Invoke(102L);
	}
}
