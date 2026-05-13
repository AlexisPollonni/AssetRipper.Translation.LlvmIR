using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE2EE5mergeEmmm")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)2>::merge(unsigned long, unsigned long, unsigned long)")]
internal static partial class fputil_internal_FPStorage_fputil_FPType_2_merge_unsigned_long_unsigned_long_unsigned_long
{
	public static long Invoke(long a, long b, long mask)
	{
		return a ^ ((a ^ b) & mask);
	}
}
