using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fstatvfs
{
	[MangledName("fstatvfs")]
	[DemangledName("fstatvfs")]
	public unsafe static int Invoke([MangledName("fd")] int Fd, [MangledName("buf")] global::LlvmLibC.Structures.Statvfs* Buf)
	{
		Cpp_optional_qbe95b cpp_optional_qbe95b = default(Cpp_optional_qbe95b);
		global::LlvmLibC.Structures.Statvfs statvfs = default(global::LlvmLibC.Structures.Statvfs);
		Llvm_lifetime_start_p0.Invoke(128L, &cpp_optional_qbe95b);
		Llvm_memset_p0_i64.Invoke(&cpp_optional_qbe95b, -86, 128L, isVolatile: false);
		Statfs_utils_linux_fstatfs.Invoke(&cpp_optional_qbe95b, Fd);
		if (Optional_statfs_ToBoolean.Invoke(&cpp_optional_qbe95b))
		{
			Llvm_lifetime_start_p0.Invoke(88L, &statvfs);
			Statfs_utils_statfs_to_statvfs.Invoke(&statvfs, Optional_statfs_Multiply.Invoke(&cpp_optional_qbe95b));
			Llvm_memcpy_p0_p0_i64.Invoke(Buf, &statvfs, 88L, isVolatile: false);
			Llvm_lifetime_end_p0.Invoke(88L, &statvfs);
		}
		int result = InstructionHelper.Select(Optional_statfs_ToBoolean.Invoke(&cpp_optional_qbe95b), 0, -1);
		Llvm_lifetime_end_p0.Invoke(128L, &cpp_optional_qbe95b);
		return result;
	}
}
