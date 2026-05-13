using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil9exact_addILb0EEENS_10NumberPairIdEEdd")]
[DemangledName("__llvm_libc_20_1_2_::NumberPair<double> __llvm_libc_20_1_2_::fputil::exact_add<false>(double, double)")]
internal static partial class NumberPair_double_fputil_exact_add_false_double_double
{
	public unsafe static Struct_4ydhja Invoke(double a, double b)
	{
		NumberPair numberPair = default(NumberPair);
		double num = 0.0;
		double num2 = 0.0;
		double num3 = 0.0;
		double num4 = 0.0;
		unchecked
		{
			*(double*)(&numberPair) = double.NaN;
			((double*)(&numberPair))[1] = double.NaN;
			numberPair.lo = 0.0;
			numberPair.hi = 0.0;
			numberPair.hi = a + b;
			llvm_lifetime_start_p0.Invoke(8L, &num);
			num = numberPair.hi - a;
			llvm_lifetime_start_p0.Invoke(8L, &num2);
			num2 = numberPair.hi - num;
			llvm_lifetime_start_p0.Invoke(8L, &num3);
			num3 = b - num;
			llvm_lifetime_start_p0.Invoke(8L, &num4);
			num4 = a - num2;
			numberPair.lo = num3 + num4;
			llvm_lifetime_end_p0.Invoke(8L, &num4);
			llvm_lifetime_end_p0.Invoke(8L, &num3);
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return *(Struct_4ydhja*)(&numberPair);
		}
	}
}
