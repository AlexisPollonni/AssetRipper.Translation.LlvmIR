using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_is_float_hex_start
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal18is_float_hex_startEPKcc")]
	[DemangledName("__llvm_libc_20_1_2_::internal::is_float_hex_start(char const*, char)")]
	public unsafe static bool Invoke([MangledName("src")][NativeType("char const*")] void* Src, [MangledName("decimalPoint")][NativeType("char")] sbyte DecimalPoint)
	{
		long num = 0L;
		sbyte b = DecimalPoint;
		unchecked
		{
			bool result;
			if (*(sbyte*)Src != 48 || Internal_tolower_b2645y.Invoke(((sbyte*)Src)[1]) != 120)
			{
				result = false;
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(8L, &num);
				num = 2L;
				if (((sbyte*)Src)[2] == b)
				{
					num++;
				}
				result = Internal_isalnum_eh69hd.Invoke(((sbyte*)Src)[num]) && Internal_b36_char_to_int_kxqrdt.Invoke(((sbyte*)Src)[num]) < 16;
				Llvm_lifetime_end_p0.Invoke(8L, &num);
			}
			return result;
		}
	}
}
