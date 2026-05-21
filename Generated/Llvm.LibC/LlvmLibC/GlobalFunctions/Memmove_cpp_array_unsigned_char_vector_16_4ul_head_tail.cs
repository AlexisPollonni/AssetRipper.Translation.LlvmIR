using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Memmove_cpp_array_unsigned_char_vector_16_4ul_head_tail
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic7MemmoveINS_3cpp5arrayIDv16_hLm4EEEE9head_tailEPNS2_4byteEPKS7_m")]
	[DemangledName("__llvm_libc_20_1_2_::generic::Memmove<__llvm_libc_20_1_2_::cpp::array<unsigned char vector[16], 4ul>>::head_tail(__llvm_libc_20_1_2_::cpp::byte*, __llvm_libc_20_1_2_::cpp::byte const*, unsigned long)")]
	public unsafe static void Invoke([MangledName("dst")][NativeType("__llvm_libc_20_1_2_::cpp::byte*")] void* Dst, [MangledName("src")][NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* Src, [MangledName("count")][NativeType("unsigned long")] long Count)
	{
		long num = 0L;
		Llvm_libc_20_1_2_cpp_array_2b9gdz llvm_libc_20_1_2_cpp_array_2b9gdz = default(Llvm_libc_20_1_2_cpp_array_2b9gdz);
		Llvm_libc_20_1_2_cpp_array_2b9gdz llvm_libc_20_1_2_cpp_array_2b9gdz2 = default(Llvm_libc_20_1_2_cpp_array_2b9gdz);
		Llvm_libc_20_1_2_cpp_array_2b9gdz llvm_libc_20_1_2_cpp_array_2b9gdz3 = default(Llvm_libc_20_1_2_cpp_array_2b9gdz);
		Llvm_libc_20_1_2_cpp_array_2b9gdz llvm_libc_20_1_2_cpp_array_2b9gdz4 = default(Llvm_libc_20_1_2_cpp_array_2b9gdz);
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		unchecked
		{
			num = Count - 64L;
			Llvm_lifetime_start_p0.Invoke(64L, &llvm_libc_20_1_2_cpp_array_2b9gdz);
			Llvm_memset_p0_i64.Invoke(&llvm_libc_20_1_2_cpp_array_2b9gdz, -86, 64L, isVolatile: false);
			Generic_load_cpp_array_unsigned_char_vector_16_4ul.Invoke(&llvm_libc_20_1_2_cpp_array_2b9gdz, Src);
			Llvm_lifetime_start_p0.Invoke(64L, &llvm_libc_20_1_2_cpp_array_2b9gdz2);
			Llvm_memset_p0_i64.Invoke(&llvm_libc_20_1_2_cpp_array_2b9gdz2, -86, 64L, isVolatile: false);
			Generic_load_cpp_array_unsigned_char_vector_16_4ul.Invoke(&llvm_libc_20_1_2_cpp_array_2b9gdz2, (byte*)Src + num);
			Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_cpp_array_2b9gdz3, &llvm_libc_20_1_2_cpp_array_2b9gdz, 64L, isVolatile: false);
			Generic_store_cpp_array_unsigned_char_vector_16_4ul.Invoke(Dst, &llvm_libc_20_1_2_cpp_array_2b9gdz3);
			byte* dst = (byte*)Dst + num;
			Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_cpp_array_2b9gdz4, &llvm_libc_20_1_2_cpp_array_2b9gdz2, 64L, isVolatile: false);
			Generic_store_cpp_array_unsigned_char_vector_16_4ul.Invoke(dst, &llvm_libc_20_1_2_cpp_array_2b9gdz4);
			Llvm_lifetime_end_p0.Invoke(64L, &llvm_libc_20_1_2_cpp_array_2b9gdz2);
			Llvm_lifetime_end_p0.Invoke(64L, &llvm_libc_20_1_2_cpp_array_2b9gdz);
			Llvm_lifetime_end_p0.Invoke(8L, &num);
		}
	}
}
