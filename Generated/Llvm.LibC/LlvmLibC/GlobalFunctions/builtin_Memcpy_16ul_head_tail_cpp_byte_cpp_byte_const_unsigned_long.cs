using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_7builtin6MemcpyILm16EE9head_tailEPNS_3cpp4byteEPKS4_m")]
[DemangledName("__llvm_libc_20_1_2_::builtin::Memcpy<16ul>::head_tail(__llvm_libc_20_1_2_::cpp::byte*, __llvm_libc_20_1_2_::cpp::byte const*, unsigned long)")]
internal static partial class builtin_Memcpy_16ul_head_tail_cpp_byte_cpp_byte_const_unsigned_long
{
	public unsafe static void Invoke(void* dst, void* src, long count)
	{
		builtin_Memcpy_16ul_block_cpp_byte_cpp_byte_const.Invoke(dst, src);
		builtin_Memcpy_16ul_tail_cpp_byte_cpp_byte_const_unsigned_long.Invoke(dst, src, count);
	}
}
