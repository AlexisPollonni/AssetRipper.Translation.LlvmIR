using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_7generic5storeINS_3cpp5arrayIDv16_hLm2EEEEEvPNS2_4byteET_")]
[DemangledName("void __llvm_libc_20_1_2_::generic::store<__llvm_libc_20_1_2_::cpp::array<unsigned char vector[16], 2ul>>(__llvm_libc_20_1_2_::cpp::byte*, __llvm_libc_20_1_2_::cpp::array<unsigned char vector[16], 2ul>)")]
internal static partial class void_generic_store_cpp_array_unsigned_char_vector_16_2ul_cpp_byte_cpp_array_unsigned_char_vector_16_2ul
{
	public unsafe static void Invoke(void* dst, void* value)
	{
		long num = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		unchecked
		{
			for (num = 0L; (ulong)num < 2uL; num++)
			{
				void_generic_store_unsigned_char_vector_16_cpp_byte_unsigned_char_vector_16.Invoke((byte*)dst + num * 16L, *(InlineArray16_SByte*)cpp_array_unsigned_char_vector_16_2ul_operator_unsigned_long.Invoke(value, num));
			}
			llvm_lifetime_end_p0.Invoke(8L, &num);
		}
	}
}
