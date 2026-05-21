using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class generic_load_unsigned_char
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic4loadIhEET_PKNS_3cpp4byteE")]
	[DemangledName("unsigned char __llvm_libc_20_1_2_::generic::load<unsigned char>(__llvm_libc_20_1_2_::cpp::byte const*)")]
	[return: NativeType("unsigned char")]
	public unsafe static sbyte Invoke([NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* src)
	{
		return load_unsigned_char.Invoke(src);
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_7generic4loadIhEET_PKNS_3cpp4byteEm")]
	[DemangledName("unsigned char __llvm_libc_20_1_2_::generic::load<unsigned char>(__llvm_libc_20_1_2_::cpp::byte const*, unsigned long)")]
	[return: NativeType("unsigned char")]
	public unsafe static sbyte Invoke([NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* ptr, [NativeType("unsigned long")] long offset)
	{
		return load_unsigned_char.Invoke(unchecked((byte*)ptr) + offset);
	}
}
