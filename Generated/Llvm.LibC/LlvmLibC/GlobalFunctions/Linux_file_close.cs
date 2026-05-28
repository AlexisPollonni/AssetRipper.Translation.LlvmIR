using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Linux_file_close
{
	public unsafe static readonly void* __pointer = (delegate*<File_sjnxn4*, int>)(&Invoke);

	[MangledName("_ZN19__llvm_libc_20_1_2_16linux_file_closeEPNS_4FileE")]
	[DemangledName("__llvm_libc_20_1_2_::linux_file_close(__llvm_libc_20_1_2_::File*)")]
	public unsafe static int Invoke([MangledName("f")][NativeType("__llvm_libc_20_1_2_::File*")] File_sjnxn4* F)
	{
		void* ptr = null;
		int num = 0;
		Llvm_lifetime_start_p0.Invoke(8L, &ptr);
		ptr = F;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = Syscall_impl_int_int.Invoke(3L, LinuxFile_get_fd.Invoke(unchecked((LinuxFile*)ptr)));
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
				Delete_sized.Invoke(ptr2, 128L);
			}
			result = 0;
		}
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		Llvm_lifetime_end_p0.Invoke(8L, &ptr);
		return result;
	}
}
