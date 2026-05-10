using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_4loadIhEET_PKNS_3cpp4byteE")]
[DemangledName("unsigned char __llvm_libc_20_1_2_::load<unsigned char>(__llvm_libc_20_1_2_::cpp::byte const*)")]
internal static partial class unsigned_char_load_unsigned_char_cpp_byte_const
{
	public unsafe static sbyte Invoke(void* ptr)
	{
		sbyte b = 0;
		llvm_lifetime_start_p0.Invoke(1L, &b);
		b = -86;
		void_memcpy_inline_1ul_void_void_const.Invoke(&b, ptr);
		sbyte result = b;
		llvm_lifetime_end_p0.Invoke(1L, &b);
		return result;
	}
}
