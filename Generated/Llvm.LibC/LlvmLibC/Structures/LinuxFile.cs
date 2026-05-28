using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 128)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_9LinuxFileE")]
[MangledName("class.__llvm_libc_20_1_2_::LinuxFile")]
[DemangledName("__llvm_libc_20_1_2_::LinuxFile")]
public partial struct LinuxFile
{
	[FieldOffset(0)]
	public File_nubcdg File;

	[FieldOffset(124)]
	public int Fd;
}
