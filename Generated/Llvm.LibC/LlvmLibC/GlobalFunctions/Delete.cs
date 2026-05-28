using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Delete
{
	[MangledName("__llvm_libc_20_1_2__delete")]
	[DemangledName("__llvm_libc_20_1_2__delete")]
	public unsafe static void Invoke([MangledName("mem")] void* Mem)
	{
		Free.Invoke(Mem);
	}
}
