using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Index
{
	[MangledName("index")]
	[DemangledName("index")]
	public unsafe static void* Invoke([MangledName("src")] void* Src, [MangledName("c")] int C)
	{
		return Internal_strchr_implementation_true_d3u7r6.Invoke(Src, C);
	}
}
