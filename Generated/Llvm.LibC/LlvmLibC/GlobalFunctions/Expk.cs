using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Expk
{
	[MangledName("expk")]
	[DemangledName("expk")]
	public unsafe static int Invoke([MangledName("x")] int X)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		int a = 0;
		int a2 = 0;
		int b = 0;
		int b2 = 0;
		unchecked
		{
			int result;
			if (Details_expects_bool_condition_bool.Invoke(X >= 363408, Expected: false))
			{
				result = FXRep_Accum_MAX.Invoke();
			}
			else if (Details_expects_bool_condition_bool.Invoke(X <= -363409, Expected: false))
			{
				result = FXRep_Accum_ZERO.Invoke();
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num);
				num = 1024;
				Llvm_lifetime_start_p0.Invoke(4L, &num2);
				num2 = X + 1024 >> 11 << 11;
				Llvm_lifetime_start_p0.Invoke(4L, &num3);
				num3 = X - num2;
				Llvm_lifetime_start_p0.Invoke(4L, &num4);
				Llvm_lifetime_start_p0.Invoke(4L, &num5);
				num5 = num2 + 362496 >> 11;
				int num6 = Cpp_bit_cast_unsigned_int_Accum.Invoke(&num5);
				Llvm_lifetime_end_p0.Invoke(4L, &num5);
				num4 = num6;
				Llvm_lifetime_start_p0.Invoke(4L, &a);
				long num7 = (uint)(num4 >>> 4);
				a = ((int*)Anonymous_namespace_EXP_HI.Pointer)[num7];
				Llvm_lifetime_start_p0.Invoke(4L, &a2);
				long num8 = (uint)(num4 & 0xF);
				a2 = ((int*)Anonymous_namespace_EXP_MID.Pointer)[num8];
				Llvm_lifetime_start_p0.Invoke(4L, &b);
				b = 32768 + (num3 >> 1);
				Llvm_lifetime_start_p0.Invoke(4L, &b2);
				b2 = 32768 + Llvm_smul_fix_i32.Invoke(num3, b, 15);
				result = Llvm_smul_fix_i32.Invoke(a, Llvm_smul_fix_i32.Invoke(a2, b2, 15), 15);
				Llvm_lifetime_end_p0.Invoke(4L, &b2);
				Llvm_lifetime_end_p0.Invoke(4L, &b);
				Llvm_lifetime_end_p0.Invoke(4L, &a2);
				Llvm_lifetime_end_p0.Invoke(4L, &a);
				Llvm_lifetime_end_p0.Invoke(4L, &num4);
				Llvm_lifetime_end_p0.Invoke(4L, &num3);
				Llvm_lifetime_end_p0.Invoke(4L, &num2);
				Llvm_lifetime_end_p0.Invoke(4L, &num);
			}
			return result;
		}
	}
}
