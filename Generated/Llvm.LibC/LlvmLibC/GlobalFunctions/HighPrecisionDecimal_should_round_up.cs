using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class HighPrecisionDecimal_should_round_up
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal20HighPrecisionDecimal15should_round_upEiNS0_14RoundDirectionE")]
	[DemangledName("__llvm_libc_20_1_2_::internal::HighPrecisionDecimal::should_round_up(int, __llvm_libc_20_1_2_::internal::RoundDirection)")]
	public unsafe static bool Invoke([MangledName("this")] Internal_HighPrecisionDecimal* This, [MangledName("round_to_digit")][NativeType("int")] int Round_to_digit, [MangledName("round")][NativeType("__llvm_libc_20_1_2_::internal::RoundDirection")] RoundDirection_b3pcwy Round)
	{
		unchecked
		{
			if (Round_to_digit < 0 || (uint)Round_to_digit >= (uint)This->Num_digits)
			{
				return false;
			}
			switch (Round)
			{
			case RoundDirection_b3pcwy.Up:
				return true;
			case RoundDirection_b3pcwy.Down:
				return false;
			default:
				if ((byte)((sbyte*)(&This->Digits))[Round_to_digit] == 5 && checked(Round_to_digit + 1) == This->Num_digits)
				{
					if ((This->Truncated & 1) == 1)
					{
						return true;
					}
					if (Round_to_digit == 0)
					{
						return false;
					}
					return (byte)((sbyte*)(&This->Digits))[checked(Round_to_digit - 1)] % 2 != 0;
				}
				return (byte)((sbyte*)(&This->Digits))[Round_to_digit] >= 5;
			}
		}
	}
}
