using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Isalnum
{
	[MangledName("isalnum")]
	[DemangledName("isalnum")]
	public static int Invoke([MangledName("c")] int C)
	{
		return Internal_isalnum_bxmyzh.Invoke(C) ? 1 : 0;
	}
}
