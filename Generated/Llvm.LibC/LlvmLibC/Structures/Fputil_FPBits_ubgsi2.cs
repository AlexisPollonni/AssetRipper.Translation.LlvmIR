using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 16)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_6BigIntILm16512ELb0EmEE")]
[MangledName("struct.__llvm_libc_20_1_2_::fputil::FPBits")]
[DemangledName("__llvm_libc_20_1_2_::fputil::FPBits")]
[CleanName("Fputil_FPBits")]
public partial struct Fputil_FPBits_ubgsi2
{
	[FieldOffset(0)]
	public Fputil_internal_FPRepImpl_jrxud9 Val;
}
