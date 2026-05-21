using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class generic_eq_unsigned_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic2eqImEEbPKNS_3cpp4byteES5_m")]
	[DemangledName("bool __llvm_libc_20_1_2_::generic::eq<unsigned long>(__llvm_libc_20_1_2_::cpp::byte const*, __llvm_libc_20_1_2_::cpp::byte const*, unsigned long)")]
	[return: NativeType("bool")]
	public unsafe static bool Invoke([NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* p1, [NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* p2, [NativeType("unsigned long")] long offset)
	{
		return generic_load_unsigned_long.Invoke(p1, offset) == generic_load_unsigned_long.Invoke(p2, offset);
	}
}
