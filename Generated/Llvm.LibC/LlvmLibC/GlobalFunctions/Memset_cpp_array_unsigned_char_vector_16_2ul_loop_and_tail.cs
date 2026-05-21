using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Memset_cpp_array_unsigned_char_vector_16_2ul_loop_and_tail
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic6MemsetINS_3cpp5arrayIDv16_hLm2EEEE13loop_and_tailEPNS2_4byteEhm")]
	[DemangledName("__llvm_libc_20_1_2_::generic::Memset<__llvm_libc_20_1_2_::cpp::array<unsigned char vector[16], 2ul>>::loop_and_tail(__llvm_libc_20_1_2_::cpp::byte*, unsigned char, unsigned long)")]
	public unsafe static void Invoke([NativeType("__llvm_libc_20_1_2_::cpp::byte*")] void* dst, [NativeType("unsigned char")] sbyte value, [NativeType("unsigned long")] long count)
	{
		Memset_cpp_array_unsigned_char_vector_16_2ul_loop_and_tail_offset.Invoke(dst, value, count, 0L);
	}
}
