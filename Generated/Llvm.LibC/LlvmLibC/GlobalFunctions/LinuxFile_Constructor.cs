using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class LinuxFile_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_9LinuxFileC2EiPhmibj")]
	[DemangledName("__llvm_libc_20_1_2_::LinuxFile::LinuxFile(int, unsigned char*, unsigned long, int, bool, unsigned int)")]
	public unsafe static void Invoke([MangledName("this")] Llvm_libc_20_1_2_LinuxFile* This, [MangledName("file_descriptor")][NativeType("int")] int File_descriptor, [MangledName("buffer")][NativeType("unsigned char*")] void* Buffer, [MangledName("buffer_size")][NativeType("unsigned long")] long Buffer_size, [MangledName("buffer_mode")][NativeType("int")] int Buffer_mode, [MangledName("owned")][NativeType("bool")] bool Owned, [MangledName("modeflags")][NativeType("unsigned int")] int Modeflags)
	{
		sbyte b = (Owned ? ((sbyte)1) : ((sbyte)0));
		File_Constructor.Invoke(unchecked((Llvm_libc_20_1_2_File_sjnxn4*)This), Llvm_libc_20_1_2_linux_file_write.__pointer, Llvm_libc_20_1_2_linux_file_read.__pointer, Llvm_libc_20_1_2_linux_file_seek.__pointer, Llvm_libc_20_1_2_linux_file_close.__pointer, Buffer, Buffer_size, Buffer_mode, (b & 1) == 1, Modeflags);
		This->Fd = File_descriptor;
	}
}
