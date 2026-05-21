using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPStorage_fputil_FPType_0_merge
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE0EE5mergeEttt")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)0>::merge(unsigned short, unsigned short, unsigned short)")]
	public static short Invoke([NativeType("unsigned short")] short a, [NativeType("unsigned short")] short b, [NativeType("unsigned short")] short mask)
	{
		short num = a;
		return unchecked((short)((ushort)num ^ (((ushort)num ^ (ushort)b) & (ushort)mask)));
	}
}
