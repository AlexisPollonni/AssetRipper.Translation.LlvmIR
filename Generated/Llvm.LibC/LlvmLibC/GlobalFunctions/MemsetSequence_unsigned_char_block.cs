using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class MemsetSequence_unsigned_char_block
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic14MemsetSequenceIhJEE5blockEPNS_3cpp4byteEh")]
	[DemangledName("__llvm_libc_20_1_2_::generic::MemsetSequence<unsigned char>::block(__llvm_libc_20_1_2_::cpp::byte*, unsigned char)")]
	public unsafe static void Invoke([MangledName("dst")][NativeType("__llvm_libc_20_1_2_::cpp::byte*")] void* Dst, [MangledName("value")][NativeType("unsigned char")] sbyte Value)
	{
		Memset_unsigned_char_block.Invoke(Dst, Value);
	}
}
