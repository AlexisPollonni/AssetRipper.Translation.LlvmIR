using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_5storeIhEEvPNS_3cpp4byteET_")]
[DemangledName("void __llvm_libc_20_1_2_::store<unsigned char>(__llvm_libc_20_1_2_::cpp::byte*, unsigned char)")]
internal static partial class void_store_unsigned_char_cpp_byte_unsigned_char
{
	public unsafe static void Invoke(void* ptr, sbyte value)
	{
		sbyte b = value;
		void_memcpy_inline_1ul_void_void_const.Invoke(ptr, &b);
	}
}
