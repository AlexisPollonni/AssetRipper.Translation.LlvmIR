using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Strtok_r
{
	[MangledName("strtok_r")]
	[DemangledName("strtok_r")]
	public unsafe static void* Invoke([MangledName("src")] void* Src, [MangledName("delimiter_string")] void* Delimiter_string, [MangledName("saveptr")] void* Saveptr)
	{
		return Internal_string_token_true.Invoke(Src, Delimiter_string, Saveptr);
	}
}
