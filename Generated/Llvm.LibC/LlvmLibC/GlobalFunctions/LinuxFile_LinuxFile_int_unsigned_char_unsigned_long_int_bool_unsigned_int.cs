using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_9LinuxFileC2EiPhmibj")]
[DemangledName("__llvm_libc_20_1_2_::LinuxFile::LinuxFile(int, unsigned char*, unsigned long, int, bool, unsigned int)")]
internal static partial class LinuxFile_LinuxFile_int_unsigned_char_unsigned_long_int_bool_unsigned_int
{
	public unsafe static void Invoke(LinuxFile* @this, int file_descriptor, void* buffer, long buffer_size, int buffer_mode, bool owned, int modeflags)
	{
		sbyte b = (owned ? ((sbyte)1) : ((sbyte)0));
		File_File_FileIOResult_File_void_const_unsigned_long_FileIOResult_File_void_unsigned_long_cpp_expected_long_int_File_long_int_int_File_unsigned_char_unsigned_long_int_bool_unsigned_int.Invoke(unchecked((File_sjnxn4*)@this), linux_file_write_File_void_const_unsigned_long.__pointer, linux_file_read_File_void_unsigned_long.__pointer, linux_file_seek_File_long_int.__pointer, linux_file_close_File.__pointer, buffer, buffer_size, buffer_mode, (b & 1) == 1, modeflags);
		@this->fd = file_descriptor;
	}
}
