using AssetRipper.Translation.LlvmIR.Runtime;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class statvfs
{
	public unsafe static int Invoke(void* path, LlvmLibC.Structures.statvfs* buf)
	{
		cpp_optional_qbe95b cpp_optional_qbe95b2 = default(cpp_optional_qbe95b);
		LlvmLibC.Structures.statvfs statvfs2 = default(LlvmLibC.Structures.statvfs);
		llvm_lifetime_start_p0.Invoke(128L, &cpp_optional_qbe95b2);
		llvm_memset_p0_i64.Invoke(&cpp_optional_qbe95b2, -86, 128L, isVolatile: false);
		statfs_utils_linux_statfs.Invoke(&cpp_optional_qbe95b2, path);
		if (optional_statfs_ToBoolean.Invoke(&cpp_optional_qbe95b2))
		{
			llvm_lifetime_start_p0.Invoke(88L, &statvfs2);
			statfs_utils_statfs_to_statvfs.Invoke(&statvfs2, optional_statfs_Multiply.Invoke(&cpp_optional_qbe95b2));
			llvm_memcpy_p0_p0_i64.Invoke(buf, &statvfs2, 88L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(88L, &statvfs2);
		}
		int result = InstructionHelper.Select(optional_statfs_ToBoolean.Invoke(&cpp_optional_qbe95b2), 0, -1);
		llvm_lifetime_end_p0.Invoke(128L, &cpp_optional_qbe95b2);
		return result;
	}
}
