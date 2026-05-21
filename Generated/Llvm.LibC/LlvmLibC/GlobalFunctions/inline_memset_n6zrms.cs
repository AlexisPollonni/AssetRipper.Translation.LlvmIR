using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class inline_memset_n6zrms
{
	[MangledName("_ZN19__llvm_libc_20_1_2_L13inline_memsetEPvhm.163")]
	[DemangledName("__llvm_libc_20_1_2_::inline_memset(void*, unsigned char, unsigned long) (.163)")]
	[CleanName("inline_memset")]
	public unsafe static void Invoke([NativeType("void*")] void* dst, [NativeType("unsigned char")] sbyte value, [NativeType("unsigned long")] long count)
	{
		inline_memset_x86_n8av5f.Invoke(dst, value, count);
	}
}
