using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class statvfs
{
	public unsafe static int Invoke(void* path, void* buf)
	{
		cpp_optional_hij69m cpp_optional_hij69m2 = default(cpp_optional_hij69m);
		LlvmLibC.Structures.statvfs statvfs2 = default(LlvmLibC.Structures.statvfs);
		llvm_lifetime_start_p0.Invoke(128L, &cpp_optional_hij69m2);
		llvm_memset_p0_i64.Invoke(&cpp_optional_hij69m2, -86, 128L, isVolatile: false);
		statfs_utils_linux_statfs_char_const.Invoke(&cpp_optional_hij69m2, path);
		if (cpp_optional_statfs_operator_bool_const.Invoke(&cpp_optional_hij69m2))
		{
			llvm_lifetime_start_p0.Invoke(88L, &statvfs2);
			statfs_utils_statfs_to_statvfs_statfs_const.Invoke(&statvfs2, cpp_optional_statfs_operator.Invoke(&cpp_optional_hij69m2));
			llvm_memcpy_p0_p0_i64.Invoke(buf, &statvfs2, 88L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(88L, &statvfs2);
		}
		int result = InstructionHelper.Select(cpp_optional_statfs_operator_bool_const.Invoke(&cpp_optional_hij69m2), 0, -1);
		llvm_lifetime_end_p0.Invoke(128L, &cpp_optional_hij69m2);
		return result;
	}
}
