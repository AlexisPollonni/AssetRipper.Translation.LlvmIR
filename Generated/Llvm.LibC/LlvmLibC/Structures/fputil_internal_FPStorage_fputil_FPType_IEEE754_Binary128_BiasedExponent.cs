using System.Runtime.InteropServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 4)]
[MangledName("struct.__llvm_libc_20_1_2_::fputil::internal::FPStorage<__llvm_libc_20_1_2_::fputil::FPType::IEEE754_Binary128>::BiasedExponent")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<__llvm_libc_20_1_2_::fputil::FPType::IEEE754_Binary128>::BiasedExponent")]
public partial struct fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent
{
	[FieldOffset(0)]
	public fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt field_0;
}
