using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Memcpy_64ul_head_tail
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7builtin6MemcpyILm64EE9head_tailEPNS_3cpp4byteEPKS4_m")]
	[DemangledName("__llvm_libc_20_1_2_::builtin::Memcpy<64ul>::head_tail(__llvm_libc_20_1_2_::cpp::byte*, __llvm_libc_20_1_2_::cpp::byte const*, unsigned long)")]
	public unsafe static void Invoke([NativeType("__llvm_libc_20_1_2_::cpp::byte*")] void* dst, [NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* src, [NativeType("unsigned long")] long count)
	{
		Memcpy_64ul_block.Invoke(dst, src);
		Memcpy_64ul_tail.Invoke(dst, src, count);
	}
}
