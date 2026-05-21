using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class generic_neq_unsigned_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic3neqImEEjPKNS_3cpp4byteES5_m")]
	[DemangledName("unsigned int __llvm_libc_20_1_2_::generic::neq<unsigned long>(__llvm_libc_20_1_2_::cpp::byte const*, __llvm_libc_20_1_2_::cpp::byte const*, unsigned long)")]
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke([NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* p1, [NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* p2, [NativeType("unsigned long")] long offset)
	{
		return unchecked((byte)((generic_eq_unsigned_long.Invoke(p1, p2, offset) ? 1 : 0) ^ -1));
	}
}
