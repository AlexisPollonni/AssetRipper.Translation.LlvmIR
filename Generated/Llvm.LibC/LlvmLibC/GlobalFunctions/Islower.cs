using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Islower
{
	[MangledName("islower")]
	[DemangledName("islower")]
	public static int Invoke([MangledName("c")] int C)
	{
		return Internal_islower_6njmbn.Invoke(C) ? 1 : 0;
	}
}
