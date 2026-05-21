using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Isdigit
{
	[MangledName("isdigit")]
	[DemangledName("isdigit")]
	public static int Invoke([MangledName("c")] int C)
	{
		return Internal_isdigit_xdnave.Invoke(C) ? 1 : 0;
	}
}
