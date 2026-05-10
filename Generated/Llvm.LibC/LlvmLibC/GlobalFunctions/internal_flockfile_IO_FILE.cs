using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Unimplemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal9flockfileEP8_IO_FILE")]
[DemangledName("__llvm_libc_20_1_2_::internal::flockfile(_IO_FILE*)")]
internal static partial class internal_flockfile_IO_FILE
{
	public unsafe static void Invoke(void* f)
	{
		flockfile.Invoke(f);
	}
}
