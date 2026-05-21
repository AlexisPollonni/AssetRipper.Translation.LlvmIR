using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Strchrnul
{
	[MangledName("strchrnul")]
	[DemangledName("strchrnul")]
	public unsafe static void* Invoke([MangledName("src")] void* Src, [MangledName("c")] int C)
	{
		return Internal_strchr_implementation_false.Invoke(Src, C);
	}
}
