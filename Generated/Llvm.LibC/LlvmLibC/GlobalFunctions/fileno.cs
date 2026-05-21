using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fileno
{
	public unsafe static int Invoke(void* stream)
	{
		return Get_fileno.Invoke(unchecked((File_sjnxn4*)stream));
	}
}
