using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Memset_cpp_array_unsigned_char_vector_16_4ul_head_tail
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic6MemsetINS_3cpp5arrayIDv16_hLm4EEEE9head_tailEPNS2_4byteEhm")]
	[DemangledName("__llvm_libc_20_1_2_::generic::Memset<__llvm_libc_20_1_2_::cpp::array<unsigned char vector[16], 4ul>>::head_tail(__llvm_libc_20_1_2_::cpp::byte*, unsigned char, unsigned long)")]
	public unsafe static void Invoke([NativeType("__llvm_libc_20_1_2_::cpp::byte*")] void* dst, [NativeType("unsigned char")] sbyte value, [NativeType("unsigned long")] long count)
	{
		sbyte value2 = value;
		Memset_cpp_array_unsigned_char_vector_16_4ul_block.Invoke(dst, value2);
		Memset_cpp_array_unsigned_char_vector_16_4ul_tail.Invoke(dst, value2, count);
	}
}
