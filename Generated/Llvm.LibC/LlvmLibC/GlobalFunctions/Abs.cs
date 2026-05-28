using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Abs
{
	[MangledName("abs")]
	[DemangledName("abs")]
	public static int Invoke([MangledName("n")] int N)
	{
		return Integer_abs_int.Invoke(N);
	}
}
