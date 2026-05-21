using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Generic_branchless_head_tail_neq_unsigned_int
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic24branchless_head_tail_neqIjEEjPKNS_3cpp4byteES5_m")]
	[DemangledName("unsigned int __llvm_libc_20_1_2_::generic::branchless_head_tail_neq<unsigned int>(__llvm_libc_20_1_2_::cpp::byte const*, __llvm_libc_20_1_2_::cpp::byte const*, unsigned long)")]
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke([MangledName("p1")][NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* P1, [MangledName("p2")][NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* P2, [MangledName("count")][NativeType("unsigned long")] long Count)
	{
		return Generic_neq_unsigned_int.Invoke(P1, P2, 0L) | Generic_neq_unsigned_int.Invoke(P1, P2, unchecked(Count - 4L));
	}
}
