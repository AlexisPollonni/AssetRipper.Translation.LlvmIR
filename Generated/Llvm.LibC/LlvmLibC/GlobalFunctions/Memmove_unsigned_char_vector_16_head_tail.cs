using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Memmove_unsigned_char_vector_16_head_tail
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic7MemmoveIDv16_hE9head_tailEPNS_3cpp4byteEPKS5_m")]
	[DemangledName("__llvm_libc_20_1_2_::generic::Memmove<unsigned char vector[16]>::head_tail(__llvm_libc_20_1_2_::cpp::byte*, __llvm_libc_20_1_2_::cpp::byte const*, unsigned long)")]
	public unsafe static void Invoke([MangledName("dst")][NativeType("__llvm_libc_20_1_2_::cpp::byte*")] void* Dst, [MangledName("src")][NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* Src, [MangledName("count")][NativeType("unsigned long")] long Count)
	{
		long num = 0L;
		InlineArray16_SByte value = default(InlineArray16_SByte);
		InlineArray16_SByte value2 = default(InlineArray16_SByte);
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		unchecked
		{
			num = Count - 16L;
			Llvm_lifetime_start_p0.Invoke(16L, &value);
			value = InlineArrayHelper.Create<InlineArray16_SByte, byte>(new byte[16]
			{
				170, 170, 170, 170, 170, 170, 170, 170, 170, 170,
				170, 170, 170, 170, 170, 170
			});
			value = Generic_load_unsigned_char_vector_16.Invoke(Src);
			Llvm_lifetime_start_p0.Invoke(16L, &value2);
			value2 = InlineArrayHelper.Create<InlineArray16_SByte, byte>(new byte[16]
			{
				170, 170, 170, 170, 170, 170, 170, 170, 170, 170,
				170, 170, 170, 170, 170, 170
			});
			value2 = Generic_load_unsigned_char_vector_16.Invoke((byte*)Src + num);
			Generic_store_unsigned_char_vector_16.Invoke(Dst, value);
			Generic_store_unsigned_char_vector_16.Invoke((byte*)Dst + num, value2);
			Llvm_lifetime_end_p0.Invoke(16L, &value2);
			Llvm_lifetime_end_p0.Invoke(16L, &value);
			Llvm_lifetime_end_p0.Invoke(8L, &num);
		}
	}
}
