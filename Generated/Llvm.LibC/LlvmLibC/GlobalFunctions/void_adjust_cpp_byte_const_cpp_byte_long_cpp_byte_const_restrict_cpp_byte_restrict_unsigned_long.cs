using System;
using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6adjustIKNS_3cpp4byteES2_EEvlRrPT_RrPT0_Rm")]
[DemangledName("void __llvm_libc_20_1_2_::adjust<__llvm_libc_20_1_2_::cpp::byte const, __llvm_libc_20_1_2_::cpp::byte>(long, __llvm_libc_20_1_2_::cpp::byte const* restrict&, __llvm_libc_20_1_2_::cpp::byte* restrict&, unsigned long&)")]
internal static partial class void_adjust_cpp_byte_const_cpp_byte_long_cpp_byte_const_restrict_cpp_byte_restrict_unsigned_long
{
	public unsafe static void Invoke(long offset, void* p1, void* p2, void* count)
	{
		unchecked
		{
			*(IntPtr*)p1 += (nint)offset;
			*(IntPtr*)p2 += (nint)offset;
			*(long*)count -= offset;
		}
	}
}
