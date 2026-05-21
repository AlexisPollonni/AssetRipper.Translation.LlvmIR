using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llvm_libc_20_1_2_linux_file_write
{
	public unsafe static readonly void* __pointer = PointerIndices.Register((delegate*<Llvm_libc_20_1_2_File_sjnxn4*, void*, long, Struct_3driym>)(&Invoke));

	[MangledName("_ZN19__llvm_libc_20_1_2_16linux_file_writeEPNS_4FileEPKvm")]
	[DemangledName("__llvm_libc_20_1_2_::linux_file_write(__llvm_libc_20_1_2_::File*, void const*, unsigned long)")]
	public unsafe static Struct_3driym Invoke([MangledName("f")][NativeType("__llvm_libc_20_1_2_::File*")] Llvm_libc_20_1_2_File_sjnxn4* F, [MangledName("data")][NativeType("void const*")] void* Data, [MangledName("size")][NativeType("unsigned long")] long Size)
	{
		Llvm_libc_20_1_2_FileIOResult llvm_libc_20_1_2_FileIOResult = default(Llvm_libc_20_1_2_FileIOResult);
		void* ptr = null;
		int num = 0;
		Llvm_lifetime_start_p0.Invoke(8L, &ptr);
		ptr = F;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = Llvm_libc_20_1_2_syscall_impl_int_int_void_const_unsigned_long.Invoke(1L, LinuxFile_get_fd.Invoke(unchecked((Llvm_libc_20_1_2_LinuxFile*)ptr)), Data, Size);
		if (num < 0)
		{
			FileIOResult_Constructor.Invoke(&llvm_libc_20_1_2_FileIOResult, 0L, -num);
		}
		else
		{
			FileIOResult_Constructor.Invoke(&llvm_libc_20_1_2_FileIOResult, num);
		}
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		Llvm_lifetime_end_p0.Invoke(8L, &ptr);
		return *unchecked((Struct_3driym*)(&llvm_libc_20_1_2_FileIOResult));
	}
}
