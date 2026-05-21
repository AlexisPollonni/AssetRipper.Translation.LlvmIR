using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class load_unsigned_char
{
	[MangledName("_ZN19__llvm_libc_20_1_2_4loadIhEET_PKNS_3cpp4byteE")]
	[DemangledName("unsigned char __llvm_libc_20_1_2_::load<unsigned char>(__llvm_libc_20_1_2_::cpp::byte const*)")]
	[return: NativeType("unsigned char")]
	public unsafe static sbyte Invoke([NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* ptr)
	{
		sbyte b = 0;
		llvm_lifetime_start_p0.Invoke(1L, &b);
		b = -86;
		memcpy_inline_1ul.Invoke(&b, ptr);
		sbyte result = b;
		llvm_lifetime_end_p0.Invoke(1L, &b);
		return result;
	}
}
