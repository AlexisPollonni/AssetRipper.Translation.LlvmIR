using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_7generic5storeItEEvPNS_3cpp4byteET_")]
[DemangledName("void __llvm_libc_20_1_2_::generic::store<unsigned short>(__llvm_libc_20_1_2_::cpp::byte*, unsigned short)")]
internal static partial class void_generic_store_unsigned_short_cpp_byte_unsigned_short
{
	public unsafe static void Invoke(void* dst, short value)
	{
		void_store_unsigned_short_cpp_byte_unsigned_short.Invoke(dst, value);
	}
}
