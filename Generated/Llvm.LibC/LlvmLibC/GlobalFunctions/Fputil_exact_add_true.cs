using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_exact_add_true
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil9exact_addILb1EEENS_10NumberPairIdEEdd")]
	[DemangledName("__llvm_libc_20_1_2_::NumberPair<double> __llvm_libc_20_1_2_::fputil::exact_add<true>(double, double)")]
	[return: NativeType("__llvm_libc_20_1_2_::NumberPair<double>")]
	public unsafe static Struct_4ydhja Invoke([MangledName("a")][NativeType("double")] double A, [MangledName("b")][NativeType("double")] double B)
	{
		NumberPair numberPair = default(NumberPair);
		double num = 0.0;
		unchecked
		{
			*(double*)(&numberPair) = double.NaN;
			((double*)(&numberPair))[1] = double.NaN;
			numberPair.Lo = 0.0;
			numberPair.Hi = 0.0;
			numberPair.Hi = A + B;
			Llvm_lifetime_start_p0.Invoke(8L, &num);
			num = numberPair.Hi - A;
			numberPair.Lo = B - num;
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			return *(Struct_4ydhja*)(&numberPair);
		}
	}
}
