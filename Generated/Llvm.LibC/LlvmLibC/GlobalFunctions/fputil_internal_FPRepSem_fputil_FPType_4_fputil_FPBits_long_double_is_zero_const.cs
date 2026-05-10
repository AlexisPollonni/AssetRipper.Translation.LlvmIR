using System;
using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil8internal8FPRepSemILNS0_6FPTypeE4ENS0_6FPBitsIeEEE7is_zeroEv")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepSem<(__llvm_libc_20_1_2_::fputil::FPType)4, __llvm_libc_20_1_2_::fputil::FPBits<long double>>::is_zero() const")]
internal static partial class fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_zero_const
{
	public unsafe static bool Invoke(void* @this)
	{
		Int128 x = default(Int128);
		Struct_fiz2nb struct_fiz2nb = fputil_internal_FPStorage_fputil_FPType_4_exp_sig_bits_const.Invoke(@this);
		Int128* num = &x;
		Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
		unchecked
		{
			*(long*)num = struct_fiz2nb2.field_0;
			byte* num2 = (byte*)(&x) + 8u;
			Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
			*(long*)num2 = struct_fiz2nb3.field_1;
			return NumericHelper.IntCmpEq(x, 0L);
		}
	}
}
