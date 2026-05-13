using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_7generic5storeImEEvPNS_3cpp4byteET_")]
[DemangledName("void __llvm_libc_20_1_2_::generic::store<unsigned long>(__llvm_libc_20_1_2_::cpp::byte*, unsigned long)")]
internal static partial class void_generic_store_unsigned_long_cpp_byte_unsigned_long
{
	public unsafe static void Invoke(void* dst, long value)
	{
		void_store_unsigned_long_cpp_byte_unsigned_long.Invoke(dst, value);
	}
}
