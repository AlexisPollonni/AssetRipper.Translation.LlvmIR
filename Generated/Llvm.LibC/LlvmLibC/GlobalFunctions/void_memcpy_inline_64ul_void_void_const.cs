using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Unimplemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_13memcpy_inlineILm64EEEvPvPKv")]
[DemangledName("void __llvm_libc_20_1_2_::memcpy_inline<64ul>(void*, void const*)")]
internal static partial class void_memcpy_inline_64ul_void_void_const
{
	public unsafe static void Invoke(void* dst, void* src)
	{
		llvm_memcpy_inline_p0_p0_i64.Invoke(dst, src, 64L, parameter_3: false);
	}
}
