using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil3divERKNS_10NumberPairIdEES4_")]
[DemangledName("__llvm_libc_20_1_2_::fputil::div(__llvm_libc_20_1_2_::NumberPair<double> const&, __llvm_libc_20_1_2_::NumberPair<double> const&)")]
internal static partial class fputil_div_NumberPair_double_const_NumberPair_double_const
{
	public unsafe static Struct_4ydhja Invoke(void* a, void* b)
	{
		NumberPair numberPair = default(NumberPair);
		double num = 0.0;
		double num2 = 0.0;
		double num3 = 0.0;
		unchecked
		{
			*(double*)(&numberPair) = double.NaN;
			((double*)(&numberPair))[1] = double.NaN;
			NumberPair_double_NumberPair.Invoke(&numberPair);
			llvm_lifetime_start_p0.Invoke(8L, &num);
			num = 1.0 / ((NumberPair*)b)->hi;
			numberPair.hi = ((NumberPair*)a)->hi * num;
			llvm_lifetime_start_p0.Invoke(8L, &num2);
			num2 = fputil_multiply_add_double_double_double.Invoke(((NumberPair*)b)->hi, 0.0 - numberPair.hi, ((NumberPair*)a)->hi);
			llvm_lifetime_start_p0.Invoke(8L, &num3);
			num3 = fputil_multiply_add_double_double_double.Invoke(((NumberPair*)b)->lo, 0.0 - numberPair.hi, ((NumberPair*)a)->lo);
			numberPair.lo = num * (num2 + num3);
			llvm_lifetime_end_p0.Invoke(8L, &num3);
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return *(Struct_4ydhja*)(&numberPair);
		}
	}
}
