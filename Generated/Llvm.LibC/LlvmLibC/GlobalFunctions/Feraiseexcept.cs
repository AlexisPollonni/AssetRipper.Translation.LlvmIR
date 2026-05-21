using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Feraiseexcept
{
	[MangledName("feraiseexcept")]
	[DemangledName("feraiseexcept")]
	public static int Invoke([MangledName("e")] int E)
	{
		return Fputil_raise_except.Invoke(E);
	}
}
