using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("__llvm_libc_20_1_2__delete_aligned")]
[DemangledName("__llvm_libc_20_1_2__delete_aligned")]
internal static partial class delete_aligned
{
	public unsafe static void Invoke(void* mem, long parameter_1)
	{
		free.Invoke(mem);
	}
}
