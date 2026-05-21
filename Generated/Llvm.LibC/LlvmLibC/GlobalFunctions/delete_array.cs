using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class delete_array
{
	[MangledName("__llvm_libc_20_1_2__delete_array")]
	[DemangledName("__llvm_libc_20_1_2__delete_array")]
	public unsafe static void Invoke(void* mem)
	{
		free.Invoke(mem);
	}
}
