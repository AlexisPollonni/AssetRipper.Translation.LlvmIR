using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_16linux_file_closeEPNS_4FileE")]
[DemangledName("__llvm_libc_20_1_2_::linux_file_close(__llvm_libc_20_1_2_::File*)")]
internal static partial class linux_file_close_File
{
	public unsafe static readonly void* __pointer = PointerIndices.Register((delegate*<File_sjnxn4*, int>)(&Invoke));

	public unsafe static int Invoke(File_sjnxn4* f)
	{
		void* ptr = null;
		int num = 0;
		llvm_lifetime_start_p0.Invoke(8L, &ptr);
		ptr = f;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = int_syscall_impl_int_int_long_int.Invoke(3L, LinuxFile_get_fd_const.Invoke(unchecked((LinuxFile*)ptr)));
		int result;
		if (num < 0)
		{
			result = -num;
		}
		else
		{
			void* ptr2 = ptr;
			if (ptr2 != null)
			{
				delete_sized.Invoke(ptr2, 128L);
			}
			result = 0;
		}
		llvm_lifetime_end_p0.Invoke(4L, &num);
		llvm_lifetime_end_p0.Invoke(8L, &ptr);
		return result;
	}
}
