using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Generic_load_cpp_array_unsigned_char_vector_16_2ul
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic4loadINS_3cpp5arrayIDv16_hLm2EEEEET_PKNS2_4byteE")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned char vector[16], 2ul> __llvm_libc_20_1_2_::generic::load<__llvm_libc_20_1_2_::cpp::array<unsigned char vector[16], 2ul>>(__llvm_libc_20_1_2_::cpp::byte const*)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned char vector[16], 2ul>")]
	public unsafe static void Invoke([MangledName("agg.result")] Llvm_libc_20_1_2_cpp_array_ueviby* Agg_result, [MangledName("src")][NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* Src)
	{
		long num = 0L;
		unchecked
		{
			*(InlineArray16_SByte*)Agg_result = InlineArrayHelper.Create<InlineArray16_SByte, byte>(new byte[16]
			{
				170, 170, 170, 170, 170, 170, 170, 170, 170, 170,
				170, 170, 170, 170, 170, 170
			});
			((InlineArray16_SByte*)Agg_result)[1] = InlineArrayHelper.Create<InlineArray16_SByte, byte>(new byte[16]
			{
				170, 170, 170, 170, 170, 170, 170, 170, 170, 170,
				170, 170, 170, 170, 170, 170
			});
			Llvm_lifetime_start_p0.Invoke(8L, &num);
			for (num = 0L; (ulong)num < 2uL; num++)
			{
				InlineArray16_SByte inlineArray16_SByte = Generic_load_unsigned_char_vector_16.Invoke((byte*)Src + num * 16L);
				*(InlineArray16_SByte*)Array_unsigned_char_vector_16_2ul_Index.Invoke(Agg_result, num) = inlineArray16_SByte;
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num);
		}
	}
}
