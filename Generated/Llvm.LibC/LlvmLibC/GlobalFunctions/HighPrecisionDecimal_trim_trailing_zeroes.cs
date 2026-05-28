using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class HighPrecisionDecimal_trim_trailing_zeroes
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal20HighPrecisionDecimal20trim_trailing_zeroesEv")]
	[DemangledName("__llvm_libc_20_1_2_::internal::HighPrecisionDecimal::trim_trailing_zeroes()")]
	public unsafe static void Invoke([MangledName("this")] Internal_HighPrecisionDecimal* This)
	{
		unchecked
		{
			while (This->Num_digits != 0 && (byte)((sbyte*)(&This->Digits))[(uint)(This->Num_digits - 1)] == 0)
			{
				This->Num_digits += -1;
			}
			if (This->Num_digits == 0)
			{
				This->Decimal_point = 0;
			}
		}
	}
}
