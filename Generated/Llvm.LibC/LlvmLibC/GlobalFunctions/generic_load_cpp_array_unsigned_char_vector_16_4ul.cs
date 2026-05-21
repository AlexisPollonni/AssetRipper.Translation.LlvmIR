using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class generic_load_cpp_array_unsigned_char_vector_16_4ul
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic4loadINS_3cpp5arrayIDv16_hLm4EEEEET_PKNS2_4byteE")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned char vector[16], 4ul> __llvm_libc_20_1_2_::generic::load<__llvm_libc_20_1_2_::cpp::array<unsigned char vector[16], 4ul>>(__llvm_libc_20_1_2_::cpp::byte const*)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned char vector[16], 4ul>")]
	public unsafe static void Invoke([MangledName("agg.result")] cpp_array_2b9gdz* agg_result, [NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* src)
	{
		long num = 0L;
		llvm_memset_p0_i64.Invoke(agg_result, -86, 64L, isVolatile: false);
		llvm_lifetime_start_p0.Invoke(8L, &num);
		unchecked
		{
			for (num = 0L; (ulong)num < 4uL; num++)
			{
				InlineArray16_SByte inlineArray16_SByte = generic_load_unsigned_char_vector_16.Invoke((byte*)src + num * 16L);
				*(InlineArray16_SByte*)array_unsigned_char_vector_16_4ul_Index.Invoke(agg_result, num) = inlineArray16_SByte;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num);
		}
	}
}
