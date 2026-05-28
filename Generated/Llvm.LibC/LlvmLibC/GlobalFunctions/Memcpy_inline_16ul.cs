using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Memcpy_inline_16ul
{
	[MangledName("_ZN19__llvm_libc_20_1_2_13memcpy_inlineILm16EEEvPvPKv")]
	[DemangledName("void __llvm_libc_20_1_2_::memcpy_inline<16ul>(void*, void const*)")]
	[return: NativeType("void")]
	public unsafe static void Invoke([MangledName("dst")][NativeType("void*")] void* Dst, [MangledName("src")][NativeType("void const*")] void* Src)
	{
		Llvm_memcpy_inline_p0_p0_i64.Invoke(Dst, Src, 16L, isVolatile: false);
	}
}
