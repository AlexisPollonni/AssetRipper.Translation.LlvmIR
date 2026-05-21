using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Isspace
{
	[MangledName("isspace")]
	[DemangledName("isspace")]
	public static int Invoke([MangledName("c")] int C)
	{
		return Internal_isspace_gyrrf5.Invoke(C) ? 1 : 0;
	}
}
