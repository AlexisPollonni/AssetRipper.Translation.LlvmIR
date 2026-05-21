using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class exphk
{
	public unsafe static short Invoke(short x)
	{
		short num = 0;
		short num2 = 0;
		short num3 = 0;
		short num4 = 0;
		short num5 = 0;
		short a = 0;
		short a2 = 0;
		short num6 = x;
		unchecked
		{
			short result;
			if (details_expects_bool_condition_bool.Invoke(num6 >= 712, expected: false))
			{
				result = FXRep_short_Accum_MAX.Invoke();
			}
			else if (details_expects_bool_condition_bool.Invoke(num6 <= -710, expected: false))
			{
				result = FXRep_short_Accum_ZERO.Invoke();
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(2L, &num);
				num = 8;
				llvm_lifetime_start_p0.Invoke(2L, &num2);
				num2 = (short)(num6 + 8 >> 4 << 4);
				llvm_lifetime_start_p0.Invoke(2L, &num3);
				num3 = (short)(num6 - num2);
				llvm_lifetime_start_p0.Invoke(2L, &num4);
				llvm_lifetime_start_p0.Invoke(2L, &num5);
				num5 = (short)(num2 + 704 >> 4);
				short num7 = cpp_bit_cast_unsigned_short_short_Accum.Invoke(&num5);
				llvm_lifetime_end_p0.Invoke(2L, &num5);
				num4 = num7;
				llvm_lifetime_start_p0.Invoke(2L, &a);
				long num8 = (ushort)num4 >> 3;
				a = ((short*)anonymous_namespace_EXP_HI_1.Pointer)[num8];
				llvm_lifetime_start_p0.Invoke(2L, &a2);
				long num9 = (ushort)num4 & 7;
				a2 = ((short*)anonymous_namespace_EXP_MID_2.Pointer)[num9];
				result = llvm_smul_fix_i16.Invoke(a, llvm_smul_fix_i16.Invoke(a2, (short)(128 + num3), 7), 7);
				llvm_lifetime_end_p0.Invoke(2L, &a2);
				llvm_lifetime_end_p0.Invoke(2L, &a);
				llvm_lifetime_end_p0.Invoke(2L, &num4);
				llvm_lifetime_end_p0.Invoke(2L, &num3);
				llvm_lifetime_end_p0.Invoke(2L, &num2);
				llvm_lifetime_end_p0.Invoke(2L, &num);
			}
			return result;
		}
	}
}
