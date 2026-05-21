using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llvm_libc_20_1_2_inline_bzero_u3zpr6
{
	[MangledName("_ZN19__llvm_libc_20_1_2_L12inline_bzeroEPNS_3cpp4byteEm.203")]
	[DemangledName("__llvm_libc_20_1_2_::inline_bzero(__llvm_libc_20_1_2_::cpp::byte*, unsigned long) (.203)")]
	[CleanName("Llvm_libc_20_1_2_inline_bzero")]
	public unsafe static void Invoke([MangledName("dst")][NativeType("__llvm_libc_20_1_2_::cpp::byte*")] void* Dst, [MangledName("count")][NativeType("unsigned long")] long Count)
	{
		Llvm_libc_20_1_2_inline_memset_t7nzzw.Invoke(Dst, 0, Count);
	}
}
