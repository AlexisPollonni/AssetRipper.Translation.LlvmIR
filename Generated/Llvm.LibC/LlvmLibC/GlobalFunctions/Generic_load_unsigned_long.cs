using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Generic_load_unsigned_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic4loadImEET_PKNS_3cpp4byteE")]
	[DemangledName("unsigned long __llvm_libc_20_1_2_::generic::load<unsigned long>(__llvm_libc_20_1_2_::cpp::byte const*)")]
	[return: NativeType("unsigned long")]
	public unsafe static long Invoke([MangledName("src")][NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* Src)
	{
		return Llvm_libc_20_1_2_load_unsigned_long.Invoke(Src);
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_7generic4loadImEET_PKNS_3cpp4byteEm")]
	[DemangledName("unsigned long __llvm_libc_20_1_2_::generic::load<unsigned long>(__llvm_libc_20_1_2_::cpp::byte const*, unsigned long)")]
	[return: NativeType("unsigned long")]
	public unsafe static long Invoke([MangledName("ptr")][NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* Ptr, [MangledName("offset")][NativeType("unsigned long")] long Offset)
	{
		return Llvm_libc_20_1_2_load_unsigned_long.Invoke(unchecked((byte*)Ptr) + Offset);
	}
}
