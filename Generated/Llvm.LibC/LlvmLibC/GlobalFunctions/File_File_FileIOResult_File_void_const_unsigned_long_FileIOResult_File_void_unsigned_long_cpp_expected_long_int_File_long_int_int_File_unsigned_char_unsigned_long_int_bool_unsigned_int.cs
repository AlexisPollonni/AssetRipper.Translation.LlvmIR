using LlvmLibC.Enumerations;
using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_4FileC2EPFNS_12FileIOResultEPS0_PKvmEPFS1_S2_PvmEPFNS_3cpp8expectedIliEES2_liEPFiS2_EPhmibj")]
[DemangledName("__llvm_libc_20_1_2_::File::File(__llvm_libc_20_1_2_::FileIOResult (*)(__llvm_libc_20_1_2_::File*, void const*, unsigned long), __llvm_libc_20_1_2_::FileIOResult (*)(__llvm_libc_20_1_2_::File*, void*, unsigned long), __llvm_libc_20_1_2_::cpp::expected<long, int> (*)(__llvm_libc_20_1_2_::File*, long, int), int (*)(__llvm_libc_20_1_2_::File*), unsigned char*, unsigned long, int, bool, unsigned int)")]
internal static partial class File_File_FileIOResult_File_void_const_unsigned_long_FileIOResult_File_void_unsigned_long_cpp_expected_long_int_File_long_int_int_File_unsigned_char_unsigned_long_int_bool_unsigned_int
{
	public unsafe static void Invoke(File_sjnxn4* @this, void* wf, void* rf, void* sf, void* cf, void* buffer, long buffer_size, int buffer_mode, bool owned, int modeflags)
	{
		sbyte b = (owned ? ((sbyte)1) : ((sbyte)0));
		@this->platform_write = wf;
		@this->platform_read = rf;
		@this->platform_seek = sf;
		@this->platform_close = cf;
		Mutex_Mutex_bool_bool_bool_bool.Invoke(&@this->mutex, is_timed: false, is_recursive: false, is_robust: false, is_pshared: false);
		@this->ungetc_buf = 0;
		@this->buf = buffer;
		@this->bufsize = buffer_size;
		@this->bufmode = buffer_mode;
		@this->own_buf = (((b & 1) == 1) ? ((sbyte)1) : ((sbyte)0));
		@this->mode = modeflags;
		@this->pos = 0L;
		@this->prev_op = FileOp.NONE;
		@this->read_limit = 0L;
		@this->eof = 0;
		@this->err = 0;
		File_adjust_buf.Invoke(@this);
	}
}
