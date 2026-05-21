using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Memset_cpp_array_unsigned_char_vector_16_4ul_tail
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic6MemsetINS_3cpp5arrayIDv16_hLm4EEEE4tailEPNS2_4byteEhm")]
	[DemangledName("__llvm_libc_20_1_2_::generic::Memset<__llvm_libc_20_1_2_::cpp::array<unsigned char vector[16], 4ul>>::tail(__llvm_libc_20_1_2_::cpp::byte*, unsigned char, unsigned long)")]
	public unsafe static void Invoke([NativeType("__llvm_libc_20_1_2_::cpp::byte*")] void* dst, [NativeType("unsigned char")] sbyte value, [NativeType("unsigned long")] long count)
	{
		Memset_cpp_array_unsigned_char_vector_16_4ul_block.Invoke(unchecked((byte*)dst) + count + -64, value);
	}
}
