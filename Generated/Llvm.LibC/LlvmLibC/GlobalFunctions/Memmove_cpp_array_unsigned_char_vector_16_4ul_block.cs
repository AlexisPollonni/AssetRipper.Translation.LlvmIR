using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Memmove_cpp_array_unsigned_char_vector_16_4ul_block
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic7MemmoveINS_3cpp5arrayIDv16_hLm4EEEE5blockEPNS2_4byteEPKS7_")]
	[DemangledName("__llvm_libc_20_1_2_::generic::Memmove<__llvm_libc_20_1_2_::cpp::array<unsigned char vector[16], 4ul>>::block(__llvm_libc_20_1_2_::cpp::byte*, __llvm_libc_20_1_2_::cpp::byte const*)")]
	public unsafe static void Invoke([NativeType("__llvm_libc_20_1_2_::cpp::byte*")] void* dst, [NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* src)
	{
		cpp_array_2b9gdz cpp_array_2b9gdz2 = default(cpp_array_2b9gdz);
		generic_load_cpp_array_unsigned_char_vector_16_4ul.Invoke(&cpp_array_2b9gdz2, src);
		generic_store_cpp_array_unsigned_char_vector_16_4ul.Invoke(dst, &cpp_array_2b9gdz2);
	}
}
