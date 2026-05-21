using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class inline_memset_rivytf
{
	[MangledName("_ZN19__llvm_libc_20_1_2_L13inline_memsetEPvhm.206")]
	[DemangledName("__llvm_libc_20_1_2_::inline_memset(void*, unsigned char, unsigned long) (.206)")]
	[CleanName("inline_memset")]
	public unsafe static void Invoke([NativeType("void*")] void* dst, [NativeType("unsigned char")] sbyte value, [NativeType("unsigned long")] long count)
	{
		inline_memset_x86_9epiy5.Invoke(dst, value, count);
	}
}
