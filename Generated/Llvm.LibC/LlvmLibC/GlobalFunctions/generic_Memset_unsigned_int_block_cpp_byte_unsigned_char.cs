using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_7generic6MemsetIjE5blockEPNS_3cpp4byteEh")]
[DemangledName("__llvm_libc_20_1_2_::generic::Memset<unsigned int>::block(__llvm_libc_20_1_2_::cpp::byte*, unsigned char)")]
internal static partial class generic_Memset_unsigned_int_block_cpp_byte_unsigned_char
{
	public unsafe static void Invoke(void* dst, sbyte value)
	{
		void_generic_store_unsigned_int_cpp_byte_unsigned_int.Invoke(dst, unsigned_int_generic_splat_unsigned_int_unsigned_char.Invoke(value));
	}
}
