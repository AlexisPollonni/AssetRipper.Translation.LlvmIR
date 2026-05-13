using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_5storeIjEEvPNS_3cpp4byteET_")]
[DemangledName("void __llvm_libc_20_1_2_::store<unsigned int>(__llvm_libc_20_1_2_::cpp::byte*, unsigned int)")]
internal static partial class void_store_unsigned_int_cpp_byte_unsigned_int
{
	public unsafe static void Invoke(void* ptr, int value)
	{
		int num = value;
		void_memcpy_inline_4ul_void_void_const.Invoke(ptr, &num);
	}
}
