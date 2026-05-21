using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Tolower
{
	[MangledName("tolower")]
	[DemangledName("tolower")]
	public static int Invoke([MangledName("c")] int C)
	{
		return Internal_tolower_wkrigs.Invoke(C);
	}
}
