using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPRepImplILNS0_6FPTypeE2ENS0_6FPBitsIdEEE12set_mantissaEm")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)2, __llvm_libc_20_1_2_::fputil::FPBits<double>>::set_mantissa(unsigned long)")]
internal static partial class fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_set_mantissa_unsigned_long
{
	public unsafe static void Invoke(fputil_internal_FPRepImpl_ucubaq* @this, long mantVal)
	{
		unchecked
		{
			((fputil_internal_FPStorage_v3nexn*)@this)->val = fputil_internal_FPStorage_fputil_FPType_2_merge_unsigned_long_unsigned_long_unsigned_long.Invoke(((fputil_internal_FPStorage_v3nexn*)@this)->val, mantVal, 4503599627370495L);
		}
	}
}
