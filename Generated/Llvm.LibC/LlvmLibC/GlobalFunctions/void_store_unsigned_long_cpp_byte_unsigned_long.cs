using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_5storeImEEvPNS_3cpp4byteET_")]
[DemangledName("void __llvm_libc_20_1_2_::store<unsigned long>(__llvm_libc_20_1_2_::cpp::byte*, unsigned long)")]
internal static partial class void_store_unsigned_long_cpp_byte_unsigned_long
{
	public unsafe static void Invoke(void* ptr, long value)
	{
		long num = value;
		void_memcpy_inline_8ul_void_void_const.Invoke(ptr, &num);
	}
}
