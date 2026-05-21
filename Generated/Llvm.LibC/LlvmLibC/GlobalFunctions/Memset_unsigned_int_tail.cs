using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Memset_unsigned_int_tail
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic6MemsetIjE4tailEPNS_3cpp4byteEhm")]
	[DemangledName("__llvm_libc_20_1_2_::generic::Memset<unsigned int>::tail(__llvm_libc_20_1_2_::cpp::byte*, unsigned char, unsigned long)")]
	public unsafe static void Invoke([NativeType("__llvm_libc_20_1_2_::cpp::byte*")] void* dst, [NativeType("unsigned char")] sbyte value, [NativeType("unsigned long")] long count)
	{
		Memset_unsigned_int_block.Invoke(unchecked((byte*)dst) + count + -4, value);
	}
}
