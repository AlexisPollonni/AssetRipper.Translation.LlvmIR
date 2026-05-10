using System.Runtime.InteropServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 128)]
[MangledName("class.__llvm_libc_20_1_2_::LinuxFile")]
[DemangledName("__llvm_libc_20_1_2_::LinuxFile")]
public partial struct LinuxFile
{
	[FieldOffset(0)]
	public File_nubcdg File;

	[FieldOffset(124)]
	public int fd;
}
