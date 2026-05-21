using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class generic_load_cpp_array_unsigned_char_vector_16_2ul
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic4loadINS_3cpp5arrayIDv16_hLm2EEEEET_PKNS2_4byteE")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned char vector[16], 2ul> __llvm_libc_20_1_2_::generic::load<__llvm_libc_20_1_2_::cpp::array<unsigned char vector[16], 2ul>>(__llvm_libc_20_1_2_::cpp::byte const*)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned char vector[16], 2ul>")]
	public unsafe static void Invoke([MangledName("agg.result")] cpp_array_ueviby* agg_result, [NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* src)
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
				InlineArray16_SByte inlineArray16_SByte = generic_load_unsigned_char_vector_16.Invoke((byte*)src + num * 16L);
				*(InlineArray16_SByte*)array_unsigned_char_vector_16_2ul_Index.Invoke(agg_result, num) = inlineArray16_SByte;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num);
		}
	}
}
