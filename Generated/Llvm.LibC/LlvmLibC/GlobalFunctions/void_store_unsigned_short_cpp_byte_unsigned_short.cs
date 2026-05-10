using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_5storeItEEvPNS_3cpp4byteET_")]
[DemangledName("void __llvm_libc_20_1_2_::store<unsigned short>(__llvm_libc_20_1_2_::cpp::byte*, unsigned short)")]
internal static partial class void_store_unsigned_short_cpp_byte_unsigned_short
{
	public unsafe static void Invoke(void* ptr, short value)
	{
		short num = value;
		void_memcpy_inline_2ul_void_void_const.Invoke(ptr, &num);
	}
}
