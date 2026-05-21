using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llvm_libc_20_1_2_load_unsigned_char
{
	[MangledName("_ZN19__llvm_libc_20_1_2_4loadIhEET_PKNS_3cpp4byteE")]
	[DemangledName("unsigned char __llvm_libc_20_1_2_::load<unsigned char>(__llvm_libc_20_1_2_::cpp::byte const*)")]
	[return: NativeType("unsigned char")]
	public unsafe static sbyte Invoke([MangledName("ptr")][NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* Ptr)
	{
		sbyte b = 0;
		Llvm_lifetime_start_p0.Invoke(1L, &b);
		b = -86;
		Llvm_libc_20_1_2_memcpy_inline_1ul.Invoke(&b, Ptr);
		sbyte result = b;
		Llvm_lifetime_end_p0.Invoke(1L, &b);
		return result;
	}
}
