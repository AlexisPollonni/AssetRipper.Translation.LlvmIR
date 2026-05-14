using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_L12inline_bzeroEPvm.202")]
[DemangledName("__llvm_libc_20_1_2_::inline_bzero(void*, unsigned long) (.202)")]
internal static partial class inline_bzero_void_unsigned_long_202
{
	public unsafe static void Invoke(void* dst, long count)
	{
		inline_bzero_cpp_byte_unsigned_long_203.Invoke(dst, count);
	}
}
