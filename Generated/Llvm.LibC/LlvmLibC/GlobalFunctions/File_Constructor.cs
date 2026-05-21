using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class File_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_4FileC2EPFNS_12FileIOResultEPS0_PKvmEPFS1_S2_PvmEPFNS_3cpp8expectedIliEES2_liEPFiS2_EPhmibj")]
	[DemangledName("__llvm_libc_20_1_2_::File::File(__llvm_libc_20_1_2_::FileIOResult (*)(__llvm_libc_20_1_2_::File*, void const*, unsigned long), __llvm_libc_20_1_2_::FileIOResult (*)(__llvm_libc_20_1_2_::File*, void*, unsigned long), __llvm_libc_20_1_2_::cpp::expected<long, int> (*)(__llvm_libc_20_1_2_::File*, long, int), int (*)(__llvm_libc_20_1_2_::File*), unsigned char*, unsigned long, int, bool, unsigned int)")]
	public unsafe static void Invoke([MangledName("this")] Llvm_libc_20_1_2_File_sjnxn4* This, [MangledName("wf")][NativeType("__llvm_libc_20_1_2_::FileIOResult (*)(__llvm_libc_20_1_2_::File*, void const*, unsigned long)")] void* Wf, [MangledName("rf")][NativeType("__llvm_libc_20_1_2_::FileIOResult (*)(__llvm_libc_20_1_2_::File*, void*, unsigned long)")] void* Rf, [MangledName("sf")][NativeType("__llvm_libc_20_1_2_::cpp::expected<long, int> (*)(__llvm_libc_20_1_2_::File*, long, int)")] void* Sf, [MangledName("cf")][NativeType("int (*)(__llvm_libc_20_1_2_::File*)")] void* Cf, [MangledName("buffer")][NativeType("unsigned char*")] void* Buffer, [MangledName("buffer_size")][NativeType("unsigned long")] long Buffer_size, [MangledName("buffer_mode")][NativeType("int")] int Buffer_mode, [MangledName("owned")][NativeType("bool")] bool Owned, [MangledName("modeflags")][NativeType("unsigned int")] int Modeflags)
	{
		sbyte b = (Owned ? ((sbyte)1) : ((sbyte)0));
		This->Platform_write = Wf;
		This->Platform_read = Rf;
		This->Platform_seek = Sf;
		This->Platform_close = Cf;
		Mutex_Constructor.Invoke(&This->Mutex, Is_timed: false, Is_recursive: false, Is_robust: false, Is_pshared: false);
		This->Ungetc_buf = 0;
		This->Buf = Buffer;
		This->Bufsize = Buffer_size;
		This->Bufmode = Buffer_mode;
		This->Own_buf = (((b & 1) == 1) ? ((sbyte)1) : ((sbyte)0));
		This->Mode = Modeflags;
		This->Pos = 0L;
		This->Prev_op = FileOp.NONE;
		This->Read_limit = 0L;
		This->Eof = 0;
		This->Err = 0;
		File_adjust_buf.Invoke(This);
	}
}
