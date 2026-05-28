using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Getpid
{
	[MangledName("getpid")]
	[DemangledName("getpid")]
	public static int Invoke()
	{
		return Syscall_impl_int.Invoke(39L);
	}
}
