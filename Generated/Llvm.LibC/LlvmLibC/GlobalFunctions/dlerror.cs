using LlvmLibC.GlobalVariables;

namespace LlvmLibC.GlobalFunctions;

internal static partial class dlerror
{
	public unsafe static void* Invoke()
	{
		return str_218.Pointer;
	}
}
