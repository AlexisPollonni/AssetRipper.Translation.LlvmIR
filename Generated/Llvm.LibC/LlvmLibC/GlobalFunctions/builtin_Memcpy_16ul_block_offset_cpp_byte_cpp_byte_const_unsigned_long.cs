using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_7builtin6MemcpyILm16EE12block_offsetEPNS_3cpp4byteEPKS4_m")]
[DemangledName("__llvm_libc_20_1_2_::builtin::Memcpy<16ul>::block_offset(__llvm_libc_20_1_2_::cpp::byte*, __llvm_libc_20_1_2_::cpp::byte const*, unsigned long)")]
internal static partial class builtin_Memcpy_16ul_block_offset_cpp_byte_cpp_byte_const_unsigned_long
{
	public unsafe static void Invoke(void* dst, void* src, long offset)
	{
		unchecked
		{
			void_memcpy_inline_16ul_void_void_const.Invoke((byte*)dst + offset, (byte*)src + offset);
		}
	}
}
