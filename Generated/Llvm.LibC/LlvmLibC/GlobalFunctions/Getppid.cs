using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Getppid
{
	[MangledName("getppid")]
	[DemangledName("getppid")]
	public static int Invoke()
	{
		return Syscall_impl_int.Invoke(110L);
	}
}
