using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Linux_file_read
{
	public unsafe static readonly void* __pointer = (delegate*<File_sjnxn4*, void*, long, Struct_3driym>)(&Invoke);

	[MangledName("_ZN19__llvm_libc_20_1_2_15linux_file_readEPNS_4FileEPvm")]
	[DemangledName("__llvm_libc_20_1_2_::linux_file_read(__llvm_libc_20_1_2_::File*, void*, unsigned long)")]
	public unsafe static Struct_3driym Invoke([MangledName("f")][NativeType("__llvm_libc_20_1_2_::File*")] File_sjnxn4* F, [MangledName("buf")][NativeType("void*")] void* Buf, [MangledName("size")][NativeType("unsigned long")] long Size)
	{
		FileIOResult fileIOResult = default(FileIOResult);
		void* ptr = null;
		int num = 0;
		Llvm_lifetime_start_p0.Invoke(8L, &ptr);
		ptr = F;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = Syscall_impl_int_int_void_unsigned_long.Invoke(0L, LinuxFile_get_fd.Invoke(unchecked((LinuxFile*)ptr)), Buf, Size);
		if (num < 0)
		{
			FileIOResult_Constructor.Invoke(&fileIOResult, 0L, -num);
		}
		else
		{
			FileIOResult_Constructor.Invoke(&fileIOResult, num);
		}
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		Llvm_lifetime_end_p0.Invoke(8L, &ptr);
		return *unchecked((Struct_3driym*)(&fileIOResult));
	}
}
