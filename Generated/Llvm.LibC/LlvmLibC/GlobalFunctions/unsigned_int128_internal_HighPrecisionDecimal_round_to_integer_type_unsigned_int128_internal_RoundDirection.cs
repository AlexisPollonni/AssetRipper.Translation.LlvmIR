using System;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal20HighPrecisionDecimal21round_to_integer_typeIoEET_NS0_14RoundDirectionE")]
[DemangledName("unsigned __int128 __llvm_libc_20_1_2_::internal::HighPrecisionDecimal::round_to_integer_type<unsigned __int128>(__llvm_libc_20_1_2_::internal::RoundDirection)")]
internal static partial class unsigned_int128_internal_HighPrecisionDecimal_round_to_integer_type_unsigned_int128_internal_RoundDirection
{
	public unsafe static Struct_fiz2nb Invoke(void* @this, int round)
	{
		Int128 x = default(Int128);
		int i = 0;
		llvm_lifetime_start_p0.Invoke(16L, &x);
		x = 0L;
		llvm_lifetime_start_p0.Invoke(4L, &i);
		unchecked
		{
			for (i = 0; i < ((internal_HighPrecisionDecimal*)@this)->decimal_point && (uint)i < (uint)((internal_HighPrecisionDecimal*)@this)->num_digits; i++)
			{
				x = NumericHelper.Add(NumericHelper.Multiply(x, 10L), (Int128)(UInt128)(byte)((sbyte*)(&((internal_HighPrecisionDecimal*)@this)->digits))[(uint)i]);
			}
			for (; i < ((internal_HighPrecisionDecimal*)@this)->decimal_point; i++)
			{
				x = NumericHelper.Multiply(x, 10L);
			}
			Int128 @int = NumericHelper.Add(x, (Int128)(UInt128)(internal_HighPrecisionDecimal_should_round_up_int_internal_RoundDirection.Invoke(@this, ((internal_HighPrecisionDecimal*)@this)->decimal_point, round) ? 1u : 0u));
			llvm_lifetime_end_p0.Invoke(4L, &i);
			llvm_lifetime_end_p0.Invoke(16L, &x);
			return *(Struct_fiz2nb*)(&@int);
		}
	}
}
