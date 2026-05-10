using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_7generic4loadINS_3cpp5arrayIDv16_hLm2EEEEET_PKNS2_4byteE")]
[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned char vector[16], 2ul> __llvm_libc_20_1_2_::generic::load<__llvm_libc_20_1_2_::cpp::array<unsigned char vector[16], 2ul>>(__llvm_libc_20_1_2_::cpp::byte const*)")]
internal static partial class cpp_array_unsigned_char_vector_16_2ul_generic_load_cpp_array_unsigned_char_vector_16_2ul_cpp_byte_const
{
	public unsafe static void Invoke([MangledName("agg.result")] cpp_array_ueviby* agg_result, void* src)
	{
		long num = 0L;
		unchecked
		{
			*(InlineArray16_SByte*)agg_result = InlineArrayHelper.Create<InlineArray16_SByte, byte>(new byte[16]
			{
				170, 170, 170, 170, 170, 170, 170, 170, 170, 170,
				170, 170, 170, 170, 170, 170
			});
			((InlineArray16_SByte*)agg_result)[1] = InlineArrayHelper.Create<InlineArray16_SByte, byte>(new byte[16]
			{
				170, 170, 170, 170, 170, 170, 170, 170, 170, 170,
				170, 170, 170, 170, 170, 170
			});
			llvm_lifetime_start_p0.Invoke(8L, &num);
			for (num = 0L; (ulong)num < 2uL; num++)
			{
				InlineArray16_SByte inlineArray16_SByte = unsigned_char_vector_16_generic_load_unsigned_char_vector_16_cpp_byte_const.Invoke((byte*)src + num * 16L);
				*(InlineArray16_SByte*)cpp_array_unsigned_char_vector_16_2ul_operator_unsigned_long.Invoke(agg_result, num) = inlineArray16_SByte;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num);
		}
	}
}
