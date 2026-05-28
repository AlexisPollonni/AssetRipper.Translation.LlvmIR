using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Getuid
{
	[MangledName("getuid")]
	[DemangledName("getuid")]
	public static int Invoke()
	{
		return Syscall_impl_unsigned_int.Invoke(102L);
	}
}
