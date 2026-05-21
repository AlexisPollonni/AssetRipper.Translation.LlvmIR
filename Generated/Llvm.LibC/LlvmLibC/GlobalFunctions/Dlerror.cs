using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Dlerror
{
	[MangledName("dlerror")]
	[DemangledName("dlerror")]
	public unsafe static void* Invoke()
	{
		return Str_220.Pointer;
	}
}
