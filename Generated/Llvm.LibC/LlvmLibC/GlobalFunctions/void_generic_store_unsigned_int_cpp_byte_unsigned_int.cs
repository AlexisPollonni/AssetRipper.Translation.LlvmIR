using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_7generic5storeIjEEvPNS_3cpp4byteET_")]
[DemangledName("void __llvm_libc_20_1_2_::generic::store<unsigned int>(__llvm_libc_20_1_2_::cpp::byte*, unsigned int)")]
internal static partial class void_generic_store_unsigned_int_cpp_byte_unsigned_int
{
	public unsafe static void Invoke(void* dst, int value)
	{
		void_store_unsigned_int_cpp_byte_unsigned_int.Invoke(dst, value);
	}
}
