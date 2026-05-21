using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fetestexcept
{
	[MangledName("fetestexcept")]
	[DemangledName("fetestexcept")]
	public static int Invoke([MangledName("e")] int E)
	{
		return Fputil_test_except.Invoke(E);
	}
}
