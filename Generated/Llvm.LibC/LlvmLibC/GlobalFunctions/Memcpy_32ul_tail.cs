using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Memcpy_32ul_tail
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7builtin6MemcpyILm32EE4tailEPNS_3cpp4byteEPKS4_m")]
	[DemangledName("__llvm_libc_20_1_2_::builtin::Memcpy<32ul>::tail(__llvm_libc_20_1_2_::cpp::byte*, __llvm_libc_20_1_2_::cpp::byte const*, unsigned long)")]
	public unsafe static void Invoke([NativeType("__llvm_libc_20_1_2_::cpp::byte*")] void* dst, [NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* src, [NativeType("unsigned long")] long count)
	{
		Memcpy_32ul_block_offset.Invoke(dst, src, unchecked(count - 32L));
	}
}
