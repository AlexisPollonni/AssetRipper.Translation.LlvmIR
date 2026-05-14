using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_13memcpy_inlineILm2EEEvPvPKv")]
[DemangledName("void __llvm_libc_20_1_2_::memcpy_inline<2ul>(void*, void const*)")]
internal static partial class void_memcpy_inline_2ul_void_void_const
{
	public unsafe static void Invoke(void* dst, void* src)
	{
		llvm_memcpy_inline_p0_p0_i64.Invoke(dst, src, 2L, isVolatile: false);
	}
}
