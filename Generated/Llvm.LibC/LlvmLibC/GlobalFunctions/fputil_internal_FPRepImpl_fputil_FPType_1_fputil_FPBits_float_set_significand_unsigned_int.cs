using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPRepImplILNS0_6FPTypeE1ENS0_6FPBitsIfEEE15set_significandEj")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)1, __llvm_libc_20_1_2_::fputil::FPBits<float>>::set_significand(unsigned int)")]
internal static partial class fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_set_significand_unsigned_int
{
	public unsafe static void Invoke(void* @this, int sigVal)
	{
		unchecked
		{
			((fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt*)@this)->field_0 = fputil_internal_FPStorage_fputil_FPType_1_merge_unsigned_int_unsigned_int_unsigned_int.Invoke(((fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt*)@this)->field_0, sigVal, 8388607);
		}
	}
}
