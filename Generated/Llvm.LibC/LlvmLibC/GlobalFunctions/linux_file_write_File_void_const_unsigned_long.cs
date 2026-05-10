using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_16linux_file_writeEPNS_4FileEPKvm")]
[DemangledName("__llvm_libc_20_1_2_::linux_file_write(__llvm_libc_20_1_2_::File*, void const*, unsigned long)")]
internal static partial class linux_file_write_File_void_const_unsigned_long
{
	public unsafe static readonly void* __pointer = PointerIndices.Register((delegate*<void*, void*, long, Struct_3driym>)(&Invoke));

	public unsafe static Struct_3driym Invoke(void* f, void* data, long size)
	{
		FileIOResult fileIOResult = default(FileIOResult);
		void* ptr = null;
		int num = 0;
		llvm_lifetime_start_p0.Invoke(8L, &ptr);
		ptr = f;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = int_syscall_impl_int_int_void_const_unsigned_long_long_int_void_const_unsigned_long.Invoke(1L, LinuxFile_get_fd_const.Invoke(ptr), data, size);
		if (num < 0)
		{
			FileIOResult_FileIOResult_unsigned_long_int.Invoke(&fileIOResult, 0L, -num);
		}
		else
		{
			FileIOResult_FileIOResult_unsigned_long.Invoke(&fileIOResult, num);
		}
		llvm_lifetime_end_p0.Invoke(4L, &num);
		llvm_lifetime_end_p0.Invoke(8L, &ptr);
		return *unchecked((Struct_3driym*)(&fileIOResult));
	}
}
