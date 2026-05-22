using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Isblank
{
	[MangledName("isblank")]
	[DemangledName("isblank")]
	public static int Invoke([MangledName("c")] int C)
	{
		return (C == 32 || C == 9) ? 1 : 0;
	}
}
