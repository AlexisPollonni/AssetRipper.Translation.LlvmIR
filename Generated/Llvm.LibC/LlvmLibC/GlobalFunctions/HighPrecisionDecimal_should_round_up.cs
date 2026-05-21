using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class HighPrecisionDecimal_should_round_up
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal20HighPrecisionDecimal15should_round_upEiNS0_14RoundDirectionE")]
	[DemangledName("__llvm_libc_20_1_2_::internal::HighPrecisionDecimal::should_round_up(int, __llvm_libc_20_1_2_::internal::RoundDirection)")]
	public unsafe static bool Invoke(internal_HighPrecisionDecimal* @this, [NativeType("int")] int round_to_digit, [NativeType("__llvm_libc_20_1_2_::internal::RoundDirection")] RoundDirection_b3pcwy round)
	{
		unchecked
		{
			if (round_to_digit < 0 || (uint)round_to_digit >= (uint)@this->num_digits)
			{
				return false;
			}
			switch (round)
			{
			case RoundDirection_b3pcwy.Up:
				return true;
			case RoundDirection_b3pcwy.Down:
				return false;
			default:
				if ((byte)((sbyte*)(&@this->digits))[round_to_digit] == 5 && checked(round_to_digit + 1) == @this->num_digits)
				{
					if ((@this->truncated & 1) == 1)
					{
						return true;
					}
					if (round_to_digit == 0)
					{
						return false;
					}
					return (byte)((sbyte*)(&@this->digits))[checked(round_to_digit - 1)] % 2 != 0;
				}
				return (byte)((sbyte*)(&@this->digits))[round_to_digit] >= 5;
			}
		}
	}
}
