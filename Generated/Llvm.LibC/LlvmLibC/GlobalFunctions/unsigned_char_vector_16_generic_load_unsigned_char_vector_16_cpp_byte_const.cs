using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_7generic4loadIDv16_hEET_PKNS_3cpp4byteE")]
[DemangledName("unsigned char vector[16] __llvm_libc_20_1_2_::generic::load<unsigned char vector[16]>(__llvm_libc_20_1_2_::cpp::byte const*)")]
internal static partial class unsigned_char_vector_16_generic_load_unsigned_char_vector_16_cpp_byte_const
{
	public unsafe static InlineArray16_SByte Invoke(void* src)
	{
		return unsigned_char_vector_16_load_unsigned_char_vector_16_cpp_byte_const.Invoke(src);
	}
}
