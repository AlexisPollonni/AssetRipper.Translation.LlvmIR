using System;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9normalizeIeEEvRiRNS0_6FPBitsIT_E11StorageTypeE")]
[DemangledName("void __llvm_libc_20_1_2_::fputil::internal::normalize<long double>(int&, __llvm_libc_20_1_2_::fputil::FPBits<long double>::StorageType&)")]
internal static partial class void_fputil_internal_normalize_long_double_int_fputil_FPBits_long_double_StorageType
{
	public unsafe static void Invoke(void* exponent, void* mantissa)
	{
		int num = 0;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		Int128 @int = *unchecked((Int128*)mantissa);
		num = unchecked(cpp_enable_if_cpp_is_unsigned_v_unsigned_int128_int_type_cpp_countl_zero_unsigned_int128_unsigned_int128.Invoke(*(long*)(&@int), ((long*)(&@int))[1])) - 64;
		*unchecked((int*)exponent) -= num;
		int num2 = num;
		unchecked
		{
			*(Int128*)mantissa = NumericHelper.ShiftLeft(*(Int128*)mantissa, (Int128)(UInt128)(uint)num2);
			llvm_lifetime_end_p0.Invoke(4L, &num);
		}
	}
}
