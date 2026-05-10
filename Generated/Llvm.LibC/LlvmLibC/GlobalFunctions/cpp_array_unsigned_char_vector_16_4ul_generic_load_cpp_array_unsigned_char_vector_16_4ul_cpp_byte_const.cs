using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_7generic4loadINS_3cpp5arrayIDv16_hLm4EEEEET_PKNS2_4byteE")]
[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned char vector[16], 4ul> __llvm_libc_20_1_2_::generic::load<__llvm_libc_20_1_2_::cpp::array<unsigned char vector[16], 4ul>>(__llvm_libc_20_1_2_::cpp::byte const*)")]
internal static partial class cpp_array_unsigned_char_vector_16_4ul_generic_load_cpp_array_unsigned_char_vector_16_4ul_cpp_byte_const
{
	public unsafe static void Invoke([MangledName("agg.result")] cpp_array_2b9gdz* agg_result, void* src)
	{
		long num = 0L;
		llvm_memset_p0_i64.Invoke(agg_result, -86, 64L, isVolatile: false);
		llvm_lifetime_start_p0.Invoke(8L, &num);
		unchecked
		{
			for (num = 0L; (ulong)num < 4uL; num++)
			{
				InlineArray16_SByte inlineArray16_SByte = unsigned_char_vector_16_generic_load_unsigned_char_vector_16_cpp_byte_const.Invoke((byte*)src + num * 16L);
				*(InlineArray16_SByte*)cpp_array_unsigned_char_vector_16_4ul_operator_unsigned_long.Invoke(agg_result, num) = inlineArray16_SByte;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num);
		}
	}
}
