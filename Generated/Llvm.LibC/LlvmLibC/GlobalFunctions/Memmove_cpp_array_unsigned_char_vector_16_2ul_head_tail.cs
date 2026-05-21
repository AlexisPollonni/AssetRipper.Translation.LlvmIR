using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Memmove_cpp_array_unsigned_char_vector_16_2ul_head_tail
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic7MemmoveINS_3cpp5arrayIDv16_hLm2EEEE9head_tailEPNS2_4byteEPKS7_m")]
	[DemangledName("__llvm_libc_20_1_2_::generic::Memmove<__llvm_libc_20_1_2_::cpp::array<unsigned char vector[16], 2ul>>::head_tail(__llvm_libc_20_1_2_::cpp::byte*, __llvm_libc_20_1_2_::cpp::byte const*, unsigned long)")]
	public unsafe static void Invoke([MangledName("dst")][NativeType("__llvm_libc_20_1_2_::cpp::byte*")] void* Dst, [MangledName("src")][NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* Src, [MangledName("count")][NativeType("unsigned long")] long Count)
	{
		long num = 0L;
		Llvm_libc_20_1_2_cpp_array_ueviby llvm_libc_20_1_2_cpp_array_ueviby = default(Llvm_libc_20_1_2_cpp_array_ueviby);
		Llvm_libc_20_1_2_cpp_array_ueviby llvm_libc_20_1_2_cpp_array_ueviby2 = default(Llvm_libc_20_1_2_cpp_array_ueviby);
		Llvm_libc_20_1_2_cpp_array_ueviby llvm_libc_20_1_2_cpp_array_ueviby3 = default(Llvm_libc_20_1_2_cpp_array_ueviby);
		Llvm_libc_20_1_2_cpp_array_ueviby llvm_libc_20_1_2_cpp_array_ueviby4 = default(Llvm_libc_20_1_2_cpp_array_ueviby);
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		unchecked
		{
			num = Count - 32L;
			Llvm_lifetime_start_p0.Invoke(32L, &llvm_libc_20_1_2_cpp_array_ueviby);
			sbyte* ptr = (sbyte*)(&llvm_libc_20_1_2_cpp_array_ueviby);
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
			Generic_load_cpp_array_unsigned_char_vector_16_2ul.Invoke(&llvm_libc_20_1_2_cpp_array_ueviby, Src);
			Llvm_lifetime_start_p0.Invoke(32L, &llvm_libc_20_1_2_cpp_array_ueviby2);
			sbyte* ptr2 = (sbyte*)(&llvm_libc_20_1_2_cpp_array_ueviby2);
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
			Generic_load_cpp_array_unsigned_char_vector_16_2ul.Invoke(&llvm_libc_20_1_2_cpp_array_ueviby2, (byte*)Src + num);
			Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_cpp_array_ueviby3, &llvm_libc_20_1_2_cpp_array_ueviby, 32L, isVolatile: false);
			Generic_store_cpp_array_unsigned_char_vector_16_2ul.Invoke(Dst, &llvm_libc_20_1_2_cpp_array_ueviby3);
			byte* dst = (byte*)Dst + num;
			Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_cpp_array_ueviby4, &llvm_libc_20_1_2_cpp_array_ueviby2, 32L, isVolatile: false);
			Generic_store_cpp_array_unsigned_char_vector_16_2ul.Invoke(dst, &llvm_libc_20_1_2_cpp_array_ueviby4);
			Llvm_lifetime_end_p0.Invoke(32L, &llvm_libc_20_1_2_cpp_array_ueviby2);
			Llvm_lifetime_end_p0.Invoke(32L, &llvm_libc_20_1_2_cpp_array_ueviby);
			Llvm_lifetime_end_p0.Invoke(8L, &num);
		}
	}
}
