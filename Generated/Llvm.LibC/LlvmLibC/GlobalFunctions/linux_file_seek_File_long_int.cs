using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_15linux_file_seekEPNS_4FileEli")]
[DemangledName("__llvm_libc_20_1_2_::linux_file_seek(__llvm_libc_20_1_2_::File*, long, int)")]
internal static partial class linux_file_seek_File_long_int
{
	public unsafe static readonly void* __pointer = PointerIndices.Register((delegate*<void*, long, int, Struct_8myw6y>)(&Invoke));

	public unsafe static Struct_8myw6y Invoke(void* f, long offset, int whence)
	{
		cpp_expected cpp_expected2 = default(cpp_expected);
		void* ptr = null;
		cpp_expected cpp_expected3 = default(cpp_expected);
		llvm_lifetime_start_p0.Invoke(8L, &ptr);
		ptr = f;
		llvm_lifetime_start_p0.Invoke(16L, &cpp_expected3);
		unchecked
		{
			*(long*)(&cpp_expected3) = -6148914691236517206L;
			((sbyte*)(&cpp_expected3))[8] = -86;
			sbyte* ptr2 = (sbyte*)(&cpp_expected3) + 9;
			*ptr2 = -86;
			ptr2[1] = -86;
			ptr2[2] = -86;
			ptr2[3] = -86;
			ptr2[4] = -86;
			ptr2[5] = -86;
			ptr2[6] = -86;
			Struct_8myw6y struct_8myw6y = internal_lseekimpl_int_long_int.Invoke(LinuxFile_get_fd_const.Invoke(ptr), offset, whence);
			llvm_memcpy_p0_p0_i64.Invoke(&cpp_expected3, &struct_8myw6y, 9L, isVolatile: false);
			if (!cpp_expected_long_int_has_value_const.Invoke(&cpp_expected3))
			{
				cpp_expected_long_int_expected_long.Invoke(&cpp_expected2, *(int*)cpp_expected_long_int_error.Invoke(&cpp_expected3));
			}
			else
			{
				cpp_expected_long_int_expected_long.Invoke(&cpp_expected2, *(long*)cpp_expected_long_int_value.Invoke(&cpp_expected3));
			}
			llvm_lifetime_end_p0.Invoke(16L, &cpp_expected3);
			llvm_lifetime_end_p0.Invoke(8L, &ptr);
			return *(Struct_8myw6y*)(&cpp_expected2);
		}
	}
}
