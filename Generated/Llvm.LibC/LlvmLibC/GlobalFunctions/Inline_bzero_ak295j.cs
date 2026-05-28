using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Inline_bzero_ak295j
{
	[MangledName("_ZN19__llvm_libc_20_1_2_L12inline_bzeroEPNS_3cpp4byteEm")]
	[DemangledName("__llvm_libc_20_1_2_::inline_bzero(__llvm_libc_20_1_2_::cpp::byte*, unsigned long)")]
	[CleanName("Inline_bzero")]
	public unsafe static void Invoke([MangledName("dst")][NativeType("__llvm_libc_20_1_2_::cpp::byte*")] void* Dst, [MangledName("count")][NativeType("unsigned long")] long Count)
	{
		Inline_memset_v4bwdv.Invoke(Dst, 0, Count);
	}
}
