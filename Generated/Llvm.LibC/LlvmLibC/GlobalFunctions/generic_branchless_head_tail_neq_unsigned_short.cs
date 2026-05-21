using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class generic_branchless_head_tail_neq_unsigned_short
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic24branchless_head_tail_neqItEEjPKNS_3cpp4byteES5_m")]
	[DemangledName("unsigned int __llvm_libc_20_1_2_::generic::branchless_head_tail_neq<unsigned short>(__llvm_libc_20_1_2_::cpp::byte const*, __llvm_libc_20_1_2_::cpp::byte const*, unsigned long)")]
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke([NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* p1, [NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* p2, [NativeType("unsigned long")] long count)
	{
		return generic_neq_unsigned_short.Invoke(p1, p2, 0L) | generic_neq_unsigned_short.Invoke(p1, p2, unchecked(count - 2L));
	}
}
