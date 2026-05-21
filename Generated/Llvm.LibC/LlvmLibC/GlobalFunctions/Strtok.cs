using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Strtok
{
	[MangledName("strtok")]
	[DemangledName("strtok")]
	public unsafe static void* Invoke([MangledName("src")] void* Src, [MangledName("delimiter_string")] void* Delimiter_string)
	{
		return Internal_string_token_true.Invoke(Src, Delimiter_string, Llvm_libc_20_1_2_strtok_str.Pointer);
	}
}
