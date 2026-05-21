using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPStorage_fputil_FPType_1_merge
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE1EE5mergeEjjj")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)1>::merge(unsigned int, unsigned int, unsigned int)")]
	public static int Invoke([MangledName("a")][NativeType("unsigned int")] int A, [MangledName("b")][NativeType("unsigned int")] int B, [MangledName("mask")][NativeType("unsigned int")] int Mask)
	{
		return A ^ ((A ^ B) & Mask);
	}
}
