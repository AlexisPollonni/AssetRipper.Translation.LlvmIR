using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Isalpha
{
	[MangledName("isalpha")]
	[DemangledName("isalpha")]
	public static int Invoke([MangledName("c")] int C)
	{
		return Internal_isalpha.Invoke(C) ? 1 : 0;
	}
}
