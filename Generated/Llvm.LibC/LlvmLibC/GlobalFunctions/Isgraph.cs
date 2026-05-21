using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Isgraph
{
	[MangledName("isgraph")]
	[DemangledName("isgraph")]
	public static int Invoke([MangledName("c")] int C)
	{
		return Internal_isgraph_mybz3v.Invoke(C) ? 1 : 0;
	}
}
