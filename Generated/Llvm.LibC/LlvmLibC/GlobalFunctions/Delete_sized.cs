using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Delete_sized
{
	[MangledName("__llvm_libc_20_1_2__delete_sized")]
	[DemangledName("__llvm_libc_20_1_2__delete_sized")]
	public unsafe static void Invoke([MangledName("mem")] void* Mem, long parameter_1)
	{
		Free.Invoke(Mem);
	}
}
