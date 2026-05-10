using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal20HighPrecisionDecimal15should_round_upEiNS0_14RoundDirectionE")]
[DemangledName("__llvm_libc_20_1_2_::internal::HighPrecisionDecimal::should_round_up(int, __llvm_libc_20_1_2_::internal::RoundDirection)")]
internal static partial class internal_HighPrecisionDecimal_should_round_up_int_internal_RoundDirection
{
	public unsafe static bool Invoke(void* @this, int round_to_digit, int round)
	{
		unchecked
		{
			if (round_to_digit < 0 || (uint)round_to_digit >= (uint)((internal_HighPrecisionDecimal*)@this)->num_digits)
			{
				return false;
			}
			switch (round)
			{
			case 0:
				return true;
			case 1:
				return false;
			default:
				if ((byte)((sbyte*)(&((internal_HighPrecisionDecimal*)@this)->digits))[round_to_digit] == 5 && checked(round_to_digit + 1) == ((internal_HighPrecisionDecimal*)@this)->num_digits)
				{
					if ((((internal_HighPrecisionDecimal*)@this)->truncated & 1) == 1)
					{
						return true;
					}
					if (round_to_digit == 0)
					{
						return false;
					}
					return (byte)((sbyte*)(&((internal_HighPrecisionDecimal*)@this)->digits))[checked(round_to_digit - 1)] % 2 != 0;
				}
				return (byte)((sbyte*)(&((internal_HighPrecisionDecimal*)@this)->digits))[round_to_digit] >= 5;
			}
		}
	}
}
