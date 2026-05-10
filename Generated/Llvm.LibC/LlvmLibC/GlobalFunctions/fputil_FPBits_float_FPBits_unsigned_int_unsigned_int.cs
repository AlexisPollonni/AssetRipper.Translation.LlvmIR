using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil6FPBitsIfEC2IjEET_")]
[DemangledName("__llvm_libc_20_1_2_::fputil::FPBits<float>::FPBits<unsigned int>(unsigned int)")]
internal static partial class fputil_FPBits_float_FPBits_unsigned_int_unsigned_int
{
	public unsafe static void Invoke(void* @this, int x)
	{
		fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_FPRepImpl.Invoke(@this);
		unchecked((fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt*)@this)->field_0 = x;
	}
}
