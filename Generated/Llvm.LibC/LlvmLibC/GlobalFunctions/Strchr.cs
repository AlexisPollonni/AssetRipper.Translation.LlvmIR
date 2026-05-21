using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Strchr
{
	[MangledName("strchr")]
	[DemangledName("strchr")]
	public unsafe static void* Invoke([MangledName("src")] void* Src, [MangledName("c")] int C)
	{
		return Internal_strchr_implementation_true_82huui.Invoke(Src, C);
	}
}
