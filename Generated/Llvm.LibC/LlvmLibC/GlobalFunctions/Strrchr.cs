using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Strrchr
{
	[MangledName("strrchr")]
	[DemangledName("strrchr")]
	public unsafe static void* Invoke([MangledName("src")] void* Src, [MangledName("c")] int C)
	{
		return Internal_strrchr_implementation_743nz4.Invoke(Src, C);
	}
}
