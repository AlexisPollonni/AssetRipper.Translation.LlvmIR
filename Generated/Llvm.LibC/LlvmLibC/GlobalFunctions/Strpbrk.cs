using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Strpbrk
{
	[MangledName("strpbrk")]
	[DemangledName("strpbrk")]
	public unsafe static void* Invoke([MangledName("src")] void* Src, [MangledName("breakset")] void* Breakset)
	{
		void* ptr = Src;
		unchecked
		{
			ptr = (byte*)ptr + Internal_complementary_span.Invoke(ptr, Breakset);
			return (*(sbyte*)ptr == 0) ? null : ptr;
		}
	}
}
