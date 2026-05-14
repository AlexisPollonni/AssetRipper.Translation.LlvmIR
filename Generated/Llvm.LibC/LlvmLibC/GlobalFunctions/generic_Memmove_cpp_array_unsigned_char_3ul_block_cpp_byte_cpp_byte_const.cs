using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_7generic7MemmoveINS_3cpp5arrayIhLm3EEEE5blockEPNS2_4byteEPKS6_")]
[DemangledName("__llvm_libc_20_1_2_::generic::Memmove<__llvm_libc_20_1_2_::cpp::array<unsigned char, 3ul>>::block(__llvm_libc_20_1_2_::cpp::byte*, __llvm_libc_20_1_2_::cpp::byte const*)")]
internal static partial class generic_Memmove_cpp_array_unsigned_char_3ul_block_cpp_byte_cpp_byte_const
{
	public unsafe static void Invoke(void* dst, void* src)
	{
		cpp_array_txpwtz cpp_array_txpwtz2 = default(cpp_array_txpwtz);
		InlineArray3_Byte value = default(InlineArray3_Byte);
		InlineArray3_Byte data = cpp_array_unsigned_char_3ul_generic_load_cpp_array_unsigned_char_3ul_cpp_byte_const.Invoke(src);
		*unchecked((InlineArray3_Byte*)(&cpp_array_txpwtz2.Data)) = data;
		llvm_memcpy_p0_p0_i64.Invoke(&value, &cpp_array_txpwtz2.Data, 3L, isVolatile: false);
		void_generic_store_cpp_array_unsigned_char_3ul_cpp_byte_cpp_array_unsigned_char_3ul.Invoke(dst, value);
	}
}
