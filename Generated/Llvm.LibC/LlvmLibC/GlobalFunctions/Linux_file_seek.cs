using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Linux_file_seek
{
	public unsafe static readonly void* __pointer = (delegate*<File_sjnxn4*, long, int, Struct_8myw6y>)(&Invoke);

	[MangledName("_ZN19__llvm_libc_20_1_2_15linux_file_seekEPNS_4FileEli")]
	[DemangledName("__llvm_libc_20_1_2_::linux_file_seek(__llvm_libc_20_1_2_::File*, long, int)")]
	public unsafe static Struct_8myw6y Invoke([MangledName("f")][NativeType("__llvm_libc_20_1_2_::File*")] File_sjnxn4* F, [MangledName("offset")][NativeType("long")] long Offset, [MangledName("whence")][NativeType("int")] int Whence)
	{
		Cpp_expected cpp_expected = default(Cpp_expected);
		void* ptr = null;
		Cpp_expected cpp_expected2 = default(Cpp_expected);
		Llvm_lifetime_start_p0.Invoke(8L, &ptr);
		ptr = F;
		Llvm_lifetime_start_p0.Invoke(16L, &cpp_expected2);
		unchecked
		{
			*(long*)(&cpp_expected2) = -6148914691236517206L;
			((sbyte*)(&cpp_expected2))[8] = -86;
			sbyte* ptr2 = (sbyte*)(&cpp_expected2) + 9;
			*ptr2 = -86;
			ptr2[1] = -86;
			ptr2[2] = -86;
			ptr2[3] = -86;
			ptr2[4] = -86;
			ptr2[5] = -86;
			ptr2[6] = -86;
			Struct_8myw6y struct_8myw6y = Internal_lseekimpl.Invoke(LinuxFile_get_fd.Invoke((LinuxFile*)ptr), Offset, Whence);
			Llvm_memcpy_p0_p0_i64.Invoke(&cpp_expected2, &struct_8myw6y, 9L, isVolatile: false);
			if (!Expected_long_int_has_value.Invoke(&cpp_expected2))
			{
				Expected_long_int_Constructor.Invoke((void*)(&cpp_expected), (long)(*(int*)Expected_long_int_error.Invoke(&cpp_expected2)));
			}
			else
			{
				Expected_long_int_Constructor.Invoke(&cpp_expected, *(long*)Expected_long_int_value.Invoke(&cpp_expected2));
			}
			Llvm_lifetime_end_p0.Invoke(16L, &cpp_expected2);
			Llvm_lifetime_end_p0.Invoke(8L, &ptr);
			return *(Struct_8myw6y*)(&cpp_expected);
		}
	}
}
