using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil8internal8FPRepSemILNS0_6FPTypeE4ENS0_6FPBitsIeEEE16get_implicit_bitEv")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepSem<(__llvm_libc_20_1_2_::fputil::FPType)4, __llvm_libc_20_1_2_::fputil::FPBits<long double>>::get_implicit_bit() const")]
internal static partial class fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_get_implicit_bit_const
{
	public unsafe static bool Invoke(void* @this)
	{
		return NumericHelper.IntCmpNe(NumericHelper.BitwiseAnd(unchecked((fputil_internal_FPStorage_w3h7gw*)@this)->field_0, long.MinValue), 0L);
	}
}
