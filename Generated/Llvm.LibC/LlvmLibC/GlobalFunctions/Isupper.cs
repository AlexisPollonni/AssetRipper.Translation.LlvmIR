using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Isupper
{
	[MangledName("isupper")]
	[DemangledName("isupper")]
	public static int Invoke([MangledName("c")] int C)
	{
		return Internal_isupper_99z59d.Invoke(C) ? 1 : 0;
	}
}
