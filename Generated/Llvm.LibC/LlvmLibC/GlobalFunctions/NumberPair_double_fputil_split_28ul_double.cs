using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil5splitILm28EEENS_10NumberPairIdEEd")]
[DemangledName("__llvm_libc_20_1_2_::NumberPair<double> __llvm_libc_20_1_2_::fputil::split<28ul>(double)")]
internal static partial class NumberPair_double_fputil_split_28ul_double
{
	public unsafe static Struct_4ydhja Invoke(double a)
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
			llvm_lifetime_start_p0.Invoke(8L, &num);
			num = 268435456.0;
			llvm_lifetime_start_p0.Invoke(8L, &num2);
			num2 = 268435457.0;
			llvm_lifetime_start_p0.Invoke(8L, &num3);
			num3 = 268435457.0 * a;
			llvm_lifetime_start_p0.Invoke(8L, &num4);
			num4 = a - num3;
			numberPair.hi = num3 + num4;
			numberPair.lo = a - numberPair.hi;
			llvm_lifetime_end_p0.Invoke(8L, &num4);
			llvm_lifetime_end_p0.Invoke(8L, &num3);
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return *(Struct_4ydhja*)(&numberPair);
		}
	}
}
