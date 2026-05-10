using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil8internal9FPRepImplILNS0_6FPTypeE1ENS0_6FPBitsIfEEE3absEv")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)1, __llvm_libc_20_1_2_::fputil::FPBits<float>>::abs() const")]
internal static partial class fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_abs_const
{
	public unsafe static int Invoke(void* @this)
	{
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		fputil_FPBits_float_FPBits_unsigned_int_unsigned_int.Invoke(&fputil_FPBits_5nkvcs2, unchecked((fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt*)@this)->field_0 & 0x7FFFFFFF);
		return fputil_FPBits_5nkvcs2.FPRepImpl.FPRepSem.field_0.field_0;
	}
}
