using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fileno
{
	[MangledName("fileno")]
	[DemangledName("fileno")]
	public unsafe static int Invoke([MangledName("stream")] void* Stream)
	{
		return Llvm_libc_20_1_2_get_fileno.Invoke(unchecked((Llvm_libc_20_1_2_File_sjnxn4*)Stream));
	}
}
