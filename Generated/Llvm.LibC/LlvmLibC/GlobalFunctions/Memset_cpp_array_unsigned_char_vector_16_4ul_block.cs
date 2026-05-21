using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Memset_cpp_array_unsigned_char_vector_16_4ul_block
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic6MemsetINS_3cpp5arrayIDv16_hLm4EEEE5blockEPNS2_4byteEh")]
	[DemangledName("__llvm_libc_20_1_2_::generic::Memset<__llvm_libc_20_1_2_::cpp::array<unsigned char vector[16], 4ul>>::block(__llvm_libc_20_1_2_::cpp::byte*, unsigned char)")]
	public unsafe static void Invoke([NativeType("__llvm_libc_20_1_2_::cpp::byte*")] void* dst, [NativeType("unsigned char")] sbyte value)
	{
		InlineArray16_SByte value2 = default(InlineArray16_SByte);
		long num = 0L;
		llvm_lifetime_start_p0.Invoke(16L, &value2);
		value2 = InlineArrayHelper.Create<InlineArray16_SByte, byte>(new byte[16]
		{
			170, 170, 170, 170, 170, 170, 170, 170, 170, 170,
			170, 170, 170, 170, 170, 170
		});
		value2 = generic_splat_unsigned_char_vector_16.Invoke(value);
		llvm_lifetime_start_p0.Invoke(8L, &num);
		unchecked
		{
			for (num = 0L; (ulong)num < 4uL; num++)
			{
				generic_store_unsigned_char_vector_16.Invoke((byte*)dst + num * 16L, value2);
			}
			llvm_lifetime_end_p0.Invoke(8L, &num);
			llvm_lifetime_end_p0.Invoke(16L, &value2);
		}
	}
}
