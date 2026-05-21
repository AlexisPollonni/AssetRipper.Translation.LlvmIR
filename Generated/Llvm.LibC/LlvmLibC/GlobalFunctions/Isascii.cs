using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Isascii
{
	[MangledName("isascii")]
	[DemangledName("isascii")]
	public static int Invoke([MangledName("c")] int C)
	{
		return ((C & -128) == 0) ? 1 : 0;
	}
}
