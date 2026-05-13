using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_7generic4loadItEET_PKNS_3cpp4byteE")]
[DemangledName("unsigned short __llvm_libc_20_1_2_::generic::load<unsigned short>(__llvm_libc_20_1_2_::cpp::byte const*)")]
internal static partial class unsigned_short_generic_load_unsigned_short_cpp_byte_const
{
	public unsafe static short Invoke(void* src)
	{
		return unsigned_short_load_unsigned_short_cpp_byte_const.Invoke(src);
	}
}
