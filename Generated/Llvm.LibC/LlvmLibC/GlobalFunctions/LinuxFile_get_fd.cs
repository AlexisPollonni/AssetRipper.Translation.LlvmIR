using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class LinuxFile_get_fd
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_9LinuxFile6get_fdEv")]
	[DemangledName("__llvm_libc_20_1_2_::LinuxFile::get_fd() const")]
	public unsafe static int Invoke([MangledName("this")] LinuxFile* This)
	{
		return This->Fd;
	}
}
