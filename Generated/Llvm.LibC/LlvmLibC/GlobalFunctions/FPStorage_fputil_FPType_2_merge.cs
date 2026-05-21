using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPStorage_fputil_FPType_2_merge
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE2EE5mergeEmmm")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)2>::merge(unsigned long, unsigned long, unsigned long)")]
	public static long Invoke([MangledName("a")][NativeType("unsigned long")] long A, [MangledName("b")][NativeType("unsigned long")] long B, [MangledName("mask")][NativeType("unsigned long")] long Mask)
	{
		return A ^ ((A ^ B) & Mask);
	}
}
