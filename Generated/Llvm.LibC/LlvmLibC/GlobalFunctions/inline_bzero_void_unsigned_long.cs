using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_L12inline_bzeroEPvm")]
[DemangledName("__llvm_libc_20_1_2_::inline_bzero(void*, unsigned long)")]
internal static partial class inline_bzero_void_unsigned_long
{
	public unsafe static void Invoke(void* dst, long count)
	{
		inline_bzero_cpp_byte_unsigned_long.Invoke(dst, count);
	}
}
