using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 4)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_6fputil8internal9FPRepImplILNS0_6FPTypeE1ENS0_6FPBitsIfEEEE")]
[MangledName("struct.__llvm_libc_20_1_2_::fputil::internal::FPRepImpl.1")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl")]
[CleanName("Llvm_libc_20_1_2_fputil_internal_FPRepImpl")]
public partial struct Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm
{
	[FieldOffset(0)]
	public Llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent FPRepSem;
}
