using LlvmLibC.Enumerations;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal20HighPrecisionDecimal21round_to_integer_typeIjEET_NS0_14RoundDirectionE")]
[DemangledName("unsigned int __llvm_libc_20_1_2_::internal::HighPrecisionDecimal::round_to_integer_type<unsigned int>(__llvm_libc_20_1_2_::internal::RoundDirection)")]
internal static partial class unsigned_int_internal_HighPrecisionDecimal_round_to_integer_type_unsigned_int_internal_RoundDirection
{
	public unsafe static int Invoke(internal_HighPrecisionDecimal* @this, RoundDirection_b3pcwy round)
	{
		int num = 0;
		int i = 0;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = 0;
		llvm_lifetime_start_p0.Invoke(4L, &i);
		unchecked
		{
			for (i = 0; i < @this->decimal_point && (uint)i < (uint)@this->num_digits; i++)
			{
				num = num * 10 + (byte)((sbyte*)(&@this->digits))[(uint)i];
			}
			for (; i < @this->decimal_point; i++)
			{
				num *= 10;
			}
			int result = num + (internal_HighPrecisionDecimal_should_round_up_int_internal_RoundDirection.Invoke(@this, @this->decimal_point, round) ? 1 : 0);
			llvm_lifetime_end_p0.Invoke(4L, &i);
			llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}
