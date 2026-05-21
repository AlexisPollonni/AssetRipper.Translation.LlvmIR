using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class generic_neq_unsigned_int
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic3neqIjEEjPKNS_3cpp4byteES5_m")]
	[DemangledName("unsigned int __llvm_libc_20_1_2_::generic::neq<unsigned int>(__llvm_libc_20_1_2_::cpp::byte const*, __llvm_libc_20_1_2_::cpp::byte const*, unsigned long)")]
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke([NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* p1, [NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* p2, [NativeType("unsigned long")] long offset)
	{
		return generic_load_unsigned_int.Invoke(p1, offset) ^ generic_load_unsigned_int.Invoke(p2, offset);
	}
}
