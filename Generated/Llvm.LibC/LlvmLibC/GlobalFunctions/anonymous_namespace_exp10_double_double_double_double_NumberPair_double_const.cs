using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_119exp10_double_doubleEddRKNS_10NumberPairIdEE")]
[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::exp10_double_double(double, double, __llvm_libc_20_1_2_::NumberPair<double> const&)")]
internal static partial class anonymous_namespace_exp10_double_double_double_double_NumberPair_double_const
{
	public unsafe static Struct_4ydhja Invoke(double x, double kd, NumberPair* exp_mid)
	{
		NumberPair numberPair = default(NumberPair);
		double a = 0.0;
		double b = 0.0;
		double num = 0.0;
		NumberPair numberPair2 = default(NumberPair);
		NumberPair numberPair3 = default(NumberPair);
		llvm_lifetime_start_p0.Invoke(8L, &a);
		a = fputil_multiply_add_double_double_double.Invoke(kd, -7.349365128561658E-05, x);
		llvm_lifetime_start_p0.Invoke(8L, &b);
		b = kd * 4.649201285808973E-16;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = kd * 1.1980559920951342E-26;
		llvm_lifetime_start_p0.Invoke(16L, &numberPair2);
		unchecked
		{
			*(double*)(&numberPair2) = double.NaN;
			((double*)(&numberPair2))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja = NumberPair_double_fputil_exact_add_true_double_double.Invoke(a, b);
			NumberPair* num2 = &numberPair2;
			Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
			*(double*)num2 = struct_4ydhja2.field_0;
			byte* num3 = (byte*)(&numberPair2) + 8u;
			Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
			*(double*)num3 = struct_4ydhja3.field_1;
			numberPair2.lo += num;
			llvm_lifetime_start_p0.Invoke(16L, &numberPair3);
			*(double*)(&numberPair3) = double.NaN;
			((double*)(&numberPair3))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja4 = anonymous_namespace_poly_approx_dd_NumberPair_double_const_48.Invoke(&numberPair2);
			NumberPair* num4 = &numberPair3;
			Struct_4ydhja struct_4ydhja5 = struct_4ydhja4;
			*(double*)num4 = struct_4ydhja5.field_0;
			byte* num5 = (byte*)(&numberPair3) + 8u;
			Struct_4ydhja struct_4ydhja6 = struct_4ydhja4;
			*(double*)num5 = struct_4ydhja6.field_1;
			*(double*)(&numberPair) = double.NaN;
			((double*)(&numberPair))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja7 = NumberPair_double_fputil_quick_mult_27ul_NumberPair_double_const_NumberPair_double_const.Invoke(exp_mid, &numberPair3);
			NumberPair* num6 = &numberPair;
			Struct_4ydhja struct_4ydhja8 = struct_4ydhja7;
			*(double*)num6 = struct_4ydhja8.field_0;
			byte* num7 = (byte*)(&numberPair) + 8u;
			Struct_4ydhja struct_4ydhja9 = struct_4ydhja7;
			*(double*)num7 = struct_4ydhja9.field_1;
			llvm_lifetime_end_p0.Invoke(16L, &numberPair3);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair2);
			llvm_lifetime_end_p0.Invoke(8L, &num);
			llvm_lifetime_end_p0.Invoke(8L, &b);
			llvm_lifetime_end_p0.Invoke(8L, &a);
			return *(Struct_4ydhja*)(&numberPair);
		}
	}
}
