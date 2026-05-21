using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Memchr
{
	[MangledName("memchr")]
	[DemangledName("memchr")]
	public unsafe static void* Invoke([MangledName("src")] void* Src, [MangledName("c")] int C, [MangledName("n")] long N)
	{
		return Internal_find_first_character.Invoke(Src, unchecked((sbyte)C), N);
	}
}
