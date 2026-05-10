using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("__llvm_libc_20_1_2__delete")]
[DemangledName("__llvm_libc_20_1_2__delete")]
internal static partial class delete
{
	public unsafe static void Invoke(void* mem)
	{
		free.Invoke(mem);
	}
}
