using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_19atan_evalERKNS_10NumberPairIdEE")]
[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::atan_eval(__llvm_libc_20_1_2_::NumberPair<double> const&)")]
internal static partial class anonymous_namespace_atan_eval_NumberPair_double_const
{
	public unsafe static Struct_4ydhja Invoke(NumberPair* x)
	{
		NumberPair numberPair = default(NumberPair);
		double num = 0.0;
		double z = 0.0;
		double y = 0.0;
		double x2 = 0.0;
		double num2 = 0.0;
		double y2 = 0.0;
		double z2 = 0.0;
		unchecked
		{
			*(double*)(&numberPair) = double.NaN;
			((double*)(&numberPair))[1] = double.NaN;
			NumberPair_double_NumberPair.Invoke(&numberPair);
			numberPair.hi = x->hi;
			llvm_lifetime_start_p0.Invoke(8L, &num);
			num = x->hi * x->hi;
			llvm_lifetime_start_p0.Invoke(8L, &z);
			z = fputil_multiply_add_double_double_double.Invoke(num, 0.2, -1.0 / 3.0);
			llvm_lifetime_start_p0.Invoke(8L, &y);
			y = fputil_multiply_add_double_double_double.Invoke(num, 1.0 / 9.0, -1.0 / 7.0);
			llvm_lifetime_start_p0.Invoke(8L, &x2);
			x2 = num * x->hi;
			llvm_lifetime_start_p0.Invoke(8L, &num2);
			num2 = num * num;
			llvm_lifetime_start_p0.Invoke(8L, &y2);
			y2 = fputil_multiply_add_double_double_double.Invoke(num2, y, z);
			llvm_lifetime_start_p0.Invoke(8L, &z2);
			z2 = fputil_multiply_add_double_double_double.Invoke(num2 - num, x->lo, x->lo);
			numberPair.lo = fputil_multiply_add_double_double_double.Invoke(x2, y2, z2);
			llvm_lifetime_end_p0.Invoke(8L, &z2);
			llvm_lifetime_end_p0.Invoke(8L, &y2);
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			llvm_lifetime_end_p0.Invoke(8L, &x2);
			llvm_lifetime_end_p0.Invoke(8L, &y);
			llvm_lifetime_end_p0.Invoke(8L, &z);
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return *(Struct_4ydhja*)(&numberPair);
		}
	}
}
