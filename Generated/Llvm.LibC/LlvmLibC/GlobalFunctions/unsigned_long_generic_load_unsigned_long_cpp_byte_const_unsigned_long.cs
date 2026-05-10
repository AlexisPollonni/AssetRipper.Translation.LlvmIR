using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_7generic4loadImEET_PKNS_3cpp4byteEm")]
[DemangledName("unsigned long __llvm_libc_20_1_2_::generic::load<unsigned long>(__llvm_libc_20_1_2_::cpp::byte const*, unsigned long)")]
internal static partial class unsigned_long_generic_load_unsigned_long_cpp_byte_const_unsigned_long
{
	public unsafe static long Invoke(void* ptr, long offset)
	{
		return unsigned_long_load_unsigned_long_cpp_byte_const.Invoke(unchecked((byte*)ptr) + offset);
	}
}
