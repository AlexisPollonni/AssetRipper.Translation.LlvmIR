using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_9LinuxFile6get_fdEv")]
[DemangledName("__llvm_libc_20_1_2_::LinuxFile::get_fd() const")]
internal static partial class LinuxFile_get_fd_const
{
	public unsafe static int Invoke(void* @this)
	{
		return unchecked((LinuxFile*)@this)->fd;
	}
}
