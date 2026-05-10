using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("__llvm_libc_20_1_2__delete_array_sized_aligned")]
[DemangledName("__llvm_libc_20_1_2__delete_array_sized_aligned")]
internal static partial class delete_array_sized_aligned
{
	public unsafe static void Invoke(void* mem, long parameter_1, long parameter_2)
	{
		free.Invoke(mem);
	}
}
