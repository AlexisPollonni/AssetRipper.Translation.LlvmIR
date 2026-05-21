using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_exact_add_true
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil9exact_addILb1EEENS_10NumberPairIdEEdd")]
	[DemangledName("__llvm_libc_20_1_2_::NumberPair<double> __llvm_libc_20_1_2_::fputil::exact_add<true>(double, double)")]
	[return: NativeType("__llvm_libc_20_1_2_::NumberPair<double>")]
	public unsafe static Struct_4ydhja Invoke([NativeType("double")] double a, [NativeType("double")] double b)
	{
		NumberPair numberPair = default(NumberPair);
		double num = 0.0;
		unchecked
		{
			*(double*)(&numberPair) = double.NaN;
			((double*)(&numberPair))[1] = double.NaN;
			numberPair.lo = 0.0;
			numberPair.hi = 0.0;
			numberPair.hi = a + b;
			llvm_lifetime_start_p0.Invoke(8L, &num);
			num = numberPair.hi - a;
			numberPair.lo = b - num;
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return *(Struct_4ydhja*)(&numberPair);
		}
	}
}
