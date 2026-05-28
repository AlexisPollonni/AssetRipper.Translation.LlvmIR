using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fileno
{
	[MangledName("fileno")]
	[DemangledName("fileno")]
	public unsafe static int Invoke([MangledName("stream")] void* Stream)
	{
		return Get_fileno.Invoke(unchecked((File_sjnxn4*)Stream));
	}
}
