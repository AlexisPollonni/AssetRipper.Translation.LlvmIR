using System;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fdopen
{
	public unsafe static void* Invoke(int fd, void* mode)
	{
		cpp_optional_char_OptionalStorage cpp_optional_char_OptionalStorage2 = default(cpp_optional_char_OptionalStorage);
		llvm_lifetime_start_p0.Invoke(16L, &cpp_optional_char_OptionalStorage2);
		unchecked
		{
			*(IntPtr*)(&cpp_optional_char_OptionalStorage2) = unchecked((nint)(-6148914691236517206L));
			((sbyte*)(&cpp_optional_char_OptionalStorage2))[8] = -86;
			sbyte* ptr = (sbyte*)(&cpp_optional_char_OptionalStorage2) + 9;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			ptr[3] = -86;
			ptr[4] = -86;
			ptr[5] = -86;
			ptr[6] = -86;
			Struct_yx4nca struct_yx4nca = create_file_from_fd.Invoke(fd, mode);
			llvm_memcpy_p0_p0_i64.Invoke(&cpp_optional_char_OptionalStorage2, &struct_yx4nca, 9L, isVolatile: false);
			void* result;
			if (!expected_LinuxFile_int_has_value.Invoke(&cpp_optional_char_OptionalStorage2))
			{
				Errno_Assignment.Invoke(a: *(int*)expected_LinuxFile_int_error.Invoke(&cpp_optional_char_OptionalStorage2), @this: libc_errno.Pointer);
				result = null;
			}
			else
			{
				result = *expected_LinuxFile_int_value.Invoke(&cpp_optional_char_OptionalStorage2);
			}
			llvm_lifetime_end_p0.Invoke(16L, &cpp_optional_char_OptionalStorage2);
			return result;
		}
	}
}
