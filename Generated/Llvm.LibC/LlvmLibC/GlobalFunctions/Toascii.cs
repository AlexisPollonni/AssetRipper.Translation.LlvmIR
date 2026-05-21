using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Toascii
{
	[MangledName("toascii")]
	[DemangledName("toascii")]
	public static int Invoke([MangledName("c")] int C)
	{
		return C & 0x7F;
	}
}
