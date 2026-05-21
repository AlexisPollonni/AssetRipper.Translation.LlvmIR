using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class HighPrecisionDecimal_shift
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal20HighPrecisionDecimal5shiftEi")]
	[DemangledName("__llvm_libc_20_1_2_::internal::HighPrecisionDecimal::shift(int)")]
	public unsafe static void Invoke([MangledName("this")] Llvm_libc_20_1_2_internal_HighPrecisionDecimal* This, [MangledName("shift_amount")][NativeType("int")] int Shift_amount)
	{
		int i = Shift_amount;
		if (i == 0)
		{
			return;
		}
		unchecked
		{
			if (i > 0)
			{
				while ((uint)i > 4u)
				{
					HighPrecisionDecimal_left_shift.Invoke(This, 4);
					i -= 4;
				}
				HighPrecisionDecimal_left_shift.Invoke(This, i);
			}
			else
			{
				for (; (uint)i < 4294967292u; i += 4)
				{
					HighPrecisionDecimal_right_shift.Invoke(This, 4);
				}
				HighPrecisionDecimal_right_shift.Invoke(This, checked(-i));
			}
		}
	}
}
