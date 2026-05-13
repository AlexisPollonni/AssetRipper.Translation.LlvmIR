using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 16)]
[MangledName("struct.__llvm_libc_20_1_2_::fputil::FPBits")]
[DemangledName("__llvm_libc_20_1_2_::fputil::FPBits")]
[CleanName("fputil_FPBits")]
public partial struct fputil_FPBits_ubgsi2
{
	[FieldOffset(0)]
	public fputil_internal_FPRepImpl_jrxud9 val;
}
