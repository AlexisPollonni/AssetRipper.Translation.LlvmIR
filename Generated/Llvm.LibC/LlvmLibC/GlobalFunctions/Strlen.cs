using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Strlen
{
	[MangledName("strlen")]
	[DemangledName("strlen")]
	public unsafe static long Invoke([MangledName("src")] void* Src)
	{
		return Internal_string_length_char.Invoke(Src);
	}
}
