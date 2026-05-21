using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class MemsetSequence_unsigned_short_unsigned_char_block
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic14MemsetSequenceItJhEE5blockEPNS_3cpp4byteEh")]
	[DemangledName("__llvm_libc_20_1_2_::generic::MemsetSequence<unsigned short, unsigned char>::block(__llvm_libc_20_1_2_::cpp::byte*, unsigned char)")]
	public unsafe static void Invoke([NativeType("__llvm_libc_20_1_2_::cpp::byte*")] void* dst, [NativeType("unsigned char")] sbyte value)
	{
		sbyte value2 = value;
		Memset_unsigned_short_block.Invoke(dst, value2);
		MemsetSequence_unsigned_char_block.Invoke(unchecked((byte*)dst) + 2, value2);
	}
}
