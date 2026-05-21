using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class linux_file_read
{
	public unsafe static readonly void* __pointer = PointerIndices.Register((delegate*<File_sjnxn4*, void*, long, Struct_3driym>)(&Invoke));

	[MangledName("_ZN19__llvm_libc_20_1_2_15linux_file_readEPNS_4FileEPvm")]
	[DemangledName("__llvm_libc_20_1_2_::linux_file_read(__llvm_libc_20_1_2_::File*, void*, unsigned long)")]
	public unsafe static Struct_3driym Invoke([NativeType("__llvm_libc_20_1_2_::File*")] File_sjnxn4* f, [NativeType("void*")] void* buf, [NativeType("unsigned long")] long size)
	{
		FileIOResult fileIOResult = default(FileIOResult);
		void* ptr = null;
		int num = 0;
		llvm_lifetime_start_p0.Invoke(8L, &ptr);
		ptr = f;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = syscall_impl_int_int_void_unsigned_long.Invoke(0L, LinuxFile_get_fd.Invoke(unchecked((LinuxFile*)ptr)), buf, size);
		if (num < 0)
		{
			FileIOResult_Constructor.Invoke(&fileIOResult, 0L, -num);
		}
		else
		{
			FileIOResult_Constructor.Invoke(&fileIOResult, num);
		}
		llvm_lifetime_end_p0.Invoke(4L, &num);
		llvm_lifetime_end_p0.Invoke(8L, &ptr);
		return *unchecked((Struct_3driym*)(&fileIOResult));
	}
}
