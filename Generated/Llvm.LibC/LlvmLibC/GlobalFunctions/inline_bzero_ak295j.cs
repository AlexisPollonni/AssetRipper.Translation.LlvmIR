using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class inline_bzero_ak295j
{
	[MangledName("_ZN19__llvm_libc_20_1_2_L12inline_bzeroEPNS_3cpp4byteEm")]
	[DemangledName("__llvm_libc_20_1_2_::inline_bzero(__llvm_libc_20_1_2_::cpp::byte*, unsigned long)")]
	[CleanName("inline_bzero")]
	public unsafe static void Invoke([NativeType("__llvm_libc_20_1_2_::cpp::byte*")] void* dst, [NativeType("unsigned long")] long count)
	{
		inline_memset_v4bwdv.Invoke(dst, 0, count);
	}
}
