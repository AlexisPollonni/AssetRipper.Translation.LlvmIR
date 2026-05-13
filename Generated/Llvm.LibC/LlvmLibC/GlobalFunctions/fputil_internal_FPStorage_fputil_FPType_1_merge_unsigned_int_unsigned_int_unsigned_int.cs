using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE1EE5mergeEjjj")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)1>::merge(unsigned int, unsigned int, unsigned int)")]
internal static partial class fputil_internal_FPStorage_fputil_FPType_1_merge_unsigned_int_unsigned_int_unsigned_int
{
	public static int Invoke(int a, int b, int mask)
	{
		return a ^ ((a ^ b) & mask);
	}
}
