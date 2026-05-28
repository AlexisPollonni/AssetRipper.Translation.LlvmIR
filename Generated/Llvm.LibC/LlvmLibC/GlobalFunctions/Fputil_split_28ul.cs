using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_split_28ul
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil5splitILm28EEENS_10NumberPairIdEEd")]
	[DemangledName("__llvm_libc_20_1_2_::NumberPair<double> __llvm_libc_20_1_2_::fputil::split<28ul>(double)")]
	[return: NativeType("__llvm_libc_20_1_2_::NumberPair<double>")]
	public unsafe static Struct_4ydhja Invoke([MangledName("a")][NativeType("double")] double A)
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
			Llvm_lifetime_start_p0.Invoke(8L, &num);
			num = 268435456.0;
			Llvm_lifetime_start_p0.Invoke(8L, &num2);
			num2 = 268435457.0;
			Llvm_lifetime_start_p0.Invoke(8L, &num3);
			num3 = 268435457.0 * A;
			Llvm_lifetime_start_p0.Invoke(8L, &num4);
			num4 = A - num3;
			numberPair.Hi = num3 + num4;
			numberPair.Lo = A - numberPair.Hi;
			Llvm_lifetime_end_p0.Invoke(8L, &num4);
			Llvm_lifetime_end_p0.Invoke(8L, &num3);
			Llvm_lifetime_end_p0.Invoke(8L, &num2);
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			return *(Struct_4ydhja*)(&numberPair);
		}
	}
}
