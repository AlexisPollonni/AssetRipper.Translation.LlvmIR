using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal20HighPrecisionDecimal5shiftEi")]
[DemangledName("__llvm_libc_20_1_2_::internal::HighPrecisionDecimal::shift(int)")]
internal static partial class internal_HighPrecisionDecimal_shift_int
{
	public unsafe static void Invoke(internal_HighPrecisionDecimal* @this, int shift_amount)
	{
		int i = shift_amount;
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
					internal_HighPrecisionDecimal_left_shift_unsigned_int.Invoke(@this, 4);
					i -= 4;
				}
				internal_HighPrecisionDecimal_left_shift_unsigned_int.Invoke(@this, i);
			}
			else
			{
				for (; (uint)i < 4294967292u; i += 4)
				{
					internal_HighPrecisionDecimal_right_shift_unsigned_int.Invoke(@this, 4);
				}
				internal_HighPrecisionDecimal_right_shift_unsigned_int.Invoke(@this, checked(-i));
			}
		}
	}
}
