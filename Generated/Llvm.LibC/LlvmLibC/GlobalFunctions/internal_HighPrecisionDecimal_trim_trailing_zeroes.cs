using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal20HighPrecisionDecimal20trim_trailing_zeroesEv")]
[DemangledName("__llvm_libc_20_1_2_::internal::HighPrecisionDecimal::trim_trailing_zeroes()")]
internal static partial class internal_HighPrecisionDecimal_trim_trailing_zeroes
{
	public unsafe static void Invoke(internal_HighPrecisionDecimal* @this)
	{
		unchecked
		{
			while (@this->num_digits != 0 && (byte)((sbyte*)(&@this->digits))[(uint)(@this->num_digits - 1)] == 0)
			{
				@this->num_digits += -1;
			}
			if (@this->num_digits == 0)
			{
				@this->decimal_point = 0;
			}
		}
	}
}
