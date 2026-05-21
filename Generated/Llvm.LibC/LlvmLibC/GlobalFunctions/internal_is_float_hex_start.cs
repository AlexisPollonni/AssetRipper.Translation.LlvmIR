using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class internal_is_float_hex_start
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal18is_float_hex_startEPKcc")]
	[DemangledName("__llvm_libc_20_1_2_::internal::is_float_hex_start(char const*, char)")]
	public unsafe static bool Invoke([NativeType("char const*")] void* src, [NativeType("char")] sbyte decimalPoint)
	{
		long num = 0L;
		sbyte b = decimalPoint;
		unchecked
		{
			bool result;
			if (*(sbyte*)src != 48 || internal_tolower_b2645y.Invoke(((sbyte*)src)[1]) != 120)
			{
				result = false;
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(8L, &num);
				num = 2L;
				if (((sbyte*)src)[2] == b)
				{
					num++;
				}
				result = internal_isalnum_eh69hd.Invoke(((sbyte*)src)[num]) && internal_b36_char_to_int_kxqrdt.Invoke(((sbyte*)src)[num]) < 16;
				llvm_lifetime_end_p0.Invoke(8L, &num);
			}
			return result;
		}
	}
}
