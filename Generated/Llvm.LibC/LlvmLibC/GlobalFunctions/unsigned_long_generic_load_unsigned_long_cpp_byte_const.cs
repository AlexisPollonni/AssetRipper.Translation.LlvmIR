using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_7generic4loadImEET_PKNS_3cpp4byteE")]
[DemangledName("unsigned long __llvm_libc_20_1_2_::generic::load<unsigned long>(__llvm_libc_20_1_2_::cpp::byte const*)")]
internal static partial class unsigned_long_generic_load_unsigned_long_cpp_byte_const
{
	public unsafe static long Invoke(void* src)
	{
		return unsigned_long_load_unsigned_long_cpp_byte_const.Invoke(src);
	}
}
