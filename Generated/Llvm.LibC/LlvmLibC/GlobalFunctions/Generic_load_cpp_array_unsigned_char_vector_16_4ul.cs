using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Generic_load_cpp_array_unsigned_char_vector_16_4ul
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic4loadINS_3cpp5arrayIDv16_hLm4EEEEET_PKNS2_4byteE")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned char vector[16], 4ul> __llvm_libc_20_1_2_::generic::load<__llvm_libc_20_1_2_::cpp::array<unsigned char vector[16], 4ul>>(__llvm_libc_20_1_2_::cpp::byte const*)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned char vector[16], 4ul>")]
	public unsafe static void Invoke([MangledName("agg.result")] Llvm_libc_20_1_2_cpp_array_2b9gdz* Agg_result, [MangledName("src")][NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* Src)
	{
		long num = 0L;
		Llvm_memset_p0_i64.Invoke(Agg_result, -86, 64L, isVolatile: false);
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		unchecked
		{
			for (num = 0L; (ulong)num < 4uL; num++)
			{
				InlineArray16_SByte inlineArray16_SByte = Generic_load_unsigned_char_vector_16.Invoke((byte*)Src + num * 16L);
				*(InlineArray16_SByte*)Array_unsigned_char_vector_16_4ul_Index.Invoke(Agg_result, num) = inlineArray16_SByte;
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num);
		}
	}
}
