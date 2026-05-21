using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Memset_unsigned_int_head_tail
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic6MemsetIjE9head_tailEPNS_3cpp4byteEhm")]
	[DemangledName("__llvm_libc_20_1_2_::generic::Memset<unsigned int>::head_tail(__llvm_libc_20_1_2_::cpp::byte*, unsigned char, unsigned long)")]
	public unsafe static void Invoke([MangledName("dst")][NativeType("__llvm_libc_20_1_2_::cpp::byte*")] void* Dst, [MangledName("value")][NativeType("unsigned char")] sbyte Value, [MangledName("count")][NativeType("unsigned long")] long Count)
	{
		sbyte value = Value;
		Memset_unsigned_int_block.Invoke(Dst, value);
		Memset_unsigned_int_tail.Invoke(Dst, value, Count);
	}
}
