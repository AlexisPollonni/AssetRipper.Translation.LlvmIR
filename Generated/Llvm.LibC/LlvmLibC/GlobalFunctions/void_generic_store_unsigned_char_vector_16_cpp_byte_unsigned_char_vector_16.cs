using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_7generic5storeIDv16_hEEvPNS_3cpp4byteET_")]
[DemangledName("void __llvm_libc_20_1_2_::generic::store<unsigned char vector[16]>(__llvm_libc_20_1_2_::cpp::byte*, unsigned char vector[16])")]
internal static partial class void_generic_store_unsigned_char_vector_16_cpp_byte_unsigned_char_vector_16
{
	public unsafe static void Invoke(void* dst, InlineArray16_SByte value)
	{
		void_store_unsigned_char_vector_16_cpp_byte_unsigned_char_vector_16.Invoke(dst, value);
	}
}
