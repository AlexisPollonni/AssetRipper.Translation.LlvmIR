using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fdopen
{
	[MangledName("fdopen")]
	[DemangledName("fdopen")]
	public unsafe static void* Invoke([MangledName("fd")] int Fd, [MangledName("mode")] void* Mode)
	{
		Cpp_optional_char_OptionalStorage cpp_optional_char_OptionalStorage = default(Cpp_optional_char_OptionalStorage);
		Llvm_lifetime_start_p0.Invoke(16L, &cpp_optional_char_OptionalStorage);
		unchecked
		{
			*(IntPtr*)(&cpp_optional_char_OptionalStorage) = unchecked((nint)(-6148914691236517206L));
			((sbyte*)(&cpp_optional_char_OptionalStorage))[8] = -86;
			sbyte* ptr = (sbyte*)(&cpp_optional_char_OptionalStorage) + 9;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			ptr[3] = -86;
			ptr[4] = -86;
			ptr[5] = -86;
			ptr[6] = -86;
			Struct_yx4nca struct_yx4nca = Create_file_from_fd.Invoke(Fd, Mode);
			Llvm_memcpy_p0_p0_i64.Invoke(&cpp_optional_char_OptionalStorage, &struct_yx4nca, 9L, isVolatile: false);
			void* result;
			if (!Expected_LinuxFile_int_has_value.Invoke(&cpp_optional_char_OptionalStorage))
			{
				Errno_Assignment.Invoke(A: *(int*)Expected_LinuxFile_int_error.Invoke(&cpp_optional_char_OptionalStorage), This: Libc_errno.Pointer);
				result = null;
			}
			else
			{
				result = *Expected_LinuxFile_int_value.Invoke(&cpp_optional_char_OptionalStorage);
			}
			Llvm_lifetime_end_p0.Invoke(16L, &cpp_optional_char_OptionalStorage);
			return result;
		}
	}
}
