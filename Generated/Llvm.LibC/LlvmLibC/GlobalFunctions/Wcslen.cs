using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Wcslen
{
	[MangledName("wcslen")]
	[DemangledName("wcslen")]
	public unsafe static long Invoke([MangledName("src")] void* Src)
	{
		return Internal_string_length_wchar_t.Invoke(Src);
	}
}
