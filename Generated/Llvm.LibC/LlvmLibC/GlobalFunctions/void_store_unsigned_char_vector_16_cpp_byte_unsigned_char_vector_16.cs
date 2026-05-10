using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_5storeIDv16_hEEvPNS_3cpp4byteET_")]
[DemangledName("void __llvm_libc_20_1_2_::store<unsigned char vector[16]>(__llvm_libc_20_1_2_::cpp::byte*, unsigned char vector[16])")]
internal static partial class void_store_unsigned_char_vector_16_cpp_byte_unsigned_char_vector_16
{
	public unsafe static void Invoke(void* ptr, InlineArray16_SByte value)
	{
		InlineArray16_SByte inlineArray16_SByte = value;
		void_memcpy_inline_16ul_void_void_const.Invoke(ptr, &inlineArray16_SByte);
	}
}
