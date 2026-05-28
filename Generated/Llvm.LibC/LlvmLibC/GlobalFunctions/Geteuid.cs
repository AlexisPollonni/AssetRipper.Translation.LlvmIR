using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Geteuid
{
	[MangledName("geteuid")]
	[DemangledName("geteuid")]
	public static int Invoke()
	{
		return Syscall_impl_unsigned_int.Invoke(107L);
	}
}
