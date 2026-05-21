using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Memset_unsigned_long_tail
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic6MemsetImE4tailEPNS_3cpp4byteEhm")]
	[DemangledName("__llvm_libc_20_1_2_::generic::Memset<unsigned long>::tail(__llvm_libc_20_1_2_::cpp::byte*, unsigned char, unsigned long)")]
	public unsafe static void Invoke([MangledName("dst")][NativeType("__llvm_libc_20_1_2_::cpp::byte*")] void* Dst, [MangledName("value")][NativeType("unsigned char")] sbyte Value, [MangledName("count")][NativeType("unsigned long")] long Count)
	{
		Memset_unsigned_long_block.Invoke(unchecked((byte*)Dst) + Count + -8, Value);
	}
}
