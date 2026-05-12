using LlvmLibC.Enumerations;
using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core19get_round_directionEibNS_4SignE")]
[DemangledName("__llvm_libc_20_1_2_::printf_core::get_round_direction(int, bool, __llvm_libc_20_1_2_::Sign)")]
internal static partial class printf_core_get_round_direction_int_bool_Sign
{
	public unsafe static RoundDirection_zvveyk Invoke(int last_digit, bool truncated, [MangledName("sign.coerce")] sbyte sign)
	{
		anon_izyfb7 anon_izyfb8 = new anon_izyfb7
		{
			val = sign
		};
		sbyte b = (truncated ? ((sbyte)1) : ((sbyte)0));
		unchecked
		{
			switch (fputil_quick_get_round.Invoke())
			{
			case 0:
				if (last_digit != 5)
				{
					return (RoundDirection_zvveyk)InstructionHelper.Select(last_digit > 5, 0, 1);
				}
				return (RoundDirection_zvveyk)InstructionHelper.Select((byte)((((b & 1) == 1) ? 1u : 0u) ^ 0xFFFFFFFFu) != 0, 2, 0);
			case 1024:
				if (Sign_is_neg_const.Invoke(&anon_izyfb8) && ((b & 1) == 1 || last_digit > 0))
				{
					return RoundDirection_zvveyk.Up;
				}
				return RoundDirection_zvveyk.Down;
			case 2048:
				if (Sign_is_pos_const.Invoke(&anon_izyfb8) && ((b & 1) == 1 || last_digit > 0))
				{
					return RoundDirection_zvveyk.Up;
				}
				return RoundDirection_zvveyk.Down;
			case 3072:
				return RoundDirection_zvveyk.Down;
			default:
				return RoundDirection_zvveyk.Down;
			}
		}
	}
}
