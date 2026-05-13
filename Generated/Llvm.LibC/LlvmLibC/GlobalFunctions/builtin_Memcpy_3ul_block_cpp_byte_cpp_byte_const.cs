using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_7builtin6MemcpyILm3EE5blockEPNS_3cpp4byteEPKS4_")]
[DemangledName("__llvm_libc_20_1_2_::builtin::Memcpy<3ul>::block(__llvm_libc_20_1_2_::cpp::byte*, __llvm_libc_20_1_2_::cpp::byte const*)")]
internal static partial class builtin_Memcpy_3ul_block_cpp_byte_cpp_byte_const
{
	public unsafe static void Invoke(void* dst, void* src)
	{
		builtin_Memcpy_3ul_block_offset_cpp_byte_cpp_byte_const_unsigned_long.Invoke(dst, src, 0L);
	}
}
