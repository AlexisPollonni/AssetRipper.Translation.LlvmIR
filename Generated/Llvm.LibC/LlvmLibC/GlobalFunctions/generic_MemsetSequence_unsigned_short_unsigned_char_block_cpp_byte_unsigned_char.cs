using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_7generic14MemsetSequenceItJhEE5blockEPNS_3cpp4byteEh")]
[DemangledName("__llvm_libc_20_1_2_::generic::MemsetSequence<unsigned short, unsigned char>::block(__llvm_libc_20_1_2_::cpp::byte*, unsigned char)")]
internal static partial class generic_MemsetSequence_unsigned_short_unsigned_char_block_cpp_byte_unsigned_char
{
	public unsafe static void Invoke(void* dst, sbyte value)
	{
		sbyte value2 = value;
		generic_Memset_unsigned_short_block_cpp_byte_unsigned_char.Invoke(dst, value2);
		generic_MemsetSequence_unsigned_char_block_cpp_byte_unsigned_char.Invoke(unchecked((byte*)dst) + 2, value2);
	}
}
