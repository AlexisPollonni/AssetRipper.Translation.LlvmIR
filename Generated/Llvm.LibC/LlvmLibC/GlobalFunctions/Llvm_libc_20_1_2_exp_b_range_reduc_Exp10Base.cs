using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llvm_libc_20_1_2_exp_b_range_reduc_Exp10Base
{
	[MangledName("_ZN19__llvm_libc_20_1_2_17exp_b_range_reducINS_9Exp10BaseEEENS_13exp_b_reduc_tEf")]
	[DemangledName("__llvm_libc_20_1_2_::exp_b_reduc_t __llvm_libc_20_1_2_::exp_b_range_reduc<__llvm_libc_20_1_2_::Exp10Base>(float)")]
	[return: NativeType("__llvm_libc_20_1_2_::exp_b_reduc_t")]
	public unsafe static Struct_4ydhja Invoke([MangledName("x")][NativeType("float")] float X)
	{
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair = default(Llvm_libc_20_1_2_NumberPair);
		double num = 0.0;
		double num2 = 0.0;
		int num3 = 0;
		long num4 = 0L;
		long x = 0L;
		double lo = 0.0;
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		double hi = 0.0;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = X;
		Llvm_lifetime_start_p0.Invoke(8L, &num2);
		num2 = Fputil_nearest_integer.Invoke(106.30169903639559 * num);
		Llvm_lifetime_start_p0.Invoke(4L, &num3);
		unchecked
		{
			num3 = (int)num2;
			Llvm_lifetime_start_p0.Invoke(8L, &num4);
			num4 = (long)(num3 >> 5) << 52;
			Llvm_lifetime_start_p0.Invoke(8L, &x);
			long num5 = num3 & 0x1F;
			x = ((long*)Llvm_libc_20_1_2_ExpBase_EXP_2_MID.Pointer)[num5] + num4;
			Llvm_lifetime_start_p0.Invoke(8L, &lo);
			Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
			FPBits_double_FPBits_unsigned_long.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm, x);
			double num6 = FPBits_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
			Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
			lo = num6;
			Llvm_lifetime_start_p0.Invoke(8L, &hi);
			hi = Fputil_multiply_add_double.Invoke(num2, 2.6663575990803458E-15, Fputil_multiply_add_double.Invoke(num2, -0.009407187364502079, num));
			llvm_libc_20_1_2_NumberPair.Lo = lo;
			llvm_libc_20_1_2_NumberPair.Hi = hi;
			Llvm_lifetime_end_p0.Invoke(8L, &hi);
			Llvm_lifetime_end_p0.Invoke(8L, &lo);
			Llvm_lifetime_end_p0.Invoke(8L, &x);
			Llvm_lifetime_end_p0.Invoke(8L, &num4);
			Llvm_lifetime_end_p0.Invoke(4L, &num3);
			Llvm_lifetime_end_p0.Invoke(8L, &num2);
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			return *(Struct_4ydhja*)(&llvm_libc_20_1_2_NumberPair);
		}
	}
}
