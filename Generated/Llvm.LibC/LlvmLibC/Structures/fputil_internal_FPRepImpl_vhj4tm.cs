using System.Runtime.InteropServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 4)]
[MangledName("struct.__llvm_libc_20_1_2_::fputil::internal::FPRepImpl.1")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl")]
[CleanName("fputil_internal_FPRepImpl")]
public partial struct fputil_internal_FPRepImpl_vhj4tm
{
	[FieldOffset(0)]
	public fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent FPRepSem;
}
