using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class inline_bzero_s6t36y
{
	[MangledName("_ZN19__llvm_libc_20_1_2_L12inline_bzeroEPvm.202")]
	[DemangledName("__llvm_libc_20_1_2_::inline_bzero(void*, unsigned long) (.202)")]
	[CleanName("inline_bzero")]
	public unsafe static void Invoke([NativeType("void*")] void* dst, [NativeType("unsigned long")] long count)
	{
		inline_bzero_u3zpr6.Invoke(dst, count);
	}
}
