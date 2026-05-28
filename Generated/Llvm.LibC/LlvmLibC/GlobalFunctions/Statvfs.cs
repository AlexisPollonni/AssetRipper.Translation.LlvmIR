using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Statvfs
{
	[MangledName("statvfs")]
	[DemangledName("statvfs")]
	public unsafe static int Invoke([MangledName("path")] void* Path, [MangledName("buf")] global::LlvmLibC.Structures.Statvfs* Buf)
	{
		Llvm_libc_20_1_2_cpp_optional_qbe95b llvm_libc_20_1_2_cpp_optional_qbe95b = default(Llvm_libc_20_1_2_cpp_optional_qbe95b);
		global::LlvmLibC.Structures.Statvfs statvfs = default(global::LlvmLibC.Structures.Statvfs);
		Llvm_lifetime_start_p0.Invoke(128L, &llvm_libc_20_1_2_cpp_optional_qbe95b);
		Llvm_memset_p0_i64.Invoke(&llvm_libc_20_1_2_cpp_optional_qbe95b, -86, 128L, isVolatile: false);
		Statfs_utils_linux_statfs.Invoke(&llvm_libc_20_1_2_cpp_optional_qbe95b, Path);
		if (Optional_statfs_ToBoolean.Invoke(&llvm_libc_20_1_2_cpp_optional_qbe95b))
		{
			Llvm_lifetime_start_p0.Invoke(88L, &statvfs);
			Statfs_utils_statfs_to_statvfs.Invoke(&statvfs, Optional_statfs_Multiply.Invoke(&llvm_libc_20_1_2_cpp_optional_qbe95b));
			Llvm_memcpy_p0_p0_i64.Invoke(Buf, &statvfs, 88L, isVolatile: false);
			Llvm_lifetime_end_p0.Invoke(88L, &statvfs);
		}
		int result = InstructionHelper.Select(Optional_statfs_ToBoolean.Invoke(&llvm_libc_20_1_2_cpp_optional_qbe95b), 0, -1);
		Llvm_lifetime_end_p0.Invoke(128L, &llvm_libc_20_1_2_cpp_optional_qbe95b);
		return result;
	}
}
