using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Rindex
{
	[MangledName("rindex")]
	[DemangledName("rindex")]
	public unsafe static void* Invoke([MangledName("src")] void* Src, [MangledName("c")] int C)
	{
		return Internal_strrchr_implementation_vj8pat.Invoke(Src, C);
	}
}
