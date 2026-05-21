using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fegetexcept
{
	[MangledName("fegetexcept")]
	[DemangledName("fegetexcept")]
	public static int Invoke()
	{
		return Fputil_get_except.Invoke();
	}
}
