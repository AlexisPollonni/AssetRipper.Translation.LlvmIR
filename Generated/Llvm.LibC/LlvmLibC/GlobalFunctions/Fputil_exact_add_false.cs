using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_exact_add_false
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil9exact_addILb0EEENS_10NumberPairIdEEdd")]
	[DemangledName("__llvm_libc_20_1_2_::NumberPair<double> __llvm_libc_20_1_2_::fputil::exact_add<false>(double, double)")]
	[return: NativeType("__llvm_libc_20_1_2_::NumberPair<double>")]
	public unsafe static Struct_4ydhja Invoke([MangledName("a")][NativeType("double")] double A, [MangledName("b")][NativeType("double")] double B)
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
			numberPair.Lo = 0.0;
			numberPair.Hi = 0.0;
			numberPair.Hi = A + B;
			Llvm_lifetime_start_p0.Invoke(8L, &num);
			num = numberPair.Hi - A;
			Llvm_lifetime_start_p0.Invoke(8L, &num2);
			num2 = numberPair.Hi - num;
			Llvm_lifetime_start_p0.Invoke(8L, &num3);
			num3 = B - num;
			Llvm_lifetime_start_p0.Invoke(8L, &num4);
			num4 = A - num2;
			numberPair.Lo = num3 + num4;
			Llvm_lifetime_end_p0.Invoke(8L, &num4);
			Llvm_lifetime_end_p0.Invoke(8L, &num3);
			Llvm_lifetime_end_p0.Invoke(8L, &num2);
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			return *(Struct_4ydhja*)(&numberPair);
		}
	}
}
