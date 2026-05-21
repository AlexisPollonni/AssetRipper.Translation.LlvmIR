using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class exp_b_range_reduc_Exp10Base
{
	[MangledName("_ZN19__llvm_libc_20_1_2_17exp_b_range_reducINS_9Exp10BaseEEENS_13exp_b_reduc_tEf")]
	[DemangledName("__llvm_libc_20_1_2_::exp_b_reduc_t __llvm_libc_20_1_2_::exp_b_range_reduc<__llvm_libc_20_1_2_::Exp10Base>(float)")]
	[return: NativeType("__llvm_libc_20_1_2_::exp_b_reduc_t")]
	public unsafe static Struct_4ydhja Invoke([NativeType("float")] float x)
	{
		NumberPair numberPair = default(NumberPair);
		double num = 0.0;
		double num2 = 0.0;
		int num3 = 0;
		long num4 = 0L;
		long x2 = 0L;
		double lo = 0.0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		double hi = 0.0;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = x;
		llvm_lifetime_start_p0.Invoke(8L, &num2);
		num2 = fputil_nearest_integer.Invoke(106.30169903639559 * num);
		llvm_lifetime_start_p0.Invoke(4L, &num3);
		unchecked
		{
			num3 = (int)num2;
			llvm_lifetime_start_p0.Invoke(8L, &num4);
			num4 = (long)(num3 >> 5) << 52;
			llvm_lifetime_start_p0.Invoke(8L, &x2);
			long num5 = num3 & 0x1F;
			x2 = ((long*)ExpBase_EXP_2_MID.Pointer)[num5] + num4;
			llvm_lifetime_start_p0.Invoke(8L, &lo);
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			FPBits_double_FPBits_unsigned_long.Invoke(&fputil_FPBits_wjhbrm2, x2);
			double num6 = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm2);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			lo = num6;
			llvm_lifetime_start_p0.Invoke(8L, &hi);
			hi = fputil_multiply_add_double.Invoke(num2, 2.6663575990803458E-15, fputil_multiply_add_double.Invoke(num2, -0.009407187364502079, num));
			numberPair.lo = lo;
			numberPair.hi = hi;
			llvm_lifetime_end_p0.Invoke(8L, &hi);
			llvm_lifetime_end_p0.Invoke(8L, &lo);
			llvm_lifetime_end_p0.Invoke(8L, &x2);
			llvm_lifetime_end_p0.Invoke(8L, &num4);
			llvm_lifetime_end_p0.Invoke(4L, &num3);
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return *(Struct_4ydhja*)(&numberPair);
		}
	}
}
