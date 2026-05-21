using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Memmove_cpp_array_unsigned_char_vector_16_4ul_loop_and_tail_forward
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic7MemmoveINS_3cpp5arrayIDv16_hLm4EEEE21loop_and_tail_forwardEPNS2_4byteEPKS7_m")]
	[DemangledName("__llvm_libc_20_1_2_::generic::Memmove<__llvm_libc_20_1_2_::cpp::array<unsigned char vector[16], 4ul>>::loop_and_tail_forward(__llvm_libc_20_1_2_::cpp::byte*, __llvm_libc_20_1_2_::cpp::byte const*, unsigned long)")]
	public unsafe static void Invoke([MangledName("dst")][NativeType("__llvm_libc_20_1_2_::cpp::byte*")] void* Dst, [MangledName("src")][NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* Src, [MangledName("count")][NativeType("unsigned long")] long Count)
	{
		long num = 0L;
		Llvm_libc_20_1_2_cpp_array_2b9gdz llvm_libc_20_1_2_cpp_array_2b9gdz = default(Llvm_libc_20_1_2_cpp_array_2b9gdz);
		long num2 = 0L;
		Llvm_libc_20_1_2_cpp_array_2b9gdz llvm_libc_20_1_2_cpp_array_2b9gdz2 = default(Llvm_libc_20_1_2_cpp_array_2b9gdz);
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		unchecked
		{
			num = Count - 64L;
			Llvm_lifetime_start_p0.Invoke(64L, &llvm_libc_20_1_2_cpp_array_2b9gdz);
			Llvm_memset_p0_i64.Invoke(&llvm_libc_20_1_2_cpp_array_2b9gdz, -86, 64L, isVolatile: false);
			Generic_load_cpp_array_unsigned_char_vector_16_4ul.Invoke(&llvm_libc_20_1_2_cpp_array_2b9gdz, (byte*)Src + num);
			Llvm_lifetime_start_p0.Invoke(8L, &num2);
			num2 = 0L;
			do
			{
				Memmove_cpp_array_unsigned_char_vector_16_4ul_block.Invoke((byte*)Dst + num2, (byte*)Src + num2);
				num2 += 64L;
			}
			while ((ulong)num2 < (ulong)(Count - 64L));
			byte* dst = (byte*)Dst + num;
			Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_cpp_array_2b9gdz2, &llvm_libc_20_1_2_cpp_array_2b9gdz, 64L, isVolatile: false);
			Generic_store_cpp_array_unsigned_char_vector_16_4ul.Invoke(dst, &llvm_libc_20_1_2_cpp_array_2b9gdz2);
			Llvm_lifetime_end_p0.Invoke(8L, &num2);
			Llvm_lifetime_end_p0.Invoke(64L, &llvm_libc_20_1_2_cpp_array_2b9gdz);
			Llvm_lifetime_end_p0.Invoke(8L, &num);
		}
	}
}
