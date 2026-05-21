using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class generic_load_be_unsigned_int
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic7load_beIjEET_PKNS_3cpp4byteEm")]
	[DemangledName("unsigned int __llvm_libc_20_1_2_::generic::load_be<unsigned int>(__llvm_libc_20_1_2_::cpp::byte const*, unsigned long)")]
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke([NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* ptr, [NativeType("unsigned long")] long offset)
	{
		return Endian_1234u_to_big_endian_unsigned_int.Invoke(generic_load_unsigned_int.Invoke(ptr, offset));
	}
}
