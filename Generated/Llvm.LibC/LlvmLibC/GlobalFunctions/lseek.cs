using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class lseek
{
	public unsafe static long Invoke(int fd, long offset, int whence)
	{
		cpp_expected cpp_expected2 = default(cpp_expected);
		llvm_lifetime_start_p0.Invoke(16L, &cpp_expected2);
		unchecked
		{
			*(long*)(&cpp_expected2) = -6148914691236517206L;
			((sbyte*)(&cpp_expected2))[8] = -86;
			sbyte* ptr = (sbyte*)(&cpp_expected2) + 9;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			ptr[3] = -86;
			ptr[4] = -86;
			ptr[5] = -86;
			ptr[6] = -86;
			Struct_8myw6y struct_8myw6y = internal_lseekimpl.Invoke(fd, offset, whence);
			llvm_memcpy_p0_p0_i64.Invoke(&cpp_expected2, &struct_8myw6y, 9L, isVolatile: false);
			long result;
			if (!expected_long_int_has_value.Invoke(&cpp_expected2))
			{
				Errno_Assignment.Invoke(a: *(int*)expected_long_int_error.Invoke(&cpp_expected2), @this: libc_errno.Pointer);
				result = -1L;
			}
			else
			{
				result = *(long*)expected_long_int_value.Invoke(&cpp_expected2);
			}
			llvm_lifetime_end_p0.Invoke(16L, &cpp_expected2);
			return result;
		}
	}
}
