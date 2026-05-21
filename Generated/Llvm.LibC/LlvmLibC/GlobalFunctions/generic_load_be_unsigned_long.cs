using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class generic_load_be_unsigned_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic7load_beImEET_PKNS_3cpp4byteEm")]
	[DemangledName("unsigned long __llvm_libc_20_1_2_::generic::load_be<unsigned long>(__llvm_libc_20_1_2_::cpp::byte const*, unsigned long)")]
	[return: NativeType("unsigned long")]
	public unsafe static long Invoke([NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* ptr, [NativeType("unsigned long")] long offset)
	{
		return Endian_1234u_to_big_endian_unsigned_long.Invoke(generic_load_unsigned_long.Invoke(ptr, offset));
	}
}
