using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_7generic7MemmoveItE5blockEPNS_3cpp4byteEPKS4_")]
[DemangledName("__llvm_libc_20_1_2_::generic::Memmove<unsigned short>::block(__llvm_libc_20_1_2_::cpp::byte*, __llvm_libc_20_1_2_::cpp::byte const*)")]
internal static partial class generic_Memmove_unsigned_short_block_cpp_byte_cpp_byte_const
{
	public unsafe static void Invoke(void* dst, void* src)
	{
		void_generic_store_unsigned_short_cpp_byte_unsigned_short.Invoke(dst, unsigned_short_generic_load_unsigned_short_cpp_byte_const.Invoke(src));
	}
}
