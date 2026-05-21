using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Generic_eq_unsigned_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic2eqImEEbPKNS_3cpp4byteES5_m")]
	[DemangledName("bool __llvm_libc_20_1_2_::generic::eq<unsigned long>(__llvm_libc_20_1_2_::cpp::byte const*, __llvm_libc_20_1_2_::cpp::byte const*, unsigned long)")]
	[return: NativeType("bool")]
	public unsafe static bool Invoke([MangledName("p1")][NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* P1, [MangledName("p2")][NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* P2, [MangledName("offset")][NativeType("unsigned long")] long Offset)
	{
		return Generic_load_unsigned_long.Invoke(P1, Offset) == Generic_load_unsigned_long.Invoke(P2, Offset);
	}
}
