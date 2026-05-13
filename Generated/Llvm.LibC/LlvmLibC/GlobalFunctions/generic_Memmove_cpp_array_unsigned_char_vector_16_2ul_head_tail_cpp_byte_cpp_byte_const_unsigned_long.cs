using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_7generic7MemmoveINS_3cpp5arrayIDv16_hLm2EEEE9head_tailEPNS2_4byteEPKS7_m")]
[DemangledName("__llvm_libc_20_1_2_::generic::Memmove<__llvm_libc_20_1_2_::cpp::array<unsigned char vector[16], 2ul>>::head_tail(__llvm_libc_20_1_2_::cpp::byte*, __llvm_libc_20_1_2_::cpp::byte const*, unsigned long)")]
internal static partial class generic_Memmove_cpp_array_unsigned_char_vector_16_2ul_head_tail_cpp_byte_cpp_byte_const_unsigned_long
{
	public unsafe static void Invoke(void* dst, void* src, long count)
	{
		long num = 0L;
		cpp_array_ueviby cpp_array_ueviby2 = default(cpp_array_ueviby);
		cpp_array_ueviby cpp_array_ueviby3 = default(cpp_array_ueviby);
		cpp_array_ueviby cpp_array_ueviby4 = default(cpp_array_ueviby);
		cpp_array_ueviby cpp_array_ueviby5 = default(cpp_array_ueviby);
		llvm_lifetime_start_p0.Invoke(8L, &num);
		unchecked
		{
			num = count - 32L;
			llvm_lifetime_start_p0.Invoke(32L, &cpp_array_ueviby2);
			sbyte* ptr = (sbyte*)(&cpp_array_ueviby2);
			*(InlineArray16_SByte*)ptr = InlineArrayHelper.Create<InlineArray16_SByte, byte>(new byte[16]
			{
				170, 170, 170, 170, 170, 170, 170, 170, 170, 170,
				170, 170, 170, 170, 170, 170
			});
			((InlineArray16_SByte*)ptr)[1] = InlineArrayHelper.Create<InlineArray16_SByte, byte>(new byte[16]
			{
				170, 170, 170, 170, 170, 170, 170, 170, 170, 170,
				170, 170, 170, 170, 170, 170
			});
			cpp_array_unsigned_char_vector_16_2ul_generic_load_cpp_array_unsigned_char_vector_16_2ul_cpp_byte_const.Invoke(&cpp_array_ueviby2, src);
			llvm_lifetime_start_p0.Invoke(32L, &cpp_array_ueviby3);
			sbyte* ptr2 = (sbyte*)(&cpp_array_ueviby3);
			*(InlineArray16_SByte*)ptr2 = InlineArrayHelper.Create<InlineArray16_SByte, byte>(new byte[16]
			{
				170, 170, 170, 170, 170, 170, 170, 170, 170, 170,
				170, 170, 170, 170, 170, 170
			});
			((InlineArray16_SByte*)ptr2)[1] = InlineArrayHelper.Create<InlineArray16_SByte, byte>(new byte[16]
			{
				170, 170, 170, 170, 170, 170, 170, 170, 170, 170,
				170, 170, 170, 170, 170, 170
			});
			cpp_array_unsigned_char_vector_16_2ul_generic_load_cpp_array_unsigned_char_vector_16_2ul_cpp_byte_const.Invoke(&cpp_array_ueviby3, (byte*)src + num);
			llvm_memcpy_p0_p0_i64.Invoke(&cpp_array_ueviby4, &cpp_array_ueviby2, 32L, isVolatile: false);
			void_generic_store_cpp_array_unsigned_char_vector_16_2ul_cpp_byte_cpp_array_unsigned_char_vector_16_2ul.Invoke(dst, &cpp_array_ueviby4);
			byte* dst2 = (byte*)dst + num;
			llvm_memcpy_p0_p0_i64.Invoke(&cpp_array_ueviby5, &cpp_array_ueviby3, 32L, isVolatile: false);
			void_generic_store_cpp_array_unsigned_char_vector_16_2ul_cpp_byte_cpp_array_unsigned_char_vector_16_2ul.Invoke(dst2, &cpp_array_ueviby5);
			llvm_lifetime_end_p0.Invoke(32L, &cpp_array_ueviby3);
			llvm_lifetime_end_p0.Invoke(32L, &cpp_array_ueviby2);
			llvm_lifetime_end_p0.Invoke(8L, &num);
		}
	}
}
