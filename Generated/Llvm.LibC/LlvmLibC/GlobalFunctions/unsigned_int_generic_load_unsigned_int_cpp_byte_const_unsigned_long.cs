using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_7generic4loadIjEET_PKNS_3cpp4byteEm")]
[DemangledName("unsigned int __llvm_libc_20_1_2_::generic::load<unsigned int>(__llvm_libc_20_1_2_::cpp::byte const*, unsigned long)")]
internal static partial class unsigned_int_generic_load_unsigned_int_cpp_byte_const_unsigned_long
{
	public unsafe static int Invoke(void* ptr, long offset)
	{
		return unsigned_int_load_unsigned_int_cpp_byte_const.Invoke(unchecked((byte*)ptr) + offset);
	}
}
