using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_7generic5storeINS_3cpp5arrayIhLm3EEEEEvPNS2_4byteET_")]
[DemangledName("void __llvm_libc_20_1_2_::generic::store<__llvm_libc_20_1_2_::cpp::array<unsigned char, 3ul>>(__llvm_libc_20_1_2_::cpp::byte*, __llvm_libc_20_1_2_::cpp::array<unsigned char, 3ul>)")]
internal static partial class void_generic_store_cpp_array_unsigned_char_3ul_cpp_byte_cpp_array_unsigned_char_3ul
{
	public unsafe static void Invoke(void* dst, [MangledName("value.coerce")] InlineArray3_Byte value)
	{
		cpp_array_cdhstp cpp_array_cdhstp2 = default(cpp_array_cdhstp);
		long num = 0L;
		unchecked
		{
			*(InlineArray3_Byte*)(&cpp_array_cdhstp2.Data) = value;
			llvm_lifetime_start_p0.Invoke(8L, &num);
			for (num = 0L; (ulong)num < 3uL; num++)
			{
				void_generic_store_unsigned_char_cpp_byte_unsigned_char.Invoke((byte*)dst + num * 1L, *(sbyte*)cpp_array_unsigned_char_3ul_operator_unsigned_long.Invoke(&cpp_array_cdhstp2, num));
			}
			llvm_lifetime_end_p0.Invoke(8L, &num);
		}
	}
}
