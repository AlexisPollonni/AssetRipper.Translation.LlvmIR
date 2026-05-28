using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Exphk
{
	[MangledName("exphk")]
	[DemangledName("exphk")]
	public unsafe static short Invoke([MangledName("x")] short X)
	{
		short num = 0;
		short num2 = 0;
		short num3 = 0;
		short num4 = 0;
		short num5 = 0;
		short a = 0;
		short a2 = 0;
		short num6 = X;
		unchecked
		{
			short result;
			if (Details_expects_bool_condition_bool.Invoke(num6 >= 712, Expected: false))
			{
				result = FXRep_short_Accum_MAX.Invoke();
			}
			else if (Details_expects_bool_condition_bool.Invoke(num6 <= -710, Expected: false))
			{
				result = FXRep_short_Accum_ZERO.Invoke();
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(2L, &num);
				num = 8;
				Llvm_lifetime_start_p0.Invoke(2L, &num2);
				num2 = (short)(num6 + 8 >> 4 << 4);
				Llvm_lifetime_start_p0.Invoke(2L, &num3);
				num3 = (short)(num6 - num2);
				Llvm_lifetime_start_p0.Invoke(2L, &num4);
				Llvm_lifetime_start_p0.Invoke(2L, &num5);
				num5 = (short)(num2 + 704 >> 4);
				short num7 = Cpp_bit_cast_unsigned_short_short_Accum.Invoke(&num5);
				Llvm_lifetime_end_p0.Invoke(2L, &num5);
				num4 = num7;
				Llvm_lifetime_start_p0.Invoke(2L, &a);
				long num8 = (ushort)num4 >> 3;
				a = ((short*)Anonymous_namespace_EXP_HI_1.Pointer)[num8];
				Llvm_lifetime_start_p0.Invoke(2L, &a2);
				long num9 = (ushort)num4 & 7;
				a2 = ((short*)Anonymous_namespace_EXP_MID_2.Pointer)[num9];
				result = Llvm_smul_fix_i16.Invoke(a, Llvm_smul_fix_i16.Invoke(a2, (short)(128 + num3), 7), 7);
				Llvm_lifetime_end_p0.Invoke(2L, &a2);
				Llvm_lifetime_end_p0.Invoke(2L, &a);
				Llvm_lifetime_end_p0.Invoke(2L, &num4);
				Llvm_lifetime_end_p0.Invoke(2L, &num3);
				Llvm_lifetime_end_p0.Invoke(2L, &num2);
				Llvm_lifetime_end_p0.Invoke(2L, &num);
			}
			return result;
		}
	}
}
