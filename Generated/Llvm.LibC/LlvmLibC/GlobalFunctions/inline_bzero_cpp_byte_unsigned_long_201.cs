using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_L12inline_bzeroEPNS_3cpp4byteEm.201")]
[DemangledName("__llvm_libc_20_1_2_::inline_bzero(__llvm_libc_20_1_2_::cpp::byte*, unsigned long) (.201)")]
internal static partial class inline_bzero_cpp_byte_unsigned_long_201
{
	public unsafe static void Invoke(void* dst, long count)
	{
		inline_memset_void_unsigned_char_unsigned_long_202.Invoke(dst, 0, count);
	}
}
