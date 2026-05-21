using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Toupper
{
	[MangledName("toupper")]
	[DemangledName("toupper")]
	public static int Invoke([MangledName("c")] int C)
	{
		return Internal_toupper_i3vw5p.Invoke(C);
	}
}
