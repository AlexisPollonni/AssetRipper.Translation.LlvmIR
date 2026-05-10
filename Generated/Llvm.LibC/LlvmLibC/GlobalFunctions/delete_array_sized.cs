using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("__llvm_libc_20_1_2__delete_array_sized")]
[DemangledName("__llvm_libc_20_1_2__delete_array_sized")]
internal static partial class delete_array_sized
{
	public unsafe static void Invoke(void* mem, long parameter_1)
	{
		free.Invoke(mem);
	}
}
