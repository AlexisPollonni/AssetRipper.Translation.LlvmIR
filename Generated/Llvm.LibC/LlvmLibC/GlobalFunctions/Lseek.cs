using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Lseek
{
	[MangledName("lseek")]
	[DemangledName("lseek")]
	public unsafe static long Invoke([MangledName("fd")] int Fd, [MangledName("offset")] long Offset, [MangledName("whence")] int Whence)
	{
		Llvm_libc_20_1_2_cpp_expected llvm_libc_20_1_2_cpp_expected = default(Llvm_libc_20_1_2_cpp_expected);
		Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_expected);
		unchecked
		{
			*(long*)(&llvm_libc_20_1_2_cpp_expected) = -6148914691236517206L;
			((sbyte*)(&llvm_libc_20_1_2_cpp_expected))[8] = -86;
			sbyte* ptr = (sbyte*)(&llvm_libc_20_1_2_cpp_expected) + 9;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			ptr[3] = -86;
			ptr[4] = -86;
			ptr[5] = -86;
			ptr[6] = -86;
			Struct_8myw6y struct_8myw6y = Internal_lseekimpl.Invoke(Fd, Offset, Whence);
			Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_cpp_expected, &struct_8myw6y, 9L, isVolatile: false);
			long result;
			if (!Expected_long_int_has_value.Invoke(&llvm_libc_20_1_2_cpp_expected))
			{
				Errno_Assignment.Invoke(A: *(int*)Expected_long_int_error.Invoke(&llvm_libc_20_1_2_cpp_expected), This: Llvm_libc_20_1_2_libc_errno.Pointer);
				result = -1L;
			}
			else
			{
				result = *(long*)Expected_long_int_value.Invoke(&llvm_libc_20_1_2_cpp_expected);
			}
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_expected);
			return result;
		}
	}
}
