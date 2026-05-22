using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Printf_core_get_round_direction
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core19get_round_directionEibNS_4SignE")]
	[DemangledName("__llvm_libc_20_1_2_::printf_core::get_round_direction(int, bool, __llvm_libc_20_1_2_::Sign)")]
	public unsafe static RoundDirection_zvveyk Invoke([MangledName("last_digit")][NativeType("int")] int Last_digit, [MangledName("truncated")][NativeType("bool")] bool Truncated, [MangledName("sign.coerce")][NativeType("__llvm_libc_20_1_2_::Sign")] sbyte Sign)
	{
		Anon_izyfb7 anon_izyfb = new Anon_izyfb7
		{
			Val = Sign
		};
		sbyte b = (Truncated ? ((sbyte)1) : ((sbyte)0));
		unchecked
		{
			switch (Fputil_quick_get_round.Invoke())
			{
			case 0:
				if (Last_digit != 5)
				{
					return (RoundDirection_zvveyk)InstructionHelper.Select(Last_digit > 5, 0, 1);
				}
				return (RoundDirection_zvveyk)InstructionHelper.Select(InstructionHelper.BooleanXor((b & 1) == 1, right: true), 2, 0);
			case 1024:
				if (Sign_is_neg.Invoke(&anon_izyfb) && ((b & 1) == 1 || Last_digit > 0))
				{
					return RoundDirection_zvveyk.Up;
				}
				return RoundDirection_zvveyk.Down;
			case 2048:
				if (Sign_is_pos.Invoke(&anon_izyfb) && ((b & 1) == 1 || Last_digit > 0))
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
