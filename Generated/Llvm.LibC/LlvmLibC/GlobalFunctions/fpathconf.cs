using System;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fpathconf
{
	public unsafe static long Invoke(int fd, int name)
	{
		long result = 0L;
		cpp_optional_qbe95b cpp_optional_qbe95b2 = default(cpp_optional_qbe95b);
		llvm_lifetime_start_p0.Invoke(128L, &cpp_optional_qbe95b2);
		llvm_memset_p0_i64.Invoke(&cpp_optional_qbe95b2, -86, 128L, isVolatile: false);
		statfs_utils_linux_fstatfs.Invoke(&cpp_optional_qbe95b2, fd);
		int num;
		if (optional_statfs_ToBoolean.Invoke(&cpp_optional_qbe95b2))
		{
			result = pathconfig.Invoke(optional_statfs_value.Invoke(&cpp_optional_qbe95b2), name);
			num = 1;
		}
		else
		{
			num = 0;
		}
		llvm_lifetime_end_p0.Invoke(128L, &cpp_optional_qbe95b2);
		switch (num)
		{
		case 0:
			result = -1L;
			goto case 1;
		case 1:
			return result;
		default:
			throw new NotImplementedException("Reached LLVM unreachable instruction.");
		}
	}
}
