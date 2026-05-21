using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Memset_unsigned_char_vector_16_block
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic6MemsetIDv16_hE5blockEPNS_3cpp4byteEh")]
	[DemangledName("__llvm_libc_20_1_2_::generic::Memset<unsigned char vector[16]>::block(__llvm_libc_20_1_2_::cpp::byte*, unsigned char)")]
	public unsafe static void Invoke([NativeType("__llvm_libc_20_1_2_::cpp::byte*")] void* dst, [NativeType("unsigned char")] sbyte value)
	{
		generic_store_unsigned_char_vector_16.Invoke(dst, generic_splat_unsigned_char_vector_16.Invoke(value));
	}
}
