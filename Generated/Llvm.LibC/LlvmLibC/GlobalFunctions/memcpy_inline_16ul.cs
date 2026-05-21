using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class memcpy_inline_16ul
{
	[MangledName("_ZN19__llvm_libc_20_1_2_13memcpy_inlineILm16EEEvPvPKv")]
	[DemangledName("void __llvm_libc_20_1_2_::memcpy_inline<16ul>(void*, void const*)")]
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("void*")] void* dst, [NativeType("void const*")] void* src)
	{
		llvm_memcpy_inline_p0_p0_i64.Invoke(dst, src, 16L, isVolatile: false);
	}
}
