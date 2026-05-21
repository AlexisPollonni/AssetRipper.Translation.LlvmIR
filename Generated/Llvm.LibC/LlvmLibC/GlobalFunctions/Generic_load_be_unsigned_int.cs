using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Generic_load_be_unsigned_int
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic7load_beIjEET_PKNS_3cpp4byteEm")]
	[DemangledName("unsigned int __llvm_libc_20_1_2_::generic::load_be<unsigned int>(__llvm_libc_20_1_2_::cpp::byte const*, unsigned long)")]
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke([MangledName("ptr")][NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* Ptr, [MangledName("offset")][NativeType("unsigned long")] long Offset)
	{
		return Endian_1234u_to_big_endian_unsigned_int.Invoke(Generic_load_unsigned_int.Invoke(Ptr, Offset));
	}
}
