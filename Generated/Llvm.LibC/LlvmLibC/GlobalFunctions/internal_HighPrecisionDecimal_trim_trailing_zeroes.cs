using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal20HighPrecisionDecimal20trim_trailing_zeroesEv")]
[DemangledName("__llvm_libc_20_1_2_::internal::HighPrecisionDecimal::trim_trailing_zeroes()")]
internal static partial class internal_HighPrecisionDecimal_trim_trailing_zeroes
{
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			while (((internal_HighPrecisionDecimal*)@this)->num_digits != 0 && (byte)((sbyte*)(&((internal_HighPrecisionDecimal*)@this)->digits))[(uint)(((internal_HighPrecisionDecimal*)@this)->num_digits - 1)] == 0)
			{
				((internal_HighPrecisionDecimal*)@this)->num_digits += -1;
			}
			if (((internal_HighPrecisionDecimal*)@this)->num_digits == 0)
			{
				((internal_HighPrecisionDecimal*)@this)->decimal_point = 0;
			}
		}
	}
}
