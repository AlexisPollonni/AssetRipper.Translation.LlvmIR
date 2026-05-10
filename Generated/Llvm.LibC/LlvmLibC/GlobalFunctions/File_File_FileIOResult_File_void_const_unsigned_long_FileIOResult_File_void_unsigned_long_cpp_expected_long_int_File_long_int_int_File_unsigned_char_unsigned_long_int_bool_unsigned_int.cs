using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_4FileC2EPFNS_12FileIOResultEPS0_PKvmEPFS1_S2_PvmEPFNS_3cpp8expectedIliEES2_liEPFiS2_EPhmibj")]
[DemangledName("__llvm_libc_20_1_2_::File::File(__llvm_libc_20_1_2_::FileIOResult (*)(__llvm_libc_20_1_2_::File*, void const*, unsigned long), __llvm_libc_20_1_2_::FileIOResult (*)(__llvm_libc_20_1_2_::File*, void*, unsigned long), __llvm_libc_20_1_2_::cpp::expected<long, int> (*)(__llvm_libc_20_1_2_::File*, long, int), int (*)(__llvm_libc_20_1_2_::File*), unsigned char*, unsigned long, int, bool, unsigned int)")]
internal static partial class File_File_FileIOResult_File_void_const_unsigned_long_FileIOResult_File_void_unsigned_long_cpp_expected_long_int_File_long_int_int_File_unsigned_char_unsigned_long_int_bool_unsigned_int
{
	public unsafe static void Invoke(void* @this, void* wf, void* rf, void* sf, void* cf, void* buffer, long buffer_size, int buffer_mode, bool owned, int modeflags)
	{
		sbyte b = (owned ? ((sbyte)1) : ((sbyte)0));
		unchecked
		{
			((File_sjnxn4*)@this)->platform_write = wf;
			((File_sjnxn4*)@this)->platform_read = rf;
			((File_sjnxn4*)@this)->platform_seek = sf;
			((File_sjnxn4*)@this)->platform_close = cf;
			Mutex_Mutex_bool_bool_bool_bool.Invoke(&((File_sjnxn4*)@this)->mutex, is_timed: false, is_recursive: false, is_robust: false, is_pshared: false);
			((File_sjnxn4*)@this)->ungetc_buf = 0;
			((File_sjnxn4*)@this)->buf = buffer;
			((File_sjnxn4*)@this)->bufsize = buffer_size;
			((File_sjnxn4*)@this)->bufmode = buffer_mode;
			((File_sjnxn4*)@this)->own_buf = (((b & 1) == 1) ? ((sbyte)1) : ((sbyte)0));
			((File_sjnxn4*)@this)->mode = modeflags;
			((File_sjnxn4*)@this)->pos = 0L;
			((File_sjnxn4*)@this)->prev_op = 0;
			((File_sjnxn4*)@this)->read_limit = 0L;
			((File_sjnxn4*)@this)->eof = 0;
			((File_sjnxn4*)@this)->err = 0;
			File_adjust_buf.Invoke(@this);
		}
	}
}
