using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Memset_cpp_array_unsigned_char_vector_16_2ul_block
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic6MemsetINS_3cpp5arrayIDv16_hLm2EEEE5blockEPNS2_4byteEh")]
	[DemangledName("__llvm_libc_20_1_2_::generic::Memset<__llvm_libc_20_1_2_::cpp::array<unsigned char vector[16], 2ul>>::block(__llvm_libc_20_1_2_::cpp::byte*, unsigned char)")]
	public unsafe static void Invoke([MangledName("dst")][NativeType("__llvm_libc_20_1_2_::cpp::byte*")] void* Dst, [MangledName("value")][NativeType("unsigned char")] sbyte Value)
	{
		InlineArray16_SByte value = default(InlineArray16_SByte);
		long num = 0L;
		Llvm_lifetime_start_p0.Invoke(16L, &value);
		value = InlineArrayHelper.Create<InlineArray16_SByte, byte>(new byte[16]
		{
			170, 170, 170, 170, 170, 170, 170, 170, 170, 170,
			170, 170, 170, 170, 170, 170
		});
		value = Generic_splat_unsigned_char_vector_16.Invoke(Value);
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		unchecked
		{
			for (num = 0L; (ulong)num < 2uL; num++)
			{
				Generic_store_unsigned_char_vector_16.Invoke((byte*)Dst + num * 16L, value);
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			Llvm_lifetime_end_p0.Invoke(16L, &value);
		}
	}
}
