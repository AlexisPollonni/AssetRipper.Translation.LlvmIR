using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil10exact_multILm27EEENS_10NumberPairIdEEdd")]
[DemangledName("__llvm_libc_20_1_2_::NumberPair<double> __llvm_libc_20_1_2_::fputil::exact_mult<27ul>(double, double)")]
internal static partial class NumberPair_double_fputil_exact_mult_27ul_double_double
{
	public unsafe static Struct_4ydhja Invoke(double a, double b)
	{
		NumberPair numberPair = default(NumberPair);
		unchecked
		{
			*(double*)(&numberPair) = double.NaN;
			((double*)(&numberPair))[1] = double.NaN;
			numberPair.lo = 0.0;
			numberPair.hi = 0.0;
			numberPair.hi = a * b;
			numberPair.lo = fputil_multiply_add_double_double_double.Invoke(a, b, 0.0 - numberPair.hi);
			return *(Struct_4ydhja*)(&numberPair);
		}
	}
}
