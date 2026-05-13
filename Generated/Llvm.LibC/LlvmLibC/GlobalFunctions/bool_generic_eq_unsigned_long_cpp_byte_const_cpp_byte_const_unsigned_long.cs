using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_7generic2eqImEEbPKNS_3cpp4byteES5_m")]
[DemangledName("bool __llvm_libc_20_1_2_::generic::eq<unsigned long>(__llvm_libc_20_1_2_::cpp::byte const*, __llvm_libc_20_1_2_::cpp::byte const*, unsigned long)")]
internal static partial class bool_generic_eq_unsigned_long_cpp_byte_const_cpp_byte_const_unsigned_long
{
	public unsafe static bool Invoke(void* p1, void* p2, long offset)
	{
		return unsigned_long_generic_load_unsigned_long_cpp_byte_const_unsigned_long.Invoke(p1, offset) == unsigned_long_generic_load_unsigned_long_cpp_byte_const_unsigned_long.Invoke(p2, offset);
	}
}
