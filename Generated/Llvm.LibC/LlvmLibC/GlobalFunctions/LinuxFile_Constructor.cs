using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class LinuxFile_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_9LinuxFileC2EiPhmibj")]
	[DemangledName("__llvm_libc_20_1_2_::LinuxFile::LinuxFile(int, unsigned char*, unsigned long, int, bool, unsigned int)")]
	public unsafe static void Invoke(LinuxFile* @this, [NativeType("int")] int file_descriptor, [NativeType("unsigned char*")] void* buffer, [NativeType("unsigned long")] long buffer_size, [NativeType("int")] int buffer_mode, [NativeType("bool")] bool owned, [NativeType("unsigned int")] int modeflags)
	{
		sbyte b = (owned ? ((sbyte)1) : ((sbyte)0));
		File_Constructor.Invoke(unchecked((File_sjnxn4*)@this), linux_file_write.__pointer, linux_file_read.__pointer, linux_file_seek.__pointer, linux_file_close.__pointer, buffer, buffer_size, buffer_mode, (b & 1) == 1, modeflags);
		@this->fd = file_descriptor;
	}
}
