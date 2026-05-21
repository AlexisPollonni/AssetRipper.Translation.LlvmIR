using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class MemsetSequence_unsigned_char_block
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic14MemsetSequenceIhJEE5blockEPNS_3cpp4byteEh")]
	[DemangledName("__llvm_libc_20_1_2_::generic::MemsetSequence<unsigned char>::block(__llvm_libc_20_1_2_::cpp::byte*, unsigned char)")]
	public unsafe static void Invoke([NativeType("__llvm_libc_20_1_2_::cpp::byte*")] void* dst, [NativeType("unsigned char")] sbyte value)
	{
		Memset_unsigned_char_block.Invoke(dst, value);
	}
}
