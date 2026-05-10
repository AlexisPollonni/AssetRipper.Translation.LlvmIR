using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE1EE8TypedIntIiEC2Ei")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)1>::TypedInt<int>::TypedInt(int)")]
internal static partial class fputil_internal_FPStorage_fputil_FPType_1_TypedInt_int_TypedInt_int
{
	public unsafe static void Invoke(void* @this, int value)
	{
		unchecked((fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt*)@this)->field_0 = value;
	}
}
