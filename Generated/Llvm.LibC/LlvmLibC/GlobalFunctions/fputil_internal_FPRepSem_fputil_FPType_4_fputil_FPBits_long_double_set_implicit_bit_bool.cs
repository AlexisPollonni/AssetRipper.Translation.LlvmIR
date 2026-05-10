using System;
using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal8FPRepSemILNS0_6FPTypeE4ENS0_6FPBitsIeEEE16set_implicit_bitEb")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepSem<(__llvm_libc_20_1_2_::fputil::FPType)4, __llvm_libc_20_1_2_::fputil::FPBits<long double>>::set_implicit_bit(bool)")]
internal static partial class fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_set_implicit_bit_bool
{
	public unsafe static void Invoke(void* @this, bool implicitVal)
	{
		sbyte b = (implicitVal ? ((sbyte)1) : ((sbyte)0));
		if (fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_get_implicit_bit_const.Invoke(@this) != ((b & 1) == 1))
		{
			Int128* field_ = &unchecked((fputil_internal_FPStorage_w3h7gw*)@this)->field_0;
			*field_ = NumericHelper.BitwiseXor(*field_, long.MinValue);
		}
	}
}
