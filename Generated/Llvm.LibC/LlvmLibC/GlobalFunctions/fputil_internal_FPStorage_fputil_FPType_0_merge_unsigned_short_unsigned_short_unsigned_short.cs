using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE0EE5mergeEttt")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)0>::merge(unsigned short, unsigned short, unsigned short)")]
internal static partial class fputil_internal_FPStorage_fputil_FPType_0_merge_unsigned_short_unsigned_short_unsigned_short
{
	public static short Invoke(short a, short b, short mask)
	{
		short num = a;
		return unchecked((short)((ushort)num ^ (((ushort)num ^ (ushort)b) & (ushort)mask)));
	}
}
