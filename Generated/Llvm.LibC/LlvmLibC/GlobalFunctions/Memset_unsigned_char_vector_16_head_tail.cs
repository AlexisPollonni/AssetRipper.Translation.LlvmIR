using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Memset_unsigned_char_vector_16_head_tail
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic6MemsetIDv16_hE9head_tailEPNS_3cpp4byteEhm")]
	[DemangledName("__llvm_libc_20_1_2_::generic::Memset<unsigned char vector[16]>::head_tail(__llvm_libc_20_1_2_::cpp::byte*, unsigned char, unsigned long)")]
	public unsafe static void Invoke([NativeType("__llvm_libc_20_1_2_::cpp::byte*")] void* dst, [NativeType("unsigned char")] sbyte value, [NativeType("unsigned long")] long count)
	{
		sbyte value2 = value;
		Memset_unsigned_char_vector_16_block.Invoke(dst, value2);
		Memset_unsigned_char_vector_16_tail.Invoke(dst, value2, count);
	}
}
