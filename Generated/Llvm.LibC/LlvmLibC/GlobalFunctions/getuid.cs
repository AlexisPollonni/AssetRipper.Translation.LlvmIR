namespace LlvmLibC.GlobalFunctions;

internal static partial class getuid
{
	public static int Invoke()
	{
		return syscall_impl_unsigned_int.Invoke(102L);
	}
}
