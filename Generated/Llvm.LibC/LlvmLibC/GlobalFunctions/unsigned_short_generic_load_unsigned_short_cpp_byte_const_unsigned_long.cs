using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_7generic4loadItEET_PKNS_3cpp4byteEm")]
[DemangledName("unsigned short __llvm_libc_20_1_2_::generic::load<unsigned short>(__llvm_libc_20_1_2_::cpp::byte const*, unsigned long)")]
internal static partial class unsigned_short_generic_load_unsigned_short_cpp_byte_const_unsigned_long
{
	public unsafe static short Invoke(void* ptr, long offset)
	{
		return unsigned_short_load_unsigned_short_cpp_byte_const.Invoke(unchecked((byte*)ptr) + offset);
	}
}
