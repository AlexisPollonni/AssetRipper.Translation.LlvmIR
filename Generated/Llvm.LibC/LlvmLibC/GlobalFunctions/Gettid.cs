using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Gettid
{
	[MangledName("gettid")]
	[DemangledName("gettid")]
	public static int Invoke()
	{
		return Internal_gettid.Invoke();
	}
}
