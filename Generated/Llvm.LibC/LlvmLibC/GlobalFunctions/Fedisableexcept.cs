using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fedisableexcept
{
	[MangledName("fedisableexcept")]
	[DemangledName("fedisableexcept")]
	public static int Invoke([MangledName("e")] int E)
	{
		return Fputil_disable_except.Invoke(E);
	}
}
