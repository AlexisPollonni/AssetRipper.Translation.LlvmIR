using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class File_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_4FileC2EPFNS_12FileIOResultEPS0_PKvmEPFS1_S2_PvmEPFNS_3cpp8expectedIliEES2_liEPFiS2_EPhmibj")]
	[DemangledName("__llvm_libc_20_1_2_::File::File(__llvm_libc_20_1_2_::FileIOResult (*)(__llvm_libc_20_1_2_::File*, void const*, unsigned long), __llvm_libc_20_1_2_::FileIOResult (*)(__llvm_libc_20_1_2_::File*, void*, unsigned long), __llvm_libc_20_1_2_::cpp::expected<long, int> (*)(__llvm_libc_20_1_2_::File*, long, int), int (*)(__llvm_libc_20_1_2_::File*), unsigned char*, unsigned long, int, bool, unsigned int)")]
	public unsafe static void Invoke(File_sjnxn4* @this, [NativeType("__llvm_libc_20_1_2_::FileIOResult (*)(__llvm_libc_20_1_2_::File*, void const*, unsigned long)")] void* wf, [NativeType("__llvm_libc_20_1_2_::FileIOResult (*)(__llvm_libc_20_1_2_::File*, void*, unsigned long)")] void* rf, [NativeType("__llvm_libc_20_1_2_::cpp::expected<long, int> (*)(__llvm_libc_20_1_2_::File*, long, int)")] void* sf, [NativeType("int (*)(__llvm_libc_20_1_2_::File*)")] void* cf, [NativeType("unsigned char*")] void* buffer, [NativeType("unsigned long")] long buffer_size, [NativeType("int")] int buffer_mode, [NativeType("bool")] bool owned, [NativeType("unsigned int")] int modeflags)
	{
		sbyte b = (owned ? ((sbyte)1) : ((sbyte)0));
		@this->platform_write = wf;
		@this->platform_read = rf;
		@this->platform_seek = sf;
		@this->platform_close = cf;
		Mutex_Constructor.Invoke(&@this->mutex, is_timed: false, is_recursive: false, is_robust: false, is_pshared: false);
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
