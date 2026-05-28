using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Generic_load_unsigned_char
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic4loadIhEET_PKNS_3cpp4byteE")]
	[DemangledName("unsigned char __llvm_libc_20_1_2_::generic::load<unsigned char>(__llvm_libc_20_1_2_::cpp::byte const*)")]
	[return: NativeType("unsigned char")]
	public unsafe static sbyte Invoke([MangledName("src")][NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* Src)
	{
		return Load_unsigned_char.Invoke(Src);
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_7generic4loadIhEET_PKNS_3cpp4byteEm")]
	[DemangledName("unsigned char __llvm_libc_20_1_2_::generic::load<unsigned char>(__llvm_libc_20_1_2_::cpp::byte const*, unsigned long)")]
	[return: NativeType("unsigned char")]
	public unsafe static sbyte Invoke([MangledName("ptr")][NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* Ptr, [MangledName("offset")][NativeType("unsigned long")] long Offset)
	{
		return Load_unsigned_char.Invoke(unchecked((byte*)Ptr) + Offset);
	}
}
